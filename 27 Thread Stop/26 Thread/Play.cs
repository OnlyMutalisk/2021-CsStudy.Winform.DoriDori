using System;
using System.Threading;
using System.Windows.Forms;

namespace _26_Thread
{
    public partial class Play : Form
    {
        public delegate int delMessage(object sender, string strResult); // delegate 선언
        public event delMessage eventdelMessage;

        string _strPlayerName = string.Empty;
        public string StrPlayerName { get => _strPlayerName; set => _strPlayerName = value; }

        Thread _thread = null;

        bool _bThreadStop = false; // Thread Stop 을 위한 Flag 생성

        public Play()
        {
            InitializeComponent();
        }

        public Play(string strPlayerName)
        {
            InitializeComponent();

            lblPlayerName.Text = StrPlayerName = strPlayerName;
        }

        public void fThreadStart()
        {
            // _thread = new Thread(new ThreadStart(Run)); // ThreadStart 델리게이트 타입 객체를 생성 후 함수를 넘김

            _thread = new Thread(Run); // 컴파일러에서 델리게이트 객체를 추론해서 생성 후 함수를 넘김 ( new Thread Start 생략 )

            // _thread = new Thread(delegate ()
            // {
            // Run();
            // }); // 익명 메소드를 사용하여 생성 후 함수를 넘김

            _thread.Start();
        }

        public void Run()
        {
            // UI Control 이 자신이 만들어진 Thread 가 아닌 다른 Thread 에서 접근 할 경우 Cross Thread 가 발생
            // CheckForIllegalCrossThreadCalls = false; // Thread 충돌에 대한 예외 처리를 무시 ( Cross Thread 무시 )

            try
            {
                int ivar = 0;

                Random rd = new Random();

                while (pbarPlayer.Value < 100 && !_bThreadStop)
                {
                    if (this.InvokeRequired) // 요청 한 Thread 가 현재 Main Thread 있는 Control 을 액세스 할 수 있는지 확인
                    {
                        this.Invoke(new Action(delegate ()
                        {
                            ivar = rd.Next(1, 11);
                            // pbarPlayer.Value = ();

                            if (pbarPlayer.Value + ivar > 100)
                            {
                                pbarPlayer.Value = 100;
                            }
                            else
                            {
                                pbarPlayer.Value = pbarPlayer.Value + ivar;
                            }

                            lblProcess.Text = string.Format("진행 상황 표시 : {0}%", pbarPlayer.Value);

                            this.Refresh();
                        }));

                        Thread.Sleep(300);
                    }
                }

                if (_bThreadStop)
                {
                    eventdelMessage(this, "중도 포기... ( Thread Stop )");
                }
                else
                {
                    eventdelMessage(this, "완주 !! ( Thread Complete )");
                }

            }
            catch (ThreadInterruptedException exInterrupt)
            {
                exInterrupt.ToString();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        public void ThreadAbort()
        {
            if (_thread.IsAlive) // Thread 가 동작 중일 경우
            {
                _thread.Abort(); // Thread 를 강제 종료
            }
        }

        public void ThreadJoin()
        {
            if (_thread.IsAlive) // thread 가 동작 중일 경우
            {
                bool bThreadEnd = _thread.Join(3000);
            }
        }

        public void ThreadInterrupt()
        {
            if (_thread.IsAlive)
            {
                _thread.Interrupt();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // ThreadInterrupt();

            if (_thread.IsAlive)
            {
                _bThreadStop = true;
            }
        }
    }
}
