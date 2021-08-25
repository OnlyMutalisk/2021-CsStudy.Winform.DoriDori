using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _21_List
{
    public partial class Form1 : Form
    {
        List<string> strList = new List<string>();

        ArrayList arrList = new ArrayList();


        public Form1()
        {
            InitializeComponent();

            // dgViewList.Columns.Add("dgValue", "Value");
        }

        private void pbox_Click(object sender, EventArgs e)
        {
            PictureBox pbox = sender as PictureBox;

            string strSelectText = string.Empty;

            switch (pbox.Name)
            {
                case "pbox1":
                    strSelectText = "cake";
                    break;
                case "pbox2":
                    strSelectText = "burger";
                    break;
                case "pbox3":
                    strSelectText = "pizza";
                    break;
                case "pbox4":
                    strSelectText = "ice";
                    break;
            }

            strList.Add(strSelectText);

            fUIDisplay();

            fDataGridViewDisplay();

        }

        private void fUIDisplay()
        {
            int iCake = 0;
            int iBurger = 0;
            int iPizza = 0;
            int iIce = 0;

            foreach (string oItem in strList)
            {
                switch (oItem)
                {
                    case "cake":
                        iCake++;
                        break;
                    case "burger":
                        iBurger++;
                        break;
                    case "pizza":
                        iPizza++;
                        break;
                    case "ice":
                        iIce++;
                        break;
                }
            }

            lblPick1.Text = iCake.ToString();
            lblPick2.Text = iBurger.ToString();
            lblPick3.Text = iPizza.ToString();
            lblPick4.Text = iIce.ToString();

            lblTotalCount.Text = strList.Count.ToString();

        }

        private void fDataGridViewDisplay()
        {
            dgViewList.DataSource = strList.Select(x => new {value = x}).ToList();

            //dgViewList.Rows.Clear();

            //foreach (string oItem in strList)
            //{
            //    dgViewList.Rows.Add(oItem);
            //}

            foreach (DataGridViewRow oRow in dgViewList.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }

            dgViewList.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
