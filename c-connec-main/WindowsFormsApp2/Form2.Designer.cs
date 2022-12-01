
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
            this.textName = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            this.endDate = new System.Windows.Forms.TextBox();
            this.startDate = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.종류 = new System.Windows.Forms.Label();
            this.kind = new System.Windows.Forms.TextBox();
            this.비용 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.TextBox();
            this.locknum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(278, 28);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(126, 28);
            this.textName.TabIndex = 1;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(549, 28);
            this.textPhone.Margin = new System.Windows.Forms.Padding(4);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(126, 28);
            this.textPhone.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "전화번호";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 164);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "회원 추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(529, 164);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "회원 수정";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(706, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "종료일";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "등록일";
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(809, 96);
            this.text.Margin = new System.Windows.Forms.Padding(4);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(126, 28);
            this.text.TabIndex = 19;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(549, 96);
            this.endDate.Margin = new System.Windows.Forms.Padding(4);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(126, 28);
            this.endDate.TabIndex = 18;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(280, 96);
            this.startDate.Margin = new System.Windows.Forms.Padding(4);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(126, 28);
            this.startDate.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(825, 164);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 35);
            this.button4.TabIndex = 23;
            this.button4.Text = "회원 조회";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(684, 164);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "회원 삭제";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(100, 230);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersWidth = 62;
            this.DBGrid.RowTemplate.Height = 30;
            this.DBGrid.Size = new System.Drawing.Size(835, 273);
            this.DBGrid.TabIndex = 24;
            this.DBGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellContentClick);
            // 
            // 종류
            // 
            this.종류.AutoSize = true;
            this.종류.Location = new System.Drawing.Point(8, 31);
            this.종류.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.종류.Name = "종류";
            this.종류.Size = new System.Drawing.Size(44, 18);
            this.종류.TabIndex = 26;
            this.종류.Text = "종류";
            // 
            // kind
            // 
            this.kind.Location = new System.Drawing.Point(76, 28);
            this.kind.Margin = new System.Windows.Forms.Padding(4);
            this.kind.Name = "kind";
            this.kind.Size = new System.Drawing.Size(126, 28);
            this.kind.TabIndex = 25;
            // 
            // 비용
            // 
            this.비용.AutoSize = true;
            this.비용.Location = new System.Drawing.Point(8, 99);
            this.비용.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.비용.Name = "비용";
            this.비용.Size = new System.Drawing.Size(44, 18);
            this.비용.TabIndex = 28;
            this.비용.Text = "비용";
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(76, 96);
            this.cost.Margin = new System.Windows.Forms.Padding(4);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(126, 28);
            this.cost.TabIndex = 27;
            // 
            // locknum
            // 
            this.locknum.Location = new System.Drawing.Point(809, 31);
            this.locknum.Margin = new System.Windows.Forms.Padding(4);
            this.locknum.Name = "locknum";
            this.locknum.Size = new System.Drawing.Size(126, 28);
            this.locknum.TabIndex = 29;
            // 
            // member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 540);
            this.Controls.Add(this.locknum);
            this.Controls.Add(this.비용);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.종류);
            this.Controls.Add(this.kind);
            this.Controls.Add(this.DBGrid);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "member";
            this.Text = "회원관리";
            this.Load += new System.EventHandler(this.member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.TextBox endDate;
        private System.Windows.Forms.TextBox startDate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Label 종류;
        private System.Windows.Forms.TextBox kind;
        private System.Windows.Forms.Label 비용;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.TextBox locknum;
    }
}