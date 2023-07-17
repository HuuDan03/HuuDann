namespace Question
{
    partial class Cau1
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
            this.txtc1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtc1
            // 
            this.txtc1.AutoSize = true;
            this.txtc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc1.Location = new System.Drawing.Point(208, 106);
            this.txtc1.Name = "txtc1";
            this.txtc1.Size = new System.Drawing.Size(92, 16);
            this.txtc1.TabIndex = 0;
            this.txtc1.Text = "Đây là câu 1";
            this.txtc1.UseWaitCursor = true;
            this.txtc1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cau1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtc1);
            this.Name = "Cau1";
            this.Text = "Cau1";
            this.Load += new System.EventHandler(this.Cau1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtc1;
    }
}