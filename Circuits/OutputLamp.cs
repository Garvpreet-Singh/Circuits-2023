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
    internal class OutputLamp : Gate
    {
        private bool isHighVoltage = false; // Boolean variable to track high or low voltage

        public OutputLamp(int x, int y)
        {
            //Add a input pins to the gate
            pins.Add(new Pin(this, true, 20));
            // Move the gate and the pin to the position passed in
            MoveTo(x, y);
        }

        public override void Draw(Graphics paper)
        {

            SolidBrush br;
            br = new SolidBrush(Color.White);
            Pen pen1 = new Pen(Color.Black, 2);
            /*  // Check if the gate has been selected
              if (selected)
              {
                  // Toggle the boolean value when selected
                  isHighVoltage = !isHighVoltage;

                  // Set color based on the boolean value
                  if (isHighVoltage)
                      br = new SolidBrush(Color.Yellow); // High voltage (true)
                  else
                      br = new SolidBrush(Color.White);  // Low voltage (false)
              }
              else
              {
                  // Set the default color (e.g., white) 
                  br = new SolidBrush(Color.White);
              }*/
            if (selected)
            {
                br = new SolidBrush(Color.Red);
            }
            else
            {
                br = new SolidBrush(Color.White);
            }

            paper.FillRectangle(br, left, top, 15, 15);
            paper.DrawRectangle(pen1, left, top, 15, 15);

            // Draw the output pin
            pins[0].Draw(paper);
        }

        public override void MoveTo(int x, int y)
        {
            left = x;
            top = y;

            // Update the position of the output pin
            pins[0].X = x - 15;
            pins[0].Y = y + 7;
        }
    }
}







