namespace SimpleOrderSys
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
            this.LblOrderCount = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPlus = new System.Windows.Forms.ComboBox();
            this.comboBoxIce = new System.Windows.Forms.ComboBox();
            this.comboBoxSugar = new System.Windows.Forms.ComboBox();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblTotalPrice = new System.Windows.Forms.Label();
            this.Lbl8 = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMine = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.txtDrinkCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.chkTakeout = new System.Windows.Forms.CheckBox();
            this.chkBuyBag = new System.Windows.Forms.CheckBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "訂購人";
            // 
            // LblOrderCount
            // 
            this.LblOrderCount.AutoSize = true;
            this.LblOrderCount.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblOrderCount.Location = new System.Drawing.Point(587, 40);
            this.LblOrderCount.Name = "LblOrderCount";
            this.LblOrderCount.Size = new System.Drawing.Size(44, 24);
            this.LblOrderCount.TabIndex = 1;
            this.LblOrderCount.Text = "🚩5";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(14, 102);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 455);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBoxPlus);
            this.tabPage1.Controls.Add(this.comboBoxIce);
            this.tabPage1.Controls.Add(this.comboBoxSugar);
            this.tabPage1.Controls.Add(this.btnAddtoCart);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.LblTotalPrice);
            this.tabPage1.Controls.Add(this.Lbl8);
            this.tabPage1.Controls.Add(this.LblPrice);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnMine);
            this.tabPage1.Controls.Add(this.btnPlus);
            this.tabPage1.Controls.Add(this.txtDrinkCount);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(755, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "飲料";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "杯";
            // 
            // comboBoxPlus
            // 
            this.comboBoxPlus.FormattingEnabled = true;
            this.comboBoxPlus.Location = new System.Drawing.Point(573, 237);
            this.comboBoxPlus.Name = "comboBoxPlus";
            this.comboBoxPlus.Size = new System.Drawing.Size(121, 20);
            this.comboBoxPlus.TabIndex = 20;
            this.comboBoxPlus.TextChanged += new System.EventHandler(this.comboBoxPlus_TextChanged);
            // 
            // comboBoxIce
            // 
            this.comboBoxIce.FormattingEnabled = true;
            this.comboBoxIce.Location = new System.Drawing.Point(573, 147);
            this.comboBoxIce.Name = "comboBoxIce";
            this.comboBoxIce.Size = new System.Drawing.Size(121, 20);
            this.comboBoxIce.TabIndex = 19;
            // 
            // comboBoxSugar
            // 
            this.comboBoxSugar.FormattingEnabled = true;
            this.comboBoxSugar.Location = new System.Drawing.Point(573, 72);
            this.comboBoxSugar.Name = "comboBoxSugar";
            this.comboBoxSugar.Size = new System.Drawing.Size(121, 20);
            this.comboBoxSugar.TabIndex = 18;
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.Location = new System.Drawing.Point(635, 381);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddtoCart.TabIndex = 17;
            this.btnAddtoCart.Text = "加入購物車";
            this.btnAddtoCart.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(500, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 16;
            this.label12.Text = "加料";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(500, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 15;
            this.label11.Text = "冰塊";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(500, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "甜度";
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.AutoSize = true;
            this.LblTotalPrice.Location = new System.Drawing.Point(533, 357);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(35, 12);
            this.LblTotalPrice.TabIndex = 12;
            this.LblTotalPrice.Text = "000元";
            // 
            // Lbl8
            // 
            this.Lbl8.AutoSize = true;
            this.Lbl8.Location = new System.Drawing.Point(533, 321);
            this.Lbl8.Name = "Lbl8";
            this.Lbl8.Size = new System.Drawing.Size(53, 12);
            this.Lbl8.TabIndex = 11;
            this.Lbl8.Text = "單品總價";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Location = new System.Drawing.Point(280, 357);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(35, 12);
            this.LblPrice.TabIndex = 10;
            this.LblPrice.Text = "000元";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "單價";
            // 
            // btnMine
            // 
            this.btnMine.Location = new System.Drawing.Point(111, 394);
            this.btnMine.Name = "btnMine";
            this.btnMine.Size = new System.Drawing.Size(75, 23);
            this.btnMine.TabIndex = 8;
            this.btnMine.Text = "-";
            this.btnMine.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(23, 394);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 7;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // txtDrinkCount
            // 
            this.txtDrinkCount.Location = new System.Drawing.Point(23, 347);
            this.txtDrinkCount.Name = "txtDrinkCount";
            this.txtDrinkCount.Size = new System.Drawing.Size(100, 22);
            this.txtDrinkCount.TabIndex = 6;
            this.txtDrinkCount.TextChanged += new System.EventHandler(this.txtDrinkCount_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "數量";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(23, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(422, 236);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "飲料品項";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(755, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "點心";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(755, 429);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "小物";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(755, 429);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "其他";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUserName.Location = new System.Drawing.Point(104, 28);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 36);
            this.txtUserName.TabIndex = 21;
            // 
            // chkTakeout
            // 
            this.chkTakeout.AutoSize = true;
            this.chkTakeout.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkTakeout.Location = new System.Drawing.Point(300, 34);
            this.chkTakeout.Name = "chkTakeout";
            this.chkTakeout.Size = new System.Drawing.Size(77, 28);
            this.chkTakeout.TabIndex = 22;
            this.chkTakeout.Text = "外帶";
            this.chkTakeout.UseVisualStyleBackColor = true;
            // 
            // chkBuyBag
            // 
            this.chkBuyBag.AutoSize = true;
            this.chkBuyBag.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkBuyBag.Location = new System.Drawing.Point(381, 36);
            this.chkBuyBag.Name = "chkBuyBag";
            this.chkBuyBag.Size = new System.Drawing.Size(195, 28);
            this.chkBuyBag.TabIndex = 23;
            this.chkBuyBag.Text = "買購物袋(+3元 )";
            this.chkBuyBag.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(676, 41);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(75, 23);
            this.btnCheckout.TabIndex = 21;
            this.btnCheckout.Text = "結帳";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 569);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.chkBuyBag);
            this.Controls.Add(this.chkTakeout);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LblOrderCount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblOrderCount;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label Lbl8;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMine;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TextBox txtDrinkCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox comboBoxPlus;
        private System.Windows.Forms.ComboBox comboBoxIce;
        private System.Windows.Forms.ComboBox comboBoxSugar;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblTotalPrice;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.CheckBox chkTakeout;
        private System.Windows.Forms.CheckBox chkBuyBag;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label label2;
    }
}

