﻿namespace Spielesammlung.Tic_Tac_Toe
{
    partial class form_TicTacToe
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
            this.btn_A1 = new System.Windows.Forms.Button();
            this.btn_A2 = new System.Windows.Forms.Button();
            this.btn_A3 = new System.Windows.Forms.Button();
            this.btn_B1 = new System.Windows.Forms.Button();
            this.btn_B2 = new System.Windows.Forms.Button();
            this.btn_B3 = new System.Windows.Forms.Button();
            this.btn_C1 = new System.Windows.Forms.Button();
            this.btn_C2 = new System.Windows.Forms.Button();
            this.btn_C3 = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_zug = new System.Windows.Forms.Label();
            this.lbl_zuganzeige = new System.Windows.Forms.Label();
            this.lbl_spielerX = new System.Windows.Forms.Label();
            this.lbl_spielerO = new System.Windows.Forms.Label();
            this.lbl_punkteX = new System.Windows.Forms.Label();
            this.lbl_punkteO = new System.Windows.Forms.Label();
            this.lbl_spielstand = new System.Windows.Forms.Label();
            this.btn_menue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_A1
            // 
            this.btn_A1.Font = new System.Drawing.Font("Arial", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_A1.Location = new System.Drawing.Point(100, 100);
            this.btn_A1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_A1.Name = "btn_A1";
            this.btn_A1.Size = new System.Drawing.Size(150, 150);
            this.btn_A1.TabIndex = 0;
            this.btn_A1.UseVisualStyleBackColor = true;
            this.btn_A1.Click += new System.EventHandler(this.btn_Spielfeld_Click);
            // 
            // btn_A2
            // 
            this.btn_A2.Font = new System.Drawing.Font("Arial", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_A2.Location = new System.Drawing.Point(250, 100);
            this.btn_A2.Margin = new System.Windows.Forms.Padding(0);
            this.btn_A2.Name = "btn_A2";
            this.btn_A2.Size = new System.Drawing.Size(150, 150);
            this.btn_A2.TabIndex = 1;
            this.btn_A2.UseVisualStyleBackColor = true;
            this.btn_A2.Click += new System.EventHandler(this.btn_Spielfeld_Click);
            // 
            // btn_A3
            // 
            this.btn_A3.Font = new System.Drawing.Font("Arial", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_A3.Location = new System.Drawing.Point(400, 100);
            this.btn_A3.Margin = new System.Windows.Forms.Padding(0);
            this.btn_A3.Name = "btn_A3";
            this.btn_A3.Size = new System.Drawing.Size(150, 150);
            this.btn_A3.TabIndex = 2;
            this.btn_A3.UseVisualStyleBackColor = true;
            this.btn_A3.Click += new System.EventHandler(this.btn_Spielfeld_Click);
            // 
            // btn_B1
            // 
            this.btn_B1.Font = new System.Drawing.Font("Arial", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_B1.Location = new System.Drawing.Point(100, 250);
            this.btn_B1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_B1.Name = "btn_B1";
            this.btn_B1.Size = new System.Drawing.Size(150, 150);
            this.btn_B1.TabIndex = 3;
            this.btn_B1.UseVisualStyleBackColor = true;
            this.btn_B1.Click += new System.EventHandler(this.btn_Spielfeld_Click);
            // 
            // btn_B2
            // 
            this.btn_B2.Font = new System.Drawing.Font("Arial", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_B2.Location = new System.Drawing.Point(250, 250);
            this.btn_B2.Margin = new System.Windows.Forms.Padding(0);
            this.btn_B2.Name = "btn_B2";
            this.btn_B2.Size = new System.Drawing.Size(150, 150);
            this.btn_B2.TabIndex = 4;
            this.btn_B2.UseVisualStyleBackColor = true;
            this.btn_B2.Click += new System.EventHandler(this.btn_Spielfeld_Click);
            // 
            // btn_B3
            // 
            this.btn_B3.Font = new System.Drawing.Font("Arial", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_B3.Location = new System.Drawing.Point(400, 250);
            this.btn_B3.Margin = new System.Windows.Forms.Padding(0);
            this.btn_B3.Name = "btn_B3";
            this.btn_B3.Size = new System.Drawing.Size(150, 150);
            this.btn_B3.TabIndex = 5;
            this.btn_B3.UseVisualStyleBackColor = true;
            this.btn_B3.Click += new System.EventHandler(this.btn_Spielfeld_Click);
            // 
            // btn_C1
            // 
            this.btn_C1.Font = new System.Drawing.Font("Arial", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C1.Location = new System.Drawing.Point(100, 400);
            this.btn_C1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_C1.Name = "btn_C1";
            this.btn_C1.Size = new System.Drawing.Size(150, 150);
            this.btn_C1.TabIndex = 6;
            this.btn_C1.UseVisualStyleBackColor = true;
            this.btn_C1.Click += new System.EventHandler(this.btn_Spielfeld_Click);
            // 
            // btn_C2
            // 
            this.btn_C2.Font = new System.Drawing.Font("Arial", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C2.Location = new System.Drawing.Point(250, 400);
            this.btn_C2.Margin = new System.Windows.Forms.Padding(0);
            this.btn_C2.Name = "btn_C2";
            this.btn_C2.Size = new System.Drawing.Size(150, 150);
            this.btn_C2.TabIndex = 7;
            this.btn_C2.UseVisualStyleBackColor = true;
            this.btn_C2.Click += new System.EventHandler(this.btn_Spielfeld_Click);
            // 
            // btn_C3
            // 
            this.btn_C3.Font = new System.Drawing.Font("Arial", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C3.Location = new System.Drawing.Point(400, 400);
            this.btn_C3.Margin = new System.Windows.Forms.Padding(0);
            this.btn_C3.Name = "btn_C3";
            this.btn_C3.Size = new System.Drawing.Size(150, 150);
            this.btn_C3.TabIndex = 8;
            this.btn_C3.UseVisualStyleBackColor = true;
            this.btn_C3.Click += new System.EventHandler(this.btn_Spielfeld_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(650, 444);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(200, 50);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "Zurücksetzen";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lbl_zug
            // 
            this.lbl_zug.BackColor = System.Drawing.Color.Lime;
            this.lbl_zug.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_zug.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zug.Location = new System.Drawing.Point(600, 100);
            this.lbl_zug.Name = "lbl_zug";
            this.lbl_zug.Size = new System.Drawing.Size(300, 50);
            this.lbl_zug.TabIndex = 10;
            this.lbl_zug.Text = "Am Zug:";
            this.lbl_zug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_zuganzeige
            // 
            this.lbl_zuganzeige.BackColor = System.Drawing.Color.Lime;
            this.lbl_zuganzeige.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_zuganzeige.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zuganzeige.Location = new System.Drawing.Point(600, 150);
            this.lbl_zuganzeige.Name = "lbl_zuganzeige";
            this.lbl_zuganzeige.Size = new System.Drawing.Size(300, 50);
            this.lbl_zuganzeige.TabIndex = 11;
            this.lbl_zuganzeige.Text = "Spieler X";
            this.lbl_zuganzeige.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_spielerX
            // 
            this.lbl_spielerX.BackColor = System.Drawing.Color.Yellow;
            this.lbl_spielerX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_spielerX.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spielerX.Location = new System.Drawing.Point(600, 300);
            this.lbl_spielerX.Name = "lbl_spielerX";
            this.lbl_spielerX.Size = new System.Drawing.Size(150, 50);
            this.lbl_spielerX.TabIndex = 12;
            this.lbl_spielerX.Text = "Spieler X";
            this.lbl_spielerX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_spielerO
            // 
            this.lbl_spielerO.BackColor = System.Drawing.Color.Yellow;
            this.lbl_spielerO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_spielerO.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spielerO.Location = new System.Drawing.Point(750, 300);
            this.lbl_spielerO.Name = "lbl_spielerO";
            this.lbl_spielerO.Size = new System.Drawing.Size(150, 50);
            this.lbl_spielerO.TabIndex = 13;
            this.lbl_spielerO.Text = "Spieler O";
            this.lbl_spielerO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_punkteX
            // 
            this.lbl_punkteX.BackColor = System.Drawing.Color.Yellow;
            this.lbl_punkteX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_punkteX.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_punkteX.Location = new System.Drawing.Point(600, 350);
            this.lbl_punkteX.Name = "lbl_punkteX";
            this.lbl_punkteX.Size = new System.Drawing.Size(150, 50);
            this.lbl_punkteX.TabIndex = 14;
            this.lbl_punkteX.Text = "0";
            this.lbl_punkteX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_punkteO
            // 
            this.lbl_punkteO.BackColor = System.Drawing.Color.Yellow;
            this.lbl_punkteO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_punkteO.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_punkteO.Location = new System.Drawing.Point(750, 350);
            this.lbl_punkteO.Name = "lbl_punkteO";
            this.lbl_punkteO.Size = new System.Drawing.Size(150, 50);
            this.lbl_punkteO.TabIndex = 15;
            this.lbl_punkteO.Text = "0";
            this.lbl_punkteO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_spielstand
            // 
            this.lbl_spielstand.BackColor = System.Drawing.Color.Yellow;
            this.lbl_spielstand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_spielstand.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spielstand.Location = new System.Drawing.Point(600, 250);
            this.lbl_spielstand.Name = "lbl_spielstand";
            this.lbl_spielstand.Size = new System.Drawing.Size(300, 50);
            this.lbl_spielstand.TabIndex = 16;
            this.lbl_spielstand.Text = "Spielstand";
            this.lbl_spielstand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_menue
            // 
            this.btn_menue.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menue.Location = new System.Drawing.Point(650, 500);
            this.btn_menue.Name = "btn_menue";
            this.btn_menue.Size = new System.Drawing.Size(200, 50);
            this.btn_menue.TabIndex = 17;
            this.btn_menue.Text = "Zum Menü";
            this.btn_menue.UseVisualStyleBackColor = true;
            this.btn_menue.Click += new System.EventHandler(this.btn_menue_Click);
            // 
            // form_TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_menue);
            this.Controls.Add(this.lbl_spielstand);
            this.Controls.Add(this.lbl_punkteO);
            this.Controls.Add(this.lbl_punkteX);
            this.Controls.Add(this.lbl_spielerO);
            this.Controls.Add(this.lbl_spielerX);
            this.Controls.Add(this.lbl_zuganzeige);
            this.Controls.Add(this.lbl_zug);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_C3);
            this.Controls.Add(this.btn_C2);
            this.Controls.Add(this.btn_C1);
            this.Controls.Add(this.btn_B3);
            this.Controls.Add(this.btn_B2);
            this.Controls.Add(this.btn_B1);
            this.Controls.Add(this.btn_A3);
            this.Controls.Add(this.btn_A2);
            this.Controls.Add(this.btn_A1);
            this.Name = "form_TicTacToe";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_A1;
        private System.Windows.Forms.Button btn_A2;
        private System.Windows.Forms.Button btn_A3;
        private System.Windows.Forms.Button btn_B1;
        private System.Windows.Forms.Button btn_B2;
        private System.Windows.Forms.Button btn_B3;
        private System.Windows.Forms.Button btn_C1;
        private System.Windows.Forms.Button btn_C2;
        private System.Windows.Forms.Button btn_C3;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_menue;
        private System.Windows.Forms.Label lbl_zug;
        private System.Windows.Forms.Label lbl_zuganzeige;
        private System.Windows.Forms.Label lbl_spielerX;
        private System.Windows.Forms.Label lbl_spielerO;
        private System.Windows.Forms.Label lbl_punkteX;
        private System.Windows.Forms.Label lbl_punkteO;
        private System.Windows.Forms.Label lbl_spielstand;
    }
}