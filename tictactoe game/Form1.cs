using System.Windows.Forms;
using System.Media;

namespace tictactoe_game
{
    public partial class Form1 : Form
    {
        String[] gameboard = new String[9];
        int currentTurn = 0;
        int winXCount = 0;
        int winOCount = 0;
        int drawCount = 0;
        int totalGames = 0;
        int gameTimeSeconds = 0;
        bool gameActive = true;
        Button[] gameButtons;
        int[] winningCombination = null;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Initialize button array for easier management
            gameButtons = new Button[] { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8 };

            // Set initial UI state
            UpdateCurrentPlayerDisplay();
            UpdateStatistics();

            // Start the game timer
            gameTimer.Start();
            gameTimeSeconds = 0;
        }

        private string ReturnSymbol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }

        private void UpdateCurrentPlayerDisplay()
        {
            string currentPlayer = ReturnSymbol(currentTurn + 1);
            labelCurrentPlayer.Text = $"Current Player: {currentPlayer}";
            labelCurrentPlayer.ForeColor = currentPlayer == "X" ? Color.Blue : Color.Red;
        }

        private void UpdateStatistics()
        {
            labelWinXCount.Text = $"X Wins: {winXCount}";
            labelWinOCount.Text = $"O Wins: {winOCount}";
            labelDrawCount.Text = $"Draws: {drawCount}";
            labelTotalGames.Text = $"Total Games: {totalGames}";
        }

        private void PlayClickSound()
        {
            try
            {
                SystemSounds.Hand.Play();
            }
            catch
            {
                // Silently handle if sound can't play
            }
        }

        private void PlayWinSound()
        {
            try
            {
                SystemSounds.Exclamation.Play();
            }
            catch
            {
                // Silently handle if sound can't play
            }
        }

        private void HighlightWinningCombination(int[] winningIndexes)
        {
            if (winningIndexes != null)
            {
                foreach (int index in winningIndexes)
                {
                    gameButtons[index].BackColor = Color.LightGreen;
                    gameButtons[index].ForeColor = Color.DarkGreen;
                }
            }
        }

        private void CheckWin()
        {
            // Define all possible winning combinations
            int[,] winPatterns = {
                {0, 1, 2}, {3, 4, 5}, {6, 7, 8}, // Rows
                {0, 3, 6}, {1, 4, 7}, {2, 5, 8}, // Columns
                {0, 4, 8}, {2, 4, 6}             // Diagonals
            };

            for (int i = 0; i < winPatterns.GetLength(0); i++)
            {
                int pos1 = winPatterns[i, 0];
                int pos2 = winPatterns[i, 1];
                int pos3 = winPatterns[i, 2];

                string combination = gameboard[pos1] + gameboard[pos2] + gameboard[pos3];

                if (combination.Equals("OOO"))
                {
                    GameWon("O", new int[] { pos1, pos2, pos3 });
                    return;
                }
                else if (combination.Equals("XXX"))
                {
                    GameWon("X", new int[] { pos1, pos2, pos3 });
                    return;
                }
            }

            CheckDraw();
        }

        private void GameWon(string winner, int[] winningIndexes)
        {
            gameActive = false;
            gameTimer.Stop();

            PlayWinSound();
            HighlightWinningCombination(winningIndexes);

            if (winner == "O")
            {
                winOCount++;
            }
            else
            {
                winXCount++;
            }

            totalGames++;
            UpdateStatistics();

            // Disable all buttons
            foreach (Button btn in gameButtons)
            {
                btn.Enabled = false;
            }

            MessageBox.Show($"{winner} is the winner!\nTime: {FormatTime(gameTimeSeconds)}",
                          "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CheckDraw()
        {
            int counter = 0;
            for (int i = 0; i < gameboard.Length; i++)
            {
                if (gameboard[i] != null)
                {
                    counter++;
                }
            }

            if (counter == 9 && gameActive)
            {
                gameActive = false;
                gameTimer.Stop();
                drawCount++;
                totalGames++;
                UpdateStatistics();

                // Disable all buttons
                foreach (Button btn in gameButtons)
                {
                    btn.Enabled = false;
                }

                MessageBox.Show($"It's a Draw!\nTime: {FormatTime(gameTimeSeconds)}",
                              "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetGame()
        {
            Array.Clear(gameboard, 0, gameboard.Length);
            currentTurn = 0;
            gameActive = true;
            winningCombination = null;
            gameTimeSeconds = 0;

            // Reset all buttons
            foreach (Button button in gameButtons)
            {
                button.Text = "";
                button.Enabled = true;
                button.BackColor = SystemColors.Control;
                button.ForeColor = SystemColors.ControlText;
            }

            UpdateCurrentPlayerDisplay();
            gameTimer.Start();
        }

        private string FormatTime(int seconds)
        {
            int minutes = seconds / 60;
            int secs = seconds % 60;
            return $"{minutes:D2}:{secs:D2}";
        }

        private void MakeMove(int position)
        {
            if (!gameActive || gameboard[position] != null) return;

            PlayClickSound();
            currentTurn++;
            gameboard[position] = ReturnSymbol(currentTurn);
            gameButtons[position].Text = gameboard[position];
            gameButtons[position].ForeColor = gameboard[position] == "X" ? Color.Blue : Color.Red;
            gameButtons[position].Enabled = false;

            UpdateCurrentPlayerDisplay();
            CheckWin();
        }

        // Timer event handler
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (gameActive)
            {
                gameTimeSeconds++;
                labelGameTimer.Text = $"Time: {FormatTime(gameTimeSeconds)}";
            }
        }

        // Button event handlers
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Start a completely new game? This will reset all statistics.",
                                       "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                winXCount = 0;
                winOCount = 0;
                drawCount = 0;
                totalGames = 0;
                UpdateStatistics();
                ResetGame();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Center the form on screen
            this.CenterToScreen();

            // Set window properties
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Game button click handlers
        private void btn0_Click(object sender, EventArgs e) => MakeMove(0);
        private void btn1_Click(object sender, EventArgs e) => MakeMove(1);
        private void btn2_Click(object sender, EventArgs e) => MakeMove(2);
        private void btn3_Click(object sender, EventArgs e) => MakeMove(3);
        private void btn4_Click(object sender, EventArgs e) => MakeMove(4);
        private void btn5_Click(object sender, EventArgs e) => MakeMove(5);
        private void btn6_Click(object sender, EventArgs e) => MakeMove(6);
        private void btn7_Click(object sender, EventArgs e) => MakeMove(7);
        private void btn8_Click(object sender, EventArgs e) => MakeMove(8);
    }
}
