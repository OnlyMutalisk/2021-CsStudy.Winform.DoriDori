using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_StreamReader_Writer
{
    public partial class Form1 : Form
    {
        CXMLControl _XML = new CXMLControl();

        Dictionary<string, string> _dData = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfigSet_Click(object sender, EventArgs e)
        {
            string strEnter = "\r\n";

            string strText = tboxData.Text;
            bool bChecked = cboxData.Checked;
            int iNumber = (int)numData.Value;

            StringBuilder sb = new StringBuilder();
            sb.Append(strText + strEnter);
            sb.Append(bChecked.ToString() + strEnter);
            sb.Append(iNumber.ToString());

            tboxConfigData.Text = sb.ToString();

            _dData.Clear();

            _dData.Add(CXMLControl._TEXT_DATA, strText);
            _dData.Add(CXMLControl._CBOX_DATA, bChecked.ToString());
            _dData.Add(CXMLControl._NUMBER_DATA, iNumber.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            SFdialog.InitialDirectory = Application.StartupPath; // 프로그램 실행 파일 위치
            SFdialog.FileName = "*.xml";
            SFdialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

            if (SFdialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = SFdialog.FileName;

                //StreamWriter swSFDialog = new StreamWriter(strFilePath);

                //swSFDialog.WriteLine(tboxConfigData.Text);
                //swSFDialog.Close();

                //File.WriteAllText(strFilePath, tboxConfigData.Text);

                _XML.fXML_Writer(strFilePath, _dData);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            OFdialog.InitialDirectory = Application.StartupPath; // 프로그램 실행 파일 위치
            OFdialog.FileName = "*.xml";
            OFdialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

            StringBuilder sb = new StringBuilder();

            if(OFdialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = OFdialog.FileName;

                //StreamReader srOFdialog = new StreamReader(strFilePath);

                //while(srOFdialog.EndOfStream == false)
                //{
                //    sb.Append(srOFdialog.ReadLine() + "\r\n");
                //}

                sb.Append(File.ReadAllText(strFilePath));

                //string[] dd = File.ReadAllLines(strFilePath);

                tboxConfigData.Text = sb.ToString();

                _dData.Clear();
                _dData = _XML.fXML_Reader(strFilePath);
            }
        }

        private void btnConfigLoad_Click(object sender, EventArgs e)
        {
            //string[] strConfig = tboxConfigData.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            //tboxData.Text = strConfig[0];
            //cboxData.Checked = bool.Parse(strConfig[1]);
            //numData.Value = int.Parse(strConfig[2]);

            tboxData.Text = _dData[CXMLControl._TEXT_DATA];
            cboxData.Checked = bool.Parse(_dData[CXMLControl._CBOX_DATA]);
            numData.Value = int.Parse(_dData[CXMLControl._NUMBER_DATA]);
        }
    }
}
