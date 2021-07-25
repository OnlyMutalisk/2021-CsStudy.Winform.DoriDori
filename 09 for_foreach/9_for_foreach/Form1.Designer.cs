
namespace _9_for_foreach
{
    partial class btnForeach
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
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxResult
            // 
            this.tboxResult.Location = new System.Drawing.Point(12, 12);
            this.tboxResult.Multiline = true;
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tboxResult.Size = new System.Drawing.Size(289, 253);
            this.tboxResult.TabIndex = 0;
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(307, 12);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(238, 65);
            this.btnFor.TabIndex = 1;
            this.btnFor.Text = "for 문";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "foreach 문";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnForeach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 279);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.tboxResult);
            this.Name = "btnForeach";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxResult;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button button2;
    }
}

