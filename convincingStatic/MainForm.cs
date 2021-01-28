using convincingStatic.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace convincingStatic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.pcStaticElement.Image = Image.FromFile(@"Images\img1.jpg");
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            int px = this.pcStaticElement.Location.X;
            int py = this.pcStaticElement.Location.Y;

            if (PathService.IsCoords(e.X, e.Y, px, py))
            {
                if (BorderService.RightBorder(px + 185, this.Width))
                {
                    this.pcStaticElement.Location = new Point(px + 100, py);
                }
                else
                {
                    this.pcStaticElement.Location = new Point(px - 100, py);
                }
            }
            
            //  Left -> Right
            if (BorderService.RightBorder(px + 85, this.Width))
            {
                if (PathService.ToRight(e.X, e.Y, px, py)
                    && !PathService.ToLeft(e.X, e.Y, px, py)
                    && !PathService.ToBottom(e.X, e.Y, px, py))
                {
                    pcStaticElement.Location = new Point(pcStaticElement.Location.X + 5, pcStaticElement.Location.Y);
                    px += 5;
                }
            }
            else 
            {
                this.pcStaticElement.Location = new Point(px-100, py);
            }
            //  Top -> Bottom
            if (BorderService.DownBorder(py+85, this.Height)) 
            {
            if (PathService.ToBottom(e.X, e.Y, px, py)
               && !PathService.ToUp(e.X, e.Y, px, py))
            {
                pcStaticElement.Location = new Point(pcStaticElement.Location.X, pcStaticElement.Location.Y+5);
                py += 5;
            }
            }
            else
            {
                this.pcStaticElement.Location = new Point(px, py - 100);
            }
            //  Bottom -> Top
            if (BorderService.UpBorder(py))
            {
                if (PathService.ToUp(e.X, e.Y, px, py)
                   && !PathService.ToBottom(e.X, e.Y, px, py))
                {
                    pcStaticElement.Location = new Point(pcStaticElement.Location.X, pcStaticElement.Location.Y - 5);
                    py -= 5;
                }
            }
            else
            {
                this.pcStaticElement.Location = new Point(px, py + 100);
            }
            // Right -> Left
            if (BorderService.LeftBorder(px)) 
            {
            if (PathService.ToLeft(e.X, e.Y, px, py)
                && !PathService.ToRight(e.X, e.Y, px, py)
                && !PathService.ToBottom(e.X, e.Y, px, py))
            {
                pcStaticElement.Location = new Point(pcStaticElement.Location.X - 5, pcStaticElement.Location.Y);
                px += 5;
            }
            }
            else
            {
                this.pcStaticElement.Location = new Point(px + 100, py);
            }
            
        }
    }
}
