using KosarVezerlo.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KosarVezerlo
{
    internal class Team
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public Button TeamButton { get; set; }


        public Team(string line)
        {
            string[] data = line.Split(';') ;
            Code = data[0];
            Name = data[1];
            TeamButton = new Button
            {
                Text = Code,
                Height = 40,
                Width = 80,
                ForeColor = Color.White
            };
        }
        public void SetButtonPosition(int p)
        {
            TeamButton.Top = 40 * (p / 10 + 1);
            TeamButton.Left = 80 * (p % 10);
        }
    }
}
