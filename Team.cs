using KosarVezerlo.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
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
        public Color MainColor { get; set; }
        public Color SecondColor { get; set; }
        public Button TeamButton { get; set; }


        public Team(string line)
        {
            string[] data = line.Split(';') ;
            Code = data[0];
            Name = data[1].ToUpper();
            string[] mc = data[2].Split(',');
            string[] sc = data[3].Split(',');
            MainColor = Color.FromArgb(int.Parse(mc[0]), int.Parse(mc[1]), int.Parse(mc[2]));
            SecondColor = Color.FromArgb(int.Parse(sc[0]), int.Parse(sc[1]), int.Parse(sc[2]));
            TeamButton = new Button
            {
                Name = Name,
                Text = Code,
                Height = 40,
                Width = 80,
                ForeColor = Color.White,
                Tag = new Color[2] { MainColor, SecondColor },
            };
        }
        public void SetButtonPosition(int p)
        {
            TeamButton.Top = 40 * (p / 10 + 1);
            TeamButton.Left = 80 * (p % 10);
        }
    }
}
