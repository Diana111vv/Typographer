using System;
using System.Windows.Forms;

namespace Test_Типограф_
{
    public partial class Parameters : Form
    {
        public Parameters()
        {
            InitializeComponent();
            Program.parameters = this;
        }

        private void bcancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bsave_Click(object sender, EventArgs e)
        {
            if (cbwhitespace.Checked)
            {
                Program.typographer.cbwhitespace.Checked = true;
                Close();
            }
            else
            {
                Program.typographer.cbwhitespace.Checked = false;
                Close();
            }
            if (cbquotation_marks.Checked)
            {
                Program.typographer.cbquotion_marks.Checked = true;
                Close();
            }
            else
            {
                Program.typographer.cbquotion_marks.Checked = false;
                Close();
            }
            if (cbcross_out.Checked)
            {
                Program.typographer.cbcross_out.Checked = true;
                Close();
            }
            else
            {
                Program.typographer.cbcross_out.Checked = false;
                Close();
            }
            if (cbplus_or_minus.Checked)
            {
                Program.typographer.cbplus_or_minus.Checked = true;
                Close();
            }
            else
            {
                Program.typographer.cbplus_or_minus.Checked = false;
                Close();
            }
            if (cbreplace_the_letter.Checked)
            {
                Program.typographer.cbreplace_the_letter.Checked = true;
                Close();
            }
            else
            {
                Program.typographer.cbreplace_the_letter.Checked = false;
                Close();
            }
        }


        private void Parameters_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 8000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(this.cbwhitespace, "Два пробела и более заменяются одним пробелом.");
            toolTip.SetToolTip(this.cbplus_or_minus, "Символ «+,-» заменяется на ±");
            toolTip.SetToolTip(this.cbcross_out, "Буква «з» и «в» заменяются на перечёркнутые «z» и «v» соответственно.");
            toolTip.SetToolTip(this.cbquotation_marks, "Кавычки «\"» заменяются на кавычки «ёлочки». \nЕсли в одной конструкции необходимо написать другую, то вместо «ёлочек» используются кавычки „лапки“.");
            toolTip.SetToolTip(this.cbreplace_the_letter, "Буква «и» заменяется на букву «i».");
        }
    }
}
