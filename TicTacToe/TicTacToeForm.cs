namespace TicTacToe
{
    public partial class TicTacToeForm : Form
    {
        Button[,] buttons = new Button[3, 3];
        public TicTacToeForm()
        {
            InitializeComponent();
            GenerateButtons();
        }

        private void GenerateButtons()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(175, 175);
                    buttons[i, j].Location = new Point(175 * i, 175 * j);
                    buttons[i, j].Click += new EventHandler(OnButtonClick);
                    buttons[i, j].FlatStyle = FlatStyle.Flat;

                    buttons[i, j].Font = new Font(DefaultFont.FontFamily, 80, FontStyle.Bold);
                    //buttons[i, j].Tag = new Point(i, j);
                    this.panelButtons.Controls.Add(buttons[i, j]);
                }
            }
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            if (button.Text != "")
            {
                return;
            }
            button.Text = buttonPlayer.Text;

            TogglePlayer();
        }

        private void TogglePlayer()
        {
            CheckIfGameEnds();
            if (buttonPlayer.Text == "X")
            {
                buttonPlayer.Text = "O";
            }
            else
            {
                buttonPlayer.Text = "X";
            }
        }

        private void ShowWinner(List<Button> winnerButtons)
        {
            foreach(Button button in winnerButtons)
            {
                button.BackColor = Color.LightGreen;
            }

            MessageBox.Show("Player " + buttonPlayer.Text + " wins!");

            Application.Restart();
        }

        private void CheckIfGameEnds()
        {
            List<Button> winnerButtons = new List<Button>();

            CheckVerticalForWin(winnerButtons);
            CheckHorizontalForWin(winnerButtons);
            CheckFirstDiagonalForWin(winnerButtons);
            CheckSecondDiagonalForWin(winnerButtons);
            CheckForDraw();
        }

        private void CheckVerticalForWin(List<Button> winnerButtons)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++) 
                {
                    Button currentButton = buttons[i, j];

                    if (ButtonHasOtherPlayersSign(currentButton))
                    {
                        break;
                    }

                    winnerButtons.Add(currentButton);

                    if (j == 2)
                    {
                        ShowWinner(winnerButtons);
                    }
                }
            }
        }

        private void CheckHorizontalForWin(List<Button> winnerButtons)
        {
            winnerButtons.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button currentButton = buttons[j, i];

                    if (ButtonHasOtherPlayersSign(currentButton))
                    {
                        break;
                    }

                    winnerButtons.Add(currentButton);

                    if (j == 2)
                    {
                        ShowWinner(winnerButtons);
                    }
                }
            }
        }

        private void CheckFirstDiagonalForWin(List<Button> winnerButtons)
        {
            winnerButtons.Clear();

            for (int i = 0; i < 3; i++)
            {
                Button currentButton = buttons[i, i];

                if (ButtonHasOtherPlayersSign(currentButton))
                {
                    break;
                }

                winnerButtons.Add(currentButton);

                if (i == 2)
                {
                    ShowWinner(winnerButtons);
                }
            }
        }

        private void CheckSecondDiagonalForWin(List<Button> winnerButtons)
        {
            winnerButtons.Clear();

            for (int i = 0; i < 3; i++)
            {
                Button currentButton = buttons[i, 2 - i];

                if (ButtonHasOtherPlayersSign(currentButton))
                {
                    break;
                }

                winnerButtons.Add(currentButton);

                if (i == 2)
                {
                    ShowWinner(winnerButtons);
                }
            }
        }

        private void CheckForDraw()
        {
            foreach (Button button in buttons)
            {
                if (button.Text == "")
                {
                    return;
                }
            }
            MessageBox.Show("Game draw!");
            Application.Restart();
        }

        private bool ButtonHasOtherPlayersSign(Button button)
        {
            return button.Text != buttonPlayer.Text;
        }
    }
}
