
namespace WindowsFormsApp2
{
    partial class Form5
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
            this.btnSell = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.PrdGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_prddate = new System.Windows.Forms.TextBox();
            this.textBox_prdcnt = new System.Windows.Forms.TextBox();
            this.textBox_prdcost = new System.Windows.Forms.TextBox();
            this.textBox_prdname = new System.Windows.Forms.TextBox();
            this.btnData = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PrdGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(455, 464);
            this.btnSell.Margin = new System.Windows.Forms.Padding(4);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(114, 37);
            this.btnSell.TabIndex = 19;
            this.btnSell.Text = "물품 판매";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(319, 462);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 39);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "물품 폐기";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(184, 464);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 38);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "물품 추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrdGridView
            // 
            this.PrdGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrdGridView.Location = new System.Drawing.Point(37, 62);
            this.PrdGridView.Name = "PrdGridView";
            this.PrdGridView.RowHeadersWidth = 62;
            this.PrdGridView.RowTemplate.Height = 30;
            this.PrdGridView.Size = new System.Drawing.Size(931, 289);
            this.PrdGridView.TabIndex = 20;
            this.PrdGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrdGridView_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(647, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 34;
            this.label7.Text = "처리날짜";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "물품가격";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "물품명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "물품수량";
            // 
            // textBox_prddate
            // 
            this.textBox_prddate.Location = new System.Drawing.Point(744, 397);
            this.textBox_prddate.Name = "textBox_prddate";
            this.textBox_prddate.Size = new System.Drawing.Size(94, 28);
            this.textBox_prddate.TabIndex = 27;
            // 
            // textBox_prdcnt
            // 
            this.textBox_prdcnt.Location = new System.Drawing.Point(332, 397);
            this.textBox_prdcnt.Name = "textBox_prdcnt";
            this.textBox_prdcnt.Size = new System.Drawing.Size(94, 28);
            this.textBox_prdcnt.TabIndex = 23;
            // 
            // textBox_prdcost
            // 
            this.textBox_prdcost.Location = new System.Drawing.Point(538, 397);
            this.textBox_prdcost.Name = "textBox_prdcost";
            this.textBox_prdcost.Size = new System.Drawing.Size(94, 28);
            this.textBox_prdcost.TabIndex = 22;
            // 
            // textBox_prdname
            // 
            this.textBox_prdname.Location = new System.Drawing.Point(129, 400);
            this.textBox_prdname.Name = "textBox_prdname";
            this.textBox_prdname.Size = new System.Drawing.Size(94, 28);
            this.textBox_prdname.TabIndex = 21;
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(590, 464);
            this.btnData.Margin = new System.Windows.Forms.Padding(4);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(112, 37);
            this.btnData.TabIndex = 35;
            this.btnData.Text = "내역 삭제";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(726, 471);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 28);
            this.textBox1.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 464);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 37;
            this.button1.Text = "내역 조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_prddate);
            this.Controls.Add(this.textBox_prdcnt);
            this.Controls.Add(this.textBox_prdcost);
            this.Controls.Add(this.textBox_prdname);
            this.Controls.Add(this.PrdGridView);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "물품관리";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrdGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView PrdGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_prddate;
        private System.Windows.Forms.TextBox textBox_prdcnt;
        private System.Windows.Forms.TextBox textBox_prdcost;
        private System.Windows.Forms.TextBox textBox_prdname;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}