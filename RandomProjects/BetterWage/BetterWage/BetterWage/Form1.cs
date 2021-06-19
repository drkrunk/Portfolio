using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterWage
{
    public partial class JobForm : Form
    {
        Job job1;
        Job job2;
        public JobForm()
        {
            InitializeComponent();

            job1 = new Job();
            job2 = new Job();



            wageBox1.Value = (Decimal)job1.Wage;
            wageBox2.Value = (Decimal)job2.Wage;

            hoursBox1.Value = (Decimal)job1.Hours;
            hoursBox2.Value = (Decimal)job2.Hours;

        }

        private void wageBox1_ValueChanged(object sender, EventArgs e)
        {
            job1.Wage = (double)wageBox1.Value;
            updateResult();
        }


        private void updateResult() {
            resultBox1.Text = job1.JobDetails;
            resultBox2.Text = job2.JobDetails;

            progressBar1.Value = (int)(Job.PercentCompareWage(job1, job2) *100);
            progressBar2.Value = (int)(Job.PercentCompareWage(job2, job1) * 100);
        }

        private void hoursBox1_ValueChanged(object sender, EventArgs e)
        {
            job1.Hours = (int)hoursBox1.Value;
            updateResult();
        }

        private void wageBox2_ValueChanged(object sender, EventArgs e)
        {
            job2.Wage = (double)wageBox2.Value;
            updateResult();
        }

        private void hoursBox2_ValueChanged(object sender, EventArgs e)
        {
            job2.Hours = (int)hoursBox2.Value;
            updateResult();
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {



            //GroupBox box = (GroupBox)sender;
            //e.Graphics.Clear(Color.FromArgb(28, 28, 28));

            //e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            //e.Graphics.DrawString(box.Text, box.Font, Brushes.White, 5, 5);

            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.White, Color.FromArgb(62, 62, 62));

        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.White, Color.FromArgb(62, 62, 62));
        }

        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y ,
                                               box.ClientRectangle.Width-1 ,
                                               box.ClientRectangle.Height-1) ;

                // Clear text and border
                g.Clear(Color.FromArgb(28, 28, 28));

                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, 15, 15);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X , rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X  , rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

    }
}
