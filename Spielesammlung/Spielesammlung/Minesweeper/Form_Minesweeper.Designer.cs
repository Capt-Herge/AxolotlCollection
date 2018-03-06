namespace Spielesammlung.Minesweeper
{
    partial class Form_Minesweeper
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMinesweeper = new System.Windows.Forms.Panel();
            this.labelMinesweeper = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelAnleitung = new System.Windows.Forms.Label();
            this.labelHighscore = new System.Windows.Forms.Label();
            this.labelZeitWert = new System.Windows.Forms.Label();
            this.labelZeitText = new System.Windows.Forms.Label();
            this.timerMinesweeper = new System.Windows.Forms.Timer(this.components);
            this.buttonNeustart = new System.Windows.Forms.Button();
            this.labelGewonnen = new System.Windows.Forms.Label();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.textBoxSpieler = new System.Windows.Forms.TextBox();
            this.buttonWeiter = new System.Windows.Forms.Button();
            this.panelMinesweeper.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMinesweeper
            // 
            this.panelMinesweeper.BackColor = System.Drawing.Color.Black;
            this.panelMinesweeper.Controls.Add(this.labelGewonnen);
            this.panelMinesweeper.Controls.Add(this.buttonWeiter);
            this.panelMinesweeper.Controls.Add(this.textBoxSpieler);
            this.panelMinesweeper.Controls.Add(this.labelMinesweeper);
            this.panelMinesweeper.Controls.Add(this.buttonStart);
            this.panelMinesweeper.Controls.Add(this.labelAnleitung);
            this.panelMinesweeper.Controls.Add(this.labelHighscore);
            this.panelMinesweeper.Location = new System.Drawing.Point(58, 18);
            this.panelMinesweeper.Name = "panelMinesweeper";
            this.panelMinesweeper.Size = new System.Drawing.Size(700, 700);
            this.panelMinesweeper.TabIndex = 3;
            // 
            // labelMinesweeper
            // 
            this.labelMinesweeper.AutoSize = true;
            this.labelMinesweeper.BackColor = System.Drawing.Color.LightGray;
            this.labelMinesweeper.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinesweeper.Location = new System.Drawing.Point(270, 110);
            this.labelMinesweeper.Name = "labelMinesweeper";
            this.labelMinesweeper.Size = new System.Drawing.Size(190, 31);
            this.labelMinesweeper.TabIndex = 18;
            this.labelMinesweeper.Text = "Minesweeper";
            this.labelMinesweeper.Visible = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.LightGray;
            this.buttonStart.Enabled = false;
            this.buttonStart.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(320, 360);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(91, 37);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Visible = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelAnleitung
            // 
            this.labelAnleitung.AutoSize = true;
            this.labelAnleitung.BackColor = System.Drawing.Color.LightGray;
            this.labelAnleitung.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnleitung.Location = new System.Drawing.Point(114, 141);
            this.labelAnleitung.Name = "labelAnleitung";
            this.labelAnleitung.Size = new System.Drawing.Size(118, 23);
            this.labelAnleitung.TabIndex = 1;
            this.labelAnleitung.Text = "Anleitung";
            this.labelAnleitung.Visible = false;
            // 
            // labelHighscore
            // 
            this.labelHighscore.AutoSize = true;
            this.labelHighscore.BackColor = System.Drawing.Color.LightGray;
            this.labelHighscore.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighscore.Location = new System.Drawing.Point(237, 180);
            this.labelHighscore.Name = "labelHighscore";
            this.labelHighscore.Size = new System.Drawing.Size(158, 31);
            this.labelHighscore.TabIndex = 0;
            this.labelHighscore.Text = "Highscore";
            this.labelHighscore.Visible = false;
            // 
            // labelZeitWert
            // 
            this.labelZeitWert.AutoSize = true;
            this.labelZeitWert.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZeitWert.Location = new System.Drawing.Point(839, 139);
            this.labelZeitWert.Name = "labelZeitWert";
            this.labelZeitWert.Size = new System.Drawing.Size(110, 27);
            this.labelZeitWert.TabIndex = 5;
            this.labelZeitWert.Text = "0:00:00";
            // 
            // labelZeitText
            // 
            this.labelZeitText.AutoSize = true;
            this.labelZeitText.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZeitText.Location = new System.Drawing.Point(839, 98);
            this.labelZeitText.Name = "labelZeitText";
            this.labelZeitText.Size = new System.Drawing.Size(82, 27);
            this.labelZeitText.TabIndex = 4;
            this.labelZeitText.Text = "Zeit:";
            // 
            // buttonNeustart
            // 
            this.buttonNeustart.Enabled = false;
            this.buttonNeustart.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNeustart.Location = new System.Drawing.Point(828, 392);
            this.buttonNeustart.Name = "buttonNeustart";
            this.buttonNeustart.Size = new System.Drawing.Size(75, 23);
            this.buttonNeustart.TabIndex = 7;
            this.buttonNeustart.Text = "Neustart";
            this.buttonNeustart.UseVisualStyleBackColor = true;
            this.buttonNeustart.Visible = false;
            this.buttonNeustart.Click += new System.EventHandler(this.buttonNeustart_Click);
            // 
            // labelGewonnen
            // 
            this.labelGewonnen.AutoSize = true;
            this.labelGewonnen.BackColor = System.Drawing.Color.LightGray;
            this.labelGewonnen.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGewonnen.Location = new System.Drawing.Point(154, 211);
            this.labelGewonnen.Name = "labelGewonnen";
            this.labelGewonnen.Size = new System.Drawing.Size(142, 31);
            this.labelGewonnen.TabIndex = 8;
            this.labelGewonnen.Text = "Gewonnen";
            this.labelGewonnen.Visible = false;
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.Location = new System.Drawing.Point(794, 350);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(138, 27);
            this.labelGameOver.TabIndex = 6;
            this.labelGameOver.Text = "Game Over";
            this.labelGameOver.Visible = false;
            // 
            // textBoxSpieler
            // 
            this.textBoxSpieler.BackColor = System.Drawing.Color.LightGray;
            this.textBoxSpieler.Enabled = false;
            this.textBoxSpieler.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSpieler.Location = new System.Drawing.Point(223, 385);
            this.textBoxSpieler.MaxLength = 3;
            this.textBoxSpieler.Name = "textBoxSpieler";
            this.textBoxSpieler.Size = new System.Drawing.Size(91, 38);
            this.textBoxSpieler.TabIndex = 19;
            this.textBoxSpieler.Visible = false;
            // 
            // buttonWeiter
            // 
            this.buttonWeiter.BackColor = System.Drawing.Color.LightGray;
            this.buttonWeiter.Enabled = false;
            this.buttonWeiter.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWeiter.Location = new System.Drawing.Point(420, 385);
            this.buttonWeiter.Name = "buttonWeiter";
            this.buttonWeiter.Size = new System.Drawing.Size(91, 38);
            this.buttonWeiter.TabIndex = 20;
            this.buttonWeiter.Text = "Weiter";
            this.buttonWeiter.UseVisualStyleBackColor = false;
            this.buttonWeiter.Visible = false;
            this.buttonWeiter.Click += new System.EventHandler(this.buttonWeiter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.buttonNeustart);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.labelZeitWert);
            this.Controls.Add(this.labelZeitText);
            this.Controls.Add(this.panelMinesweeper);
            this.Name = "Form1";
            this.Text = "Form_Minesweeper";
            this.panelMinesweeper.ResumeLayout(false);
            this.panelMinesweeper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMinesweeper;
        private System.Windows.Forms.Label labelZeitWert;
        private System.Windows.Forms.Label labelZeitText;
        private System.Windows.Forms.Timer timerMinesweeper;
        private System.Windows.Forms.Button buttonNeustart;
        private System.Windows.Forms.Label labelGewonnen;
        private System.Windows.Forms.Label labelHighscore;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelAnleitung;
        private System.Windows.Forms.Label labelMinesweeper;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Button buttonWeiter;
        private System.Windows.Forms.TextBox textBoxSpieler;
    }
}