namespace WindowsFormsApplication1
{
    partial class excelImportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.sheetTextBox = new System.Windows.Forms.TextBox();
            this.ChooseFile = new System.Windows.Forms.Button();
            this.LoadExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadSave = new System.Windows.Forms.Button();
            this.NewData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(109, 12);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(244, 20);
            this.pathTextBox.TabIndex = 0;
            this.pathTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sheetTextBox
            // 
            this.sheetTextBox.Location = new System.Drawing.Point(109, 38);
            this.sheetTextBox.Name = "sheetTextBox";
            this.sheetTextBox.Size = new System.Drawing.Size(244, 20);
            this.sheetTextBox.TabIndex = 1;
            // 
            // ChooseFile
            // 
            this.ChooseFile.Location = new System.Drawing.Point(359, 12);
            this.ChooseFile.Name = "ChooseFile";
            this.ChooseFile.Size = new System.Drawing.Size(75, 23);
            this.ChooseFile.TabIndex = 2;
            this.ChooseFile.Text = "Choose file";
            this.ChooseFile.UseVisualStyleBackColor = true;
            this.ChooseFile.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // LoadExcel
            // 
            this.LoadExcel.Location = new System.Drawing.Point(12, 76);
            this.LoadExcel.Name = "LoadExcel";
            this.LoadExcel.Size = new System.Drawing.Size(75, 23);
            this.LoadExcel.TabIndex = 3;
            this.LoadExcel.Text = "Load excel";
            this.LoadExcel.UseVisualStyleBackColor = true;
            this.LoadExcel.Click += new System.EventHandler(this.LoadExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "sheet name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(825, 315);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(765, 76);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadSave
            // 
            this.LoadSave.Location = new System.Drawing.Point(93, 76);
            this.LoadSave.Name = "LoadSave";
            this.LoadSave.Size = new System.Drawing.Size(75, 23);
            this.LoadSave.TabIndex = 8;
            this.LoadSave.Text = "Load Save";
            this.LoadSave.UseVisualStyleBackColor = true;
            this.LoadSave.Click += new System.EventHandler(this.LoadSave_Click);
            // 
            // NewData
            // 
            this.NewData.Location = new System.Drawing.Point(174, 76);
            this.NewData.Name = "NewData";
            this.NewData.Size = new System.Drawing.Size(75, 23);
            this.NewData.TabIndex = 9;
            this.NewData.Text = "New";
            this.NewData.UseVisualStyleBackColor = true;
            this.NewData.Click += new System.EventHandler(this.NewData_Click);
            // 
            // excelImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 432);
            this.Controls.Add(this.NewData);
            this.Controls.Add(this.LoadSave);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadExcel);
            this.Controls.Add(this.ChooseFile);
            this.Controls.Add(this.sheetTextBox);
            this.Controls.Add(this.pathTextBox);
            this.Name = "excelImportForm";
            this.Text = "excelImportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.TextBox sheetTextBox;
        private System.Windows.Forms.Button ChooseFile;
        private System.Windows.Forms.Button LoadExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadSave;
        private System.Windows.Forms.Button NewData;
    }
}