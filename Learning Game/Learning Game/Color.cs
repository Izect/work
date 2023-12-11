using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Learning_Game;

namespace WinFormsApp2
{
    public partial class frm_color : Form
    {
        private string[] colorNames = { "Red", "Green", "Blue", "Yellow", "Orange", "Purple", "Pink", "Brown", "Cyan", "Magenta", "Lime", "Teal" };
        private Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Orange, Color.Purple, Color.Pink, Color.Brown, Color.Cyan, Color.Magenta, Color.Lime, Color.Teal };

        private Random random = new Random();
        private int score = 0;
        private int mistakes = 0;

        private List<ScoreEntry> scoreboard = new List<ScoreEntry>();

        public frm_color()
        {
            InitializeComponent();
            RestartGame();
        }
        private void RestartGame()
        {
            mistakes = 0;
            score = 0;
            UpdateScoreLabel();

            ShowRandomColor();
            ShowRandomChoices();
        }

        private void ShowRandomColor()
        {
            int index = random.Next(colorNames.Length);
            string colorName = colorNames[index];

            colorLabel.Text = colorName;
            colorLabel.ForeColor = colors[index];
        }

        private void ShowRandomChoices()
        {
            List<string> uniqueChoices = colorNames.OrderBy(x => random.Next()).Take(3).ToList();
            choicesListBox.Items.Clear();
            choicesListBox.Items.AddRange(uniqueChoices.ToArray());

            int correctIndex = random.Next(choicesListBox.Items.Count);
            choicesListBox.Items[correctIndex] = colorLabel.Text;
        }

        private void CheckAnswer(string selectedColor)
        {
            if (IsLettersOnly(selectedColor))
            {
                if (string.Equals(selectedColor, colorLabel.Text, StringComparison.OrdinalIgnoreCase))
                {
                    score++;
                }
                else
                {
                    mistakes++;

                    if (mistakes == 3)
                    {
                        GameOver();
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter only letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            UpdateScoreLabel();
            ShowRandomColor();
            ShowRandomChoices();
        }

        private bool IsLettersOnly(string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z]+$");
        }

        private void UpdateScoreLabel()
        {
            scoreLabel.Text = $"Score: {score} | Mistakes: {mistakes}";
        }

        private void GameOver()
        {
            MessageBox.Show($"Game Over! Your final score is {score}.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AddToScoreboard();
            ShowScoreboard();
            RestartGame();
        }

        private void AddToScoreboard()
        {
            scoreboard.Add(new ScoreEntry { Score = score, Date = DateTime.Now });
            scoreboard.Sort((a, b) => b.Score.CompareTo(a.Score));
        }

        private void ShowScoreboard()
        {
            scoreboardListBox.Items.Clear();
            foreach (var entry in scoreboard)
            {
                scoreboardListBox.Items.Add($"{entry.Score} points - {entry.Date}");
            }
        }

        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string userInput = inputTextBox.Text.Trim();
                if (!string.IsNullOrEmpty(userInput))
                {
                    CheckAnswer(userInput);
                    inputTextBox.Clear();
                }
            }
        }

        public class ScoreEntry
        {
            public int Score { get; set; }
            public DateTime Date { get; set; }
        }

        private void btn_color_return_Click(object sender, EventArgs e)
        {
            Form Select = new frm_select();
            Select.FormClosed += (s, args) => this.Show(); 
            Select.Show();
            this.Hide();
            this.Focus();
        }
    }
}
