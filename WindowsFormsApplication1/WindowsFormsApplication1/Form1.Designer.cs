namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.ConnectMySql = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ipCheckOutput = new System.Windows.Forms.Label();
            this.IPcheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckIPbtn = new System.Windows.Forms.Button();
            this.IPtxt = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.LocalServerBtn = new System.Windows.Forms.Button();
            this.LocalServerLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SendString = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testItem1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testItem2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dunno1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dunno2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dunno1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dunno2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectMySql
            // 
            this.ConnectMySql.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectMySql.Location = new System.Drawing.Point(3, 119);
            this.ConnectMySql.Name = "ConnectMySql";
            this.ConnectMySql.Size = new System.Drawing.Size(75, 23);
            this.ConnectMySql.TabIndex = 0;
            this.ConnectMySql.Text = "Insert";
            this.ConnectMySql.UseVisualStyleBackColor = true;
            this.ConnectMySql.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "TableC";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(644, 473);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SendString);
            this.panel1.Controls.Add(this.LocalServerLabel);
            this.panel1.Controls.Add(this.LocalServerBtn);
            this.panel1.Controls.Add(this.ipCheckOutput);
            this.panel1.Controls.Add(this.IPcheckBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CheckIPbtn);
            this.panel1.Controls.Add(this.IPtxt);
            this.panel1.Controls.Add(this.UpdateBtn);
            this.panel1.Controls.Add(this.ConnectMySql);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 470);
            this.panel1.TabIndex = 6;
            // 
            // ipCheckOutput
            // 
            this.ipCheckOutput.AutoSize = true;
            this.ipCheckOutput.Location = new System.Drawing.Point(565, 129);
            this.ipCheckOutput.Name = "ipCheckOutput";
            this.ipCheckOutput.Size = new System.Drawing.Size(0, 13);
            this.ipCheckOutput.TabIndex = 10;
            // 
            // IPcheckBox
            // 
            this.IPcheckBox.AutoSize = true;
            this.IPcheckBox.Location = new System.Drawing.Point(525, 67);
            this.IPcheckBox.Name = "IPcheckBox";
            this.IPcheckBox.Size = new System.Drawing.Size(113, 17);
            this.IPcheckBox.TabIndex = 9;
            this.IPcheckBox.Text = "Continue to check";
            this.IPcheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Check this IP";
            // 
            // CheckIPbtn
            // 
            this.CheckIPbtn.Location = new System.Drawing.Point(546, 90);
            this.CheckIPbtn.Name = "CheckIPbtn";
            this.CheckIPbtn.Size = new System.Drawing.Size(75, 23);
            this.CheckIPbtn.TabIndex = 7;
            this.CheckIPbtn.Text = "OK";
            this.CheckIPbtn.UseVisualStyleBackColor = true;
            this.CheckIPbtn.Click += new System.EventHandler(this.CheckIPbtn_Click);
            // 
            // IPtxt
            // 
            this.IPtxt.Location = new System.Drawing.Point(528, 38);
            this.IPtxt.Name = "IPtxt";
            this.IPtxt.Size = new System.Drawing.Size(113, 20);
            this.IPtxt.TabIndex = 6;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(3, 35);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 5;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // LocalServerBtn
            // 
            this.LocalServerBtn.Location = new System.Drawing.Point(298, 309);
            this.LocalServerBtn.Name = "LocalServerBtn";
            this.LocalServerBtn.Size = new System.Drawing.Size(75, 23);
            this.LocalServerBtn.TabIndex = 11;
            this.LocalServerBtn.Text = "LocalServer";
            this.LocalServerBtn.UseVisualStyleBackColor = true;
            this.LocalServerBtn.Click += new System.EventHandler(this.LocalServerBtn_Click);
            // 
            // LocalServerLabel
            // 
            this.LocalServerLabel.AutoSize = true;
            this.LocalServerLabel.Location = new System.Drawing.Point(295, 374);
            this.LocalServerLabel.Name = "LocalServerLabel";
            this.LocalServerLabel.Size = new System.Drawing.Size(35, 13);
            this.LocalServerLabel.TabIndex = 12;
            this.LocalServerLabel.Text = "label2";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // SendString
            // 
            this.SendString.Location = new System.Drawing.Point(401, 309);
            this.SendString.Name = "SendString";
            this.SendString.Size = new System.Drawing.Size(75, 23);
            this.SendString.TabIndex = 13;
            this.SendString.Text = "SendString";
            this.SendString.UseVisualStyleBackColor = true;
            this.SendString.Click += new System.EventHandler(this.SendString_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.test2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testItem1ToolStripMenuItem,
            this.testItem2ToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.test2ToolStripMenuItem.Text = "Test2";
            // 
            // testItem1ToolStripMenuItem
            // 
            this.testItem1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dunno1ToolStripMenuItem,
            this.dunno2ToolStripMenuItem});
            this.testItem1ToolStripMenuItem.Name = "testItem1ToolStripMenuItem";
            this.testItem1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testItem1ToolStripMenuItem.Text = "test item 1";
            // 
            // testItem2ToolStripMenuItem
            // 
            this.testItem2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dunno1ToolStripMenuItem1,
            this.dunno2ToolStripMenuItem1});
            this.testItem2ToolStripMenuItem.Name = "testItem2ToolStripMenuItem";
            this.testItem2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testItem2ToolStripMenuItem.Text = "test item 2";
            // 
            // dunno1ToolStripMenuItem
            // 
            this.dunno1ToolStripMenuItem.Name = "dunno1ToolStripMenuItem";
            this.dunno1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dunno1ToolStripMenuItem.Text = "dunno1";
            this.dunno1ToolStripMenuItem.Click += new System.EventHandler(this.dunno1ToolStripMenuItem_Click);
            // 
            // dunno2ToolStripMenuItem
            // 
            this.dunno2ToolStripMenuItem.Name = "dunno2ToolStripMenuItem";
            this.dunno2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dunno2ToolStripMenuItem.Text = "dunno2";
            // 
            // dunno1ToolStripMenuItem1
            // 
            this.dunno1ToolStripMenuItem1.Name = "dunno1ToolStripMenuItem1";
            this.dunno1ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.dunno1ToolStripMenuItem1.Text = "dunno1";
            // 
            // dunno2ToolStripMenuItem1
            // 
            this.dunno2ToolStripMenuItem1.Name = "dunno2ToolStripMenuItem1";
            this.dunno2ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.dunno2ToolStripMenuItem1.Text = "dunno2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 497);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConnectMySql;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CheckIPbtn;
        private System.Windows.Forms.TextBox IPtxt;
        private System.Windows.Forms.Label ipCheckOutput;
        private System.Windows.Forms.CheckBox IPcheckBox;
        private System.Windows.Forms.Label LocalServerLabel;
        private System.Windows.Forms.Button LocalServerBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button SendString;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testItem1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dunno1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dunno2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testItem2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dunno1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dunno2ToolStripMenuItem1;
    }
}

