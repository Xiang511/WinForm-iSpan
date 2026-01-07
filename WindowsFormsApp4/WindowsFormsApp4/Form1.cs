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
        List<string> list飲料品項 = new List<string>(); //key
        List<int> list飲料價格 = new List<int>(); //value
        List<string> list甜度 = new List<string>();
        List<string> list冰塊 = new List<string>();
        List<string> list加料品項 = new List<string>(); //key
        List<int> list加料價格 = new List<int>(); //value
        int 杯數 = 0;
        int 飲料單價 = 0; //飲料 + 加料
        int 飲料單品總價 = 0; //單價 * 杯數
        string 飲料單品名稱 = "";
        string 甜度 = "";
        string 冰塊 = "";
        string 加料 = "";
        bool is外帶 = false;
        bool is買購物袋 = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //key飲料品項
            list飲料品項.Add("麥香紅茶");
            list飲料品項.Add("茉莉綠茶");
            list飲料品項.Add("波霸奶茶");
            list飲料品項.Add("玫瑰花茶");
            list飲料品項.Add("現打西瓜汁");
            //value飲料價格
            list飲料價格.Add(30);
            list飲料價格.Add(40);
            list飲料價格.Add(50);
            list飲料價格.Add(60);
            list飲料價格.Add(80);
            //key加料品項
            list加料品項.Add("不加料");
            list加料品項.Add("珍珠");
            list加料品項.Add("波霸");
            list加料品項.Add("芋圓");
            list加料品項.Add("椰果");
            //value加料價格
            list加料價格.Add(0);
            list加料價格.Add(8);
            list加料價格.Add(10);
            list加料價格.Add(12);
            list加料價格.Add(6);
            //甜度
            list甜度.Add("正常糖");
            list甜度.Add("半糖");
            list甜度.Add("微糖");
            list甜度.Add("無糖");
            //冰塊
            list冰塊.Add("正常冰");
            list冰塊.Add("少冰");
            list冰塊.Add("微冰");
            list冰塊.Add("去冰");
            ////////////////////////////////////////////
            for (int i = 0; i < list飲料品項.Count; i += 1)
            {
                listBox飲料品項.Items.Add($"{list飲料品項[i]} {list飲料價格[i]}元");
            }
            for (int i = 0; i < list加料品項.Count; i += 1)
            {
                combo加料.Items.Add($"{list加料品項[i]} {list加料價格[i]}元");
            }
            for (int i = 0; i < list甜度.Count; i += 1)
            {
                combo甜度.Items.Add($"{list甜度[i]}");
            }
            for (int i = 0; i < list冰塊.Count; i += 1)
            {
                combo冰塊.Items.Add($"{list冰塊[i]}");
            }
            ////表單預設值
            combo甜度.SelectedIndex = 0;
            甜度 = list甜度[0];
            combo冰塊.SelectedIndex = 1;
            冰塊 = list冰塊[1];
            combo加料.SelectedIndex = 0;
            加料 = list加料品項[0];

            listBox飲料品項.SelectedIndex = 0;
            飲料單品名稱 = list飲料品項[0];
            杯數 = 1;
            txt杯數.Text = $"{杯數}";
            飲料單價 = list飲料價格[listBox飲料品項.SelectedIndex] + list加料價格[combo加料.SelectedIndex];
            lbl飲料單價.Text = $"{飲料單價}";
            飲料單品總價 = 飲料單價 * 杯數;
            lbl飲料單品總價.Text = $"{飲料單品總價}";
            lbl購物車品項數量.Text = $"🛒{0}";
        }

        void 計算飲料單品總價() { 
            
            if (listBox飲料品項.SelectedIndex >= 0)
            {
                飲料單品總價 = 飲料單價 * 杯數;
                lbl飲料單價.Text = $"{飲料單價} 元";
                lbl飲料單品總價.Text = $"{飲料單品總價} 元";     
            }
        }

        private void listBox飲料品項_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox飲料品項.SelectedIndex >= 0)
            {
                飲料單品名稱 = list飲料品項[listBox飲料品項.SelectedIndex];
                飲料單價 = list飲料價格[listBox飲料品項.SelectedIndex] + list加料價格[combo加料.SelectedIndex];
                計算飲料單品總價();
            }
        }

        private void txt杯數_TextChanged(object sender, EventArgs e)
        {
            if (txt杯數.Text != "")
            {
                bool is杯數正確 = Int32.TryParse(txt杯數.Text, out 杯數);

                if ((is杯數正確 == true) && (杯數 > 0) && (杯數 < 100))
                {
                    //杯數正確
                }
                else
                {  //杯數不正確
                    MessageBox.Show("杯數輸入錯誤, 請重新輸入(1-99)杯)");
                    杯數 = 1;
                    txt杯數.Text = $"{杯數}";
                }

                計算飲料單品總價();
            }
        }

        private void btn加一杯_Click(object sender, EventArgs e)
        {
            //EXE: 回家練習
            計算飲料單品總價();
        }

        private void btn減一杯_Click(object sender, EventArgs e)
        {
            //EXE: 回家練習
            計算飲料單品總價();
        }

        private void combo甜度_SelectedIndexChanged(object sender, EventArgs e)
        {
            甜度 = list甜度[combo甜度.SelectedIndex];
        }

        private void combo冰塊_SelectedIndexChanged(object sender, EventArgs e)
        {
            冰塊 = list冰塊[combo冰塊.SelectedIndex];
        }

        private void combo加料_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((listBox飲料品項.SelectedIndex >= 0) && (combo加料.SelectedIndex >= 0))
            {
                飲料單品名稱 = list飲料品項[listBox飲料品項.SelectedIndex];
                飲料單價 = list飲料價格[listBox飲料品項.SelectedIndex] + list加料價格[combo加料.SelectedIndex];
                加料 = list加料品項[combo加料.SelectedIndex];
                計算飲料單品總價();
            }
        }

        private void btn加入購物車_Click(object sender, EventArgs e)
        {

        }

        private void chk外帶_CheckedChanged(object sender, EventArgs e)
        {
            is外帶 = chk外帶.Checked;
        }

        private void chk買購物袋_CheckedChanged(object sender, EventArgs e)
        {
            is買購物袋 = chk買購物袋.Checked;
        }

        private void btn購物車結帳_Click(object sender, EventArgs e)
        {

        }
    }
}
