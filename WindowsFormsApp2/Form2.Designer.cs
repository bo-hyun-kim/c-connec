
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
            this.startDate = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.종류 = new System.Windows.Forms.Label();
            this.kind = new System.Windows.Forms.TextBox();
            this.등록비 = new System.Windows.Forms.Label();
            this.regfee = new System.Windows.Forms.TextBox();
            this.lockernum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(195, 19);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(89, 21);
            this.username.TabIndex = 1;
            // 
            // userphone
            // 
            this.userphone.Location = new System.Drawing.Point(384, 19);
            this.userphone.Name = "userphone";
            this.userphone.Size = new System.Drawing.Size(89, 21);
            this.userphone.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "전화번호";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "회원 추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "회원 수정";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "등록 종류";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "등록일";
            // 
            // regtype
            // 
            this.regtype.Location = new System.Drawing.Point(384, 64);
            this.regtype.Name = "regtype";
            this.regtype.Size = new System.Drawing.Size(89, 21);
            this.regtype.TabIndex = 18;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(196, 64);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(89, 21);
            this.startDate.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(578, 109);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "회원 조회";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(479, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "회원 삭제";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(13, 147);
            this.DBGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersWidth = 62;
            this.DBGrid.RowTemplate.Height = 30;
            this.DBGrid.Size = new System.Drawing.Size(643, 182);
            this.DBGrid.TabIndex = 24;
            this.DBGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellContentClick);
            // 
            // 종류
            // 
            this.종류.AutoSize = true;
            this.종류.Location = new System.Drawing.Point(6, 21);
            this.종류.Name = "종류";
            this.종류.Size = new System.Drawing.Size(29, 12);
            this.종류.TabIndex = 26;
            this.종류.Text = "종류";
            // 
            // kind
            // 
            this.kind.Location = new System.Drawing.Point(53, 19);
            this.kind.Name = "kind";
            this.kind.Size = new System.Drawing.Size(89, 21);
            this.kind.TabIndex = 25;
            // 
            // 등록비
            // 
            this.등록비.AutoSize = true;
            this.등록비.Location = new System.Drawing.Point(6, 66);
            this.등록비.Name = "등록비";
            this.등록비.Size = new System.Drawing.Size(41, 12);
            this.등록비.TabIndex = 28;
            this.등록비.Text = "등록비";
            // 
            // regfee
            // 
            this.regfee.Location = new System.Drawing.Point(53, 64);
            this.regfee.Name = "regfee";
            this.regfee.Size = new System.Drawing.Size(89, 21);
            this.regfee.TabIndex = 27;
            // 
            // lockernum
            // 
            this.lockernum.Location = new System.Drawing.Point(566, 21);
            this.lockernum.Name = "lockernum";
            this.lockernum.Size = new System.Drawing.Size(89, 21);
            this.lockernum.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 30;
            this.label2.Text = "사물함 번호";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 109);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 23);
            this.button5.TabIndex = 31;
            this.button5.Text = "트레이너 관리";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lockernum);
            this.Controls.Add(this.등록비);
            this.Controls.Add(this.regfee);
            this.Controls.Add(this.종류);
            this.Controls.Add(this.kind);
            this.Controls.Add(this.DBGrid);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.regtype);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userphone);
            this.Controls.Add(this.username);
            this.Name = "member";
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
        private System.Windows.Forms.TextBox startDate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Label 종류;
        private System.Windows.Forms.TextBox kind;
        private System.Windows.Forms.Label 등록비;
        private System.Windows.Forms.TextBox regfee;
        private System.Windows.Forms.TextBox lockernum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
    }
}