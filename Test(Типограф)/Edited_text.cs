using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Типограф_
{
    public partial class Edited_text : Form
    {
        public Edited_text()
        {
            InitializeComponent();
            Program.edited_Text = this;
        }

        private void bclear_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
