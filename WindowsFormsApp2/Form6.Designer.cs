
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
            this.ptdate = new System.Windows.Forms.TextBox();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.일정조회 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.button4.Location = new System.Drawing.Point(269, 36);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 33);
            this.button4.TabIndex = 40;
            this.button4.Text = "검색";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F);
            this.label3.Location = new System.Drawing.Point(30, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "예약 일자";
            // 
            // ptdate
            // 
            this.ptdate.Location = new System.Drawing.Point(124, 36);
            this.ptdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ptdate.Name = "ptdate";
            this.ptdate.Size = new System.Drawing.Size(127, 28);
            this.ptdate.TabIndex = 27;
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(33, 75);
            this.DBGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersWidth = 51;
            this.DBGrid.RowTemplate.Height = 27;
            this.DBGrid.Size = new System.Drawing.Size(805, 254);
            this.DBGrid.TabIndex = 44;
            // 
            // 일정조회
            // 
            this.일정조회.Controls.Add(this.DBGrid);
            this.일정조회.Controls.Add(this.button4);
            this.일정조회.Controls.Add(this.label3);
            this.일정조회.Controls.Add(this.ptdate);
            this.일정조회.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.일정조회.Location = new System.Drawing.Point(17, 44);
            this.일정조회.Margin = new System.Windows.Forms.Padding(4);
            this.일정조회.Name = "일정조회";
            this.일정조회.Padding = new System.Windows.Forms.Padding(4);
            this.일정조회.Size = new System.Drawing.Size(864, 347);
            this.일정조회.TabIndex = 45;
            this.일정조회.TabStop = false;
            this.일정조회.Text = "일정조회";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DBGrid4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.findTrainer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DBGrid3);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(889, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(896, 742);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "트레이너 소속 회원";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F);
            this.label4.Location = new System.Drawing.Point(36, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "담당 회원 리스트";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F);
            this.label2.Location = new System.Drawing.Point(36, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "회원 상세정보";
            // 
            // DBGrid4
            // 
            this.DBGrid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid4.Location = new System.Drawing.Point(39, 519);
            this.DBGrid4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DBGrid4.Name = "DBGrid4";
            this.DBGrid4.RowHeadersWidth = 51;
            this.DBGrid4.RowTemplate.Height = 27;
            this.DBGrid4.Size = new System.Drawing.Size(835, 142);
            this.DBGrid4.TabIndex = 49;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(329, 51);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 34);
            this.button5.TabIndex = 48;
            this.button5.Text = "검색";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // findTrainer
            // 
            this.findTrainer.Location = new System.Drawing.Point(144, 54);
            this.findTrainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.findTrainer.Name = "findTrainer";
            this.findTrainer.Size = new System.Drawing.Size(127, 28);
            this.findTrainer.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "트레이너명";
            // 
            // DBGrid3
            // 
            this.DBGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid3.Location = new System.Drawing.Point(39, 134);
            this.DBGrid3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DBGrid3.Name = "DBGrid3";
            this.DBGrid3.RowHeadersWidth = 51;
            this.DBGrid3.RowTemplate.Height = 27;
            this.DBGrid3.Size = new System.Drawing.Size(835, 321);
            this.DBGrid3.TabIndex = 44;
            this.DBGrid3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid3_CellContentClick);
            // 
            // 물품조회
            // 
            this.물품조회.Controls.Add(this.button1);
            this.물품조회.Controls.Add(this.DBGrid2);
            this.물품조회.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.물품조회.Location = new System.Drawing.Point(17, 399);
            this.물품조회.Margin = new System.Windows.Forms.Padding(4);
            this.물품조회.Name = "물품조회";
            this.물품조회.Padding = new System.Windows.Forms.Padding(4);
            this.물품조회.Size = new System.Drawing.Size(864, 387);
            this.물품조회.TabIndex = 46;
            this.물품조회.TabStop = false;
            this.물품조회.Text = "물품재고";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 51);
            this.button1.TabIndex = 45;
            this.button1.Text = "재고 조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DBGrid2
            // 
            this.DBGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid2.Location = new System.Drawing.Point(33, 45);
            this.DBGrid2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DBGrid2.Name = "DBGrid2";
            this.DBGrid2.RowHeadersWidth = 51;
            this.DBGrid2.RowTemplate.Height = 27;
            this.DBGrid2.Size = new System.Drawing.Size(805, 261);
            this.DBGrid2.TabIndex = 44;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1803, 805);
            this.Controls.Add(this.물품조회);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.일정조회);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "통합조회";
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

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ptdate;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}