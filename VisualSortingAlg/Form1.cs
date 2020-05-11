using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualSortingAlg
{
    public partial class Form1 : Form
    {
        int[] theArray;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Marko Nikolic 2020");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
            int numEntries = panel1.Width;
            int maxVal = panel1.Height;
            theArray = new int[numEntries];
            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), 0, 0, numEntries, maxVal);
            Random random = new Random();
            for (int i = 0; i < numEntries; i++) {
                theArray[i] = random.Next(0,maxVal);
            }
            for (int i = 0; i < numEntries; i++) {
                g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Green), i, maxVal - theArray[i],1, maxVal);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ISortEngine se = new BubbleSort();
            se.DoWork(theArray, g, panel1.Height);
        }
    }
}
