
namespace WindowsFormsApp2
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SalesGridView = new System.Windows.Forms.DataGridView();
            this.날짜 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.등록매출 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.물품매출 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.당일누적매출 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "매출 조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "검색날짜";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 62);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 25);
            this.textBox1.TabIndex = 5;
            // 
            // SalesGridView
            // 
            this.SalesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.날짜,
            this.등록매출,
            this.물품매출,
            this.당일누적매출});
            this.SalesGridView.Location = new System.Drawing.Point(42, 146);
            this.SalesGridView.Name = "SalesGridView";
            this.SalesGridView.RowHeadersWidth = 51;
            this.SalesGridView.RowTemplate.Height = 27;
            this.SalesGridView.Size = new System.Drawing.Size(554, 229);
            this.SalesGridView.TabIndex = 22;
            this.SalesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesGridView_CellContentClick);
            // 
            // 날짜
            // 
            this.날짜.HeaderText = "날짜";
            this.날짜.MinimumWidth = 6;
            this.날짜.Name = "날짜";
            this.날짜.Width = 125;
            // 
            // 등록매출
            // 
            this.등록매출.HeaderText = "등록매출";
            this.등록매출.MinimumWidth = 6;
            this.등록매출.Name = "등록매출";
            this.등록매출.Width = 125;
            // 
            // 물품매출
            // 
            this.물품매출.HeaderText = "물품매출";
            this.물품매출.MinimumWidth = 6;
            this.물품매출.Name = "물품매출";
            this.물품매출.Width = 125;
            // 
            // 당일누적매출
            // 
            this.당일누적매출.HeaderText = "당일누적매출";
            this.당일누적매출.MinimumWidth = 6;
            this.당일누적매출.Name = "당일누적매출";
            this.당일누적매출.Width = 125;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalesGridView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "매출관리";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView SalesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 날짜;
        private System.Windows.Forms.DataGridViewTextBoxColumn 등록매출;
        private System.Windows.Forms.DataGridViewTextBoxColumn 물품매출;
        private System.Windows.Forms.DataGridViewTextBoxColumn 당일누적매출;
    }
}