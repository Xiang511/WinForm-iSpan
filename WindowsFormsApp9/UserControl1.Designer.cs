namespace WindowsFormsApp9
{
    partial class UserControl1
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(135, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 12);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(137, 70);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(100, 22);
            this.txtinput.TabIndex = 1;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(267, 68);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "button1";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.lblTitle);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(478, 150);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.TextBox txtinput;
        public System.Windows.Forms.Button btnModify;
    }
}
