
namespace KosarVezerlo.Forms
{
    partial class Board
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board));
            this.homePoints = new System.Windows.Forms.Label();
            this.awayPoints = new System.Windows.Forms.Label();
            this.perionLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.homePic = new System.Windows.Forms.PictureBox();
            this.awayPic = new System.Windows.Forms.PictureBox();
            this.homeTOpanel = new System.Windows.Forms.Panel();
            this.awayTOpanel = new System.Windows.Forms.Panel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.TimeOutCountLabel = new System.Windows.Forms.Label();
            this.timeOutTimer = new System.Windows.Forms.Timer(this.components);
            this.awayPanel = new System.Windows.Forms.Panel();
            this.awayTeamName = new System.Windows.Forms.Label();
            this.homePanel = new System.Windows.Forms.Panel();
            this.homeTeamName = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.homePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayPic)).BeginInit();
            this.awayPanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // homePoints
            // 
            this.homePoints.AutoSize = true;
            this.homePoints.BackColor = System.Drawing.Color.Transparent;
            this.homePoints.Font = new System.Drawing.Font("Arial", 62F);
            this.homePoints.Location = new System.Drawing.Point(275, 111);
            this.homePoints.Name = "homePoints";
            this.homePoints.Size = new System.Drawing.Size(85, 92);
            this.homePoints.TabIndex = 2;
            this.homePoints.Text = "0";
            this.homePoints.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // awayPoints
            // 
            this.awayPoints.AutoSize = true;
            this.awayPoints.BackColor = System.Drawing.Color.Transparent;
            this.awayPoints.Font = new System.Drawing.Font("Arial", 62F);
            this.awayPoints.Location = new System.Drawing.Point(19, 111);
            this.awayPoints.Name = "awayPoints";
            this.awayPoints.Size = new System.Drawing.Size(85, 92);
            this.awayPoints.TabIndex = 2;
            this.awayPoints.Text = "0";
            // 
            // perionLbl
            // 
            this.perionLbl.AutoSize = true;
            this.perionLbl.BackColor = System.Drawing.Color.Transparent;
            this.perionLbl.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.perionLbl.Location = new System.Drawing.Point(119, 30);
            this.perionLbl.Name = "perionLbl";
            this.perionLbl.Size = new System.Drawing.Size(24, 26);
            this.perionLbl.TabIndex = 2;
            this.perionLbl.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(25, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "PERIOD";
            // 
            // homePic
            // 
            this.homePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homePic.InitialImage = null;
            this.homePic.Location = new System.Drawing.Point(30, 82);
            this.homePic.Name = "homePic";
            this.homePic.Size = new System.Drawing.Size(150, 150);
            this.homePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homePic.TabIndex = 4;
            this.homePic.TabStop = false;
            // 
            // awayPic
            // 
            this.awayPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.awayPic.InitialImage = null;
            this.awayPic.Location = new System.Drawing.Point(215, 82);
            this.awayPic.Name = "awayPic";
            this.awayPic.Size = new System.Drawing.Size(150, 150);
            this.awayPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.awayPic.TabIndex = 4;
            this.awayPic.TabStop = false;
            // 
            // homeTOpanel
            // 
            this.homeTOpanel.Location = new System.Drawing.Point(30, 280);
            this.homeTOpanel.Name = "homeTOpanel";
            this.homeTOpanel.Size = new System.Drawing.Size(330, 10);
            this.homeTOpanel.TabIndex = 5;
            // 
            // awayTOpanel
            // 
            this.awayTOpanel.Location = new System.Drawing.Point(35, 280);
            this.awayTOpanel.Name = "awayTOpanel";
            this.awayTOpanel.Size = new System.Drawing.Size(330, 10);
            this.awayTOpanel.TabIndex = 5;
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold);
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.timeLabel.Location = new System.Drawing.Point(306, 17);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(168, 51);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "12:00.0";
            // 
            // TimeOutCountLabel
            // 
            this.TimeOutCountLabel.AutoSize = true;
            this.TimeOutCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeOutCountLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.TimeOutCountLabel.ForeColor = System.Drawing.Color.Red;
            this.TimeOutCountLabel.Location = new System.Drawing.Point(469, 30);
            this.TimeOutCountLabel.Name = "TimeOutCountLabel";
            this.TimeOutCountLabel.Size = new System.Drawing.Size(36, 26);
            this.TimeOutCountLabel.TabIndex = 3;
            this.TimeOutCountLabel.Text = "75";
            this.TimeOutCountLabel.Visible = false;
            // 
            // timeOutTimer
            // 
            this.timeOutTimer.Interval = 1000;
            this.timeOutTimer.Tick += new System.EventHandler(this.timeOutTimer_Tick);
            // 
            // awayPanel
            // 
            this.awayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(217)))), ((int)(((byte)(209)))));
            this.awayPanel.Controls.Add(this.awayTOpanel);
            this.awayPanel.Controls.Add(this.awayPoints);
            this.awayPanel.Controls.Add(this.awayTeamName);
            this.awayPanel.Controls.Add(this.awayPic);
            this.awayPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.awayPanel.Location = new System.Drawing.Point(390, 85);
            this.awayPanel.Name = "awayPanel";
            this.awayPanel.Size = new System.Drawing.Size(390, 315);
            this.awayPanel.TabIndex = 6;
            // 
            // awayTeamName
            // 
            this.awayTeamName.AutoSize = true;
            this.awayTeamName.BackColor = System.Drawing.Color.Transparent;
            this.awayTeamName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.awayTeamName.Location = new System.Drawing.Point(289, 25);
            this.awayTeamName.Name = "awayTeamName";
            this.awayTeamName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.awayTeamName.Size = new System.Drawing.Size(81, 29);
            this.awayTeamName.TabIndex = 2;
            this.awayTeamName.Text = "AWAY";
            this.awayTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(217)))), ((int)(((byte)(209)))));
            this.homePanel.Controls.Add(this.homeTOpanel);
            this.homePanel.Controls.Add(this.homePoints);
            this.homePanel.Controls.Add(this.homeTeamName);
            this.homePanel.Controls.Add(this.homePic);
            this.homePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.homePanel.Location = new System.Drawing.Point(0, 85);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(390, 315);
            this.homePanel.TabIndex = 7;
            // 
            // homeTeamName
            // 
            this.homeTeamName.AutoSize = true;
            this.homeTeamName.BackColor = System.Drawing.Color.Transparent;
            this.homeTeamName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.homeTeamName.Location = new System.Drawing.Point(25, 25);
            this.homeTeamName.Name = "homeTeamName";
            this.homeTeamName.Size = new System.Drawing.Size(85, 29);
            this.homeTeamName.TabIndex = 2;
            this.homeTeamName.Text = "HOME";
            this.homeTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPanel.AutoSize = true;
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.homePanel);
            this.mainPanel.Controls.Add(this.awayPanel);
            this.mainPanel.Controls.Add(this.TimeOutCountLabel);
            this.mainPanel.Controls.Add(this.timeLabel);
            this.mainPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.MaximumSize = new System.Drawing.Size(780, 400);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(780, 400);
            this.mainPanel.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 85);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(25, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.perionLbl);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.panel1.Location = new System.Drawing.Point(615, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 85);
            this.panel1.TabIndex = 8;
            // 
            // Board
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(780, 400);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoreBoard";
            ((System.ComponentModel.ISupportInitialize)(this.homePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayPic)).EndInit();
            this.awayPanel.ResumeLayout(false);
            this.awayPanel.PerformLayout();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label homePoints;
        private System.Windows.Forms.Label awayPoints;
        private System.Windows.Forms.Label perionLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox homePic;
        private System.Windows.Forms.PictureBox awayPic;
        private System.Windows.Forms.Panel homeTOpanel;
        private System.Windows.Forms.Panel awayTOpanel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label TimeOutCountLabel;
        private System.Windows.Forms.Timer timeOutTimer;
        private System.Windows.Forms.Panel awayPanel;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label homeTeamName;
        private System.Windows.Forms.Label awayTeamName;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}