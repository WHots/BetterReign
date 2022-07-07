namespace BetterReign
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_FileSizeMb = new System.Windows.Forms.Label();
            this.label_FileDirectory = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_ProcessPriority = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_SuspendedThreadCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_ProcessHandleCount = new System.Windows.Forms.Label();
            this.label_ProcessStartArugments = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_ProcessThreadCount = new System.Windows.Forms.Label();
            this.label_ProcessWindowTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ProcessMemoryUsage = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_File_SelectFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 27);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 225);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(687, 197);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label_FileSizeMb);
            this.groupBox2.Controls.Add(this.label_FileDirectory);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(327, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 188);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File";
            // 
            // label_FileSizeMb
            // 
            this.label_FileSizeMb.AutoSize = true;
            this.label_FileSizeMb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_FileSizeMb.Location = new System.Drawing.Point(69, 19);
            this.label_FileSizeMb.Name = "label_FileSizeMb";
            this.label_FileSizeMb.Size = new System.Drawing.Size(20, 15);
            this.label_FileSizeMb.TabIndex = 8;
            this.label_FileSizeMb.Text = "na";
            // 
            // label_FileDirectory
            // 
            this.label_FileDirectory.AutoSize = true;
            this.label_FileDirectory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_FileDirectory.Location = new System.Drawing.Point(69, 36);
            this.label_FileDirectory.Name = "label_FileDirectory";
            this.label_FileDirectory.Size = new System.Drawing.Size(20, 15);
            this.label_FileDirectory.TabIndex = 7;
            this.label_FileDirectory.Text = "na";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 14);
            this.label9.TabIndex = 2;
            this.label9.Text = "Directory: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label_ProcessPriority);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label_SuspendedThreadCount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label_ProcessHandleCount);
            this.groupBox1.Controls.Add(this.label_ProcessStartArugments);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label_ProcessThreadCount);
            this.groupBox1.Controls.Add(this.label_ProcessWindowTitle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_ProcessMemoryUsage);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 188);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // label_ProcessPriority
            // 
            this.label_ProcessPriority.AutoSize = true;
            this.label_ProcessPriority.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ProcessPriority.Location = new System.Drawing.Point(120, 111);
            this.label_ProcessPriority.Name = "label_ProcessPriority";
            this.label_ProcessPriority.Size = new System.Drawing.Size(20, 15);
            this.label_ProcessPriority.TabIndex = 15;
            this.label_ProcessPriority.Text = "na";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 14);
            this.label8.TabIndex = 14;
            this.label8.Text = "Priority: ";
            // 
            // label_SuspendedThreadCount
            // 
            this.label_SuspendedThreadCount.AutoSize = true;
            this.label_SuspendedThreadCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SuspendedThreadCount.Location = new System.Drawing.Point(120, 81);
            this.label_SuspendedThreadCount.Name = "label_SuspendedThreadCount";
            this.label_SuspendedThreadCount.Size = new System.Drawing.Size(20, 15);
            this.label_SuspendedThreadCount.TabIndex = 13;
            this.label_SuspendedThreadCount.Text = "na";
            this.label_SuspendedThreadCount.TextChanged += new System.EventHandler(this.label_SuspendedThreadCount_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "Suspended threads:  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Handles: ";
            // 
            // label_ProcessHandleCount
            // 
            this.label_ProcessHandleCount.AutoSize = true;
            this.label_ProcessHandleCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ProcessHandleCount.Location = new System.Drawing.Point(120, 95);
            this.label_ProcessHandleCount.Name = "label_ProcessHandleCount";
            this.label_ProcessHandleCount.Size = new System.Drawing.Size(20, 15);
            this.label_ProcessHandleCount.TabIndex = 11;
            this.label_ProcessHandleCount.Text = "na";
            // 
            // label_ProcessStartArugments
            // 
            this.label_ProcessStartArugments.AutoSize = true;
            this.label_ProcessStartArugments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ProcessStartArugments.Location = new System.Drawing.Point(120, 52);
            this.label_ProcessStartArugments.Name = "label_ProcessStartArugments";
            this.label_ProcessStartArugments.Size = new System.Drawing.Size(20, 15);
            this.label_ProcessStartArugments.TabIndex = 9;
            this.label_ProcessStartArugments.Text = "na";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Allocated memory: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Threads: ";
            // 
            // label_ProcessThreadCount
            // 
            this.label_ProcessThreadCount.AutoSize = true;
            this.label_ProcessThreadCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ProcessThreadCount.Location = new System.Drawing.Point(120, 67);
            this.label_ProcessThreadCount.Name = "label_ProcessThreadCount";
            this.label_ProcessThreadCount.Size = new System.Drawing.Size(20, 15);
            this.label_ProcessThreadCount.TabIndex = 10;
            this.label_ProcessThreadCount.Text = "na";
            // 
            // label_ProcessWindowTitle
            // 
            this.label_ProcessWindowTitle.AutoSize = true;
            this.label_ProcessWindowTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ProcessWindowTitle.Location = new System.Drawing.Point(120, 22);
            this.label_ProcessWindowTitle.Name = "label_ProcessWindowTitle";
            this.label_ProcessWindowTitle.Size = new System.Drawing.Size(20, 15);
            this.label_ProcessWindowTitle.TabIndex = 6;
            this.label_ProcessWindowTitle.Text = "na";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Arguments: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title: ";
            // 
            // label_ProcessMemoryUsage
            // 
            this.label_ProcessMemoryUsage.AutoSize = true;
            this.label_ProcessMemoryUsage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ProcessMemoryUsage.Location = new System.Drawing.Point(120, 37);
            this.label_ProcessMemoryUsage.Name = "label_ProcessMemoryUsage";
            this.label_ProcessMemoryUsage.Size = new System.Drawing.Size(20, 15);
            this.label_ProcessMemoryUsage.TabIndex = 8;
            this.label_ProcessMemoryUsage.Text = "na";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(687, 197);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ragnar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitem_File_SelectFile});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuitem_File_SelectFile
            // 
            this.menuitem_File_SelectFile.Name = "menuitem_File_SelectFile";
            this.menuitem_File_SelectFile.Size = new System.Drawing.Size(180, 22);
            this.menuitem_File_SelectFile.Text = "Select file ...";
            this.menuitem_File_SelectFile.Click += new System.EventHandler(this.menuitem_File_SelectFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 257);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asystole";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label6;
        private Label label_ProcessWindowTitle;
        private Label label_ProcessHandleCount;
        private Label label_ProcessThreadCount;
        private Label label_ProcessStartArugments;
        private Label label_ProcessMemoryUsage;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem menuitem_File_SelectFile;
        private Label label_SuspendedThreadCount;
        private Label label7;
        private Label label_ProcessPriority;
        private Label label8;
        private GroupBox groupBox2;
        private Label label_FileSizeMb;
        private Label label_FileDirectory;
        private Label label9;
        private Label label2;
    }
}