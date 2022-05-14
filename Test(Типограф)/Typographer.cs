using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Test_Типограф_
{
    public partial class Typographer : Form
    {
        public Typographer()
        {
            InitializeComponent();
            Program.typographer = this;
        }

        private void bclear_Click(object sender, EventArgs e)
        {
            rtbText.Clear();
        }

        private void bselectall_Click(object sender, EventArgs e)
        {
            rtbText.SelectAll();
            rtbText.Focus();
        }

        private void bprinting_Click(object sender, EventArgs e)
        {
            Edited_text edited_Text = new Edited_text();
            edited_Text.Show();
            Edit();
            Quotation_marks();
            Program.edited_Text.rtbeditedtext.Text = rtbText.Text;
        }

        private void bhelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        public void Edit()
        {
            foreach (var item in rtbText.Text)
            {
                rtbText.Text = rtbText.Text.Replace("  ", " ");
                rtbText.Text = Regex.Replace(rtbText.Text, @"\s*,", ",");
                rtbText.Text = Regex.Replace(rtbText.Text, @"\s*!", "!");
                rtbText.Text = Regex.Replace(rtbText.Text, @"\s*;", ";");
                rtbText.Text = Regex.Replace(rtbText.Text, @"\s*%", "%");
                rtbText.Text = Regex.Replace(rtbText.Text, @"\s*:", ":");
                rtbText.Text = Regex.Replace(rtbText.Text, @"\s*-", "-");
                rtbText.Text = Regex.Replace(rtbText.Text, @"\s*=", "=");
                rtbText.Text = Regex.Replace(rtbText.Text, @"\s*\+", "+");
                rtbText.Text = Regex.Replace(rtbText.Text, @"\s*\.", ".");
                rtbText.Text = Regex.Replace(rtbText.Text, @"\s*\?", "?");
                rtbText.Text = rtbText.Text.Replace("+,-", "±");
                rtbText.Text = rtbText.Text.Replace("(+,-)", "±");
                rtbText.Text = rtbText.Text.Replace("з", "z\u0336");
                rtbText.Text = rtbText.Text.Replace("в", "v\u0336");
                rtbText.Text = rtbText.Text.Replace("и", "i");
            }
        }
        public void Quotation_marks()
        {
            if (Regex.IsMatch(rtbText.Text, "\"(.+?)\"(.+?)\"\""))
            {
                rtbText.Text = Regex.Replace(rtbText.Text, "\"(.+?)\"(.+?)\"\"", "«$1 „$2“»");
            }
            else
            {
                rtbText.Text = Regex.Replace(rtbText.Text, "\"(.+?)\"", "«$1»");
            }
        }
    }
}
