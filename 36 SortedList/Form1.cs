using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _36_SortedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int Dec = int.Parse(tboxInput.Text);
            int[] S = new int[8];
            int i;

            for (i = 0; i < 8; i++)
            {
                S[i] = 0;
            }

            int M = 1;
            int R = 1;

            i = 7;

            while (true)
            {
                if (M == 0)
                {
                    StringBuilder sb = new StringBuilder();

                    for (i = 0; i < 8; i++)
                    {
                        sb.Append(S[i].ToString());
                    }

                    tboxOutput.Text = sb.ToString();
                    break;
                }
                else
                {
                    M = Dec / 2;
                    R = Dec - M * 2;
                    S[i] = R;
                    Dec = M;
                    i = i - 1;
                }
            }
        }
    }
}
