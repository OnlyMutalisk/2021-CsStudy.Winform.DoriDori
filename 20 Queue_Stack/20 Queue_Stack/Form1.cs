using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_Queue_Stack
{
    public partial class lblQueue : Form
    {
        Queue<int> _Queue = new Queue<int>(6);
        Stack<int> _Stack = new Stack<int>(6);

        public lblQueue()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int iData = rd.Next(1, 101);

            //Queue에 Data를 입력

            if(_Queue.Count < 6)
            {
                _Queue.Enqueue(iData);
            }


        }
    }
}
