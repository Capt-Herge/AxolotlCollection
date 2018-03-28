namespace Pong
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Player1Score = new System.Windows.Forms.Label();
            this.Player2Score = new System.Windows.Forms.Label();
            this.WinButton = new System.Windows.Forms.Button();
            this.pauseLabel = new System.Windows.Forms.Label();
            this.labelAnleitung = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.neustartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zurückZumMenüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Player1.BackColor = System.Drawing.Color.Red;
            this.Player1.Location = new System.Drawing.Point(12, 266);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(20, 100);
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.SystemColors.Control;
            this.Ball.Image = ((System.Drawing.Image)(resources.GetObject("Ball.Image")));
            this.Ball.Location = new System.Drawing.Point(479, 266);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(20, 20);
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.Blue;
            this.Player2.Location = new System.Drawing.Point(976, 266);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(20, 100);
            this.Player2.TabIndex = 2;
            this.Player2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Player1Score
            // 
            this.Player1Score.AutoSize = true;
            this.Player1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Score.Location = new System.Drawing.Point(-6, 24);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Size = new System.Drawing.Size(30, 31);
            this.Player1Score.TabIndex = 3;
            this.Player1Score.Text = "0";
            // 
            // Player2Score
            // 
            this.Player2Score.AutoSize = true;
            this.Player2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Score.Location = new System.Drawing.Point(978, 24);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.Size = new System.Drawing.Size(30, 31);
            this.Player2Score.TabIndex = 4;
            this.Player2Score.Text = "0";
            // 
            // WinButton
            // 
            this.WinButton.Location = new System.Drawing.Point(429, 81);
            this.WinButton.Name = "WinButton";
            this.WinButton.Size = new System.Drawing.Size(121, 100);
            this.WinButton.TabIndex = 5;
            this.WinButton.Text = "button1";
            this.WinButton.UseVisualStyleBackColor = true;
            this.WinButton.Visible = false;
            this.WinButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pauseLabel
            // 
            this.pauseLabel.AutoSize = true;
            this.pauseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseLabel.Location = new System.Drawing.Point(377, 266);
            this.pauseLabel.Name = "pauseLabel";
            this.pauseLabel.Size = new System.Drawing.Size(220, 73);
            this.pauseLabel.TabIndex = 6;
            this.pauseLabel.Text = "Pause\r\n";
            this.pauseLabel.Visible = false;
            // 
            // labelAnleitung
            // 
            this.labelAnleitung.AutoSize = true;
            this.labelAnleitung.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnleitung.Location = new System.Drawing.Point(159, 164);
            this.labelAnleitung.Name = "labelAnleitung";
            this.labelAnleitung.Size = new System.Drawing.Size(89, 17);
            this.labelAnleitung.TabIndex = 7;
            this.labelAnleitung.Text = "Anleitung";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(469, 342);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(81, 27);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neustartToolStripMenuItem,
            this.zurückZumMenüToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.toolStripMenuItem1.Text = "Optionen";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // neustartToolStripMenuItem
            // 
            this.neustartToolStripMenuItem.Name = "neustartToolStripMenuItem";
            this.neustartToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.neustartToolStripMenuItem.Text = "Neustart";
            this.neustartToolStripMenuItem.Click += new System.EventHandler(this.neustartToolStripMenuItem_Click);
            // 
            // zurückZumMenüToolStripMenuItem
            // 
            this.zurückZumMenüToolStripMenuItem.Name = "zurückZumMenüToolStripMenuItem";
            this.zurückZumMenüToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.zurückZumMenüToolStripMenuItem.Text = "Zurück zum Menü";
            this.zurückZumMenüToolStripMenuItem.Click += new System.EventHandler(this.zurückZumMenüToolStripMenuItem_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(598, 342);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Beenden";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Visible = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelAnleitung);
            this.Controls.Add(this.pauseLabel);
            this.Controls.Add(this.WinButton);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.Player1Score);
            this.Controls.Add(this.Player2Score);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Form1";
            this.Text = "Pong";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Player1Score;
        private System.Windows.Forms.Label Player2Score;
        private System.Windows.Forms.Button WinButton;
        private System.Windows.Forms.Label pauseLabel;
        private System.Windows.Forms.Label labelAnleitung;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem neustartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zurückZumMenüToolStripMenuItem;
        private System.Windows.Forms.Button closeButton;
    }
}


