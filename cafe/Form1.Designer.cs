namespace cafe
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
            this.components = new System.ComponentModel.Container();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.Startbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Titletxt = new System.Windows.Forms.TextBox();
            this.ContentTxt = new System.Windows.Forms.TextBox();
            this.Peopletxt = new System.Windows.Forms.TextBox();
            this.Addresstxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ExBtn = new System.Windows.Forms.Button();
            this.Extxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(64, 23);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(100, 21);
            this.idtxt.TabIndex = 0;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(64, 65);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(100, 21);
            this.passtxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "아이디:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "비밀번호:";
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(192, 23);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(75, 63);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "로그인";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // Startbtn
            // 
            this.Startbtn.Location = new System.Drawing.Point(608, 501);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(75, 23);
            this.Startbtn.TabIndex = 5;
            this.Startbtn.Text = "실행";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(706, 501);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn.TabIndex = 6;
            this.Exitbtn.Text = "종료";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "제목:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "내용:";
            // 
            // Titletxt
            // 
            this.Titletxt.Location = new System.Drawing.Point(346, 29);
            this.Titletxt.Name = "Titletxt";
            this.Titletxt.Size = new System.Drawing.Size(435, 21);
            this.Titletxt.TabIndex = 9;
            // 
            // ContentTxt
            // 
            this.ContentTxt.Location = new System.Drawing.Point(346, 68);
            this.ContentTxt.Multiline = true;
            this.ContentTxt.Name = "ContentTxt";
            this.ContentTxt.Size = new System.Drawing.Size(435, 251);
            this.ContentTxt.TabIndex = 10;
            // 
            // Peopletxt
            // 
            this.Peopletxt.Location = new System.Drawing.Point(12, 261);
            this.Peopletxt.Multiline = true;
            this.Peopletxt.Name = "Peopletxt";
            this.Peopletxt.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Peopletxt.Size = new System.Drawing.Size(135, 263);
            this.Peopletxt.TabIndex = 11;
            // 
            // Addresstxt
            // 
            this.Addresstxt.Location = new System.Drawing.Point(17, 116);
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(312, 21);
            this.Addresstxt.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "주소:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "보낼 사람들:";
            // 
            // ExBtn
            // 
            this.ExBtn.Location = new System.Drawing.Point(254, 207);
            this.ExBtn.Name = "ExBtn";
            this.ExBtn.Size = new System.Drawing.Size(75, 23);
            this.ExBtn.TabIndex = 15;
            this.ExBtn.Text = "회원 추출";
            this.ExBtn.UseVisualStyleBackColor = true;
            this.ExBtn.Click += new System.EventHandler(this.ExBtn_Click);
            // 
            // Extxt
            // 
            this.Extxt.Location = new System.Drawing.Point(184, 261);
            this.Extxt.Multiline = true;
            this.Extxt.Name = "Extxt";
            this.Extxt.Size = new System.Drawing.Size(128, 263);
            this.Extxt.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "제외할 사람들:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(564, 506);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 12);
            this.label8.TabIndex = 18;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // numtxt
            // 
            this.numtxt.Location = new System.Drawing.Point(17, 174);
            this.numtxt.Name = "numtxt";
            this.numtxt.Size = new System.Drawing.Size(130, 21);
            this.numtxt.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "글의 범위:(쪽 수)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 536);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Extxt);
            this.Controls.Add(this.ExBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Addresstxt);
            this.Controls.Add(this.Peopletxt);
            this.Controls.Add(this.ContentTxt);
            this.Controls.Add(this.Titletxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Startbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.idtxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button Startbtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Titletxt;
        private System.Windows.Forms.TextBox ContentTxt;
        private System.Windows.Forms.TextBox Peopletxt;
        private System.Windows.Forms.TextBox Addresstxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ExBtn;
        private System.Windows.Forms.TextBox Extxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox numtxt;
        private System.Windows.Forms.Label label9;
    }
}

