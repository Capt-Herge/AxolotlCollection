namespace Spielesammlung.Flappy_Bird
{
    partial class Flappy_Bird
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
            this.Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Enabled = false;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.Coral;
            this.Score.Location = new System.Drawing.Point(433, 81);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(149, 104);
            this.Score.TabIndex = 0;
            this.Score.Text = "asdf";
            this.Score.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Score.UseCompatibleTextRendering = true;
            // 
            // Flappy_Bird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 723);
            this.Controls.Add(this.Score);
            this.MaximumSize = new System.Drawing.Size(1022, 762);
            this.MinimumSize = new System.Drawing.Size(1022, 762);
            this.Name = "Flappy_Bird";
            this.Text = "Flappy_Bird";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Score;
    }
}