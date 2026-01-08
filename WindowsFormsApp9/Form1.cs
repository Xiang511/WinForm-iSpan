using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 需要先把Modifier改成public，才能在這裡修改UserControl內的元件屬性
            userControl11.lblTitle.Text = "可以修改 Title";
            userControl11.btnModify.Text="ok";
        }
    }
}
