namespace tictactoe_game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            labelWinOCount = new Label();
            labelWinXCount = new Label();
            labelCurrentPlayer = new Label();
            btnReset = new Button();
            labelDrawCount = new Label();
            labelTotalGames = new Label();
            labelGameTimer = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            btnNewGame = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 20);
            label1.Name = "label1";
            label1.Size = new Size(300, 30);
            label1.TabIndex = 0;
            label1.Text = "🎮 TIC-TAC-TOE GAME 🎮";
            label1.ForeColor = Color.DarkBlue;
            // 
            // btn0
            // 
            btn0.Location = new Point(200, 100);
            btn0.Name = "btn0";
            btn0.Size = new Size(80, 80);
            btn0.TabIndex = 1;
            btn0.Text = "";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            btn0.Font = new Font("Arial", 24F, FontStyle.Bold);
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.FlatAppearance.BorderSize = 2;
            btn0.FlatAppearance.BorderColor = Color.Black;
            // 
            // btn1
            // 
            btn1.Location = new Point(290, 100);
            btn1.Name = "btn1";
            btn1.Size = new Size(80, 80);
            btn1.TabIndex = 2;
            btn1.Text = "";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            btn1.Font = new Font("Arial", 24F, FontStyle.Bold);
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.FlatAppearance.BorderSize = 2;
            btn1.FlatAppearance.BorderColor = Color.Black;
            // 
            // btn2
            // 
            btn2.Location = new Point(380, 100);
            btn2.Name = "btn2";
            btn2.Size = new Size(80, 80);
            btn2.TabIndex = 3;
            btn2.Text = "";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            btn2.Font = new Font("Arial", 24F, FontStyle.Bold);
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.FlatAppearance.BorderSize = 2;
            btn2.FlatAppearance.BorderColor = Color.Black;
            // 
            // btn3
            // 
            btn3.Location = new Point(200, 190);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 80);
            btn3.TabIndex = 4;
            btn3.Text = "";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            btn3.Font = new Font("Arial", 24F, FontStyle.Bold);
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.FlatAppearance.BorderSize = 2;
            btn3.FlatAppearance.BorderColor = Color.Black;
            // 
            // btn4
            // 
            btn4.Location = new Point(290, 190);
            btn4.Name = "btn4";
            btn4.Size = new Size(80, 80);
            btn4.TabIndex = 5;
            btn4.Text = "";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            btn4.Font = new Font("Arial", 24F, FontStyle.Bold);
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.FlatAppearance.BorderSize = 2;
            btn4.FlatAppearance.BorderColor = Color.Black;
            // 
            // btn5
            // 
            btn5.Location = new Point(380, 190);
            btn5.Name = "btn5";
            btn5.Size = new Size(80, 80);
            btn5.TabIndex = 6;
            btn5.Text = "";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            btn5.Font = new Font("Arial", 24F, FontStyle.Bold);
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.FlatAppearance.BorderSize = 2;
            btn5.FlatAppearance.BorderColor = Color.Black;
            // 
            // btn6
            // 
            btn6.Location = new Point(200, 280);
            btn6.Name = "btn6";
            btn6.Size = new Size(80, 80);
            btn6.TabIndex = 7;
            btn6.Text = "";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            btn6.Font = new Font("Arial", 24F, FontStyle.Bold);
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.FlatAppearance.BorderSize = 2;
            btn6.FlatAppearance.BorderColor = Color.Black;
            // 
            // btn7
            // 
            btn7.Location = new Point(290, 280);
            btn7.Name = "btn7";
            btn7.Size = new Size(80, 80);
            btn7.TabIndex = 8;
            btn7.Text = "";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            btn7.Font = new Font("Arial", 24F, FontStyle.Bold);
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.FlatAppearance.BorderSize = 2;
            btn7.FlatAppearance.BorderColor = Color.Black;
            // 
            // btn8
            // 
            btn8.Location = new Point(380, 280);
            btn8.Name = "btn8";
            btn8.Size = new Size(80, 80);
            btn8.TabIndex = 9;
            btn8.Text = "";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            btn8.Font = new Font("Arial", 24F, FontStyle.Bold);
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.FlatAppearance.BorderSize = 2;
            btn8.FlatAppearance.BorderColor = Color.Black;
            // 
            // labelWinOCount
            // 
            labelWinOCount.AutoSize = true;
            labelWinOCount.Location = new Point(500, 120);
            labelWinOCount.Name = "labelWinOCount";
            labelWinOCount.Size = new Size(70, 20);
            labelWinOCount.TabIndex = 10;
            labelWinOCount.Text = "O Wins: 0";
            labelWinOCount.Font = new Font("Arial", 12F, FontStyle.Bold);
            labelWinOCount.ForeColor = Color.Red;
            // 
            // labelWinXCount
            // 
            labelWinXCount.AutoSize = true;
            labelWinXCount.Location = new Point(500, 150);
            labelWinXCount.Name = "labelWinXCount";
            labelWinXCount.Size = new Size(70, 20);
            labelWinXCount.TabIndex = 11;
            labelWinXCount.Text = "X Wins: 0";
            labelWinXCount.Font = new Font("Arial", 12F, FontStyle.Bold);
            labelWinXCount.ForeColor = Color.Blue;
            // 
            // labelCurrentPlayer
            // 
            labelCurrentPlayer.AutoSize = true;
            labelCurrentPlayer.Location = new Point(300, 70);
            labelCurrentPlayer.Name = "labelCurrentPlayer";
            labelCurrentPlayer.Size = new Size(120, 20);
            labelCurrentPlayer.TabIndex = 12;
            labelCurrentPlayer.Text = "Current Player: X";
            labelCurrentPlayer.Font = new Font("Arial", 12F, FontStyle.Bold);
            labelCurrentPlayer.ForeColor = Color.DarkGreen;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(500, 250);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 40);
            btnReset.TabIndex = 13;
            btnReset.Text = "🔄 Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            btnReset.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.FlatAppearance.BorderColor = Color.DarkBlue;
            btnReset.BackColor = Color.LightBlue;
            // 
            // labelDrawCount
            // 
            labelDrawCount.AutoSize = true;
            labelDrawCount.Location = new Point(500, 180);
            labelDrawCount.Name = "labelDrawCount";
            labelDrawCount.Size = new Size(70, 20);
            labelDrawCount.TabIndex = 14;
            labelDrawCount.Text = "Draws: 0";
            labelDrawCount.Font = new Font("Arial", 12F, FontStyle.Bold);
            labelDrawCount.ForeColor = Color.Orange;
            // 
            // labelTotalGames
            // 
            labelTotalGames.AutoSize = true;
            labelTotalGames.Location = new Point(500, 210);
            labelTotalGames.Name = "labelTotalGames";
            labelTotalGames.Size = new Size(100, 20);
            labelTotalGames.TabIndex = 15;
            labelTotalGames.Text = "Total Games: 0";
            labelTotalGames.Font = new Font("Arial", 10F, FontStyle.Regular);
            labelTotalGames.ForeColor = Color.Gray;
            // 
            // labelGameTimer
            // 
            labelGameTimer.AutoSize = true;
            labelGameTimer.Location = new Point(50, 120);
            labelGameTimer.Name = "labelGameTimer";
            labelGameTimer.Size = new Size(80, 20);
            labelGameTimer.TabIndex = 16;
            labelGameTimer.Text = "Time: 00:00";
            labelGameTimer.Font = new Font("Arial", 12F, FontStyle.Bold);
            labelGameTimer.ForeColor = Color.Purple;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 1000;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(500, 300);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(100, 40);
            btnNewGame.TabIndex = 17;
            btnNewGame.Text = "🎮 New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            btnNewGame.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnNewGame.FlatStyle = FlatStyle.Flat;
            btnNewGame.FlatAppearance.BorderColor = Color.DarkGreen;
            btnNewGame.BackColor = Color.LightGreen;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 248, 255);
            ClientSize = new Size(650, 400);
            Controls.Add(btnNewGame);
            Controls.Add(labelGameTimer);
            Controls.Add(labelTotalGames);
            Controls.Add(labelDrawCount);
            Controls.Add(btnReset);
            Controls.Add(labelCurrentPlayer);
            Controls.Add(labelWinXCount);
            Controls.Add(labelWinOCount);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn0);
            Controls.Add(label1);
            Name = "Form1";
            Text = "🎮 Advanced Tic-Tac-Toe Game - v2.0";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Label labelWinOCount;
        private Label labelWinXCount;
        private Label labelCurrentPlayer;
        private Button btnReset;
        private Label labelDrawCount;
        private Label labelTotalGames;
        private Label labelGameTimer;
        private System.Windows.Forms.Timer gameTimer;
        private Button btnNewGame;
    }
}
