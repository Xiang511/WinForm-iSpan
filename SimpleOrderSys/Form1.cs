using System;
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
                listBox1.Items.Add($"{DrinkList[i]} {DrinkPriceList[i]}元");
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

            listBox1.SelectedIndex = 0;
            DrinkName = DrinkList[0];
            Drinkcount = 1;
            txtDrinkCount.Text = $"{Drinkcount}";
            DrinkPrice = DrinkPriceList[listBox1.SelectedIndex] + PlusPriceList[comboBoxPlus.SelectedIndex];
            LblPrice.Text = $"{DrinkPrice}";
            DrinkTotalPrice = DrinkPrice * Drinkcount;
            LblTotalPrice.Text = $"{DrinkTotalPrice}";
            LblOrderCount.Text = $"🛒{0}";

        }

        public void CalculatePrice()
        {
            DrinkPrice = DrinkPriceList[listBox1.SelectedIndex] + PlusPriceList[comboBoxPlus.SelectedIndex];
            LblPrice.Text = $"{DrinkPrice}";
            DrinkTotalPrice = DrinkPrice * Drinkcount;
            LblTotalPrice.Text = $"{DrinkTotalPrice}";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {

                DrinkName = DrinkList[listBox1.SelectedIndex];
                DrinkPrice = DrinkPriceList[listBox1.SelectedIndex] + PlusPriceList[comboBoxPlus.SelectedIndex];
                CalculatePrice();
            }
        }

        private void txtDrinkCount_TextChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void comboBoxPlus_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxPlus.SelectedIndex > 0 && listBox1.SelectedIndex > 0)
            {

                CalculatePrice(); 
                Console.WriteLine(DrinkPrice);
            }
        }
    }
}
