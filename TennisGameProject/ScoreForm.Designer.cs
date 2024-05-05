namespace TennisGameProject
{
    partial class ScoreForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addNewGameButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.latestGamesTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rankingTable = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tennis Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ranking";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Latest Games";
            // 
            // addNewGameButton
            // 
            this.addNewGameButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addNewGameButton.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewGameButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addNewGameButton.Location = new System.Drawing.Point(451, 264);
            this.addNewGameButton.Name = "addNewGameButton";
            this.addNewGameButton.Size = new System.Drawing.Size(337, 42);
            this.addNewGameButton.TabIndex = 3;
            this.addNewGameButton.Text = "Add New Game";
            this.addNewGameButton.UseVisualStyleBackColor = false;
            this.addNewGameButton.Click += new System.EventHandler(this.addNewGameButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(35, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "*Click on a player\'s name to see more information about their matches";
            // 
            // latestGamesTable
            // 
            this.latestGamesTable.BackColor = System.Drawing.Color.DarkSalmon;
            this.latestGamesTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.latestGamesTable.HideSelection = false;
            this.latestGamesTable.Location = new System.Drawing.Point(38, 310);
            this.latestGamesTable.Name = "latestGamesTable";
            this.latestGamesTable.Size = new System.Drawing.Size(750, 110);
            this.latestGamesTable.TabIndex = 5;
            this.latestGamesTable.UseCompatibleStateImageBehavior = false;
            this.latestGamesTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "First Player";
            this.columnHeader1.Width = 172;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Second Player";
            this.columnHeader2.Width = 183;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Winner";
            this.columnHeader3.Width = 181;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Score";
            this.columnHeader4.Width = 198;
            // 
            // rankingTable
            // 
            this.rankingTable.BackColor = System.Drawing.Color.DarkSalmon;
            this.rankingTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader8});
            this.rankingTable.HideSelection = false;
            this.rankingTable.Location = new System.Drawing.Point(38, 116);
            this.rankingTable.Name = "rankingTable";
            this.rankingTable.Size = new System.Drawing.Size(750, 116);
            this.rankingTable.TabIndex = 6;
            this.rankingTable.UseCompatibleStateImageBehavior = false;
            this.rankingTable.View = System.Windows.Forms.View.Details;
            this.rankingTable.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Player Name";
            this.columnHeader5.Width = 371;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Score";
            this.columnHeader8.Width = 375;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(230, 272);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(157, 29);
            this.searchTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(393, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "🔍";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.rankingTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addNewGameButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.latestGamesTable);
            this.Name = "ScoreForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addNewGameButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView latestGamesTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView rankingTable;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button button1;
    }
}

