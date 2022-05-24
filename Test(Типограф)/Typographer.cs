using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Test_Типограф_
{
    public partial class Typographer : Form
    {
        string z_rus = "з";
        string z_eng = "z";
        string Z_rus = "З";
        string Z_eng = "Z";
        string v_rus = "в";
        string v_eng = "v";
        string V_rus = "В";
        string V_eng = "V";
        string i_rus = "и";
        string i_eng = "i";
        string I_rus = "И";
        string I_eng = "I";
        string cross_out = "\u0336";
        string filename;
        bool isFilechange;
        public Typographer()
        {
            InitializeComponent();
            Program.typographer = this;
            Init();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            fontDialog1.ShowColor = true;
            // расширенное окно для выбора цвета
            colorDialog1.FullOpen = true;
            // установка начального цвета для colorDialog
            colorDialog1.Color = this.BackColor;
        }
        public void Init()
        {
            filename = "";
            isFilechange = false;
        }
        private void bclear_Click(object sender, EventArgs e)
        {
            rtbText.Clear();
        }


        private void bprinting_Click(object sender, EventArgs e)
        {
            if (cbwhitespace.Checked)
            {
                Whitespace();
            }
            if (cbquotion_marks.Checked)
            {
                Quotation_marks();
            }
            if (cbplus_or_minus.Checked)
            {
                Plus_or_minus();
            }
            if (cbreplace_the_letter.Checked)
            {
                Replace_the_letter();
            }
            if (cbcross_out.Checked)
            {
                Cross_out();
            }
            else
            {
                rtbText.Text = rtbText.Text;
            }
        }

        private void bhelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Если вы не знаете, как пользоваться данной программой, то эта инструкция для вас: \n1)Нажав на кнопку Параметры, вы можете выбрать необходимые вам правила для типографирования. \n2)Наберите текст, либо откройте готовый файл с текстом. \n3)Нажмите кнопку Типографировать. \n\nГотово! Теперь вы можете сохранить этот текст в файл, распечатать или просто скопировать. \n\n\nКроме этого, в нашем типографе вы можете воспользоваться дополнительными функциями из верхнего меню. \nУспехов в использовании:-)", "Инструкция");
        }
        public void Whitespace()
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
                rtbText.Text = Regex.Replace(rtbText.Text, @"\s*±", "±");
            }
        }
        public void Plus_or_minus()
        {
            foreach (var item in rtbText.Text)
            {
                rtbText.Text = rtbText.Text.Replace("+,-", "±");
                rtbText.Text = rtbText.Text.Replace("(+,-)", "±");
            }
        }
        public void Cross_out()
        {
            foreach (var item in rtbText.Text)
            {
                rtbText.Text = rtbText.Text.Replace(z_rus, z_eng + cross_out);
                rtbText.Text = rtbText.Text.Replace(Z_rus, Z_eng + cross_out);
                rtbText.Text = rtbText.Text.Replace(v_rus, v_eng + cross_out);
                rtbText.Text = rtbText.Text.Replace(V_rus, V_eng + cross_out);
            }
        }
        public void Replace_the_letter()
        {
            foreach (var item in rtbText.Text)
            {
                rtbText.Text = rtbText.Text.Replace(i_rus, i_eng);
                rtbText.Text = rtbText.Text.Replace(I_rus, I_eng);
            }
        }
        public void Quotation_marks()
        {
            if (Regex.IsMatch(rtbText.Text, "\"(.+?) \"(.+?)\"\""))
            {
                rtbText.Text = Regex.Replace(rtbText.Text, "\"(.+?) \"(.+?)\"\"", "«$1 „$2“»");
            }
            else
            {
                rtbText.Text = Regex.Replace(rtbText.Text, "\"(.+?)\"", "«$1»");
            }
        }

        private void Typographer_Load(object sender, EventArgs e)
        {
            rtbText.Text = "Введите текст...";
            rtbText.ForeColor = Color.Gray;
        }

        private void rtbText_Enter(object sender, EventArgs e)
        {
            if (rtbText.Text.Equals("Введите текст..."))
            {
                rtbText.Text = "";
                rtbText.ForeColor = Color.Black;
            }
        }
        private void rtbText_Leave(object sender, EventArgs e)
        {
            if (rtbText.Text.Equals(""))
            {
                rtbText.Text = "Введите текст...";
                rtbText.ForeColor = Color.Gray;
            }
        }

        private void bexample_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1)  Сегодня  просто    прекрасный    вечер    ,  не   так   ли    ? - 1) Сегодня просто прекрасный вечер, не так ли?  \n\n2) Вася Пупкин сказал: \"Мой хакерский никнейм \"Neo\"! \" - 2) Вася Пупкин сказал: «Мой хакерский никнейм „Neo“» \n\n3) Нам нужно +,- 5 метров материала. - 3) Нам нужно ± 5 метров материала. \n\n4) Сегодня заяц и волк вместе позавтракали. - 4) Сегодня z̶аяц и v̶олк v̶месте поz̶аv̶тракали. \n\n5) Инвентарь искали инициативные, импульсивные инспекторы. - 5) Iнвентарь iскалi iнiцiатiвные, iмпульсiвные iнспекторы.", "Примеры");
        }

        private void bparameters_Click(object sender, EventArgs e)
        {
            Parameters parameters = new Parameters();
            parameters.Show();
            if (cbwhitespace.Checked)
            {
                Program.parameters.cbwhitespace.Checked = true;
            }
            if (cbquotion_marks.Checked)
            {
                Program.parameters.cbquotation_marks.Checked = true;
            }
            if (cbplus_or_minus.Checked)
            {
                Program.parameters.cbplus_or_minus.Checked = true;
            }
            if (cbreplace_the_letter.Checked)
            {
                Program.parameters.cbreplace_the_letter.Checked = true;
            }
            if (cbcross_out.Checked)
            {
                Program.parameters.cbcross_out.Checked = true;
            }
        }

        private void bopen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            rtbText.Text = fileText;
            MessageBox.Show("Файл открыт");
        }

        public void SaveUnsavefile()
        {
            if (isFilechange)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения в файле?", "Сохранение файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    SaveFile(filename);
                }
            }
        }
        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            SaveUnsavefile();
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader str = new StreamReader(openFileDialog1.FileName);
                    rtbText.Text = str.ReadToEnd();
                    str.Close();
                    filename = openFileDialog1.FileName;
                    isFilechange = false;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл!");
                }
            }
        }
        public void SaveFile(string _filename)
        {
            if (_filename == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _filename = saveFileDialog1.FileName;
                }
                try
                {
                    StreamWriter stream = new StreamWriter(_filename + ".txt");
                    stream.Write(rtbText.Text);
                    stream.Close();
                    filename = _filename;
                    isFilechange = false;
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить файл!");
                }
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            SaveFile(filename);
        }

        private void tsmiSaveas_Click(object sender, EventArgs e)
        {
            SaveFile("");
        }

        private void tsmiPrint_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiCut_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbText.Text.Substring(rtbText.SelectionStart, rtbText.SelectionLength));
            rtbText.Text = rtbText.Text.Remove(rtbText.SelectionStart, rtbText.SelectionLength);
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbText.SelectedText);
        }

        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            rtbText.Text = rtbText.Text.Substring(0, rtbText.SelectionStart) + Clipboard.GetText() + rtbText.Text.Substring(rtbText.SelectionStart, rtbText.Text.Length - rtbText.SelectionStart);
        }

        private void tsmiClean_Click(object sender, EventArgs e)
        {
            rtbText.Clear();
        }

        private void tsmiSelectall_Click(object sender, EventArgs e)
        {
            rtbText.SelectAll();
        }

        private void tsmiFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbText.Font = fontDialog1.Font;
            }
        }

        private void tsmiColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbText.ForeColor = colorDialog1.Color;
            }
        }

        private void tsmiColorback_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                rtbText.BackColor = colorDialog2.Color;
            }
        }

        private void tsmiAboutprogramm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа предназначена для того, чтобы Вам не доставляло неудобств печатание какого-либо текста, а сам текст выглядел более аккуратным!", "О программе");
        }

        private void tsmiHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Если вы не знаете, как пользоваться данной программой, то эта инструкция для вас: \n1)Нажав на кнопку Параметры, вы можете выбрать необходимые вам правила для типографирования. \n2)Наберите текст, либо откройте готовый файл с текстом. \n3)Нажмите кнопку Типографировать. \n\nГотово! Теперь вы можете сохранить этот текст в файл, распечатать или просто скопировать. \n\n\nКроме этого, в нашем типографе вы можете воспользоваться дополнительными функциями из верхнего меню. \nУспехов в использовании:-)", "Инструкция");
        }
    }
}
