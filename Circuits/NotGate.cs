﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuits
{
    ///meow
    internal class NotGate : Gate
    {
        public NotGate(int x, int y)
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
                paper.DrawImage(Properties.Resources.NotGateAllRed, Left, Top);
            }
            else
            {
                paper.DrawImage(Properties.Resources.NotGate, Left, Top);
            }
            //Draw each of the pins
            foreach (Pin p in pins)
                p.Draw(paper);

            // AND is simple, so we can use a circle plus a rectange.
            // An alternative would be to use a bitmap.
            // paper.FillEllipse(brush, left, top, WIDTH, HEIGHT);
            // paper.FillRectangle(brush, left, top, WIDTH / 2, HEIGHT);

            //Note: You can also use the images that have been imported into the project if you wish,
            //      using the code below.  You will need to space the pins out a bit more in the constructor.
            //      There are provided images for the other gates and selected versions of the gates as well.



        }

        //also make this work lil ...
        public override void MoveTo(int x, int y)
        {
            left = x;
            top = y;

            pins[0].X = x - 15;
            pins[0].Y = y + 20;
           /* pins[1].X = x - GAP;
            pins[1].Y = y + HEIGHT;*/
            //a not gate only has one input ;(((((( 
            pins[2].X = x + WIDTH + 20;
            pins[2].Y = (y + HEIGHT / 2) + 5;

            
        }
    }
}
