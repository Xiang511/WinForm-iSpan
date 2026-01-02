using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void callByValue(int y)
        {
            y += 1;
            lblCBV2.Text = $"傳值呼叫, 方法內的y值是:{y}";
        }

        private void btnCBV測試_Click(object sender, EventArgs e)
        {
            int x = 5;
            lblCBV1.Text = $"傳值呼叫, x 傳遞進方法之前的值是: {x}";
            callByValue(x);
            lblCBV3.Text = $"傳值呼叫, x 傳遞進方法之後的值是: {x}";
        }

        void callByReference(ref int y)
        {
            y += 1;
            lblCBR2.Text = $"傳址呼叫, 方法內的y值是:{y}";
        }

        private void btnCBR測試_Click(object sender, EventArgs e)
        {
            int x = 5;
            lblCBR1.Text = $"傳址呼叫, x 傳遞進方法之前的值是: {x}";
            callByReference(ref x);
            lblCBR3.Text = $"傳址呼叫, x 傳遞進方法之後的值是: {x}";
        }
    }
}
