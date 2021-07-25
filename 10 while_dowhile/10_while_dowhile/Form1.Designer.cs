
namespace _10_while_dowhile
{
    partial class form1
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
            this.lblWhileResult = new System.Windows.Forms.Label();
            this.btnWhileResult = new System.Windows.Forms.Button();
            this.lboxWhileResult = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDoWhileResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxNumber = new System.Windows.Forms.TextBox();
            this.lblDoWhileResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWhileResult
            // 
            this.lblWhileResult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWhileResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWhileResult.Location = new System.Drawing.Point(12, 9);
            this.lblWhileResult.Name = "lblWhileResult";
            this.lblWhileResult.Size = new System.Drawing.Size(239, 27);
            this.lblWhileResult.TabIndex = 0;
            this.lblWhileResult.Text = "0, 0, 0, 0, 0, 0.";
            this.lblWhileResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWhileResult
            // 
            this.btnWhileResult.Location = new System.Drawing.Point(257, 9);
            this.btnWhileResult.Name = "btnWhileResult";
            this.btnWhileResult.Size = new System.Drawing.Size(106, 27);
            this.btnWhileResult.TabIndex = 1;
            this.btnWhileResult.Text = "로또 번호";
            this.btnWhileResult.UseVisualStyleBackColor = true;
            this.btnWhileResult.Click += new System.EventHandler(this.btnWhileResult_Click);
            // 
            // lboxWhileResult
            // 
            this.lboxWhileResult.FormattingEnabled = true;
            this.lboxWhileResult.ItemHeight = 12;
            this.lboxWhileResult.Location = new System.Drawing.Point(14, 52);
            this.lboxWhileResult.Name = "lboxWhileResult";
            this.lboxWhileResult.Size = new System.Drawing.Size(237, 136);
            this.lboxWhileResult.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(14, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 3);
            this.panel1.TabIndex = 3;
            // 
            // btnDoWhileResult
            // 
            this.btnDoWhileResult.Location = new System.Drawing.Point(94, 234);
            this.btnDoWhileResult.Name = "btnDoWhileResult";
            this.btnDoWhileResult.Size = new System.Drawing.Size(106, 21);
            this.btnDoWhileResult.TabIndex = 4;
            this.btnDoWhileResult.Text = "로또 번호";
            this.btnDoWhileResult.UseVisualStyleBackColor = true;
            this.btnDoWhileResult.Click += new System.EventHandler(this.btnDoWhileResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "1 ~ 100 안의 숫자를 선택 하세요.";
            // 
            // tboxNumber
            // 
            this.tboxNumber.Location = new System.Drawing.Point(16, 234);
            this.tboxNumber.Name = "tboxNumber";
            this.tboxNumber.Size = new System.Drawing.Size(72, 21);
            this.tboxNumber.TabIndex = 6;
            // 
            // lblDoWhileResult
            // 
            this.lblDoWhileResult.AutoSize = true;
            this.lblDoWhileResult.Location = new System.Drawing.Point(14, 264);
            this.lblDoWhileResult.Name = "lblDoWhileResult";
            this.lblDoWhileResult.Size = new System.Drawing.Size(11, 12);
            this.lblDoWhileResult.TabIndex = 7;
            this.lblDoWhileResult.Text = "-";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 293);
            this.Controls.Add(this.lblDoWhileResult);
            this.Controls.Add(this.tboxNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoWhileResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lboxWhileResult);
            this.Controls.Add(this.btnWhileResult);
            this.Controls.Add(this.lblWhileResult);
            this.Name = "form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWhileResult;
        private System.Windows.Forms.Button btnWhileResult;
        private System.Windows.Forms.ListBox lboxWhileResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDoWhileResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxNumber;
        private System.Windows.Forms.Label lblDoWhileResult;
    }
}

