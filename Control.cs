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

        public void teamBtnClick(object sender, MouseEventArgs e)
        {
            board.setTeamImage(Board.TeamType.Home,"");
        }

        private void setQuarter(object sender, EventArgs e)
        {
            board.setQuarter();
        }

        private void newValueAdd(object sender, EventArgs e)
        {
            int pointToAdd = int.Parse((sender as Button).Text);
            Board.TeamType team = Convert.ToString((sender as Button).Tag) == "home" ? Board.TeamType.Home : Board.TeamType.Away;
            board.setPoints(team, pointToAdd);
        }
    }
}
