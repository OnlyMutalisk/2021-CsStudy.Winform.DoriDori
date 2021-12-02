using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTable_Test
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet(); // 학급들에 대한 정보를 가지고 있을 DataSet
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            bool bCheckisTable = false;
            
            if (ds.Tables.Contains(cboxRegClass.Text))
            {
                bCheckisTable = true;
            }

            //foreach (DataTable item in ds.Tables)
            //{
            //    if (item.TableName.Contains(cboxRegClass.Text))
            //    {
            //        bCheckisTable = true;
            //    }
            //}

            DataTable dt = null;

            if (!bCheckisTable)
            {
                dt = new DataTable(cboxRegClass.Text);

                DataColumn colName = new DataColumn("NAME", typeof(string));
                DataColumn colSex = new DataColumn("SEX", typeof(string));
                DataColumn colRef = new DataColumn("REF", typeof(string));

                dt.Columns.Add(colName);
                dt.Columns.Add(colSex);
                dt.Columns.Add(colRef);
            }
            else
            {
                dt = ds.Tables[cboxRegClass.Text];
            }

            // Row 자료를 등록

            DataRow dr = dt.NewRow();

            dr["NAME"] = tboxRegName.Text;

            if (rdoRegSexMale.Checked)
                dr["SEX"] = "남자";
            else
                dr["SEX"] = "여자";

            dr["REF"] = tboxRegRef.Text;

            // 생성된 Row 를 Table 에 등록
            //dt.Rows.Add(dr);

            //if (bCheckisTable)
            //{
            //    ds.Tables.Remove(cboxRegClass.Text);
            //    ds.Tables.Add(dt);
            //}

            if (bCheckisTable)
            {
                ds.Tables[cboxRegClass.Text].Rows.Add(dr);
            }
            else
            {
                dt.Rows.Add(dr);
                ds.Tables.Add(dt);
            }
            ViewRefresh();
        }

        /// <summary>
        /// 수정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tboxRegName.Text))
            {
                foreach (DataRow dr in ds.Tables[cboxRegClass.Text].Rows)
                {
                    if (dr["NAME"].Equals(tboxRegName.Text))
                    {
                        if (rdoRegSexMale.Checked)
                            dr["SEX"] = "남자";
                        else
                            dr["SEX"] = "여자";

                        dr["REF"] = tboxRegRef.Text;
                    }
                }

                ViewRefresh();
            }
        }

        /// <summary>
        /// 삭제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewDataDel_Click(object sender, EventArgs e)
        {
            int iSelectRow = dgViewInfo.SelectedRows[0].Index;
            ds.Tables[cboxViewClass.Text].Rows.RemoveAt(iSelectRow);

            ViewRefresh();

        }

        private void cboxViewClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewRefresh();
        }

        private void ViewRefresh()
        {
            dgViewInfo.DataSource = ds.Tables[cboxViewClass.Text];

            // DataGridView Cell 정렬 및 Number 적용
            foreach (DataGridViewRow row in dgViewInfo.Rows)
            {
                row.HeaderCell.Value = row.Index.ToString();
            }

            dgViewInfo.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
