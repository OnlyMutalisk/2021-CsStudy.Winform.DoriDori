using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CP = _12_Class.CPlayer;

namespace _11_Struct_Class
{


    public partial class Form1 : Form
    {
        
        
        struct structPlayer
        {
            public int iCount;

            public int iSun;
            public int iMoon;
            public int iStar;

            public int iCardSum;

            //// 값들을 더해서 반환
            //public int CardSun(int iSum, int iMoon, int iStar)
            //{
            //    return iSun + iMoon + iStar;
            //}

            //// 결과를 String 형태로 변환 ( 화면에 결과를 보여주기 위해 사용 )

            
            //public string ResultText()
            //{
            //    return string.Format("{0} 회 )  해 : {1}, 달 : {2}, 별 : {3} => 합계는 {4} 입니다.", iCount, iSun, iMoon, iStar, iCardSum);
            //}
        }


        structPlayer _stPlayer1; // 1번 Player
        structPlayer _stPlayer2; // 2번 Player

        Random _rd = new Random();

        //CP _clPlayer1 = new CP(); // 1번 Player
        //CP _clPlayer2 = new CP(); // 2번 Player

        public Form1()
        {
            InitializeComponent();
        }

        private void pboxSun_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rbtn1.Checked)
            {
                _stPlayer1.iSun = iNumber;
            }
            else
            {
                _stPlayer2.iSun = iNumber;
            }

            Result();
        }

        private void pboxMoon_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rbtn1.Checked)
            {
                _stPlayer1.iMoon = iNumber;
            }
            else
            {
                _stPlayer2.iMoon = iNumber;
            }

            Result();
        }

        private void pboxStar_Click(object sender, EventArgs e)
        {
            
            int iNumber = _rd.Next(1, 21);

            if (rbtn1.Checked)
            {
                _stPlayer1.iStar = iNumber;
            }
            else
            {
                _stPlayer2.iStar = iNumber;
            }

            Result();
        }

        private void pboxNone_Click(object sender, EventArgs e)
        {
            // 아무짓도 안하고 한 턴을 넘긴다.

            Result();

        }

        private void iCheckedChange()
        {
            if (rbtn1.Checked)
            {
                rbtn2.Checked = true;
            }
            else
            {
                rbtn1.Checked = true;
            }
        }

        _12_Class.CPlayer cPlayer;

        private void Result()
        {
            cPlayer = new _12_Class.CPlayer();

            string strResult = string.Empty;

            if (rbtn1.Checked)
            {
                _stPlayer1.iCount++;

                _stPlayer1.iCardSum = cPlayer.CardSun(_stPlayer1.iSun, _stPlayer1.iMoon, _stPlayer1.iStar);

                strResult = cPlayer.ResultText(_stPlayer1.iCount, _stPlayer1.iSun, _stPlayer1.iMoon, _stPlayer1.iStar, _stPlayer1.iCardSum);

                lboxResult1.Items.Add(strResult);
            }
            else
            {
                _stPlayer2.iCount++;

                _stPlayer2.iCardSum = cPlayer.CardSun(_stPlayer2.iSun, _stPlayer2.iMoon, _stPlayer2.iStar);

                strResult = cPlayer.ResultText(_stPlayer2.iCount, _stPlayer2.iSun, _stPlayer2.iMoon, _stPlayer2.iStar, _stPlayer2.iCardSum);

                lboxResult2.Items.Add(strResult);
            }

            iCheckedChange();

            if(_stPlayer1.iCount == _stPlayer2.iCount)
            {
                lboxNow.Items.Add(cPlayer.PlayerPair(_stPlayer2.iCount, _stPlayer1.iCardSum, _stPlayer2.iCardSum));

                if(_stPlayer2.iCount >= 5)
                {
                    lboxNow.Items.Add(cPlayer.PlayerResult(_stPlayer1.iCardSum, _stPlayer2.iCardSum));
                }
            }

            //if (_clPlayer1.iCount >= 5 && _clPlayer2.iCount >= 5)
            //{
                
            //}
        }
    }
}
