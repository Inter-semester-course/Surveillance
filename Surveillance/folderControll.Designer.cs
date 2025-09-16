namespace Surveillance
{
    partial class folderControll
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(folderControll));
            this.tailleTxt = new System.Windows.Forms.Label();
            this.dateTxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.nameTxt = new System.Windows.Forms.Label();
            this.pathTxt = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // tailleTxt
            // 
            this.tailleTxt.AutoSize = true;
            this.tailleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tailleTxt.Location = new System.Drawing.Point(160, 97);
            this.tailleTxt.Name = "tailleTxt";
            this.tailleTxt.Size = new System.Drawing.Size(35, 13);
            this.tailleTxt.TabIndex = 0;
            this.tailleTxt.Text = "label1";
            // 
            // dateTxt
            // 
            this.dateTxt.AutoSize = true;
            this.dateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTxt.Location = new System.Drawing.Point(160, 133);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(35, 13);
            this.dateTxt.TabIndex = 1;
            this.dateTxt.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chemin complet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date de Creation :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Taille :";
            // 
            // icon
            // 
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(324, 97);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(63, 45);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 6;
            this.icon.TabStop = false;
            // 
            // nameTxt
            // 
            this.nameTxt.AutoSize = true;
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(22, 35);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(44, 16);
            this.nameTxt.TabIndex = 7;
            this.nameTxt.Text = "label1";
            this.nameTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pathTxt
            // 
            this.pathTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pathTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pathTxt.Location = new System.Drawing.Point(144, 169);
            this.pathTxt.Name = "pathTxt";
            this.pathTxt.Size = new System.Drawing.Size(284, 35);
            this.pathTxt.TabIndex = 8;
            this.pathTxt.Text = "";
            // 
            // folderControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.pathTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.tailleTxt);
            this.Name = "folderControll";
            this.Size = new System.Drawing.Size(445, 222);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tailleTxt;
        private System.Windows.Forms.Label dateTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label nameTxt;
        private System.Windows.Forms.RichTextBox pathTxt;
    }
}
