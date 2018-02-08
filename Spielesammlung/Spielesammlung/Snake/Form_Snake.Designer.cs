namespace Spielesammlung
{
    partial class Form_Snake
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Snake));
            this.pictureBoxSnake = new System.Windows.Forms.PictureBox();
            this.labelScoreText = new System.Windows.Forms.Label();
            this.labelScoreWert = new System.Windows.Forms.Label();
            this.timerSnake = new System.Windows.Forms.Timer(this.components);
            this.labelGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnake)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSnake
            // 
            this.pictureBoxSnake.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBoxSnake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSnake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSnake.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSnake.Image")));
            this.pictureBoxSnake.Location = new System.Drawing.Point(14, 18);
            this.pictureBoxSnake.Name = "pictureBoxSnake";
            this.pictureBoxSnake.Size = new System.Drawing.Size(900, 700);
            this.pictureBoxSnake.TabIndex = 0;
            this.pictureBoxSnake.TabStop = false;
            this.pictureBoxSnake.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxSnake_Paint);
            // 
            // labelScoreText
            // 
            this.labelScoreText.AutoSize = true;
            this.labelScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreText.Location = new System.Drawing.Point(920, 142);
            this.labelScoreText.Name = "labelScoreText";
            this.labelScoreText.Size = new System.Drawing.Size(82, 29);
            this.labelScoreText.TabIndex = 1;
            this.labelScoreText.Text = "Score";
            // 
            // labelScoreWert
            // 
            this.labelScoreWert.AutoSize = true;
            this.labelScoreWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreWert.Location = new System.Drawing.Point(920, 184);
            this.labelScoreWert.Name = "labelScoreWert";
            this.labelScoreWert.Size = new System.Drawing.Size(34, 29);
            this.labelScoreWert.TabIndex = 2;
            this.labelScoreWert.Text = "...";
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.Location = new System.Drawing.Point(330, 226);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(203, 42);
            this.labelGameOver.TabIndex = 3;
            this.labelGameOver.Text = "game over";
            this.labelGameOver.Visible = false;
            // 
            // Form_Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.labelScoreWert);
            this.Controls.Add(this.labelScoreText);
            this.Controls.Add(this.pictureBoxSnake);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Snake";
            this.Text = "Form_Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Snake_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_Snake_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSnake;
        private System.Windows.Forms.Label labelScoreText;
        private System.Windows.Forms.Label labelScoreWert;
        private System.Windows.Forms.Timer timerSnake;
        private System.Windows.Forms.Label labelGameOver;
    }
}