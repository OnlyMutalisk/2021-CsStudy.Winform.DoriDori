using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18.Simple_Clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer oTimer = new Timer();
            oTimer.Enabled = true;
            oTimer.Interval = 5000;
            oTimer.Tick += OTimer_Tick;
            oTimer.Start();
        }

        // 타이머에서 호출 할 Event ( Interval 간격 기준 )
        private void OTimer_Tick(object sender, EventArgs e)
        {
            string dd = string.Empty;
        }
    }
}