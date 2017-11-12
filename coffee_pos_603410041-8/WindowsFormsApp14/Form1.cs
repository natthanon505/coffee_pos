using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        string a = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
        }
        public void jame(String menu,String bath)
        {
            string [] j = { menu,bath};
            var list = new ListViewItem(j);
            listView1.Items.Add(list);
            ka();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            jame("Esspresso(Hot)", "35");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jame("Esspresso(Ice)", "45");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jame("Esspresso(Frappe)", "50");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            jame("Amreicano(Hot)", "35");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            jame("Amreicano(Ice)", "45");
        }
        double price;
        public string[] ka()
        {
            price = 0;
            string[] r1 = new string[listView1.Items.Count];
            int item = listView1.Items.Count;
            for(int i = 0; i<item; i++)
            {
                price += double.Parse(listView1.Items[i].SubItems[1].Text);
                r1[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            label26.Text = price.ToString();
            return r1;
        }
        public string[] ka1()
        { 
            string[] r1 = new string[listView1.Items.Count];
            int item = listView1.Items.Count;
            for (int i = 0; i < item; i++) 
            {
                r1[i] = listView1.Items[i].SubItems[1].Text.ToString();
            }
            return r1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(Payment);
        }
        void ka2()
        {
            string[] ka_1 = ka();
            string[] ka_2 = ka1();
            string ka3 = " ร้าน กาแฟ" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string bill = "ร้าน กาแฟ";
            bill += "\r\n" + DateTime.Now.ToString("hh|mm|ss") + "\r\n" + DateTime.Now.ToString("dd/mm/yyyy") + "\r\n" + "\r\n";
            bill += "เมนู" + "\r\n";
            for (int i = 0; i < listView1.Items.Count; i++) 
            {
                bill += ka_1[i] + new string(' ', 20) + ka_2[i] + "bath" + "\r\n";
            }
            bill += "\r\n";
            bill += "Total price : " + label26.Text;
            System.IO.File.WriteAllText(a + @"\" + ka3 + ".txt", bill);
            textBox1.Text += bill + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Save File at" + a + @"\" + ka3 + ",txt";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            jame("Latte(Hot)", "35");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            jame("Latte(Ice)", "45");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            jame("Latte(Frappe)", "50");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            jame("Mocha(Hot)", "35");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            jame("Mocha(Ice)", "45");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            jame("Mocha(Frappe)", "50");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            jame("Cappuccino(Hot)", "35");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            jame("Cappuccinoa(Ice)", "45");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            jame("Cappuccino(Frappe)", "50");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            jame("GreenTea(Hot)", "20");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            jame("GreenTea(Ice)", "25");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            jame("GreenTea(Frappe)", "30");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            jame("ThaiTea(Hot)", "20");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            jame("ThaiTea(Ice)", "25");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            jame("ThaiTea(Frappe)", "30");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            jame("CoCoa(Hot)", "20");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            jame("CoCoa(Ice)", "25");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            jame("CoCoa(Frappe)", "30");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            jame("Milk(Hot)", "20");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            jame("Milk(Ice)", "25");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            jame("Milk(Frappe)", "30");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            jame("MilkTea(Ice)", "25");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            jame("MilkTea(Frappe)", "30");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            jame("LemonTea(Ice)", "25");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            jame("LemonTea(Frappe)", "30");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            jame("Milo(Hot)", "20");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            jame("Milo(Ice)", "25");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            jame("Milo(Frappe)", "30");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            jame("Nescafe(Hot)", "20");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            jame("Nescafe(Ice)", "25");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            jame("Nescafe(Frappe)", "30");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            jame("Nesteatea(Hot)", "20");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            jame("Nesteatea(Ice)", "25");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            jame("Nesteatea(Frappe)", "30");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            jame("Italian Soda(Ice)", "25");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            jame("Red lime Soda(Ice)", "25");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            jame("Honey lime Soda(Ice)", "25");
        }
        bool ok = false;
        private void button43_Click(object sender, EventArgs e)
        {
            listView1.Text = "";
            if (ok == false)
            {
                tabControl1.TabPages.Insert(1, Payment);
                ok = true;
                tabControl1.SelectedTab = Payment;
            }
            else tabControl1.SelectedTab = Payment;

            if (listView1.Items.Count > 0)
                ka2();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ok = false;
            tabControl1.Controls.Remove(Payment);
            label26.Text = "";
            textBox1.Text = "";
        }
    }
}
