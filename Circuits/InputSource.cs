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
    internal class InputSource : Gate
    {
        public bool isHighVoltage = false; // Boolean variable to track high or low voltage
        public InputSource(int x, int y)
        {
            // Add the output pin to the gate
            pins.Add(new Pin(this, false, 20));
            // Move the gate and the pin to the position passed in
            MoveTo(x, y);
            
        }
      
        public override void Draw(Graphics paper)
        {
            
            SolidBrush br;
            Pen pen1 = new Pen(Color.Black, 2);
           /* if (e.Button == MouseButtons.Right)
            {
                isHighVoltage = true;
            }
            else
            {
                isHighVoltage = false;
            }*/

            // Check if the gate has been selected
            if (selected)
            {
                // Toggle the boolean value when selected
                br = new SolidBrush(Color.Green);
            }

            else
            {
                // Set the default color (e.g., white)
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
            pins[0].X = x + 32;
            pins[0].Y = y + 7;
        }
    }
}
