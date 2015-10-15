namespace WindowsFormsApplication1
{
    partial class loadExcele
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChooseFile = new System.Windows.Forms.Button();
            this.sheetTextBox = new System.Windows.Forms.TextBox();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.Done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "sheet name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "File path";
            // 
            // ChooseFile
            // 
            this.ChooseFile.Location = new System.Drawing.Point(360, 12);
            this.ChooseFile.Name = "ChooseFile";
            this.ChooseFile.Size = new System.Drawing.Size(88, 23);
            this.ChooseFile.TabIndex = 8;
            this.ChooseFile.Text = "Load file Path";
            this.ChooseFile.UseVisualStyleBackColor = true;
            this.ChooseFile.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // sheetTextBox
            // 
            this.sheetTextBox.Location = new System.Drawing.Point(110, 38);
            this.sheetTextBox.Name = "sheetTextBox";
            this.sheetTextBox.Size = new System.Drawing.Size(244, 20);
            this.sheetTextBox.TabIndex = 7;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(110, 12);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(244, 20);
            this.pathTextBox.TabIndex = 6;
            // 
            // Done
            // 
            this.Done.Location = new System.Drawing.Point(385, 107);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(75, 23);
            this.Done.TabIndex = 11;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // loadExcele
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 142);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseFile);
            this.Controls.Add(this.sheetTextBox);
            this.Controls.Add(this.pathTextBox);
            this.Name = "loadExcele";
            this.Text = "loadExcele";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChooseFile;
        private System.Windows.Forms.TextBox sheetTextBox;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button Done;
    }
}