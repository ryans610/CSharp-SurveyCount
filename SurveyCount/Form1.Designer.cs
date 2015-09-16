namespace SurveyCount
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countCToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Location = new System.Drawing.Point(12, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(133, 185);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Count";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(152, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 184);
            this.listBox1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.countCToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileOToolStripMenuItem,
            this.saveFileSToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitEToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.fileToolStripMenuItem.Text = "File(&F)";
            // 
            // openFileOToolStripMenuItem
            // 
            this.openFileOToolStripMenuItem.Name = "openFileOToolStripMenuItem";
            this.openFileOToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openFileOToolStripMenuItem.Text = "OpenFile(&O)";
            this.openFileOToolStripMenuItem.Click += new System.EventHandler(this.openFileOToolStripMenuItem_Click);
            // 
            // saveFileSToolStripMenuItem
            // 
            this.saveFileSToolStripMenuItem.Name = "saveFileSToolStripMenuItem";
            this.saveFileSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveFileSToolStripMenuItem.Text = "SaveFile(&S)";
            this.saveFileSToolStripMenuItem.Click += new System.EventHandler(this.saveFileSToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitEToolStripMenuItem
            // 
            this.exitEToolStripMenuItem.Name = "exitEToolStripMenuItem";
            this.exitEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitEToolStripMenuItem.Text = "Exit(&E)";
            this.exitEToolStripMenuItem.Click += new System.EventHandler(this.exitEToolStripMenuItem_Click);
            // 
            // countCToolStripMenuItem
            // 
            this.countCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countCToolStripMenuItem1,
            this.clearRToolStripMenuItem});
            this.countCToolStripMenuItem.Name = "countCToolStripMenuItem";
            this.countCToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.countCToolStripMenuItem.Text = "Edit(&E)";
            // 
            // countCToolStripMenuItem1
            // 
            this.countCToolStripMenuItem1.Name = "countCToolStripMenuItem1";
            this.countCToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.countCToolStripMenuItem1.Text = "Count(&C)";
            this.countCToolStripMenuItem1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearRToolStripMenuItem
            // 
            this.clearRToolStripMenuItem.Name = "clearRToolStripMenuItem";
            this.clearRToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.clearRToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearRToolStripMenuItem.Text = "Reset(&R)";
            this.clearRToolStripMenuItem.Click += new System.EventHandler(this.clearRToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SurveyCount";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countCToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearRToolStripMenuItem;
    }
}

