namespace CompareBinaries
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button3 = new Button();
            dataGridView = new DataGridView();
            fileNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sizeInFolder1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sizeInFolder2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            versionInFolder1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            versionInFolder2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastWrite1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastWrite2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sizeDifferenceDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            versionDifferentDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            lastWriteDifferentDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isDifferentDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            fileComparisonResultBindingSource = new BindingSource(components);
            labelResults = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileComparisonResultBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Folder 1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 41);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Folder 2";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(93, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(714, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "C:\\FalconFT\\FalconAppCode\\Falcon.Client\\bin\\Release\\net8.0-windows\\publish\\win-x64";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(93, 41);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(714, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "C:\\FalconFT\\FalconAppCode\\FalconCell.Client\\bin\\Release\\net8.0-windows\\publish\\win-x64";
            // 
            // button3
            // 
            button3.Location = new Point(12, 94);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Compare";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { fileNameDataGridViewTextBoxColumn, sizeInFolder1DataGridViewTextBoxColumn, sizeInFolder2DataGridViewTextBoxColumn, versionInFolder1DataGridViewTextBoxColumn, versionInFolder2DataGridViewTextBoxColumn, lastWrite1DataGridViewTextBoxColumn, lastWrite2DataGridViewTextBoxColumn, sizeDifferenceDataGridViewCheckBoxColumn, versionDifferentDataGridViewCheckBoxColumn, lastWriteDifferentDataGridViewCheckBoxColumn, isDifferentDataGridViewCheckBoxColumn });
            dataGridView.DataSource = fileComparisonResultBindingSource;
            dataGridView.Location = new Point(12, 123);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(795, 321);
            dataGridView.TabIndex = 6;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            fileNameDataGridViewTextBoxColumn.HeaderText = "FileName";
            fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            fileNameDataGridViewTextBoxColumn.Width = 450;
            // 
            // sizeInFolder1DataGridViewTextBoxColumn
            // 
            sizeInFolder1DataGridViewTextBoxColumn.DataPropertyName = "SizeInFolder1";
            sizeInFolder1DataGridViewTextBoxColumn.HeaderText = "SizeInFolder1";
            sizeInFolder1DataGridViewTextBoxColumn.Name = "sizeInFolder1DataGridViewTextBoxColumn";
            sizeInFolder1DataGridViewTextBoxColumn.ReadOnly = true;
            sizeInFolder1DataGridViewTextBoxColumn.Visible = false;
            // 
            // sizeInFolder2DataGridViewTextBoxColumn
            // 
            sizeInFolder2DataGridViewTextBoxColumn.DataPropertyName = "SizeInFolder2";
            sizeInFolder2DataGridViewTextBoxColumn.HeaderText = "SizeInFolder2";
            sizeInFolder2DataGridViewTextBoxColumn.Name = "sizeInFolder2DataGridViewTextBoxColumn";
            sizeInFolder2DataGridViewTextBoxColumn.ReadOnly = true;
            sizeInFolder2DataGridViewTextBoxColumn.Visible = false;
            // 
            // versionInFolder1DataGridViewTextBoxColumn
            // 
            versionInFolder1DataGridViewTextBoxColumn.DataPropertyName = "VersionInFolder1";
            versionInFolder1DataGridViewTextBoxColumn.HeaderText = "VersionInFolder1";
            versionInFolder1DataGridViewTextBoxColumn.Name = "versionInFolder1DataGridViewTextBoxColumn";
            versionInFolder1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // versionInFolder2DataGridViewTextBoxColumn
            // 
            versionInFolder2DataGridViewTextBoxColumn.DataPropertyName = "VersionInFolder2";
            versionInFolder2DataGridViewTextBoxColumn.HeaderText = "VersionInFolder2";
            versionInFolder2DataGridViewTextBoxColumn.Name = "versionInFolder2DataGridViewTextBoxColumn";
            versionInFolder2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastWrite1DataGridViewTextBoxColumn
            // 
            lastWrite1DataGridViewTextBoxColumn.DataPropertyName = "LastWrite1";
            lastWrite1DataGridViewTextBoxColumn.HeaderText = "LastWrite1";
            lastWrite1DataGridViewTextBoxColumn.Name = "lastWrite1DataGridViewTextBoxColumn";
            lastWrite1DataGridViewTextBoxColumn.ReadOnly = true;
            lastWrite1DataGridViewTextBoxColumn.Visible = false;
            // 
            // lastWrite2DataGridViewTextBoxColumn
            // 
            lastWrite2DataGridViewTextBoxColumn.DataPropertyName = "LastWrite2";
            lastWrite2DataGridViewTextBoxColumn.HeaderText = "LastWrite2";
            lastWrite2DataGridViewTextBoxColumn.Name = "lastWrite2DataGridViewTextBoxColumn";
            lastWrite2DataGridViewTextBoxColumn.ReadOnly = true;
            lastWrite2DataGridViewTextBoxColumn.Visible = false;
            // 
            // sizeDifferenceDataGridViewCheckBoxColumn
            // 
            sizeDifferenceDataGridViewCheckBoxColumn.DataPropertyName = "SizeDifference";
            sizeDifferenceDataGridViewCheckBoxColumn.HeaderText = "SizeDifference";
            sizeDifferenceDataGridViewCheckBoxColumn.Name = "sizeDifferenceDataGridViewCheckBoxColumn";
            sizeDifferenceDataGridViewCheckBoxColumn.ReadOnly = true;
            sizeDifferenceDataGridViewCheckBoxColumn.Visible = false;
            // 
            // versionDifferentDataGridViewCheckBoxColumn
            // 
            versionDifferentDataGridViewCheckBoxColumn.DataPropertyName = "VersionDifferent";
            versionDifferentDataGridViewCheckBoxColumn.HeaderText = "VersionDifferent";
            versionDifferentDataGridViewCheckBoxColumn.Name = "versionDifferentDataGridViewCheckBoxColumn";
            versionDifferentDataGridViewCheckBoxColumn.ReadOnly = true;
            versionDifferentDataGridViewCheckBoxColumn.Visible = false;
            // 
            // lastWriteDifferentDataGridViewCheckBoxColumn
            // 
            lastWriteDifferentDataGridViewCheckBoxColumn.DataPropertyName = "LastWriteDifferent";
            lastWriteDifferentDataGridViewCheckBoxColumn.HeaderText = "LastWriteDifferent";
            lastWriteDifferentDataGridViewCheckBoxColumn.Name = "lastWriteDifferentDataGridViewCheckBoxColumn";
            lastWriteDifferentDataGridViewCheckBoxColumn.ReadOnly = true;
            lastWriteDifferentDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isDifferentDataGridViewCheckBoxColumn
            // 
            isDifferentDataGridViewCheckBoxColumn.DataPropertyName = "IsDifferent";
            isDifferentDataGridViewCheckBoxColumn.HeaderText = "IsDifferent";
            isDifferentDataGridViewCheckBoxColumn.Name = "isDifferentDataGridViewCheckBoxColumn";
            isDifferentDataGridViewCheckBoxColumn.ReadOnly = true;
            isDifferentDataGridViewCheckBoxColumn.Visible = false;
            // 
            // fileComparisonResultBindingSource
            // 
            fileComparisonResultBindingSource.DataSource = typeof(FileComparisonResult);
            // 
            // labelResults
            // 
            labelResults.AutoSize = true;
            labelResults.Location = new Point(93, 98);
            labelResults.Name = "labelResults";
            labelResults.Size = new Size(12, 15);
            labelResults.TabIndex = 7;
            labelResults.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 450);
            Controls.Add(labelResults);
            Controls.Add(dataGridView);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Compare Binaries";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileComparisonResultBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button3;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeInFolder1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeInFolder2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn versionInFolder1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn versionInFolder2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastWrite1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastWrite2DataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn sizeDifferenceDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn versionDifferentDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn lastWriteDifferentDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isDifferentDataGridViewCheckBoxColumn;
        private BindingSource fileComparisonResultBindingSource;
        private Label labelResults;
    }
}
