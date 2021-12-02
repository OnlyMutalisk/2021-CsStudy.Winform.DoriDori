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
        Queue<int> _queue = new Queue<int>(6);
        Stack<int> _stack = new Stack<int>(6);

        public lblQueue()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int data = rd.Next(1, 101);

            // Queue 에 Data 를 입력
            if (_queue.Count < 6)
            {
                _queue.Enqueue(data);
                fQueueDataDisplay();
            }

            // Stack 에 Data 를 입력
            if (_stack.Count < 6)
            {
                _stack.Push(data);
                fStackDataDisplay();
            }
        }

        private void btnAutoOut_Click(object sender, EventArgs e)
        {
            if (_tmCheck_flag)
            {
                _tmCheck.Stop();

                _tmCheck_flag = false;
            }
            else
            {
                _tmCheck.Interval = 2000;
                _tmCheck.Tick += _tmCheck_Tick;
                _tmCheck.Start();

                _tmCheck_flag = true;
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            fDataOut();
        }

        private void fDataOut()
        {
            //Queue에 Data를 입력
            if (_queue.Count > 0)
            {
                _queue.Dequeue();
                fQueueDataDisplay();
            }

            //Stack에 Data를 입력
            if (_stack.Count > 0)
            {
                _stack.Pop();
                fStackDataDisplay();
            }
        }

        private void fQueueDataDisplay()
        {
            int[] iArray = _queue.ToArray();

            Array.Resize(ref iArray, 6);

            lblQueue1.Text = (iArray[0] == 0) ? "" : iArray[0].ToString();
            lblQueue2.Text = (iArray[1] == 0) ? "" : iArray[1].ToString();
            lblQueue3.Text = (iArray[2] == 0) ? "" : iArray[2].ToString();
            lblQueue4.Text = (iArray[3] == 0) ? "" : iArray[3].ToString();
            lblQueue5.Text = (iArray[4] == 0) ? "" : iArray[4].ToString();
            lblQueue6.Text = (iArray[5] == 0) ? "" : iArray[5].ToString();
        }

        private void fStackDataDisplay()
        {
            int[] iArray = _stack.ToArray();

            Array.Resize(ref iArray, 6);

            lblStack1.Text = (iArray[0] == 0) ? "" : iArray[0].ToString();
            lblStack2.Text = (iArray[1] == 0) ? "" : iArray[1].ToString();
            lblStack3.Text = (iArray[2] == 0) ? "" : iArray[2].ToString();
            lblStack4.Text = (iArray[3] == 0) ? "" : iArray[3].ToString();
            lblStack5.Text = (iArray[4] == 0) ? "" : iArray[4].ToString();
            lblStack6.Text = (iArray[5] == 0) ? "" : iArray[5].ToString();
        }

        Timer _tmCheck = new Timer();
        bool _tmCheck_flag = false;   // Timer 스위치

        private void _tmCheck_Tick(object sender, EventArgs e)
        {
            fDataOut();
        }
    }
}
