using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KosarVezerlo.Forms;

namespace KosarVezerlo
{
    public partial class Control : Form
    {
        public Board board = new Board();
        public Control()
        {
            InitializeComponent();
            board.Show();

        }

        private void setQuarter(object sender, EventArgs e)
        {
            board.setQuarter();
        }

        private void newValueAdd(object sender, EventArgs e)
        {
            int pointToAdd = int.Parse((sender as Button).Text);
            Board.TeamType team = Convert.ToString((sender as Button).Tag) == "home" ? Board.TeamType.Home : Board.TeamType.Visitor;
            board.setPoints(team, pointToAdd);
        }
    }
}
