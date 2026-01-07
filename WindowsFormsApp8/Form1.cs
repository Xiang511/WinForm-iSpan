using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        List<Button> listBtns = new List<Button>();
        Dictionary<string, int> dicDrink = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dicDrink.Add("可樂", 30);
            dicDrink.Add("雪碧", 25);
            dicDrink.Add("芬達", 35);
            dicDrink.Add("蘋果西打", 20);
            dicDrink.Add("黑松沙士", 30);
            dicDrink.Add("維他命C", 25);
            dicDrink.Add("運動飲料", 40);
            dicDrink.Add("茶裏王", 30);
            dicDrink.Add("綠茶", 20);
            dicDrink.Add("紅茶", 15);
            dicDrink.Add("奶茶", 35);
            dicDrink.Add("咖啡", 50);
            dicDrink.Add("果汁", 45);
            dicDrink.Add("水", 10);
            dicDrink.Add("能量飲料", 60);
            dicDrink.Add("椰子水", 30);
            dicDrink.Add("氣泡水", 25);
            dicDrink.Add("檸檬水", 20);
            dicDrink.Add("冰茶", 30);
            dicDrink.Add("養樂多", 35);

            程式化產生Label();
            程式化產生品項(4, 8);
        }
        public void 程式化產生Label()
        {
            Label lbl = new Label();
            lbl.BackColor = Color.Black;
            lbl.ForeColor = Color.White;
            lbl.Font = new Font("標楷體", 30);
            lbl.Text = "簡單冷飲店";
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Location = new Point(380, 50);
            lbl.Size = new Size(200, 50);
            Controls.Add(lbl);
        }
        void 程式化產生品項(int row, int col)
        {
            int idx = 0;

            for (int i = 0; i < row; i++)
            {

                for (int j = 0; j < col; j++)
                {
                    Button button = new Button();
                    button.BackColor = Color.LightYellow;
                    button.Font = new Font("標楷體", 14);
                    button.Size = new Size(150, 80);
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    int posX = 20 + (110 * j);
                    int posY = 110 + (90 * i);
                    button.Location = new Point(posX, posY);
                    button.Size = new Size(110, 90);
                    button.Tag = idx;
                    button.Text = dicDrink.Keys.ElementAt(idx) + "\n" + dicDrink.Values.ElementAt(idx) + "元";
                    idx++;
                    Controls.Add(button);
                    listBtns.Add(button);
                    button.Click += Button_Click; // 事件指定運算子

                    if (idx >= dicDrink.Count)
                    {
                        return;
                    }

                }
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int idx = (int)btn.Tag;
            string str = dicDrink.Keys.ElementAt(idx) + "\n" + dicDrink.Values.ElementAt(idx) + "元";
            MessageBox.Show("您選擇的飲料是: " + str);
        }

        private void button1_Click(object sender, EventArgs e)
        { //清空按鈕
            //listBtns.ForEach(btn => btn.Dispose());
            foreach (Button mybtn in listBtns)
            {
                mybtn.Click -= Button_Click;
                Controls.Remove(mybtn);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {//今天喝甚麼
            foreach (Button mybtn in listBtns)
            {
                mybtn.BackColor = Color.LightYellow;
            }
            if (listBtns.Count > 0)
            {
                Random myradom = new Random();
                int radom = myradom.Next(0, listBtns.Count);
                Button chooseBtn = listBtns[radom];
                chooseBtn.BackColor = Color.LightGreen;
                //string str = dicDrink.Keys.ElementAt(radom) + "\n" + dicDrink.Values.ElementAt(radom) + "元";
                //MessageBox.Show("您選擇的飲料是: " + str);
            }


        }
    }
}
