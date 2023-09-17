using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Circuits
{
    // savinu
    public class Gate
    {
        protected int left;
        protected int top;
        protected const int WIDTH = 40;
        protected const int HEIGHT = 40;
        protected const int GAP = 10;

        protected List<Pin> pins = new List<Pin>();

        protected bool selected = false;
        protected bool rightselected = false;
        public bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }
        
        public int Left
        {
            get { return left; }
        }

        public int Top
        {
            get { return top; }
        }

        public List<Pin> Pins
        {
            get { return pins; }
        }

        public bool IsMouseOn(int x, int y)
        {
            if (left <= x && x < left + WIDTH && top <= y && y < top + HEIGHT)
                return true;
            else
                return false;
        }

        public virtual void Draw(Graphics paper)
        {
            if (selected)
            {
                //paper.DrawImage(Properties.Resources.AndGateAllRed, Left, Top);
            }
            else
            {
                //paper.DrawImage(Properties.Resources.AndGate, Left, Top);
            }

            foreach (Pin p in pins)
                p.Draw(paper);
        }

         public virtual void MoveTo(int x, int y)
        {
            left = x;
            top = y;

          /*pins[0].X = x - GAP;
            pins[0].Y = y + GAP;
            pins[1].X = x - GAP;
            pins[1].Y = y + HEIGHT;
            pins[2].X = x + WIDTH + 20;
            pins[2].Y = y + HEIGHT / 2 + 2;*/
        }
    }
}

