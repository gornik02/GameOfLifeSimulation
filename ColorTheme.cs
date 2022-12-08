using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLifeSimulation
{
    class ColorTheme
    {
        private Color myForeground;
        private Color myBackground;

        public ColorTheme(Color foreground, Color background)
        {
            myForeground = foreground;
            myBackground = background;
        }

        public Color GetForeGround()
        {
            return myForeground;
        }

        public Color GetBackGround()
        {
            return myBackground;
        }
    }
}
