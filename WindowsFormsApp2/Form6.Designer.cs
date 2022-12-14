
namespace WindowsFormsApp2
{
    partial class Form6
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
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptdate = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.일정조회 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DBGrid4 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.findTrainer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DBGrid3 = new System.Windows.Forms.DataGridView();
            this.물품조회 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DBGrid2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.일정조회.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid3)).BeginInit();
            this.물품조회.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(347, 57);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 22);
            this.button4.TabIndex = 40;
            this.button4.Text = "검색";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 30;
            this.label3.Text = "예약 일자";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 28;
            this.label1.Text = "이름";
            // 
            // ptdate
            // 
            this.ptdate.Location = new System.Drawing.Point(228, 58);
            this.ptdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptdate.Name = "ptdate";
            this.ptdate.Size = new System.Drawing.Size(90, 21);
            this.ptdate.TabIndex = 27;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(70, 85);
            this.username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(90, 21);
            this.username.TabIndex = 25;
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(23, 89);
            this.DBGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersWidth = 51;
            this.DBGrid.RowTemplate.Height = 27;
            this.DBGrid.Size = new System.Drawing.Size(658, 124);
            this.DBGrid.TabIndex = 44;
            // 
            // 일정조회
            // 
            this.일정조회.Controls.Add(this.DBGrid);
            this.일정조회.Controls.Add(this.button4);
            this.일정조회.Controls.Add(this.ptdate);
            this.일정조회.Location = new System.Drawing.Point(12, 29);
            this.일정조회.Name = "일정조회";
            this.일정조회.Size = new System.Drawing.Size(709, 231);
            this.일정조회.TabIndex = 45;
            this.일정조회.TabStop = false;
            this.일정조회.Text = "일정조회";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DBGrid4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.findTrainer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DBGrid3);
            this.groupBox1.Location = new System.Drawing.Point(747, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 519);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "트레이너 소속 회원";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DBGrid4
            // 
            this.DBGrid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid4.Location = new System.Drawing.Point(27, 408);
            this.DBGrid4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DBGrid4.Name = "DBGrid4";
            this.DBGrid4.RowHeadersWidth = 51;
            this.DBGrid4.RowTemplate.Height = 27;
            this.DBGrid4.Size = new System.Drawing.Size(658, 95);
            this.DBGrid4.TabIndex = 49;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(230, 34);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 23);
            this.button5.TabIndex = 48;
            this.button5.Text = "검색";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // findTrainer
            // 
            this.findTrainer.Location = new System.Drawing.Point(101, 36);
            this.findTrainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findTrainer.Name = "findTrainer";
            this.findTrainer.Size = new System.Drawing.Size(90, 21);
            this.findTrainer.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 47;
            this.label5.Text = "트레이너명";
            // 
            // DBGrid3
            // 
            this.DBGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid3.Location = new System.Drawing.Point(27, 89);
            this.DBGrid3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DBGrid3.Name = "DBGrid3";
            this.DBGrid3.RowHeadersWidth = 51;
            this.DBGrid3.RowTemplate.Height = 27;
            this.DBGrid3.Size = new System.Drawing.Size(658, 286);
            this.DBGrid3.TabIndex = 44;
            this.DBGrid3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid3_CellContentClick);
            // 
            // 물품조회
            // 
            this.물품조회.Controls.Add(this.button1);
            this.물품조회.Controls.Add(this.DBGrid2);
            this.물품조회.Location = new System.Drawing.Point(12, 266);
            this.물품조회.Name = "물품조회";
            this.물품조회.Size = new System.Drawing.Size(709, 282);
            this.물품조회.TabIndex = 46;
            this.물품조회.TabStop = false;
            this.물품조회.Text = "물품재고";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 232);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 45;
            this.button1.Text = "재고 조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DBGrid2
            // 
            this.DBGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid2.Location = new System.Drawing.Point(23, 30);
            this.DBGrid2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DBGrid2.Name = "DBGrid2";
            this.DBGrid2.RowHeadersWidth = 51;
            this.DBGrid2.RowTemplate.Height = 27;
            this.DBGrid2.Size = new System.Drawing.Size(658, 186);
            this.DBGrid2.TabIndex = 44;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 606);
            this.Controls.Add(this.물품조회);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.일정조회);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form6";
            this.Text = "조회관리";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.일정조회.ResumeLayout(false);
            this.일정조회.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid3)).EndInit();
            this.물품조회.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ptdate;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.GroupBox 일정조회;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox findTrainer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DBGrid3;
        private System.Windows.Forms.DataGridView DBGrid4;
        private System.Windows.Forms.GroupBox 물품조회;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DBGrid2;
    }
}