using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TennisGameProject
{
    public partial class NewGameForm : Form
    {
        private string[] ERROR_MESSAGES =
        {
            "",
            "Name should not be blank!",
            "Invalid name!"
        };

        private ScoreForm scoreForm;

        public NewGameForm(ScoreForm scoreForm)
        {
            InitializeComponent();
            this.scoreForm = scoreForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private int IsValidName (string name)
        {
            Regex regex = new Regex(@"(?:(?:[A-Z]\.?)|(?:[A-Z][a-z]*)) [A-Z][a-z]+");

            if (name == null || name.Trim().Length == 0) return 1;
            if (!regex.Match(name).Success ) return 2;

            return 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string firstPlayerName = firstPlayerNameTextBox.Text;
            string secondPlayerName = secondPlayerNameTextBox.Text;

            if (IsValidName(firstPlayerName) != 0 || IsValidName(secondPlayerName) != 0) return;

            int firstPlayerPoints = (int) pointsFirstPlayerNumeric.Value;
            int secondPlayerPoints = (int) pointsSecondPlayerNumeric.Value;

            this.scoreForm.games.Add(
                (
                    firstPlayerName,
                    firstPlayerPoints
                ),
                (
                    secondPlayerName,
                    secondPlayerPoints
                )
            );

            this.scoreForm.UpdateRecentGames();

            if(!this.scoreForm.players.ContainsKey(firstPlayerName))
                this.scoreForm.players.Add(firstPlayerName, 0);

            if (!this.scoreForm.players.ContainsKey(secondPlayerName))
                this.scoreForm.players.Add(secondPlayerName, 0);

            this.scoreForm.players[firstPlayerName] += firstPlayerPoints;
            this.scoreForm.players[secondPlayerName] += secondPlayerPoints;

            this.scoreForm.UpdateRanking();

            this.Close();
        }

        private void firstPlayerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValidatePlayerName(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox) sender;

            int status = IsValidName(textBox.Text);
            e.Cancel = (status != 0);

            if (textBox == this.firstPlayerNameTextBox)
            {
                this.firstPlayerNameErrorProvider.SetError(
                    textBox, ERROR_MESSAGES[status]
                );
            }
            else if (textBox == this.secondPlayerNameTextBox)
            {
                this.secondPlayerNameErrorProvider.SetError(
                    textBox, ERROR_MESSAGES[status]
                );
            }
        }
    }
}
