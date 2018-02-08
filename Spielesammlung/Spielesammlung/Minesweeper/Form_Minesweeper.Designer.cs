namespace Spielesammlung
{
    partial class Form_Minesweeper
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
            this.labelZeitText = new System.Windows.Forms.Label();
            this.labelZeitWert = new System.Windows.Forms.Label();
            this.panelMinesweeper = new System.Windows.Forms.Panel();
            this.timerMinesweeper = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelZeitText
            // 
            this.labelZeitText.AutoSize = true;
            this.labelZeitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZeitText.Location = new System.Drawing.Point(877, 120);
            this.labelZeitText.Name = "labelZeitText";
            this.labelZeitText.Size = new System.Drawing.Size(64, 29);
            this.labelZeitText.TabIndex = 0;
            this.labelZeitText.Text = "Zeit:";
            // 
            // labelZeitWert
            // 
            this.labelZeitWert.AutoSize = true;
            this.labelZeitWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZeitWert.Location = new System.Drawing.Point(907, 176);
            this.labelZeitWert.Name = "labelZeitWert";
            this.labelZeitWert.Size = new System.Drawing.Size(34, 29);
            this.labelZeitWert.TabIndex = 1;
            this.labelZeitWert.Text = "...";
            // 
            // panelMinesweeper
            // 
            this.panelMinesweeper.BackColor = System.Drawing.Color.Gray;
            this.panelMinesweeper.Location = new System.Drawing.Point(108, 18);
            this.panelMinesweeper.Name = "panelMinesweeper";
            this.panelMinesweeper.Size = new System.Drawing.Size(700, 700);
            this.panelMinesweeper.TabIndex = 2;
            // 
            // Form_Minesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.panelMinesweeper);
            this.Controls.Add(this.labelZeitWert);
            this.Controls.Add(this.labelZeitText);
            this.Name = "Form_Minesweeper";
            this.Text = "Form_Minesweeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZeitText;
        private System.Windows.Forms.Label labelZeitWert;
        private System.Windows.Forms.Panel panelMinesweeper;
        private System.Windows.Forms.Timer timerMinesweeper;
    }
}