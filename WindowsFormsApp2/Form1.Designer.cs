﻿
namespace WindowsFormsApp2
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
            this.button_member = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.부가기능ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메모장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.부가기능ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.나가기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_member
            // 
            this.button_member.BackColor = System.Drawing.Color.White;
            this.button_member.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_member.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button_member.Font = new System.Drawing.Font("휴먼엑스포", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_member.ForeColor = System.Drawing.Color.Gray;
            this.button_member.Location = new System.Drawing.Point(56, 187);
            this.button_member.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.button_member.Name = "button_member";
            this.button_member.Size = new System.Drawing.Size(164, 84);
            this.button_member.TabIndex = 1;
            this.button_member.Text = "회원 등록";
            this.button_member.UseVisualStyleBackColor = false;
            this.button_member.UseWaitCursor = true;
            this.button_member.Click += new System.EventHandler(this.button_member_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button2.Font = new System.Drawing.Font("휴먼엑스포", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(306, 187);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 84);
            this.button2.TabIndex = 3;
            this.button2.Text = "물품 관리";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button3.Font = new System.Drawing.Font("휴먼엑스포", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.Color.Gray;
            this.button3.Location = new System.Drawing.Point(56, 353);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 84);
            this.button3.TabIndex = 4;
            this.button3.Text = "매출 관리";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button4.Font = new System.Drawing.Font("휴먼엑스포", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.ForeColor = System.Drawing.Color.Gray;
            this.button4.Location = new System.Drawing.Point(306, 353);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 84);
            this.button4.TabIndex = 5;
            this.button4.Text = "통합 조회";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.UseWaitCursor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("함초롬돋움 확장", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(644, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 16);
            this.label14.TabIndex = 7;
            this.label14.Text = "영업 일자 : ";
            this.label14.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(50, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 73);
            this.label1.TabIndex = 9;
            this.label1.Text = "SYU GYM";
            this.label1.UseWaitCursor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(722, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            this.label2.UseWaitCursor = true;
            // 
            // 부가기능ToolStripMenuItem
            // 
            this.부가기능ToolStripMenuItem.Name = "부가기능ToolStripMenuItem";
            this.부가기능ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // 메모장ToolStripMenuItem
            // 
            this.메모장ToolStripMenuItem.Name = "메모장ToolStripMenuItem";
            this.메모장ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.부가기능ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(876, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // 부가기능ToolStripMenuItem1
            // 
            this.부가기능ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도움말ToolStripMenuItem1,
            this.나가기ToolStripMenuItem});
            this.부가기능ToolStripMenuItem1.Name = "부가기능ToolStripMenuItem1";
            this.부가기능ToolStripMenuItem1.Size = new System.Drawing.Size(67, 22);
            this.부가기능ToolStripMenuItem1.Text = "부가기능";
            // 
            // 도움말ToolStripMenuItem1
            // 
            this.도움말ToolStripMenuItem1.Name = "도움말ToolStripMenuItem1";
            this.도움말ToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.도움말ToolStripMenuItem1.Text = "도움말";
            this.도움말ToolStripMenuItem1.Click += new System.EventHandler(this.도움말ToolStripMenuItem1_Click);
            // 
            // 나가기ToolStripMenuItem
            // 
            this.나가기ToolStripMenuItem.Name = "나가기ToolStripMenuItem";
            this.나가기ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.나가기ToolStripMenuItem.Text = "나가기";
            this.나가기ToolStripMenuItem.Click += new System.EventHandler(this.나가기ToolStripMenuItem_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::윈프_과제_홀수반_김한영.Properties.Resources.ddddd;
            this.pictureBox1.Location = new System.Drawing.Point(558, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 272);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 548);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_member);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SYU GYM";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_member;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 부가기능ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메모장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 부가기능ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 나가기ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

