using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KosarVezerlo.Forms;

namespace KosarVezerlo
{
    public partial class Control : Form
    {
        List<Team> TeamsList = new List<Team>();
        public Board board = new Board();
        public Control()
        {
            InitializeComponent();
            LoadTeams();
            RenderTeamBtns();
            board.Show();

        }
        private void LoadTeams()
        {
            using (StreamReader sr = new StreamReader(
                path: @"..\..\src\teamsData.txt",
                encoding: Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                    TeamsList.Add(new Team(sr.ReadLine()));
            }
        }

        private void RenderTeamBtns()
        {
            for (int i = 0; i < 30; i++)
            {
                TeamsList[i].SetButtonPosition(i);
                TeamsList[i].TeamButton.MouseClick += teamBtnClick;
                this.Controls.Add(TeamsList[i].TeamButton);
                
            }
        }

        private void teamBtnClick(object sender, MouseEventArgs e)
        {
            Board.TeamType team = homeRadio.Checked ? Board.TeamType.Home : Board.TeamType.Away;
            board.setTeamImage(team, $@"..\..\img\{(sender as Button).Text}.png", sender);
        }

        private void setQuarter(object sender, EventArgs e)
        {
            if (!board.isTimeOut) board.setQuarter();
        }

        private void newValueAdd(object sender, EventArgs e)
        {
            if (!board.isTimeOut)
            {
                int pointToAdd = int.Parse((sender as Button).Text);
                Board.TeamType team = Convert.ToString((sender as Button).Tag) == "home" ? Board.TeamType.Home : Board.TeamType.Away;
                board.setPoints(team, pointToAdd);
            }
        }

        private void TimeOut(object sender, EventArgs e)
        {
            if (!board.isTimerStopped && !board.isTimeOut)
            {
                Board.TeamType team = (sender as Button).Name == "homeTO" ? Board.TeamType.Home : Board.TeamType.Away;
                board.ChangeTO(team);
                board.EnableTimeOutTimer();
            }
        }

        private void StopStartTime(object sender, EventArgs e)
        {
            if (!board.isTimeOut)
            {
                board.isTimerStopped = !board.isTimerStopped;
                board.EnableGameTimer(!board.isTimerStopped);
                startStopButton.Text = board.isTimerStopped ? "Start Game" : "Stop Game";
            }
        }
    }
}
