using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSortingAlg
{
    class BubbleSort : ISortEngine
    {
        private bool sorted = false;
        private int[] theArray;
        private Graphics g;
        private int maxVal;
        Brush greenBrush =new System.Drawing.SolidBrush(System.Drawing.Color.Green);
        Brush blackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

        public void DoWork(int[] theArray_In, Graphics g_In, int maxValue_In)
        {
            theArray = theArray_In;
            g = g_In;
            maxVal = maxValue_In;

            while (!sorted)
            {
                for (int i = 0; i < theArray.Length - 1; i++)
                {
                    if (theArray[i] > theArray[i + 1])
                        Swap(i, i + 1); ;
                }
                sorted = isSorted();
            
            }
        }

        private void Swap(int i, int v)
        {
            int temp = theArray[i];
            theArray[i] = theArray[i + 1];
            theArray[i + 1] = temp;

            g.FillRectangle(blackBrush, i, 0, 1, maxVal);
            g.FillRectangle(blackBrush, v, 0, 1, maxVal);

            g.FillRectangle(greenBrush, i, maxVal-theArray[i], 1, maxVal);
            g.FillRectangle(greenBrush, v, maxVal-theArray[v], 1, maxVal);





        }

        private bool isSorted() {
            for (int i = 0; i < theArray.Length - 1; i++)
            {
                if (theArray[i] > theArray[i + 1])
                    return false;
            }
            return true;
        }
    }
}
