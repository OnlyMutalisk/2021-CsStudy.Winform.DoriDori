
namespace if_switch
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nNumber1 = new System.Windows.Forms.NumericUpDown();
            this.nNumber2 = new System.Windows.Forms.NumericUpDown();
            this.btnIfResult = new System.Windows.Forms.Button();
            this.lblIfRsult = new System.Windows.Forms.Label();
            this.cboxDay = new System.Windows.Forms.ComboBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblSwitchResult = new System.Windows.Forms.Label();
            this.btnSwitchResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number(1)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number(2)";
            // 
            // nNumber1
            // 
            this.nNumber1.Location = new System.Drawing.Point(28, 71);
            this.nNumber1.Name = "nNumber1";
            this.nNumber1.Size = new System.Drawing.Size(120, 21);
            this.nNumber1.TabIndex = 2;
            // 
            // nNumber2
            // 
            this.nNumber2.Location = new System.Drawing.Point(183, 71);
            this.nNumber2.Name = "nNumber2";
            this.nNumber2.Size = new System.Drawing.Size(120, 21);
            this.nNumber2.TabIndex = 3;
            // 
            // btnIfResult
            // 
            this.btnIfResult.Location = new System.Drawing.Point(391, 71);
            this.btnIfResult.Name = "btnIfResult";
            this.btnIfResult.Size = new System.Drawing.Size(125, 23);
            this.btnIfResult.TabIndex = 4;
            this.btnIfResult.Text = "Number 비교";
            this.btnIfResult.UseVisualStyleBackColor = true;
            this.btnIfResult.Click += new System.EventHandler(this.btnIfResult_Click);
            // 
            // lblIfRsult
            // 
            this.lblIfRsult.AutoSize = true;
            this.lblIfRsult.Location = new System.Drawing.Point(26, 132);
            this.lblIfRsult.Name = "lblIfRsult";
            this.lblIfRsult.Size = new System.Drawing.Size(11, 12);
            this.lblIfRsult.TabIndex = 5;
            this.lblIfRsult.Text = "-";
            // 
            // cboxDay
            // 
            this.cboxDay.FormattingEnabled = true;
            this.cboxDay.Items.AddRange(new object[] {
            "월",
            "화",
            "수",
            "목",
            "금",
            "토",
            "일"});
            this.cboxDay.Location = new System.Drawing.Point(27, 211);
            this.cboxDay.Name = "cboxDay";
            this.cboxDay.Size = new System.Drawing.Size(121, 20);
            this.cboxDay.TabIndex = 6;
            this.cboxDay.Text = "월";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(26, 183);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(66, 12);
            this.lblDay.TabIndex = 7;
            this.lblDay.Text = "요일 선택 )";
            // 
            // lblSwitchResult
            // 
            this.lblSwitchResult.AutoSize = true;
            this.lblSwitchResult.Location = new System.Drawing.Point(25, 275);
            this.lblSwitchResult.Name = "lblSwitchResult";
            this.lblSwitchResult.Size = new System.Drawing.Size(11, 12);
            this.lblSwitchResult.TabIndex = 8;
            this.lblSwitchResult.Text = "-";
            // 
            // btnSwitchResult
            // 
            this.btnSwitchResult.Location = new System.Drawing.Point(391, 208);
            this.btnSwitchResult.Name = "btnSwitchResult";
            this.btnSwitchResult.Size = new System.Drawing.Size(125, 23);
            this.btnSwitchResult.TabIndex = 9;
            this.btnSwitchResult.Text = "선택 요일 확인";
            this.btnSwitchResult.UseVisualStyleBackColor = true;
            this.btnSwitchResult.Click += new System.EventHandler(this.btnSwitchResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSwitchResult);
            this.Controls.Add(this.lblSwitchResult);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.cboxDay);
            this.Controls.Add(this.lblIfRsult);
            this.Controls.Add(this.btnIfResult);
            this.Controls.Add(this.nNumber2);
            this.Controls.Add(this.nNumber1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nNumber1;
        private System.Windows.Forms.NumericUpDown nNumber2;
        private System.Windows.Forms.Button btnIfResult;
        private System.Windows.Forms.Label lblIfRsult;
        private System.Windows.Forms.ComboBox cboxDay;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblSwitchResult;
        private System.Windows.Forms.Button btnSwitchResult;
    }
}

