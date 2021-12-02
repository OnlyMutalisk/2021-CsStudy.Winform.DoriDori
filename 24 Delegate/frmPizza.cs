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

namespace _24_Delegate
{
    public partial class frmPizza : Form
    {
        public delegate int delPizzaComplete(string strResult, int iTime);
        public event delPizzaComplete eventdelPizzaComplete; // delegate event 선언

        private bool bOrderComplete = false; // 제작이 완료 됐는지 확인하는 Flag

        public bool BOrderComplete { get => bOrderComplete; set => bOrderComplete = value; }

        public frmPizza()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal void fPizzaCheck(Dictionary<string, int> dPizzaOrder)
        {
            bOrderComplete = false;

            int iTotalTime = 0;

            foreach (KeyValuePair<string, int> oOrder in dPizzaOrder)
            {
                int iNowTime = 0;
                int iTime = 0;
                int iCount = oOrder.Value;
                string strType = string.Empty;


                switch (oOrder.Key)
                {
                    // 도우
                    case "오리지널":
                        iNowTime = 3000;
                        strType = "도우";
                        break;

                    case "씬":
                        iNowTime = 3500;
                        strType = "도우";
                        break;

                    //엣지
                    case "리치골드":
                        iNowTime = 500;
                        strType = "엣지";
                        break;

                    case "치즈 크러스트":
                        iNowTime = 400;
                        strType = "엣지";
                        break;

                    //토핑
                    case "소세지":
                        iNowTime = 32;
                        strType = "토핑";
                        break;

                    case "감자":
                        iNowTime = 17;
                        strType = "토핑";

                        break;
                    case "치즈":
                        iNowTime = 48;
                        strType = "토핑";

                        break;

                    default:
                        break;
                }

                iTime = iNowTime * iCount;
                iTotalTime += iTime;
                lboxMake.Items.Add(string.Format("{0} ) {1} : {2} 초 ( {3} 초, {4} 개 )", strType, oOrder.Key, iTime, iNowTime, iCount));

                Refresh();
                Thread.Sleep(1000);
            }

            int iRet = eventdelPizzaComplete("Pizza 가 완성되었습니다.", iTotalTime);

            bOrderComplete = true;

            lboxMake.Items.Add("---------------------------");

            if (iRet == 0)
            {
                lboxMake.Items.Add("주문 완료 확인 !!");
            }
            else
            {
                lboxMake.Items.Add("제작 시간 초과로 고객 반품 !!!");
            }
        }
    }
}
