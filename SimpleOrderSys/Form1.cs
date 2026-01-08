using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleOrderSys
{
    public partial class Form1 : Form
    {

        List<string> DrinkList = new List<string>();
        List<int> DrinkPriceList = new List<int>(); //value
        List<string> SugarList = new List<string>();
        List<string> IceList = new List<string>();
        List<string> PlusList = new List<string>(); //key
        List<int> PlusPriceList = new List<int>(); //value

        int Drinkcount = 0;
        int DrinkPrice = 0; //飲料 + 加料
        int DrinkTotalPrice = 0; //單價 * 杯數

        string DrinkName = "";
        string Sugar = "";
        string Ice = "";
        string Plus = "";
        bool isTakeout = false;
        bool isBuyBag = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //key飲料品項
            DrinkList.Add("麥香紅茶");
            DrinkList.Add("茉莉綠茶");
            DrinkList.Add("波霸奶茶");
            DrinkList.Add("玫瑰花茶");
            DrinkList.Add("現打西瓜汁");
            //value飲料價格
            DrinkPriceList.Add(30);
            DrinkPriceList.Add(40);
            DrinkPriceList.Add(50);
            DrinkPriceList.Add(60);
            DrinkPriceList.Add(80);
            //key加料品項
            PlusList.Add("不加料");
            PlusList.Add("珍珠");
            PlusList.Add("波霸");
            PlusList.Add("芋圓");
            PlusList.Add("椰果");
            //value加料價格
            PlusPriceList.Add(0);
            PlusPriceList.Add(8);
            PlusPriceList.Add(10);
            PlusPriceList.Add(12);
            PlusPriceList.Add(6);
            //甜度
            SugarList.Add("正常糖");
            SugarList.Add("半糖");
            SugarList.Add("微糖");
            SugarList.Add("無糖");
            //冰塊
            IceList.Add("正常冰");
            IceList.Add("少冰");
            IceList.Add("微冰");
            IceList.Add("去冰");


            for (int i = 0; i < DrinkList.Count; i += 1)
            {
                listBoxDrink.Items.Add($"{DrinkList[i]} {DrinkPriceList[i]}元");
            }
            for (int i = 0; i < DrinkPriceList.Count; i += 1)
            {
                comboBoxPlus.Items.Add($"{PlusList[i]} {PlusPriceList[i]}元");
            }
            for (int i = 0; i < SugarList.Count; i += 1)
            {
                comboBoxSugar.Items.Add($"{SugarList[i]}");
            }
            for (int i = 0; i < IceList.Count; i += 1)
            {
                comboBoxIce.Items.Add($"{IceList[i]}");
            }
            comboBoxSugar.SelectedIndex = 0;
            Sugar = SugarList[0];
            comboBoxIce.SelectedIndex = 1;
            Ice = IceList[1];
            comboBoxPlus.SelectedIndex = 0;
            Plus = PlusList[0];

            listBoxDrink.SelectedIndex = 0;
            DrinkName = DrinkList[0];
            Drinkcount = 1;
            txtDrinkCount.Text = $"{Drinkcount}";
            DrinkPrice = DrinkPriceList[listBoxDrink.SelectedIndex] + PlusPriceList[comboBoxPlus.SelectedIndex];
            LblPrice.Text = $"{DrinkPrice}";
            DrinkTotalPrice = DrinkPrice * Drinkcount;
            LblTotalPrice.Text = $"{DrinkTotalPrice}";
            LblOrderCount.Text = $"🛒{0}";

        }

        public void CalculatePrice()
        {
            DrinkPrice = DrinkPriceList[listBoxDrink.SelectedIndex] + PlusPriceList[comboBoxPlus.SelectedIndex];
            LblPrice.Text = $"{DrinkPrice}";
            DrinkTotalPrice = DrinkPrice * Drinkcount;
            LblTotalPrice.Text = $"{DrinkTotalPrice}";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDrink.SelectedIndex >= 0)
            {

                DrinkName = DrinkList[listBoxDrink.SelectedIndex];
                DrinkPrice = DrinkPriceList[listBoxDrink.SelectedIndex] + PlusPriceList[comboBoxPlus.SelectedIndex];
                CalculatePrice();
            }
        }

        private void txtDrinkCount_TextChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void comboBoxPlus_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxPlus.SelectedIndex > 0 && listBoxDrink.SelectedIndex > 0)
            {

                CalculatePrice();
                Console.WriteLine(DrinkPrice);
            }
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (listBoxDrink.SelectedIndex >= 0)
            {
                ArrayList Orderinfo = new ArrayList();
                Orderinfo.Add(DrinkName);
                Orderinfo.Add(DrinkPrice);
                Orderinfo.Add(Drinkcount);
                Orderinfo.Add(DrinkTotalPrice);
                Orderinfo.Add(Sugar);
                Orderinfo.Add(Ice);
                Orderinfo.Add(Plus);
                GlobalVal.OrderCart.Add(Orderinfo);
                //MessageBox.Show("已加入購物車");
                GlobalVal.Cart += 1;
                LblOrderCount.Text = $"🛒{GlobalVal.Cart}";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Drinkcount++;
            txtDrinkCount.Text = Drinkcount.ToString();
            CalculatePrice();
        }

        private void btnMine_Click(object sender, EventArgs e)
        {
            Drinkcount--;
            txtDrinkCount.Text = Drinkcount.ToString();
            CalculatePrice();
        }

        private void comboBoxSugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sugar = SugarList[comboBoxSugar.SelectedIndex];
        }

        private void comboBoxIce_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ice = IceList[comboBoxIce.SelectedIndex];
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (GlobalVal.OrderCart.Count > 0)
            {
                GlobalVal.UserName = txtUserName.Text.Trim();
                GlobalVal.isTakeout = isTakeout;
                GlobalVal.isBuyBag = isBuyBag;


                Form2 form2 = new Form2(); // Create the instance
                form2.ShowDialog();        // Call the method on that instance
            }
            else
            {
                MessageBox.Show("請至少加入一件物品");
            }
        }

        private void chkTakeout_CheckedChanged(object sender, EventArgs e)
        {
            isTakeout = chkTakeout.Checked;
            isTakeout = true;
        }

        private void chkBuyBag_CheckedChanged(object sender, EventArgs e)
        {
            isBuyBag = chkBuyBag.Checked;
            isBuyBag = true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            LblOrderCount.Text = $"🛒{GlobalVal.Cart}";
        }
    }
}
