using System;
using System.Windows.Forms;
using MultiPurposeDLL;

namespace HappyWinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(textBox1.Text, out number))
            {
                HappyNumberChecker checker = new HappyNumberChecker();
                checker.Number = number;
                string result = checker.Check();
                label1.Text = "Kết quả: " + result + " (lan approves!)"; // Dấu ấn cá nhân, sửa thành tiếng Việt nếu cần
            }
            else
            {
                label1.Text = "Input không hợp lệ.";
            }
        }
    }
}