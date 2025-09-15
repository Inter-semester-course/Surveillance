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
            this.SuspendLayout();
            // 
            // chargerBtn
            // 
            this.chargerBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chargerBtn.Location = new System.Drawing.Point(12, 25);
            this.chargerBtn.Name = "chargerBtn";
            this.chargerBtn.Size = new System.Drawing.Size(144, 31);
            this.chargerBtn.TabIndex = 0;
            this.chargerBtn.Text = "Charger";
            this.chargerBtn.UseVisualStyleBackColor = true;
            this.chargerBtn.Click += new System.EventHandler(this.chargerBtn_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(220, 32);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(357, 20);
            this.txt.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 355);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.chargerBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chargerBtn;
        private System.Windows.Forms.TextBox txt;
    }
}

