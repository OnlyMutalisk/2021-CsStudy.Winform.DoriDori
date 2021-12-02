using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18.Simple_Clicker
{
    public partial class Form1 : Form
    {
        private double iTick = 0;
        private double iTotal = 0;

        private int i1Add = 1;
        private int i1Level = 1;

        private int i3Add = 3;
        private int i3Level = 1;

        private int i50Add = 0;
        private int i50Level = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer tm = new System.Windows.Forms.Timer();
            tm.Enabled = true;
            tm.Interval = 100;
            tm.Tick += OTimer_Tick;
            tm.Start();
        }

        // 타이머에서 호출 할 Event ( Interval 간격 기준 )
        private void OTimer_Tick(object sender, EventArgs e)
        {
            iTick = i1Add + i3Add + i50Add;
            iTotal = iTotal + iTick;

            lblTickPoint.Text = string.Format("{0} (1:{1}), (3:{2}), (50:{3})", iTick.ToString(), i1Level.ToString(), i3Level.ToString(), i50Level.ToString());
            lblTotal.Text = iTotal.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Name)
            {
                case "btn1Add":
                    if(iTotal > 100)
                    {
                        iTotal -= 100;

                        i1Level++;
                        i1Add = 1 * i1Level;
                    }
                    break;

                case "btn3Add":
                    if (iTotal > 500)
                    {
                        iTotal -= 100;

                        i3Level++;
                        i3Add = 3 * i3Level;
                    }
                    break;

                case "btn50Add":
                    {
                        iTotal -= 5000;

                        i50Level++;
                        i50Add = 3 * i50Level;
                    }
                    break;

                default:
                    break;
            }
        }
    }
}