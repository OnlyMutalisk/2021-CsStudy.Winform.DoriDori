
namespace Trade
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
            this.Start = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.Contain = new System.Windows.Forms.Label();
            this.Equals = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.Label();
            this.Split = new System.Windows.Forms.Label();
            this.Replace = new System.Windows.Forms.Label();
            this.Substring = new System.Windows.Forms.Label();
            this.ToUpper = new System.Windows.Forms.Label();
            this.ToLower = new System.Windows.Forms.Label();
            this.Trim = new System.Windows.Forms.Label();
            this.lblContain = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.lblToUpper = new System.Windows.Forms.Label();
            this.lblToLower = new System.Windows.Forms.Label();
            this.lblReplace = new System.Windows.Forms.Label();
            this.lblSubstring = new System.Windows.Forms.Label();
            this.lblSplit1 = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblTrim = new System.Windows.Forms.Label();
            this.lblSplit3 = new System.Windows.Forms.Label();
            this.lblSplit2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(273, 49);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "실행";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(60, 60);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(114, 12);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Sample, Test, Text";
            // 
            // Contain
            // 
            this.Contain.AutoSize = true;
            this.Contain.Location = new System.Drawing.Point(60, 116);
            this.Contain.Name = "Contain";
            this.Contain.Size = new System.Drawing.Size(48, 12);
            this.Contain.TabIndex = 2;
            this.Contain.Text = "Contain";
            // 
            // Equals
            // 
            this.Equals.AutoSize = true;
            this.Equals.Location = new System.Drawing.Point(60, 150);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(44, 12);
            this.Equals.TabIndex = 3;
            this.Equals.Text = "Equals";
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Location = new System.Drawing.Point(60, 186);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(43, 12);
            this.Length.TabIndex = 4;
            this.Length.Text = "Length";
            // 
            // Split
            // 
            this.Split.AutoSize = true;
            this.Split.Location = new System.Drawing.Point(60, 266);
            this.Split.Name = "Split";
            this.Split.Size = new System.Drawing.Size(29, 12);
            this.Split.TabIndex = 5;
            this.Split.Text = "Split";
            // 
            // Replace
            // 
            this.Replace.AutoSize = true;
            this.Replace.Location = new System.Drawing.Point(60, 222);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(51, 12);
            this.Replace.TabIndex = 6;
            this.Replace.Text = "Replace";
            // 
            // Substring
            // 
            this.Substring.AutoSize = true;
            this.Substring.Location = new System.Drawing.Point(384, 116);
            this.Substring.Name = "Substring";
            this.Substring.Size = new System.Drawing.Size(58, 12);
            this.Substring.TabIndex = 7;
            this.Substring.Text = "Substring";
            // 
            // ToUpper
            // 
            this.ToUpper.AutoSize = true;
            this.ToUpper.Location = new System.Drawing.Point(384, 186);
            this.ToUpper.Name = "ToUpper";
            this.ToUpper.Size = new System.Drawing.Size(53, 12);
            this.ToUpper.TabIndex = 8;
            this.ToUpper.Text = "ToUpper";
            // 
            // ToLower
            // 
            this.ToLower.AutoSize = true;
            this.ToLower.Location = new System.Drawing.Point(384, 150);
            this.ToLower.Name = "ToLower";
            this.ToLower.Size = new System.Drawing.Size(55, 12);
            this.ToLower.TabIndex = 9;
            this.ToLower.Text = "ToLower";
            // 
            // Trim
            // 
            this.Trim.AutoSize = true;
            this.Trim.Location = new System.Drawing.Point(384, 222);
            this.Trim.Name = "Trim";
            this.Trim.Size = new System.Drawing.Size(31, 12);
            this.Trim.TabIndex = 10;
            this.Trim.Text = "Trim";
            // 
            // lblContain
            // 
            this.lblContain.AutoSize = true;
            this.lblContain.Location = new System.Drawing.Point(165, 116);
            this.lblContain.Name = "lblContain";
            this.lblContain.Size = new System.Drawing.Size(11, 12);
            this.lblContain.TabIndex = 11;
            this.lblContain.Text = "-";
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Location = new System.Drawing.Point(165, 150);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(11, 12);
            this.lblEquals.TabIndex = 12;
            this.lblEquals.Text = "-";
            // 
            // lblToUpper
            // 
            this.lblToUpper.AutoSize = true;
            this.lblToUpper.Location = new System.Drawing.Point(482, 186);
            this.lblToUpper.Name = "lblToUpper";
            this.lblToUpper.Size = new System.Drawing.Size(11, 12);
            this.lblToUpper.TabIndex = 13;
            this.lblToUpper.Text = "-";
            // 
            // lblToLower
            // 
            this.lblToLower.AutoSize = true;
            this.lblToLower.Location = new System.Drawing.Point(482, 150);
            this.lblToLower.Name = "lblToLower";
            this.lblToLower.Size = new System.Drawing.Size(11, 12);
            this.lblToLower.TabIndex = 14;
            this.lblToLower.Text = "-";
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(165, 222);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(11, 12);
            this.lblReplace.TabIndex = 15;
            this.lblReplace.Text = "-";
            // 
            // lblSubstring
            // 
            this.lblSubstring.AutoSize = true;
            this.lblSubstring.Location = new System.Drawing.Point(482, 116);
            this.lblSubstring.Name = "lblSubstring";
            this.lblSubstring.Size = new System.Drawing.Size(11, 12);
            this.lblSubstring.TabIndex = 16;
            this.lblSubstring.Text = "-";
            // 
            // lblSplit1
            // 
            this.lblSplit1.AutoSize = true;
            this.lblSplit1.Location = new System.Drawing.Point(165, 266);
            this.lblSplit1.Name = "lblSplit1";
            this.lblSplit1.Size = new System.Drawing.Size(11, 12);
            this.lblSplit1.TabIndex = 17;
            this.lblSplit1.Text = "-";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(165, 186);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(11, 12);
            this.lblLength.TabIndex = 18;
            this.lblLength.Text = "-";
            // 
            // lblTrim
            // 
            this.lblTrim.AutoSize = true;
            this.lblTrim.Location = new System.Drawing.Point(482, 222);
            this.lblTrim.Name = "lblTrim";
            this.lblTrim.Size = new System.Drawing.Size(11, 12);
            this.lblTrim.TabIndex = 19;
            this.lblTrim.Text = "-";
            // 
            // lblSplit3
            // 
            this.lblSplit3.AutoSize = true;
            this.lblSplit3.Location = new System.Drawing.Point(165, 336);
            this.lblSplit3.Name = "lblSplit3";
            this.lblSplit3.Size = new System.Drawing.Size(11, 12);
            this.lblSplit3.TabIndex = 20;
            this.lblSplit3.Text = "-";
            // 
            // lblSplit2
            // 
            this.lblSplit2.AutoSize = true;
            this.lblSplit2.Location = new System.Drawing.Point(165, 302);
            this.lblSplit2.Name = "lblSplit2";
            this.lblSplit2.Size = new System.Drawing.Size(11, 12);
            this.lblSplit2.TabIndex = 21;
            this.lblSplit2.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSplit2);
            this.Controls.Add(this.lblSplit3);
            this.Controls.Add(this.lblTrim);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblSplit1);
            this.Controls.Add(this.lblSubstring);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.lblToLower);
            this.Controls.Add(this.lblToUpper);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.lblContain);
            this.Controls.Add(this.Trim);
            this.Controls.Add(this.ToLower);
            this.Controls.Add(this.ToUpper);
            this.Controls.Add(this.Substring);
            this.Controls.Add(this.Replace);
            this.Controls.Add(this.Split);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.Contain);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label Contain;
        private System.Windows.Forms.Label Equals;
        private System.Windows.Forms.Label Length;
        private System.Windows.Forms.Label Split;
        private System.Windows.Forms.Label Replace;
        private System.Windows.Forms.Label Substring;
        private System.Windows.Forms.Label ToUpper;
        private System.Windows.Forms.Label ToLower;
        private System.Windows.Forms.Label Trim;
        private System.Windows.Forms.Label lblContain;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Label lblToUpper;
        private System.Windows.Forms.Label lblToLower;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.Label lblSubstring;
        private System.Windows.Forms.Label lblSplit1;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblTrim;
        private System.Windows.Forms.Label lblSplit3;
        private System.Windows.Forms.Label lblSplit2;
    }
}

