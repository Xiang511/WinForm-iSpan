namespace SimpleOrderSys
{
    partial class Form2
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btn輸出訂購單TXT結帳 = new System.Windows.Forms.Button();
            this.btn刪除所有品項 = new System.Windows.Forms.Button();
            this.btn移除所選品項 = new System.Windows.Forms.Button();
            this.lbl訂單總價 = new System.Windows.Forms.Label();
            this.lbl買購物袋 = new System.Windows.Forms.Label();
            this.lbl外帶 = new System.Windows.Forms.Label();
            this.listBox訂購品項 = new System.Windows.Forms.ListBox();
            this.lbl訂購人資訊 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.Location = new System.Drawing.Point(429, 524);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(230, 49);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "繼續購物 Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn輸出訂購單TXT結帳
            // 
            this.btn輸出訂購單TXT結帳.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn輸出訂購單TXT結帳.ForeColor = System.Drawing.Color.Green;
            this.btn輸出訂購單TXT結帳.Location = new System.Drawing.Point(427, 471);
            this.btn輸出訂購單TXT結帳.Margin = new System.Windows.Forms.Padding(2);
            this.btn輸出訂購單TXT結帳.Name = "btn輸出訂購單TXT結帳";
            this.btn輸出訂購單TXT結帳.Size = new System.Drawing.Size(230, 49);
            this.btn輸出訂購單TXT結帳.TabIndex = 18;
            this.btn輸出訂購單TXT結帳.Text = "輸出訂購單TXT結帳";
            this.btn輸出訂購單TXT結帳.UseVisualStyleBackColor = true;
            this.btn輸出訂購單TXT結帳.Click += new System.EventHandler(this.btn輸出訂購單TXT結帳_Click);
            // 
            // btn刪除所有品項
            // 
            this.btn刪除所有品項.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除所有品項.ForeColor = System.Drawing.Color.Maroon;
            this.btn刪除所有品項.Location = new System.Drawing.Point(230, 524);
            this.btn刪除所有品項.Margin = new System.Windows.Forms.Padding(2);
            this.btn刪除所有品項.Name = "btn刪除所有品項";
            this.btn刪除所有品項.Size = new System.Drawing.Size(184, 49);
            this.btn刪除所有品項.TabIndex = 17;
            this.btn刪除所有品項.Text = "刪除所有品項";
            this.btn刪除所有品項.UseVisualStyleBackColor = true;
            this.btn刪除所有品項.Click += new System.EventHandler(this.btn刪除所有品項_Click);
            // 
            // btn移除所選品項
            // 
            this.btn移除所選品項.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除所選品項.ForeColor = System.Drawing.Color.Blue;
            this.btn移除所選品項.Location = new System.Drawing.Point(230, 471);
            this.btn移除所選品項.Margin = new System.Windows.Forms.Padding(2);
            this.btn移除所選品項.Name = "btn移除所選品項";
            this.btn移除所選品項.Size = new System.Drawing.Size(184, 49);
            this.btn移除所選品項.TabIndex = 16;
            this.btn移除所選品項.Text = "移除所選品項";
            this.btn移除所選品項.UseVisualStyleBackColor = true;
            this.btn移除所選品項.Click += new System.EventHandler(this.btn移除所選品項_Click);
            // 
            // lbl訂單總價
            // 
            this.lbl訂單總價.AutoSize = true;
            this.lbl訂單總價.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl訂單總價.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單總價.Location = new System.Drawing.Point(457, 413);
            this.lbl訂單總價.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl訂單總價.Name = "lbl訂單總價";
            this.lbl訂單總價.Size = new System.Drawing.Size(215, 30);
            this.lbl訂單總價.TabIndex = 15;
            this.lbl訂單總價.Text = "訂單總價 00000 元";
            // 
            // lbl買購物袋
            // 
            this.lbl買購物袋.AutoSize = true;
            this.lbl買購物袋.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl買購物袋.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl買購物袋.Location = new System.Drawing.Point(280, 413);
            this.lbl買購物袋.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl買購物袋.Name = "lbl買購物袋";
            this.lbl買購物袋.Size = new System.Drawing.Size(109, 30);
            this.lbl買購物袋.TabIndex = 14;
            this.lbl買購物袋.Text = "買購物袋";
            // 
            // lbl外帶
            // 
            this.lbl外帶.AutoSize = true;
            this.lbl外帶.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl外帶.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl外帶.Location = new System.Drawing.Point(206, 413);
            this.lbl外帶.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl外帶.Name = "lbl外帶";
            this.lbl外帶.Size = new System.Drawing.Size(61, 30);
            this.lbl外帶.TabIndex = 13;
            this.lbl外帶.Text = "外帶";
            // 
            // listBox訂購品項
            // 
            this.listBox訂購品項.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox訂購品項.FormattingEnabled = true;
            this.listBox訂購品項.ItemHeight = 30;
            this.listBox訂購品項.Location = new System.Drawing.Point(13, 92);
            this.listBox訂購品項.Margin = new System.Windows.Forms.Padding(2);
            this.listBox訂購品項.Name = "listBox訂購品項";
            this.listBox訂購品項.Size = new System.Drawing.Size(644, 304);
            this.listBox訂購品項.TabIndex = 12;
            // 
            // lbl訂購人資訊
            // 
            this.lbl訂購人資訊.AutoSize = true;
            this.lbl訂購人資訊.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購人資訊.Location = new System.Drawing.Point(8, 59);
            this.lbl訂購人資訊.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl訂購人資訊.Name = "lbl訂購人資訊";
            this.lbl訂購人資訊.Size = new System.Drawing.Size(133, 30);
            this.lbl訂購人資訊.TabIndex = 11;
            this.lbl訂購人資訊.Text = "訂購人資訊";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(175, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "🛒購物車 - 訂購品項列表🛒";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 591);
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
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btn輸出訂購單TXT結帳;
        private System.Windows.Forms.Button btn刪除所有品項;
        private System.Windows.Forms.Button btn移除所選品項;
        private System.Windows.Forms.Label lbl訂單總價;
        private System.Windows.Forms.Label lbl買購物袋;
        private System.Windows.Forms.Label lbl外帶;
        private System.Windows.Forms.ListBox listBox訂購品項;
        private System.Windows.Forms.Label lbl訂購人資訊;
        private System.Windows.Forms.Label label1;
    }
}