﻿
namespace _21_List
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPick4 = new System.Windows.Forms.Label();
            this.lblPick3 = new System.Windows.Forms.Label();
            this.lblPick2 = new System.Windows.Forms.Label();
            this.pbox1 = new System.Windows.Forms.PictureBox();
            this.pbox2 = new System.Windows.Forms.PictureBox();
            this.pbox3 = new System.Windows.Forms.PictureBox();
            this.pbox4 = new System.Windows.Forms.PictureBox();
            this.lblPick1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgViewList = new System.Windows.Forms.DataGridView();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "※ 선호하는 항목을 선택해 주세요";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPick4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPick3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPick2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbox4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPick1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 179);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(107, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "신혜";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(3, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "보검";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(315, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "보영";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(211, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "해인";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPick4
            // 
            this.lblPick4.AutoSize = true;
            this.lblPick4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPick4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPick4.Location = new System.Drawing.Point(315, 129);
            this.lblPick4.Name = "lblPick4";
            this.lblPick4.Size = new System.Drawing.Size(100, 25);
            this.lblPick4.TabIndex = 7;
            this.lblPick4.Text = "0";
            this.lblPick4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPick3
            // 
            this.lblPick3.AutoSize = true;
            this.lblPick3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPick3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPick3.Location = new System.Drawing.Point(211, 129);
            this.lblPick3.Name = "lblPick3";
            this.lblPick3.Size = new System.Drawing.Size(98, 25);
            this.lblPick3.TabIndex = 6;
            this.lblPick3.Text = "0";
            this.lblPick3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPick2
            // 
            this.lblPick2.AutoSize = true;
            this.lblPick2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPick2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPick2.Location = new System.Drawing.Point(107, 129);
            this.lblPick2.Name = "lblPick2";
            this.lblPick2.Size = new System.Drawing.Size(98, 25);
            this.lblPick2.TabIndex = 5;
            this.lblPick2.Text = "0";
            this.lblPick2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbox1
            // 
            this.pbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox1.Image = global::_21_List.Properties.Resources._11;
            this.pbox1.Location = new System.Drawing.Point(3, 3);
            this.pbox1.Name = "pbox1";
            this.pbox1.Size = new System.Drawing.Size(98, 123);
            this.pbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox1.TabIndex = 0;
            this.pbox1.TabStop = false;
            this.pbox1.Click += new System.EventHandler(this.pbox_Click);
            // 
            // pbox2
            // 
            this.pbox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox2.Image = global::_21_List.Properties.Resources._12;
            this.pbox2.Location = new System.Drawing.Point(107, 3);
            this.pbox2.Name = "pbox2";
            this.pbox2.Size = new System.Drawing.Size(98, 123);
            this.pbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox2.TabIndex = 1;
            this.pbox2.TabStop = false;
            this.pbox2.Click += new System.EventHandler(this.pbox_Click);
            // 
            // pbox3
            // 
            this.pbox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox3.Image = global::_21_List.Properties.Resources._13;
            this.pbox3.Location = new System.Drawing.Point(211, 3);
            this.pbox3.Name = "pbox3";
            this.pbox3.Size = new System.Drawing.Size(98, 123);
            this.pbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox3.TabIndex = 2;
            this.pbox3.TabStop = false;
            this.pbox3.Click += new System.EventHandler(this.pbox_Click);
            // 
            // pbox4
            // 
            this.pbox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox4.Image = global::_21_List.Properties.Resources._14;
            this.pbox4.Location = new System.Drawing.Point(315, 3);
            this.pbox4.Name = "pbox4";
            this.pbox4.Size = new System.Drawing.Size(100, 123);
            this.pbox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox4.TabIndex = 3;
            this.pbox4.TabStop = false;
            this.pbox4.Click += new System.EventHandler(this.pbox_Click);
            // 
            // lblPick1
            // 
            this.lblPick1.AutoSize = true;
            this.lblPick1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPick1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPick1.Location = new System.Drawing.Point(3, 129);
            this.lblPick1.Name = "lblPick1";
            this.lblPick1.Size = new System.Drawing.Size(98, 25);
            this.lblPick1.TabIndex = 4;
            this.lblPick1.Text = "0";
            this.lblPick1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "투표 진행 현황 :";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(115, 280);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(31, 12);
            this.lblTotalCount.TabIndex = 3;
            this.lblTotalCount.Text = "0 / 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "※ Dictionary의 Data를 화면에 보여줍니다.";
            // 
            // dgViewList
            // 
            this.dgViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewList.Location = new System.Drawing.Point(64, 348);
            this.dgViewList.Name = "dgViewList";
            this.dgViewList.RowTemplate.Height = 23;
            this.dgViewList.Size = new System.Drawing.Size(258, 248);
            this.dgViewList.TabIndex = 5;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(77, 247);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(11, 12);
            this.lblPlayerName.TabIndex = 7;
            this.lblPlayerName.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "투표자 :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 615);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgViewList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgViewList;
        private System.Windows.Forms.PictureBox pbox2;
        private System.Windows.Forms.PictureBox pbox3;
        private System.Windows.Forms.PictureBox pbox4;
        private System.Windows.Forms.Label lblPick4;
        private System.Windows.Forms.Label lblPick3;
        private System.Windows.Forms.Label lblPick2;
        private System.Windows.Forms.Label lblPick1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label label9;
    }
}

