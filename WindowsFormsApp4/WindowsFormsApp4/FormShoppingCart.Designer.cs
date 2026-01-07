namespace WindowsFormsApp4
{
    partial class FormShoppingCart
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl訂購人資訊 = new System.Windows.Forms.Label();
            this.listBox訂購品項 = new System.Windows.Forms.ListBox();
            this.lbl外帶 = new System.Windows.Forms.Label();
            this.lbl買購物袋 = new System.Windows.Forms.Label();
            this.lbl訂單總價 = new System.Windows.Forms.Label();
            this.btn移除所選品項 = new System.Windows.Forms.Button();
            this.btn刪除所有品項 = new System.Windows.Forms.Button();
            this.btn輸出訂購單TXT結帳 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(234, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "🛒購物車 - 訂購品項列表🛒";
            // 
            // lbl訂購人資訊
            // 
            this.lbl訂購人資訊.AutoSize = true;
            this.lbl訂購人資訊.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購人資訊.Location = new System.Drawing.Point(12, 71);
            this.lbl訂購人資訊.Name = "lbl訂購人資訊";
            this.lbl訂購人資訊.Size = new System.Drawing.Size(167, 38);
            this.lbl訂購人資訊.TabIndex = 1;
            this.lbl訂購人資訊.Text = "訂購人資訊";
            // 
            // listBox訂購品項
            // 
            this.listBox訂購品項.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox訂購品項.FormattingEnabled = true;
            this.listBox訂購品項.ItemHeight = 38;
            this.listBox訂購品項.Location = new System.Drawing.Point(19, 113);
            this.listBox訂購品項.Name = "listBox訂購品項";
            this.listBox訂購品項.Size = new System.Drawing.Size(857, 384);
            this.listBox訂購品項.TabIndex = 2;
            // 
            // lbl外帶
            // 
            this.lbl外帶.AutoSize = true;
            this.lbl外帶.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl外帶.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl外帶.Location = new System.Drawing.Point(276, 514);
            this.lbl外帶.Name = "lbl外帶";
            this.lbl外帶.Size = new System.Drawing.Size(77, 38);
            this.lbl外帶.TabIndex = 3;
            this.lbl外帶.Text = "外帶";
            // 
            // lbl買購物袋
            // 
            this.lbl買購物袋.AutoSize = true;
            this.lbl買購物袋.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl買購物袋.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl買購物袋.Location = new System.Drawing.Point(375, 514);
            this.lbl買購物袋.Name = "lbl買購物袋";
            this.lbl買購物袋.Size = new System.Drawing.Size(137, 38);
            this.lbl買購物袋.TabIndex = 4;
            this.lbl買購物袋.Text = "買購物袋";
            // 
            // lbl訂單總價
            // 
            this.lbl訂單總價.AutoSize = true;
            this.lbl訂單總價.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl訂單總價.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單總價.Location = new System.Drawing.Point(611, 514);
            this.lbl訂單總價.Name = "lbl訂單總價";
            this.lbl訂單總價.Size = new System.Drawing.Size(268, 38);
            this.lbl訂單總價.TabIndex = 5;
            this.lbl訂單總價.Text = "訂單總價 00000 元";
            // 
            // btn移除所選品項
            // 
            this.btn移除所選品項.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除所選品項.ForeColor = System.Drawing.Color.Blue;
            this.btn移除所選品項.Location = new System.Drawing.Point(308, 586);
            this.btn移除所選品項.Name = "btn移除所選品項";
            this.btn移除所選品項.Size = new System.Drawing.Size(246, 61);
            this.btn移除所選品項.TabIndex = 6;
            this.btn移除所選品項.Text = "移除所選品項";
            this.btn移除所選品項.UseVisualStyleBackColor = true;
            this.btn移除所選品項.Click += new System.EventHandler(this.btn移除所選品項_Click);
            // 
            // btn刪除所有品項
            // 
            this.btn刪除所有品項.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除所有品項.ForeColor = System.Drawing.Color.Maroon;
            this.btn刪除所有品項.Location = new System.Drawing.Point(308, 653);
            this.btn刪除所有品項.Name = "btn刪除所有品項";
            this.btn刪除所有品項.Size = new System.Drawing.Size(246, 61);
            this.btn刪除所有品項.TabIndex = 7;
            this.btn刪除所有品項.Text = "刪除所有品項";
            this.btn刪除所有品項.UseVisualStyleBackColor = true;
            this.btn刪除所有品項.Click += new System.EventHandler(this.btn刪除所有品項_Click);
            // 
            // btn輸出訂購單TXT結帳
            // 
            this.btn輸出訂購單TXT結帳.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn輸出訂購單TXT結帳.ForeColor = System.Drawing.Color.Green;
            this.btn輸出訂購單TXT結帳.Location = new System.Drawing.Point(570, 586);
            this.btn輸出訂購單TXT結帳.Name = "btn輸出訂購單TXT結帳";
            this.btn輸出訂購單TXT結帳.Size = new System.Drawing.Size(306, 61);
            this.btn輸出訂購單TXT結帳.TabIndex = 8;
            this.btn輸出訂購單TXT結帳.Text = "輸出訂購單TXT結帳";
            this.btn輸出訂購單TXT結帳.UseVisualStyleBackColor = true;
            this.btn輸出訂購單TXT結帳.Click += new System.EventHandler(this.btn輸出訂購單TXT結帳_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.Location = new System.Drawing.Point(573, 653);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(306, 61);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "繼續購物 Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(907, 739);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn輸出訂購單TXT結帳);
            this.Controls.Add(this.btn刪除所有品項);
            this.Controls.Add(this.btn移除所選品項);
            this.Controls.Add(this.lbl訂單總價);
            this.Controls.Add(this.lbl買購物袋);
            this.Controls.Add(this.lbl外帶);
            this.Controls.Add(this.listBox訂購品項);
            this.Controls.Add(this.lbl訂購人資訊);
            this.Controls.Add(this.label1);
            this.Name = "FormShoppingCart";
            this.Text = "購物車結帳";
            this.Load += new System.EventHandler(this.FormShoppingCart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl訂購人資訊;
        private System.Windows.Forms.ListBox listBox訂購品項;
        private System.Windows.Forms.Label lbl外帶;
        private System.Windows.Forms.Label lbl買購物袋;
        private System.Windows.Forms.Label lbl訂單總價;
        private System.Windows.Forms.Button btn移除所選品項;
        private System.Windows.Forms.Button btn刪除所有品項;
        private System.Windows.Forms.Button btn輸出訂購單TXT結帳;
        private System.Windows.Forms.Button btnClose;
    }
}