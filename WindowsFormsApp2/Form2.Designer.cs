
namespace WindowsFormsApp2
{
    partial class member
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.username = new System.Windows.Forms.TextBox();
            this.userphone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.regtype = new System.Windows.Forms.TextBox();
            this.enddate = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.종류 = new System.Windows.Forms.Label();
            this.empnum = new System.Windows.Forms.TextBox();
            this.등록비 = new System.Windows.Forms.Label();
            this.regfee = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ptnum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ptdate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.regdate = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(75, 21);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(89, 21);
            this.username.TabIndex = 1;
            // 
            // userphone
            // 
            this.userphone.Location = new System.Drawing.Point(237, 23);
            this.userphone.Name = "userphone";
            this.userphone.Size = new System.Drawing.Size(89, 21);
            this.userphone.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "전화번호";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "회원 추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "회원 수정";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "등록 종류";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "종료일자";
            // 
            // regtype
            // 
            this.regtype.Location = new System.Drawing.Point(394, 60);
            this.regtype.Name = "regtype";
            this.regtype.Size = new System.Drawing.Size(89, 21);
            this.regtype.TabIndex = 18;
            // 
            // enddate
            // 
            this.enddate.Location = new System.Drawing.Point(574, 20);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(89, 21);
            this.enddate.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(728, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "전체 조회";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(195, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "회원 삭제";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(33, 175);
            this.DBGrid.Margin = new System.Windows.Forms.Padding(2);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersWidth = 62;
            this.DBGrid.RowTemplate.Height = 30;
            this.DBGrid.Size = new System.Drawing.Size(773, 221);
            this.DBGrid.TabIndex = 24;
            this.DBGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellClick);
            this.DBGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellContentClick);
            // 
            // 종류
            // 
            this.종류.AutoSize = true;
            this.종류.Location = new System.Drawing.Point(493, 66);
            this.종류.Name = "종류";
            this.종류.Size = new System.Drawing.Size(81, 12);
            this.종류.TabIndex = 26;
            this.종류.Text = "담당 트레이너";
            // 
            // empnum
            // 
            this.empnum.Location = new System.Drawing.Point(574, 62);
            this.empnum.Name = "empnum";
            this.empnum.Size = new System.Drawing.Size(89, 21);
            this.empnum.TabIndex = 25;
            // 
            // 등록비
            // 
            this.등록비.AutoSize = true;
            this.등록비.Location = new System.Drawing.Point(32, 69);
            this.등록비.Name = "등록비";
            this.등록비.Size = new System.Drawing.Size(41, 12);
            this.등록비.TabIndex = 28;
            this.등록비.Text = "등록비";
            // 
            // regfee
            // 
            this.regfee.Location = new System.Drawing.Point(75, 64);
            this.regfee.Name = "regfee";
            this.regfee.Size = new System.Drawing.Size(87, 21);
            this.regfee.TabIndex = 27;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(713, 409);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 23);
            this.button5.TabIndex = 31;
            this.button5.Text = "트레이너 관리";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(676, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 12);
            this.label7.TabIndex = 35;
            this.label7.Text = "등록 횟수";
            // 
            // ptnum
            // 
            this.ptnum.Location = new System.Drawing.Point(737, 20);
            this.ptnum.Name = "ptnum";
            this.ptnum.Size = new System.Drawing.Size(69, 21);
            this.ptnum.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 12);
            this.label8.TabIndex = 37;
            this.label8.Text = "PT예약일자";
            // 
            // ptdate
            // 
            this.ptdate.Location = new System.Drawing.Point(237, 61);
            this.ptdate.Name = "ptdate";
            this.ptdate.Size = new System.Drawing.Size(89, 21);
            this.ptdate.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 39;
            this.label9.Text = "등록일자";
            // 
            // regdate
            // 
            this.regdate.Location = new System.Drawing.Point(398, 23);
            this.regdate.Name = "regdate";
            this.regdate.Size = new System.Drawing.Size(85, 21);
            this.regdate.TabIndex = 38;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(732, 66);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 23);
            this.button6.TabIndex = 41;
            this.button6.Text = "검색";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 444);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.regdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ptdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ptnum);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.등록비);
            this.Controls.Add(this.regfee);
            this.Controls.Add(this.종류);
            this.Controls.Add(this.empnum);
            this.Controls.Add(this.DBGrid);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.regtype);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userphone);
            this.Controls.Add(this.username);
            this.Name = "member";
            this.Text = "등록관리";
            this.Load += new System.EventHandler(this.member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox userphone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox regtype;
        private System.Windows.Forms.TextBox enddate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Label 종류;
        private System.Windows.Forms.TextBox empnum;
        private System.Windows.Forms.Label 등록비;
        private System.Windows.Forms.TextBox regfee;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ptnum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ptdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox regdate;
        private System.Windows.Forms.Button button6;
    }
}