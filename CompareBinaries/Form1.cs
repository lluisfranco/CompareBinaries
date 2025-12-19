using System.Diagnostics;

namespace CompareBinaries
{
    public partial class Form1 : Form
    {
        //C:\FalconFT\FalconAppCode\FalconConsolidations.Client\bin\Release\net8.0-windows\publish\win-x64
        //C:\FalconFT\FalconAppCode\FalconCell.Client\bin\Release\net8.0-windows\publish\win-x64
        //C:\FalconFT\FalconAppCode\Falcon.Setup.Publisher\bin\Release\net8.0-windows\publish
        public Form1()
        {
            InitializeComponent();
            button1.Click += (s,e) => 
            {
                using var fbd1 = new FolderBrowserDialog();
                if (fbd1.ShowDialog() != DialogResult.OK) return;
                textBox1.Text = fbd1.SelectedPath;
            };
            button2.Click += (s, e) =>
            {
                using var fbd2 = new FolderBrowserDialog();
                if (fbd2.ShowDialog() != DialogResult.OK) return;
                textBox2.Text = fbd2.SelectedPath;
            };
            button3.Click += (s, e) =>
            {
                Cursor = Cursors.WaitCursor;
                button3.Enabled = false;
                var folder1 = textBox1.Text;
                var folder2 = textBox2.Text;
                if (string.IsNullOrWhiteSpace(folder1) || string.IsNullOrWhiteSpace(folder2))
                {
                    MessageBox.Show("Please select both folders.");
                    return;
                }
                var comparer = new ComparaBinariesHelper(folder1, folder2);
                var results = comparer.Compare();
                dataGridView.DataSource = results.Select(r => new
                {
                    r.FileName,
                    r.SizeInFolder1,
                    r.SizeInFolder2,
                    r.VersionInFolder1,
                    r.VersionInFolder2,
                    r.LastWrite1,
                    r.LastWrite2,
                    r.SizeDifference,
                    r.VersionDifferent
                }).ToList();
                labelResults.Text = $"{results.Count} version differences.";
                button3.Enabled = true;
                Cursor = Cursors.Default;
            };
        }
    }

    public class ComparaBinariesHelper(string folder1, string folder2)
    {
        Dictionary<string, FileComparisonResult> Results = [];
        public string Folder1 { get; private set; } = folder1;
        public string Folder2 { get; private set; } = folder2;

        public IList<FileComparisonResult> Compare()
        {
            var filesInFolder1 = Directory.GetFiles(Folder1, "*.dll", SearchOption.TopDirectoryOnly);
            var filesInFolder2 = Directory.GetFiles(Folder2, "*.dll", SearchOption.TopDirectoryOnly);

            var fileInfoDetails1 = filesInFolder1.Select(f => new FileInfoDetails
            {
                FileName = new FileInfo(f).Name,
                FilePath = f
            }).ToList();

            var fileInfoDetails2 = filesInFolder2.Select(f => new FileInfoDetails
            {
                FileName = new FileInfo(f).Name,
                FilePath = f
            }).ToList();

            var onlyInFolder1 = fileInfoDetails1.Select(p => p.FileName).Except(fileInfoDetails2.Select(p => p.FileName));
            var onlyInFolder2 = fileInfoDetails2.Select(p => p.FileName).Except(fileInfoDetails1.Select(p => p.FileName));
            var inBoth = fileInfoDetails1.Select(p => p.FileName).Intersect(fileInfoDetails2.Select(p => p.FileName));

            foreach (var file in inBoth)
            {
                var file1 = new FileInfo(Path.Combine(Folder1, file));
                var file2 = new FileInfo(Path.Combine(Folder2, file));

                var version1 = FileVersionInfo.GetVersionInfo(file1.FullName).FileVersion!;
                var version2 = FileVersionInfo.GetVersionInfo(file2.FullName).FileVersion!;

                var lastWrite1 = file1.LastWriteTime;
                var lastWrite2 = file2.LastWriteTime;

                AddToResult(file, file1.Length, file2.Length, version1, version2, lastWrite1, lastWrite2);
            }

            return [.. Results.Values.Where(p => p.IsDifferent)];
        }

        private FileComparisonResult AddToResult(
            string fileName, long size1, long size2, 
            string version1, string version2, 
            DateTime lastWrite1, DateTime lastWrite2)
        {
            var result = new FileComparisonResult
            {
                FileName = fileName,
                SizeInFolder1 = size1,
                SizeInFolder2 = size2,
                VersionInFolder1 = version1,
                VersionInFolder2 = version2,
                LastWrite1 = lastWrite1,
                LastWrite2 = lastWrite2
            };
            if (!Results.ContainsKey(fileName))
            {
                Results[fileName] = result;
            }
            else
            {
                Results.Add(fileName, result);
            }
            return result;
        }
    }

    public class FileInfoDetails
    {
        public string FileName { get; set; } = default!;
        public string FilePath { get; set; } = default!;
    }

    public class FileComparisonResult
    {
        public string FileName { get; set; } = default!;
        public long SizeInFolder1 { get; set; }
        public long SizeInFolder2 { get; set; }
        public string VersionInFolder1 { get; set; } = default!;
        public string VersionInFolder2 { get; set; } = default!;
        public DateTime LastWrite1 { get; set; }
        public DateTime LastWrite2 { get; set; }
        public bool SizeDifference => SizeInFolder1 != SizeInFolder2;
        public bool VersionDifferent => VersionInFolder1 != VersionInFolder2;
        public bool LastWriteDifferent => LastWrite1 != LastWrite2;
        public bool IsDifferent => SizeDifference || VersionDifferent;

    }
}
