namespace 윈프_과제_홀수반_김한영
{
    partial class Form8
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
            this.비용 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.TextBox();
            this.종류 = new System.Windows.Forms.Label();
            this.kind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // 비용
            // 
            this.비용.AutoSize = true;
            this.비용.Location = new System.Drawing.Point(207, 60);
            this.비용.Name = "비용";
            this.비용.Size = new System.Drawing.Size(29, 12);
            this.비용.TabIndex = 32;
            this.비용.Text = "주소";
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(242, 55);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(89, 21);
            this.cost.TabIndex = 31;
            // 
            // 종류
            // 
            this.종류.AutoSize = true;
            this.종류.Location = new System.Drawing.Point(53, 59);
            this.종류.Name = "종류";
            this.종류.Size = new System.Drawing.Size(41, 12);
            this.종류.TabIndex = 30;
            this.종류.Text = "직원명";
            // 
            // kind
            // 
            this.kind.Location = new System.Drawing.Point(100, 57);
            this.kind.Name = "kind";
            this.kind.Size = new System.Drawing.Size(89, 21);
            this.kind.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 34;
            this.label1.Text = "이메일";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(397, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 21);
            this.textBox1.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(667, 227);
            this.dataGridView1.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "추가";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(445, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "수정";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(540, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 23);
            this.button3.TabIndex = 38;
            this.button3.Text = "삭제";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(635, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 23);
            this.button4.TabIndex = 39;
            this.button4.Text = "조회";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.비용);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.종류);
            this.Controls.Add(this.kind);
            this.Name = "Form8";
            this.Text = "트레이너 관리";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 비용;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.Label 종류;
        private System.Windows.Forms.TextBox kind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}