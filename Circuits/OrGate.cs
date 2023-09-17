using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuits
{
    public class OrGate:Gate
    {
        public OrGate(int x, int y)
        {

            //Add the two input pins to the gate
            pins.Add(new Pin(this, true, 20));
            pins.Add(new Pin(this, true, 20));
            //Add the output pin to the gate
            pins.Add(new Pin(this, false, 20));
            //move the gate and the pins to the position passed in
            MoveTo(x, y);
        }

        public override void Draw(Graphics paper)
        {
            //Check if the gate has been selected
            if (selected)
            {
                paper.DrawImage(Properties.Resources.OrGateRed, Left, Top);
            }
            else
            {
                paper.DrawImage(Properties.Resources.OrGate, Left, Top);
            }
            //Draw each of the pins
            foreach (Pin p in pins)
                p.Draw(paper);
        }

        //please make this work savvy savinu it gotta be different for each gate
        public override void MoveTo(int x, int y)
        {
            //Debugging message
            Console.WriteLine("pins = " + pins.Count);
            //Set the position of the gate to the values passed in
            left = x;
            top = y;
            // must move the pins too
            pins[0].X = x - GAP;
            pins[0].Y = y + GAP;
            pins[1].X = x - GAP;
            pins[1].Y = y + OrGate.HEIGHT;
            pins[2].X = x + OrGate.WIDTH + 30;
            pins[2].Y = y + OrGate.HEIGHT / 2 + 2;
        }

    }

    

}
