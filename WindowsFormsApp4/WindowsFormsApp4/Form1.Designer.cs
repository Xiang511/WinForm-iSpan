namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt訂購人 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl飲料單價 = new System.Windows.Forms.Label();
            this.lbl飲料單品總價 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listBox飲料品項 = new System.Windows.Forms.ListBox();
            this.txt杯數 = new System.Windows.Forms.TextBox();
            this.btn加一杯 = new System.Windows.Forms.Button();
            this.btn減一杯 = new System.Windows.Forms.Button();
            this.combo甜度 = new System.Windows.Forms.ComboBox();
            this.combo冰塊 = new System.Windows.Forms.ComboBox();
            this.combo加料 = new System.Windows.Forms.ComboBox();
            this.btn加入購物車 = new System.Windows.Forms.Button();
            this.chk外帶 = new System.Windows.Forms.CheckBox();
            this.chk買購物袋 = new System.Windows.Forms.CheckBox();
            this.lbl購物車品項數量 = new System.Windows.Forms.Label();
            this.btn購物車結帳 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "訂購人";
            // 
            // txt訂購人
            // 
            this.txt訂購人.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt訂購人.Location = new System.Drawing.Point(117, 9);
            this.txt訂購人.Name = "txt訂購人";
            this.txt訂購人.Size = new System.Drawing.Size(252, 43);
            this.txt訂購人.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(12, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1028, 623);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.btn加入購物車);
            this.tabPage1.Controls.Add(this.combo加料);
            this.tabPage1.Controls.Add(this.combo冰塊);
            this.tabPage1.Controls.Add(this.combo甜度);
            this.tabPage1.Controls.Add(this.btn減一杯);
            this.tabPage1.Controls.Add(this.btn加一杯);
            this.tabPage1.Controls.Add(this.txt杯數);
            this.tabPage1.Controls.Add(this.listBox飲料品項);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.lbl飲料單品總價);
            this.tabPage1.Controls.Add(this.lbl飲料單價);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 47);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1020, 572);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "飲料";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 47);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1020, 572);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "點心";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 47);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1020, 572);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "小物";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage4.Location = new System.Drawing.Point(4, 47);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1020, 572);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "其他";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "飲料品項";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "數量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 38);
            this.label4.TabIndex = 2;
            this.label4.Text = "杯";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 38);
            this.label5.TabIndex = 3;
            this.label5.Text = "單價";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(739, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 38);
            this.label6.TabIndex = 4;
            this.label6.Text = "單品總價";
            // 
            // lbl飲料單價
            // 
            this.lbl飲料單價.AutoSize = true;
            this.lbl飲料單價.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl飲料單價.Location = new System.Drawing.Point(454, 438);
            this.lbl飲料單價.Name = "lbl飲料單價";
            this.lbl飲料單價.Size = new System.Drawing.Size(98, 38);
            this.lbl飲料單價.TabIndex = 5;
            this.lbl飲料單價.Text = "000元";
            // 
            // lbl飲料單品總價
            // 
            this.lbl飲料單品總價.AutoSize = true;
            this.lbl飲料單品總價.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl飲料單品總價.Location = new System.Drawing.Point(744, 438);
            this.lbl飲料單品總價.Name = "lbl飲料單品總價";
            this.lbl飲料單品總價.Size = new System.Drawing.Size(132, 38);
            this.lbl飲料單品總價.TabIndex = 6;
            this.lbl飲料單品總價.Text = "00000元";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(626, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 38);
            this.label9.TabIndex = 7;
            this.label9.Text = "甜度";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(626, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 38);
            this.label10.TabIndex = 8;
            this.label10.Text = "冰塊";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(626, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 38);
            this.label11.TabIndex = 9;
            this.label11.Text = "加料";
            // 
            // listBox飲料品項
            // 
            this.listBox飲料品項.FormattingEnabled = true;
            this.listBox飲料品項.ItemHeight = 38;
            this.listBox飲料品項.Location = new System.Drawing.Point(26, 64);
            this.listBox飲料品項.Name = "listBox飲料品項";
            this.listBox飲料品項.Size = new System.Drawing.Size(562, 308);
            this.listBox飲料品項.TabIndex = 10;
            this.listBox飲料品項.SelectedIndexChanged += new System.EventHandler(this.listBox飲料品項_SelectedIndexChanged);
            // 
            // txt杯數
            // 
            this.txt杯數.Location = new System.Drawing.Point(72, 429);
            this.txt杯數.Name = "txt杯數";
            this.txt杯數.Size = new System.Drawing.Size(133, 47);
            this.txt杯數.TabIndex = 11;
            this.txt杯數.TextChanged += new System.EventHandler(this.txt杯數_TextChanged);
            // 
            // btn加一杯
            // 
            this.btn加一杯.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加一杯.Location = new System.Drawing.Point(72, 482);
            this.btn加一杯.Name = "btn加一杯";
            this.btn加一杯.Size = new System.Drawing.Size(60, 52);
            this.btn加一杯.TabIndex = 12;
            this.btn加一杯.Text = "+";
            this.btn加一杯.UseVisualStyleBackColor = true;
            this.btn加一杯.Click += new System.EventHandler(this.btn加一杯_Click);
            // 
            // btn減一杯
            // 
            this.btn減一杯.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn減一杯.Location = new System.Drawing.Point(147, 482);
            this.btn減一杯.Name = "btn減一杯";
            this.btn減一杯.Size = new System.Drawing.Size(60, 52);
            this.btn減一杯.TabIndex = 13;
            this.btn減一杯.Text = "-";
            this.btn減一杯.UseVisualStyleBackColor = true;
            this.btn減一杯.Click += new System.EventHandler(this.btn減一杯_Click);
            // 
            // combo甜度
            // 
            this.combo甜度.FormattingEnabled = true;
            this.combo甜度.Location = new System.Drawing.Point(724, 64);
            this.combo甜度.Name = "combo甜度";
            this.combo甜度.Size = new System.Drawing.Size(269, 46);
            this.combo甜度.TabIndex = 14;
            this.combo甜度.SelectedIndexChanged += new System.EventHandler(this.combo甜度_SelectedIndexChanged);
            // 
            // combo冰塊
            // 
            this.combo冰塊.FormattingEnabled = true;
            this.combo冰塊.Location = new System.Drawing.Point(724, 153);
            this.combo冰塊.Name = "combo冰塊";
            this.combo冰塊.Size = new System.Drawing.Size(269, 46);
            this.combo冰塊.TabIndex = 15;
            this.combo冰塊.SelectedIndexChanged += new System.EventHandler(this.combo冰塊_SelectedIndexChanged);
            // 
            // combo加料
            // 
            this.combo加料.FormattingEnabled = true;
            this.combo加料.Location = new System.Drawing.Point(724, 247);
            this.combo加料.Name = "combo加料";
            this.combo加料.Size = new System.Drawing.Size(269, 46);
            this.combo加料.TabIndex = 16;
            this.combo加料.SelectedIndexChanged += new System.EventHandler(this.combo加料_SelectedIndexChanged);
            // 
            // btn加入購物車
            // 
            this.btn加入購物車.BackColor = System.Drawing.Color.White;
            this.btn加入購物車.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入購物車.ForeColor = System.Drawing.Color.Blue;
            this.btn加入購物車.Location = new System.Drawing.Point(746, 492);
            this.btn加入購物車.Name = "btn加入購物車";
            this.btn加入購物車.Size = new System.Drawing.Size(230, 62);
            this.btn加入購物車.TabIndex = 17;
            this.btn加入購物車.Text = "加入購物車";
            this.btn加入購物車.UseVisualStyleBackColor = false;
            this.btn加入購物車.Click += new System.EventHandler(this.btn加入購物車_Click);
            // 
            // chk外帶
            // 
            this.chk外帶.AutoSize = true;
            this.chk外帶.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk外帶.Location = new System.Drawing.Point(436, 19);
            this.chk外帶.Name = "chk外帶";
            this.chk外帶.Size = new System.Drawing.Size(81, 33);
            this.chk外帶.TabIndex = 3;
            this.chk外帶.Text = "外帶";
            this.chk外帶.UseVisualStyleBackColor = true;
            this.chk外帶.CheckedChanged += new System.EventHandler(this.chk外帶_CheckedChanged);
            // 
            // chk買購物袋
            // 
            this.chk買購物袋.AutoSize = true;
            this.chk買購物袋.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk買購物袋.Location = new System.Drawing.Point(523, 19);
            this.chk買購物袋.Name = "chk買購物袋";
            this.chk買購物袋.Size = new System.Drawing.Size(177, 33);
            this.chk買購物袋.TabIndex = 4;
            this.chk買購物袋.Text = "買購物袋(3元)";
            this.chk買購物袋.UseVisualStyleBackColor = true;
            this.chk買購物袋.CheckedChanged += new System.EventHandler(this.chk買購物袋_CheckedChanged);
            // 
            // lbl購物車品項數量
            // 
            this.lbl購物車品項數量.AutoSize = true;
            this.lbl購物車品項數量.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl購物車品項數量.Location = new System.Drawing.Point(731, 38);
            this.lbl購物車品項數量.Name = "lbl購物車品項數量";
            this.lbl購物車品項數量.Size = new System.Drawing.Size(93, 50);
            this.lbl購物車品項數量.TabIndex = 5;
            this.lbl購物車品項數量.Text = "🛒5";
            // 
            // btn購物車結帳
            // 
            this.btn購物車結帳.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn購物車結帳.ForeColor = System.Drawing.Color.Green;
            this.btn購物車結帳.Location = new System.Drawing.Point(835, 23);
            this.btn購物車結帳.Name = "btn購物車結帳";
            this.btn購物車結帳.Size = new System.Drawing.Size(187, 65);
            this.btn購物車結帳.TabIndex = 6;
            this.btn購物車結帳.Text = "購物車結帳";
            this.btn購物車結帳.UseVisualStyleBackColor = true;
            this.btn購物車結帳.Click += new System.EventHandler(this.btn購物車結帳_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1052, 711);
            this.Controls.Add(this.btn購物車結帳);
            this.Controls.Add(this.lbl購物車品項數量);
            this.Controls.Add(this.chk買購物袋);
            this.Controls.Add(this.chk外帶);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txt訂購人);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "喝到飽飲料訂購單";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt訂購人;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl飲料單品總價;
        private System.Windows.Forms.Label lbl飲料單價;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo加料;
        private System.Windows.Forms.ComboBox combo冰塊;
        private System.Windows.Forms.ComboBox combo甜度;
        private System.Windows.Forms.Button btn減一杯;
        private System.Windows.Forms.Button btn加一杯;
        private System.Windows.Forms.TextBox txt杯數;
        private System.Windows.Forms.ListBox listBox飲料品項;
        private System.Windows.Forms.Button btn加入購物車;
        private System.Windows.Forms.CheckBox chk外帶;
        private System.Windows.Forms.CheckBox chk買購物袋;
        private System.Windows.Forms.Label lbl購物車品項數量;
        private System.Windows.Forms.Button btn購物車結帳;
    }
}

