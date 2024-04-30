using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TennisGameProject
{
    public partial class ScoreForm : Form
    {
        public Dictionary<string, int> players = new Dictionary<string, int>();
        public Dictionary<(string, int), (string, int)> games = new Dictionary<(string, int), (string, int)>();

        public ScoreForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void UpdateRecentGames()
        {
            latestGamesTable.Items.Clear();

            foreach (var game in games)
            {
                ListViewItem latestGamesView = new ListViewItem();

                string firstPlayerName = game.Key.Item1;
                string secondPlayerName = game.Value.Item1;

                int firstPlayerScore = game.Key.Item2;
                int secondPlayerScore = game.Value.Item2;

                string winnerName = firstPlayerScore > secondPlayerScore ? firstPlayerName : secondPlayerName;

                int winningScore = Math.Max(firstPlayerScore, secondPlayerScore);

                latestGamesView.SubItems[0].Text = firstPlayerName;
                latestGamesView.SubItems.Add(secondPlayerName);
                latestGamesView.SubItems.Add(winnerName);
                latestGamesView.SubItems.Add(winningScore.ToString());

                latestGamesTable.Items.Add(latestGamesView);
            }   
        }

        public void UpdateRanking()
        {
            rankingTable.Items.Clear();

            players.OrderByDescending(p => p.Value)
                   .ToList()
                   .ForEach(playerKeyPair =>
                   {
                       ListViewItem playerRanking = new ListViewItem();

                       playerRanking.SubItems[0].Text = playerKeyPair.Key;
                       playerRanking.SubItems.Add(playerKeyPair.Value.ToString());

                       rankingTable.Items.Add(playerRanking);
                   });
        }

        private void addNewGameButton_Click(object sender, EventArgs e)
        {
            NewGameForm form = new NewGameForm(this);
            form.Show();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
