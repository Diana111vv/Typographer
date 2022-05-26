using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace Test_Типограф_.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Replacement__to_Returned()
        {
            Typographer typ = new Typographer();
            typ.rtbText.Text = "  ";
            typ.Whitespace();
            string expected = " ";
            Assert.AreEqual(expected, typ.rtbText.Text);
        }
        [TestMethod]
        public void Replacement__point_to_point_Returned()
        {
            Typographer typ = new Typographer();
            typ.rtbText.Text = " .";
            typ.Whitespace();
            string expected = ".";
            Assert.AreEqual(expected, typ.rtbText.Text);
        }
        [TestMethod]
        public void Replacement__comma_to_comma_Returned()
        {
            Typographer typ = new Typographer();
            typ.rtbText.Text = " ,";
            typ.Whitespace();
            string expected = ",";
            Assert.AreEqual(expected, typ.rtbText.Text);
        }
        [TestMethod]
        public void Replacement__exclamation_mark_to_exclamation_mark_Returned()
        {
            Typographer typ = new Typographer();
            typ.rtbText.Text = " !";
            typ.Whitespace();
            string expected = "!";
            Assert.AreEqual(expected, typ.rtbText.Text);
        }
        [TestMethod]
        public void Replacement__colon_to_colon_Returned()
        {
            Typographer typ = new Typographer();
            typ.rtbText.Text = " :";
            typ.Whitespace();
            string expected = ":";
            Assert.AreEqual(expected, typ.rtbText.Text);
        }
        [TestMethod]
        public void Replacement__percent_to_percent_Returned()
        {
            Typographer typ = new Typographer();
            typ.rtbText.Text = " %";
            typ.Whitespace();
            string expected = "%";
            Assert.AreEqual(expected, typ.rtbText.Text);
        }
        [TestMethod]
        public void Replacement__dash_to_dash_Returned()
        {
            Typographer typ = new Typographer();
            typ.rtbText.Text = " -";
            typ.Whitespace();
            string expected = "-";
            Assert.AreEqual(expected, typ.rtbText.Text);
        }
        [TestMethod]
        public void Replacement__period_comma_to_period_comma_Returned()
        {
            Typographer typ = new Typographer();
            typ.rtbText.Text = " ;";
            typ.Whitespace();
            string expected = ";";
            Assert.AreEqual(expected, typ.rtbText.Text);
        }
        [TestMethod]
        public void Replacement__evenly_to_evenly_Returned()
        {
            Typographer typ = new Typographer();
            typ.rtbText.Text = " =";
            typ.Whitespace();
            string expected = "=";
            Assert.AreEqual(expected, typ.rtbText.Text);
        }
        public void Replacement__plus_to_plus_Returned()
        {
            Typographer typ = new Typographer();
            typ.rtbText.Text = " +";
            typ.Whitespace();
            string expected = "+";
            Assert.AreEqual(expected, typ.rtbText.Text);
        }
        [TestMethod]
        public void Replacement__question_mark_to_question_mark_Returned()
        {
            Typographer typ = new Typographer();
            typ.rtbText.Text = " ?";
            typ.Whitespace();
            string expected = "?";
            Assert.AreEqual(expected, typ.rtbText.Text);
        }
        [TestMethod]
        public void Replecement_Plus_and_Minus_to_PlusMinus()
        {
            Typographer typ = new Typographer();
            typ.rtbText.Text = "+,-";
            typ.Plus_or_minus();
            string expected = "±";
            Assert.AreEqual(expected, typ.rtbText.Text);
        }
        [TestMethod]
        public void Replecement_Plus_and_Minus_with_staples_to_PlusMinus()
        {
            Typographer typ = new Typographer();
            typ.rtbText.Text = "(+,-)";
            typ.Plus_or_minus();
            string expected = "(±)";
            Assert.AreEqual(expected, typ.rtbText.Text);
        }
        [TestMethod]
        public void Replecement_з_rus_to_z_with_Strikethrough()
        {
            Typographer typ = new Typographer();
            typ.rtbText.Text = "з";
            typ.Cross_out();
            string cross_out = "\u0336";
            string z_eng = "z";
            string expected = z_eng + cross_out;
            Assert.AreEqual(expected, typ.rtbText.Text);
        }
        [TestMethod]
        public void Replecement_З_rus_to_Z_with_Strikethrough()
        {
            Typographer typ = new Typographer();
            typ.rtbText.Text = "З";
            typ.Cross_out();
            string cross_out = "\u0336";
            string Z_eng = "Z";
            string expected = Z_eng + cross_out;
            Assert.AreEqual(expected, typ.rtbText.Text);
        }
        [TestMethod]
        public void Replecement_в_rus_to_V_with_Strikethrough()
        {
            Typographer typ = new Typographer();
            typ.rtbText.Text = "в";
            typ.Cross_out();
            string cross_out = "\u0336";
            string v_eng = "v";
            string expected = v_eng + cross_out;
            Assert.AreEqual(expected, typ.rtbText.Text);
        }
        [TestMethod]
        public void Replecement_B_rus_to_V_with_Strikethrough()
        {
            Typographer typ = new Typographer();
            typ.rtbText.Text = "В";
            typ.Cross_out();
            string cross_out = "\u0336";
            string V_eng = "V";
            string expected = V_eng + cross_out;
            Assert.AreEqual(expected, typ.rtbText.Text);
        }
        [TestMethod]
        public void Replecement_и_rus_to_i_eng()
        {
            Typographer typ = new Typographer();
            typ.rtbText.Text = "и";
            typ.Replace_the_letter();
            string expected = "i";
            Assert.AreEqual(expected, typ.rtbText.Text);
        }
        [TestMethod]
        public void Replecement_И_rus_to_I_eng()
        {
            Typographer typ = new Typographer();
            typ.rtbText.Text = "И";
            typ.Replace_the_letter();
            string expected = "I";
            Assert.AreEqual(expected, typ.rtbText.Text);
        }
        [TestMethod]
        public void Replecement_program_quotatin_mark_to_tree_quotation_mark()
        {
            Typographer typ = new Typographer();
            typ.rtbText.Text = "\"Здорова\"";
            typ.Quotation_marks();
            string expected = "«Здорова»";
            Assert.AreEqual(expected, typ.rtbText.Text);
        }
        [TestMethod]
        public void Replecement_program_two_quotatin_mark_to_tree_and_paws_quotation_mark()
        {
            Typographer typ = new Typographer();
            typ.rtbText.Text = "\"Здорова \"хакер\"\"";
            typ.Quotation_marks();
            string expected = "«Здорова „хакер“»";
            Assert.AreEqual(expected, typ.rtbText.Text);
        }
        [TestMethod]
        public void Replecement_program_three_quotatin_mark_to_two_tree_and_paws_quotation_mark()
        {
            Typographer typ = new Typographer();
            typ.rtbText.Text = "\"Здорова \"хакер\"\" сказал Миша \"программист\"";
            typ.Quotation_marks();
            string expected = "«Здорова „хакер“» сказал Миша «программист»";
            Assert.AreEqual(expected, typ.rtbText.Text);
        }
    }
}
