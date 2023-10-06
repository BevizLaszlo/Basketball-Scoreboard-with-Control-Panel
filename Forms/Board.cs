using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KosarVezerlo.Forms
{
    public partial class Board : Form
    {
        public enum TeamType { Home, Visitor }
        public Board()
        {
            InitializeComponent();
        }


        public void setQuarter()
        {
            int count = int.Parse(perionLbl.Text) + 1;
            if (count > 4) perionLbl.Text = "1";
            else perionLbl.Text = $"{count}";
        }

        public void setPoints(TeamType team, int point)
        {
            if (team == TeamType.Home) setPointsForTeam(homePoints, point);
            else setPointsForTeam(awayPoints, point);
        }

        private void setPointsForTeam(Label team, int point)
        {
            if (point != 0)
            {
                int newPoint = Convert.ToInt32(team.Text) + point;
                team.Text = $"{newPoint}";
            }
            else team.Text = "0";
        }
    }
}
