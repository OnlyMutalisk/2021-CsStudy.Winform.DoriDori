using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18.Simple_Clicker
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> dc = new Dictionary<string, string>();
        CXMLControl xml = new CXMLControl();
        string strPath = Application.StartupPath + "\\Save.txt";

        private double iTick = 0;
        private double iTotal = 0;

        private int i1Add = 1;
        private int i1Level = 1;

        private int i3Add = 0;
        private int i3Level =0;

        private int i50Add = 0;
        private int i50Level = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(strPath))
            {
                // File 이 있을 경우 File Loading
                dc = xml.fXML_Reader(strPath);

                iTick = double.Parse(dc[CXMLControl._TICK]);
                iTotal = double.Parse(dc[CXMLControl._TOTAL]);
                i1Level = int.Parse(dc[CXMLControl._LEVEL_1]);
                i3Level = int.Parse(dc[CXMLControl._LEVEL_3]);
                i50Level = int.Parse(dc[CXMLControl._LEVEL_50]);

                i1Add = 1 * i1Level;
                i3Add = 3 * i3Level;
                i50Add = 50 * i50Level;
            }

            System.Windows.Forms.Timer tm = new System.Windows.Forms.Timer();
            tm.Enabled = true;
            tm.Interval = 100;
            tm.Tick += OTimer_Tick;
            tm.Start();
        }

        private void Form1_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            dc.Clear();

            dc.Add(CXMLControl._TICK, iTick.ToString());
            dc.Add(CXMLControl._TOTAL, iTotal.ToString());
            dc.Add(CXMLControl._LEVEL_1, i1Level.ToString());
            dc.Add(CXMLControl._LEVEL_3, i3Level.ToString());
            dc.Add(CXMLControl._LEVEL_50, i50Level.ToString());

            xml.fXML_Writer(strPath, dc);
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
                        i50Add = 50 * i50Level;
                    }
                    break;

                default:
                    break;
            }
        }
    }
}