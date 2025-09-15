namespace Surveillance
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
            this.chargerBtn = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // chargerBtn
            // 
            this.chargerBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chargerBtn.Location = new System.Drawing.Point(43, 25);
            this.chargerBtn.Name = "chargerBtn";
            this.chargerBtn.Size = new System.Drawing.Size(144, 31);
            this.chargerBtn.TabIndex = 0;
            this.chargerBtn.Text = "Charger";
            this.chargerBtn.UseVisualStyleBackColor = true;
            this.chargerBtn.Click += new System.EventHandler(this.chargerBtn_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(251, 32);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(357, 20);
            this.txt.TabIndex = 3;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Created);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Deleted);
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Renamed);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 83);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(303, 455);
            this.treeView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 550);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.chargerBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chargerBtn;
        private System.Windows.Forms.TextBox txt;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

