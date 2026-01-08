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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            // 需要先把Modifier改成public，才能在這裡修改UserControl內的元件屬性

        }

        private void btnModify_Click(object sender, EventArgs e)
        // 需要先把Modifier改成public，才能在這裡修改UserControl內的元件屬性
        {
            lblTitle.Text = "Title Modified";
        }
    }
}
