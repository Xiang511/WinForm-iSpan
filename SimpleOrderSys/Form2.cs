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
using System.IO;

namespace SimpleOrderSys
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl訂購人資訊.Text = GlobalVal.UserName;

            foreach (ArrayList 品項 in GlobalVal.OrderCart)
            {

                string 品名 = (string)品項[0];
                int 單價 = (int)品項[1];
                int 杯數 = (int)品項[2];
                int 單品總價 = (int)品項[3];
                String 甜度 = (string)品項[4];
                String 冰塊 = (string)品項[5];
                String 加料 = (string)品項[6];

                string strItem = string.Format("{0}  單價:{1}  杯數:{2}  總價:{3}  {4}  {5}  {6}",
                    品名, 單價, 杯數, 單品總價, 甜度, 冰塊, 加料);
                listBox訂購品項.Items.Add(strItem);
            }

            //折扣

            calculateTotal();
        }
        void calculateTotal()
        {
            int total = 0;
            foreach (ArrayList 品項 in GlobalVal.OrderCart)
            {

                int 單品總價 = (int)品項[3];
                total += 單品總價;
            }
            if (GlobalVal.isBuyBag && GlobalVal.OrderCart.Count > 0)
            {
                total += 3;
                lbl買購物袋.Visible = true;
            }
            else
            {
                lbl買購物袋.Visible = false;

            }
            if (GlobalVal.isTakeout && GlobalVal.OrderCart.Count > 0)
            {
                total += 10;
                lbl外帶.Visible = true;
            }
            else
            {
                lbl外帶.Visible = false;
            }
            lbl訂單總價.Text = "總價: " + total.ToString();
        }

        private void btn移除所選品項_Click(object sender, EventArgs e)
        {
            if (listBox訂購品項.SelectedIndex >= 0)
            {
                int deleteIndex = listBox訂購品項.SelectedIndex;

                GlobalVal.OrderCart.RemoveAt(deleteIndex);
                listBox訂購品項.Items.RemoveAt(deleteIndex);
                calculateTotal();
            }
            else
            {
                MessageBox.Show("請選擇要移除的品項");
            }


        }

        private void btn刪除所有品項_Click(object sender, EventArgs e)
        {

            GlobalVal.OrderCart.Clear();
            listBox訂購品項.Items.Clear();
            lbl訂購人資訊.Text = "";
            lbl買購物袋.Visible = false;
            lbl外帶.Visible = false;
            GlobalVal.Cart = 0;
            calculateTotal();




        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn輸出訂購單TXT結帳_Click(object sender, EventArgs e)
        {
            string str輸出 = @"C:\Users\iSpan\Desktop\新增資料夾";
            Random myradom = new Random();
            int numRadom = myradom.Next(1000, 1000);
            string str檔名 = $"{DateTime.Now.ToString("yyMMddHHmmss")}{numRadom.ToString()}{"輸出訂購單.txt"}";
            string str完整檔名 = str輸出 + @"\" + str檔名;
            Console.WriteLine(str完整檔名);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = str輸出;
            sfd.FileName = str檔名;
            sfd.Filter = "文字檔 | *.txt";

            DialogResult R = sfd.ShowDialog();
            if (R == DialogResult.OK)
            {
                str完整檔名 = sfd.FileName;
                Console.WriteLine(str完整檔名);
            }
            else
            {
                return;
            }
            List<string> list訂單內容 = new List<string>();
            list訂單內容.Add("---------------------------------------");
            list訂單內容.Add($"訂購時間 {DateTime.Now}");
            list訂單內容.Add($"訂購人{GlobalVal.UserName}");
            list訂單內容.Add("---------------------------------------");
            list訂單內容.Add("---------------------------------------");

            foreach (ArrayList 品項 in GlobalVal.OrderCart)
            {

                string 品名 = (string)品項[0];
                int 單價 = (int)品項[1];
                int 杯數 = (int)品項[2];
                int 單品總價 = (int)品項[3];
                String 甜度 = (string)品項[4];
                String 冰塊 = (string)品項[5];
                String 加料 = (string)品項[6];

                string strItem = string.Format("{0}  單價:{1}  杯數:{2}  總價:{3}  {4}  {5}  {6}",
                    品名, 單價, 杯數, 單品總價, 甜度, 冰塊, 加料);
                list訂單內容.Add(strItem);
            }

            list訂單內容.Add("---------------------------------------");
            if (GlobalVal.isTakeout == true)
            {
                list訂單內容.Add($"外帶");
            }
            if(GlobalVal.isBuyBag == true)
            {
                list訂單內容.Add($"購買購物袋");
            }
            list訂單內容.Add("---------------------------------------");

            list訂單內容.Add($"{lbl訂單總價.Text}");
            try
            {
                // 將 List<string> 直接轉存為檔案
                File.WriteAllLines(str完整檔名, list訂單內容, System.Text.Encoding.UTF8);
                MessageBox.Show("訂單已成功輸出！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("存檔失敗：" + ex.Message);
            }



        }
    }
}
