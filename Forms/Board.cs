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
        public int HomePoints = 0;
        public int AwayPoints = 0;
        public int Quarter = 1;
        public void RenderData()
        {
            homePoints.Text = $"{HomePoints}";
            awayPoints.Text = $"{AwayPoints}";
            perionLbl.Text = $"{Quarter}";
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

        public int pointChange(int oldPoint, int plus)
        {
            return plus != 0 ? Math.Max(oldPoint + plus, 0) : 0;
        }

        public void setTeamImage(TeamType team, string imgPath)
        {
            if (team == TeamType.Home) homePic.Image = Image.FromFile(imgPath);
            else awayPic.Image = Image.FromFile(imgPath);
        }
    }
}
