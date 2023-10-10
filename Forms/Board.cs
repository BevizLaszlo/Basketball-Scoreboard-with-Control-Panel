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
        public bool isTimeOut = false;
        public bool isTimerStopped = true;
        private DateTime DateOfStartQuart;
        private TimeSpan RemainingTimeFromStartDate;
        private TimeSpan RemainingTime = new TimeSpan(0, 12, 0);
        private TimeSpan TimeOutInterval = new TimeSpan(0, 0, 75);

        public void RenderData()
        {
            homePoints.Text = $"{HomePoints}";
            homePoints.Left = homePanel.Width - homePoints.Width - 3;
            awayPoints.Text = $"{AwayPoints}";
            awayPoints.Left = 20;
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

        public void setTeamImage(TeamType team, object sender)
        {
            Color[] colors = (Color[])(sender as Button).Tag;
            PictureBox pic = team == TeamType.Home ? homePic : awayPic;
            Panel pl = team == TeamType.Home ? homePanel : awayPanel;
            
            pic.BackgroundImage = Image.FromFile($@"..\..\img\{(sender as Button).Text}.png");
            pl.BackColor = colors[0];
            pl.ForeColor = colors[1];
            ShowTO(team);
            if (team == TeamType.Home)
            {
                homeTeamName.Text = (sender as Button).Name;
                homeTeamName.Left = pl.Width / 2 - homeTeamName.Width / 2;
            }
            else
            {
                awayTeamName.Text = (sender as Button).Name;
                awayTeamName.Left = pl.Width / 2 - awayTeamName.Width / 2;
            }
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
                    BackColor = pl.ForeColor
                });
            }
        }

        public void ChangeTO(TeamType team)
        {
            if (team == TeamType.Home && HomeTO > 0) HomeTO--;
            else if (team == TeamType.Away && AwayTO > 0) AwayTO--;
            RenderData();
        }

        public void EnableGameTimer(bool enable)
        {
            if (enable)
            {
                gameTimer.Enabled = true;
                isTimerStopped = true;
            }
            else gameTimer.Enabled = false;
        }

        public void EnableTimeOutTimer()
        {
            gameTimer.Enabled = false;
            timeOutTimer.Enabled = true;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (isTimerStopped)
            {
                DateOfStartQuart = DateTime.Now;
                RemainingTimeFromStartDate = RemainingTime;
                isTimerStopped = false;
            }

            RemainingTime = RemainingTimeFromStartDate - (DateTime.Now - DateOfStartQuart);
            timeLabel.Text = RemainingTime.ToString("mm':'ss'.'f");
            
            if(RemainingTime.TotalMilliseconds < 100)
            {
                RemainingTime = new TimeSpan(0, 12, 0);
                isTimerStopped = true;
                gameTimer.Enabled = false;
            }
        }

        private void timeOutTimer_Tick(object sender, EventArgs e)
        {
            if (!isTimeOut)
            {
                TimeOutCountLabel.Visible = true;
                isTimeOut = true;
            }
            TimeOutCountLabel.Text = TimeOutInterval.TotalSeconds.ToString();
            TimeOutInterval -= new TimeSpan(0, 0, 1);

            if (TimeOutInterval.TotalSeconds < 0)
            {
                TimeOutCountLabel.Visible = false;
                isTimeOut = false;
                isTimerStopped = true;
                timeOutTimer.Enabled = false;
                TimeOutInterval = new TimeSpan(0, 0, 75);
            }
        }

        public void ResetTimers()
        {
            isTimeOut = false;
            isTimerStopped = true;
            RemainingTime = new TimeSpan(0, 12, 0);
            TimeOutInterval = new TimeSpan(0, 0, 75);
            gameTimer.Enabled = false;
            timeOutTimer.Enabled = false;
            TimeOutCountLabel.Visible = false;
            timeLabel.Text = "12:00.0";
        }
    }
}
