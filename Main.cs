using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgeKnow
{
    public partial class AgeKnow : Form
    {
        public AgeKnow()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
            // check numberic
            int n;
            string height = hightval.Text;
            bool isNumeric = int.TryParse(height, out n);
            if (isNumeric)
            {
                // true number
                int val = Int32.Parse(height);
                if (val < 50)
                {
                    //MessageBox.Show("Bạn xạo lìn vãi, có thằng nào thấp dưới 50cm?", "Xạo lòn quen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("You lie, who smaller than 50cm?", "Why you lie me?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (val > 220)
                {
                    //MessageBox.Show("Bạn xạo lìn vãi, có thằng Việt Nam nào cao trên 200cm?", "Xạo lòn quen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("You lie, who hight more than 220cm?", "Lie?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //MessageBox.Show("Chiều cao của bạn là " + height + "cm!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string trueh = "";
                    if ((val / 100) < 1)
                    {
                        trueh = (val % 100) + "cm";
                    }
                    else
                    {
                        trueh = (val / 100) + "m" + (val % 100);
                    }
                    //MessageBox.Show("Bạn cao " + trueh + "!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("You hight " + trueh + "!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (height == "")
            {
                //MessageBox.Show("Dữ liệu trống không. Vui lòng nhập số vào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Your field blank. Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //MessageBox.Show("Bạn nên nhập số, không phải chữ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("You must type number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hightval_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submit.PerformClick();
            }
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("seriously? dude, I worry about your reading skill.\n\njust type your hight (as `cm` unit), and click `Result`.\n\nGot it? do it now.", "My god!", MessageBoxButtons.OK);
        }
    }
}
