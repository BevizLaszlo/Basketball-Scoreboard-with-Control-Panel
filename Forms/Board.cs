using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KosarVezerlo.Forms
{
    public partial class Board : Form
    {
        public enum TeamType { Home, Away }
        private int HomePoints = 0;
        private int AwayPoints = 0;
        private int Quarter = 1;
        private int HomeTO = 7;
        private int AwayTO = 7;

        public void RenderData()
        {
            homePoints.Text = $"{HomePoints}";
            awayPoints.Text = $"{AwayPoints}";
            perionLbl.Text = $"{Quarter}";
            ShowTO(TeamType.Home);
            ShowTO(TeamType.Away);
        }
        public Board()
        {
            InitializeComponent();
            RenderData();
        }

        public void setQuarter()
        {
            Quarter = Quarter < 4 ? Quarter + 1 : 1;
            RenderData();
        }

        public void setPoints(TeamType team, int point)
        {
            if (team == TeamType.Home) HomePoints = pointChange(HomePoints, point);
            else AwayPoints = pointChange(AwayPoints, point);
            RenderData();
        }

        private int pointChange(int oldPoint, int plus)
        {
            return plus != 0 ? Math.Max(oldPoint + plus, 0) : 0;
        }

        public void setTeamImage(TeamType team, string imgPath)
        {
            if (team == TeamType.Home) homePic.BackgroundImage = Image.FromFile(imgPath);
            else awayPic.BackgroundImage = Image.FromFile(imgPath);
        }

        private void ShowTO(TeamType team)
        {
            int TOpoints = team == TeamType.Home ? HomeTO : AwayTO;
            Panel pl = team == TeamType.Home ? homeTOpanel : awayTOpanel;
            pl.Controls.Clear();

            for (int i = 0; i < TOpoints; i++)
            {
                pl.Controls.Add(new Label()
                {
                    Text = "",
                    Height = pl.Height,
                    Width = pl.Width / 7 - 6,
                    Left = i * pl.Width / 7 + 6,
                    BackColor = Color.Yellow,
                });
            }
        }

        public void ChangeTO(TeamType team)
        {
            if (team == TeamType.Home && HomeTO > 0) HomeTO--;
            else if (team == TeamType.Away && AwayTO > 0) AwayTO--;
            RenderData();
        }
    }
}
