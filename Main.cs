using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;
using System.Globalization;

namespace AgeKnow
{
    public partial class AgeKnow : Form
    {
        CultureInfo currentCultureInfo;
        public AgeKnow()
        {
            currentCultureInfo = new CultureInfo("en-US");
            InitializeComponent();
        }
        
        public void GetITrans()
        {
            label1.Text = GetTranslation("label1");
            submit.Text = GetTranslation("submit");
        }

        public void HideLang()
        {
            lang_eng.Visible = false;
            lang_vie.Visible = false;
        }

        private void lang_vie_Click(object sender, EventArgs e)
        {
            HideLang();
            lang_eng.Visible = true;
            currentCultureInfo = new CultureInfo("vi-VN");
            GetITrans();
        }

        private void lang_eng_Click(object sender, EventArgs e)
        {
            HideLang();
            lang_vie.Visible = true;
            currentCultureInfo = new CultureInfo("en-US");
            GetITrans();
        }

        public string GetTranslation(string s)
        {
            Assembly a = Assembly.Load("AgeKnow");
            ResourceManager rm = new ResourceManager("AgeKnow.languages.lang", a);
            return rm.GetString(s, currentCultureInfo);
        }
        
        private void submit_Click(object sender, EventArgs e)
        {
            // check numberic
            int n;
            string height = hightval.Text;
            bool isNumeric = int.TryParse(height, out n);
            if (isNumeric)
            {
                // true number
                string[] errormess = { "I sure that I've mentioned you don't fill this field number smaller than 21,5 or bigger than 107.",
                                     "Just type a number between 21 and 107, dude!",
                                     "Damn u. Why you type like that again?",
                                     "Argh! I have no idea to say with you" };
                var messagelog = errormess[new Random().Next(0, errormess.Length)];
                int val = Int32.Parse(height);
                bool ftw = false;
                if ( val < 21 )
                {
                    // smaller than world shortest hooman
                    if (ftw == false)
                    {
                        MessageBox.Show(GetTranslation("sr21mess"), GetTranslation("sr21title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ftw = true;
                    }
                    else if (ftw == true)
                    {
                        MessageBox.Show(messagelog, GetTranslation("sr21title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (val > 107)
                {
                    // bigger than world heightest hooman
                    MessageBox.Show(GetTranslation("br107mess"), GetTranslation("br107title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(GetTranslation("resmessage") + " " + val + " inches!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (height == "")
            {
                // blank field
                MessageBox.Show(GetTranslation("blankmess"), GetTranslation("blanktitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // not number
                MessageBox.Show(GetTranslation("notnumbermess"), GetTranslation("notnumbertitle"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hightval_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                submit.PerformClick();
            }
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetTranslation("help"), "My god!", MessageBoxButtons.OK);
        }
    }
}
