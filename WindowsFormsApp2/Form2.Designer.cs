
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
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(107, 32);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(125, 28);
            this.username.TabIndex = 1;
            // 
            // userphone
            // 
            this.userphone.Location = new System.Drawing.Point(339, 34);
            this.userphone.Margin = new System.Windows.Forms.Padding(4);
            this.userphone.Name = "userphone";
            this.userphone.Size = new System.Drawing.Size(125, 28);
            this.userphone.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "전화번호";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "회원 추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 202);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "회원 수정";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "등록 종류";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(743, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "종료일자";
            // 
            // regtype
            // 
            this.regtype.Location = new System.Drawing.Point(569, 90);
            this.regtype.Margin = new System.Windows.Forms.Padding(4);
            this.regtype.Name = "regtype";
            this.regtype.Size = new System.Drawing.Size(119, 28);
            this.regtype.TabIndex = 18;
            // 
            // enddate
            // 
            this.enddate.Location = new System.Drawing.Point(820, 30);
            this.enddate.Margin = new System.Windows.Forms.Padding(4);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(125, 28);
            this.enddate.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(941, 202);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 34);
            this.button4.TabIndex = 23;
            this.button4.Text = "전체 조회";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(279, 202);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 34);
            this.button3.TabIndex = 9;
            this.button3.Text = "회원 삭제";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(47, 262);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersWidth = 62;
            this.DBGrid.RowTemplate.Height = 30;
            this.DBGrid.Size = new System.Drawing.Size(1104, 332);
            this.DBGrid.TabIndex = 24;
            this.DBGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellClick);
            this.DBGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellContentClick);
            // 
            // 종류
            // 
            this.종류.AutoSize = true;
            this.종류.Location = new System.Drawing.Point(704, 99);
            this.종류.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.종류.Name = "종류";
            this.종류.Size = new System.Drawing.Size(122, 18);
            this.종류.TabIndex = 26;
            this.종류.Text = "담당 트레이너";
            // 
            // empnum
            // 
            this.empnum.Location = new System.Drawing.Point(820, 93);
            this.empnum.Margin = new System.Windows.Forms.Padding(4);
            this.empnum.Name = "empnum";
            this.empnum.Size = new System.Drawing.Size(125, 28);
            this.empnum.TabIndex = 25;
            // 
            // 등록비
            // 
            this.등록비.AutoSize = true;
            this.등록비.Location = new System.Drawing.Point(46, 104);
            this.등록비.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.등록비.Name = "등록비";
            this.등록비.Size = new System.Drawing.Size(62, 18);
            this.등록비.TabIndex = 28;
            this.등록비.Text = "등록비";
            // 
            // regfee
            // 
            this.regfee.Location = new System.Drawing.Point(107, 96);
            this.regfee.Margin = new System.Windows.Forms.Padding(4);
            this.regfee.Name = "regfee";
            this.regfee.Size = new System.Drawing.Size(123, 28);
            this.regfee.TabIndex = 27;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1019, 614);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 34);
            this.button5.TabIndex = 31;
            this.button5.Text = "트레이너 관리";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(966, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 35;
            this.label7.Text = "등록 횟수";
            // 
            // ptnum
            // 
            this.ptnum.Location = new System.Drawing.Point(1053, 30);
            this.ptnum.Margin = new System.Windows.Forms.Padding(4);
            this.ptnum.Name = "ptnum";
            this.ptnum.Size = new System.Drawing.Size(97, 28);
            this.ptnum.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 18);
            this.label8.TabIndex = 37;
            this.label8.Text = "PT예약일자";
            // 
            // ptdate
            // 
            this.ptdate.Location = new System.Drawing.Point(339, 92);
            this.ptdate.Margin = new System.Windows.Forms.Padding(4);
            this.ptdate.Name = "ptdate";
            this.ptdate.Size = new System.Drawing.Size(125, 28);
            this.ptdate.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(489, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 39;
            this.label9.Text = "등록일자";
            // 
            // regdate
            // 
            this.regdate.Location = new System.Drawing.Point(569, 34);
            this.regdate.Margin = new System.Windows.Forms.Padding(4);
            this.regdate.Name = "regdate";
            this.regdate.Size = new System.Drawing.Size(120, 28);
            this.regdate.TabIndex = 38;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(969, 94);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 34);
            this.button6.TabIndex = 41;
            this.button6.Text = "검색";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1053, 202);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 34);
            this.button7.TabIndex = 42;
            this.button7.Text = "초기화";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 666);
            this.Controls.Add(this.button7);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "회원관리";
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
        private System.Windows.Forms.Button button7;
    }
}