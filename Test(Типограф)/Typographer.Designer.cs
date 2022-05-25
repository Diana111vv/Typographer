
namespace Test_Типограф_
{
    partial class Typographer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Typographer));
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.bprinting = new System.Windows.Forms.Button();
            this.bclear = new System.Windows.Forms.Button();
            this.bexample = new System.Windows.Forms.Button();
            this.bparameters = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bopen = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClean = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectall = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColorback = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReference = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAboutprogramm = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.bheip = new System.Windows.Forms.Button();
            this.gbparameters = new System.Windows.Forms.GroupBox();
            this.cbcross_out = new System.Windows.Forms.CheckBox();
            this.cbplus_or_minus = new System.Windows.Forms.CheckBox();
            this.cbquotion_marks = new System.Windows.Forms.CheckBox();
            this.cbreplace_the_letter = new System.Windows.Forms.CheckBox();
            this.cbwhitespace = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.gbparameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbText
            // 
            this.rtbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbText.Location = new System.Drawing.Point(34, 90);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(860, 337);
            this.rtbText.TabIndex = 0;
            this.rtbText.Text = "";
            this.rtbText.Enter += new System.EventHandler(this.rtbText_Enter);
            this.rtbText.Leave += new System.EventHandler(this.rtbText_Leave);
            // 
            // bprinting
            // 
            this.bprinting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bprinting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.bprinting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(64)))), ((int)(((byte)(54)))));
            this.bprinting.FlatAppearance.BorderSize = 145;
            this.bprinting.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(191)))), ((int)(((byte)(163)))));
            this.bprinting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bprinting.Location = new System.Drawing.Point(34, 433);
            this.bprinting.Name = "bprinting";
            this.bprinting.Size = new System.Drawing.Size(153, 41);
            this.bprinting.TabIndex = 1;
            this.bprinting.Text = "Типографировать";
            this.bprinting.UseVisualStyleBackColor = false;
            this.bprinting.Click += new System.EventHandler(this.bprinting_Click);
            // 
            // bclear
            // 
            this.bclear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.bclear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(64)))), ((int)(((byte)(54)))));
            this.bclear.FlatAppearance.BorderSize = 145;
            this.bclear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(191)))), ((int)(((byte)(163)))));
            this.bclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bclear.Location = new System.Drawing.Point(193, 433);
            this.bclear.Name = "bclear";
            this.bclear.Size = new System.Drawing.Size(153, 41);
            this.bclear.TabIndex = 3;
            this.bclear.Text = "Очистить";
            this.bclear.UseVisualStyleBackColor = false;
            this.bclear.Click += new System.EventHandler(this.bclear_Click);
            // 
            // bexample
            // 
            this.bexample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bexample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.bexample.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(64)))), ((int)(((byte)(54)))));
            this.bexample.FlatAppearance.BorderSize = 145;
            this.bexample.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(191)))), ((int)(((byte)(163)))));
            this.bexample.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bexample.Location = new System.Drawing.Point(741, 43);
            this.bexample.Name = "bexample";
            this.bexample.Size = new System.Drawing.Size(153, 41);
            this.bexample.TabIndex = 4;
            this.bexample.Text = "Пример";
            this.bexample.UseVisualStyleBackColor = false;
            this.bexample.Click += new System.EventHandler(this.bexample_Click);
            // 
            // bparameters
            // 
            this.bparameters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.bparameters.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(64)))), ((int)(((byte)(54)))));
            this.bparameters.FlatAppearance.BorderSize = 145;
            this.bparameters.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(191)))), ((int)(((byte)(163)))));
            this.bparameters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bparameters.Location = new System.Drawing.Point(34, 43);
            this.bparameters.Name = "bparameters";
            this.bparameters.Size = new System.Drawing.Size(153, 41);
            this.bparameters.TabIndex = 6;
            this.bparameters.Text = "Параметры";
            this.bparameters.UseVisualStyleBackColor = false;
            this.bparameters.Click += new System.EventHandler(this.bparameters_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bopen
            // 
            this.bopen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bopen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.bopen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(64)))), ((int)(((byte)(54)))));
            this.bopen.FlatAppearance.BorderSize = 145;
            this.bopen.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(191)))), ((int)(((byte)(163)))));
            this.bopen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bopen.Location = new System.Drawing.Point(741, 433);
            this.bopen.Name = "bopen";
            this.bopen.Size = new System.Drawing.Size(153, 41);
            this.bopen.TabIndex = 7;
            this.bopen.Text = "Открыть файл";
            this.bopen.UseVisualStyleBackColor = false;
            this.bopen.Click += new System.EventHandler(this.bopen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiFormat,
            this.tsmiReference});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiSaveas,
            this.tsmiPrint,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(59, 24);
            this.tsmiFile.Text = "Файл";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(192, 26);
            this.tsmiOpen.Text = "Открыть";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(192, 26);
            this.tsmiSave.Text = "Сохранить";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiSaveas
            // 
            this.tsmiSaveas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.tsmiSaveas.Name = "tsmiSaveas";
            this.tsmiSaveas.Size = new System.Drawing.Size(192, 26);
            this.tsmiSaveas.Text = "Сохранить как";
            this.tsmiSaveas.Click += new System.EventHandler(this.tsmiSaveas_Click);
            // 
            // tsmiPrint
            // 
            this.tsmiPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.tsmiPrint.Name = "tsmiPrint";
            this.tsmiPrint.Size = new System.Drawing.Size(192, 26);
            this.tsmiPrint.Text = "Печать";
            this.tsmiPrint.Click += new System.EventHandler(this.tsmiPrint_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(192, 26);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSelectall,
            this.tsmiCopy,
            this.tsmiPaste,
            this.tsmiCut,
            this.tsmiClean});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(74, 24);
            this.tsmiEdit.Text = "Правка";
            // 
            // tsmiCut
            // 
            this.tsmiCut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.Size = new System.Drawing.Size(224, 26);
            this.tsmiCut.Text = "Вырезать";
            this.tsmiCut.Click += new System.EventHandler(this.tsmiCut_Click);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(224, 26);
            this.tsmiCopy.Text = "Копировать";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.Size = new System.Drawing.Size(224, 26);
            this.tsmiPaste.Text = "Вставить";
            this.tsmiPaste.Click += new System.EventHandler(this.tsmiPaste_Click);
            // 
            // tsmiClean
            // 
            this.tsmiClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.tsmiClean.Name = "tsmiClean";
            this.tsmiClean.Size = new System.Drawing.Size(224, 26);
            this.tsmiClean.Text = "Очистить";
            this.tsmiClean.Click += new System.EventHandler(this.tsmiClean_Click);
            // 
            // tsmiSelectall
            // 
            this.tsmiSelectall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.tsmiSelectall.Name = "tsmiSelectall";
            this.tsmiSelectall.Size = new System.Drawing.Size(224, 26);
            this.tsmiSelectall.Text = "Выделить всё";
            this.tsmiSelectall.Click += new System.EventHandler(this.tsmiSelectall_Click);
            // 
            // tsmiFormat
            // 
            this.tsmiFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFont,
            this.tsmiColor,
            this.tsmiColorback});
            this.tsmiFormat.Name = "tsmiFormat";
            this.tsmiFormat.Size = new System.Drawing.Size(77, 24);
            this.tsmiFormat.Text = "Формат";
            // 
            // tsmiFont
            // 
            this.tsmiFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.tsmiFont.Name = "tsmiFont";
            this.tsmiFont.Size = new System.Drawing.Size(171, 26);
            this.tsmiFont.Text = "Шрифт";
            this.tsmiFont.Click += new System.EventHandler(this.tsmiFont_Click);
            // 
            // tsmiColor
            // 
            this.tsmiColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.tsmiColor.Name = "tsmiColor";
            this.tsmiColor.Size = new System.Drawing.Size(171, 26);
            this.tsmiColor.Text = "Цвет текста";
            this.tsmiColor.Click += new System.EventHandler(this.tsmiColor_Click);
            // 
            // tsmiColorback
            // 
            this.tsmiColorback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.tsmiColorback.Name = "tsmiColorback";
            this.tsmiColorback.Size = new System.Drawing.Size(171, 26);
            this.tsmiColorback.Text = "Цвет фона";
            this.tsmiColorback.Click += new System.EventHandler(this.tsmiColorback_Click);
            // 
            // tsmiReference
            // 
            this.tsmiReference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelp,
            this.tsmiAboutprogramm});
            this.tsmiReference.Name = "tsmiReference";
            this.tsmiReference.Size = new System.Drawing.Size(81, 24);
            this.tsmiReference.Text = "Справка";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(187, 26);
            this.tsmiHelp.Text = "Помощь";
            this.tsmiHelp.Click += new System.EventHandler(this.tsmiHelp_Click);
            // 
            // tsmiAboutprogramm
            // 
            this.tsmiAboutprogramm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.tsmiAboutprogramm.Name = "tsmiAboutprogramm";
            this.tsmiAboutprogramm.Size = new System.Drawing.Size(187, 26);
            this.tsmiAboutprogramm.Text = "О программе";
            this.tsmiAboutprogramm.Click += new System.EventHandler(this.tsmiAboutprogramm_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // bheip
            // 
            this.bheip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bheip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(230)))), ((int)(((byte)(195)))));
            this.bheip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(64)))), ((int)(((byte)(54)))));
            this.bheip.FlatAppearance.BorderSize = 145;
            this.bheip.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(191)))), ((int)(((byte)(163)))));
            this.bheip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bheip.Location = new System.Drawing.Point(582, 43);
            this.bheip.Name = "bheip";
            this.bheip.Size = new System.Drawing.Size(153, 41);
            this.bheip.TabIndex = 11;
            this.bheip.Text = "Помощь";
            this.bheip.UseVisualStyleBackColor = false;
            this.bheip.Click += new System.EventHandler(this.bhelp_Click);
            // 
            // gbparameters
            // 
            this.gbparameters.Controls.Add(this.cbcross_out);
            this.gbparameters.Controls.Add(this.cbplus_or_minus);
            this.gbparameters.Controls.Add(this.cbquotion_marks);
            this.gbparameters.Controls.Add(this.cbreplace_the_letter);
            this.gbparameters.Controls.Add(this.cbwhitespace);
            this.gbparameters.Location = new System.Drawing.Point(241, 188);
            this.gbparameters.Name = "gbparameters";
            this.gbparameters.Size = new System.Drawing.Size(301, 162);
            this.gbparameters.TabIndex = 22;
            this.gbparameters.TabStop = false;
            this.gbparameters.Text = "Параметры";
            this.gbparameters.Visible = false;
            // 
            // cbcross_out
            // 
            this.cbcross_out.AutoSize = true;
            this.cbcross_out.Location = new System.Drawing.Point(6, 102);
            this.cbcross_out.Name = "cbcross_out";
            this.cbcross_out.Size = new System.Drawing.Size(184, 21);
            this.cbcross_out.TabIndex = 5;
            this.cbcross_out.Text = "Зачёркнутые «z» и «v»";
            this.cbcross_out.UseVisualStyleBackColor = true;
            // 
            // cbplus_or_minus
            // 
            this.cbplus_or_minus.AutoSize = true;
            this.cbplus_or_minus.Location = new System.Drawing.Point(6, 75);
            this.cbplus_or_minus.Name = "cbplus_or_minus";
            this.cbplus_or_minus.Size = new System.Drawing.Size(91, 21);
            this.cbplus_or_minus.TabIndex = 3;
            this.cbplus_or_minus.Text = "Символ ±";
            this.cbplus_or_minus.UseVisualStyleBackColor = true;
            // 
            // cbquotion_marks
            // 
            this.cbquotion_marks.AutoSize = true;
            this.cbquotion_marks.Location = new System.Drawing.Point(6, 48);
            this.cbquotion_marks.Name = "cbquotion_marks";
            this.cbquotion_marks.Size = new System.Drawing.Size(226, 21);
            this.cbquotion_marks.TabIndex = 2;
            this.cbquotion_marks.Text = "Кавычки «Ёлочки» и „Лапки“ ";
            this.cbquotion_marks.UseVisualStyleBackColor = true;
            // 
            // cbreplace_the_letter
            // 
            this.cbreplace_the_letter.AutoSize = true;
            this.cbreplace_the_letter.Location = new System.Drawing.Point(6, 129);
            this.cbreplace_the_letter.Name = "cbreplace_the_letter";
            this.cbreplace_the_letter.Size = new System.Drawing.Size(49, 21);
            this.cbreplace_the_letter.TabIndex = 6;
            this.cbreplace_the_letter.Text = "«i»";
            this.cbreplace_the_letter.UseVisualStyleBackColor = true;
            // 
            // cbwhitespace
            // 
            this.cbwhitespace.AutoSize = true;
            this.cbwhitespace.Location = new System.Drawing.Point(6, 21);
            this.cbwhitespace.Name = "cbwhitespace";
            this.cbwhitespace.Size = new System.Drawing.Size(117, 21);
            this.cbwhitespace.TabIndex = 0;
            this.cbwhitespace.Text = "Один пробел";
            this.cbwhitespace.UseVisualStyleBackColor = true;
            // 
            // Typographer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(933, 486);
            this.Controls.Add(this.bheip);
            this.Controls.Add(this.bopen);
            this.Controls.Add(this.bparameters);
            this.Controls.Add(this.bexample);
            this.Controls.Add(this.bclear);
            this.Controls.Add(this.bprinting);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbparameters);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Typographer";
            this.Text = "Типограф";
            this.Load += new System.EventHandler(this.Typographer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbparameters.ResumeLayout(false);
            this.gbparameters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bprinting;
        private System.Windows.Forms.Button bclear;
        private System.Windows.Forms.Button bexample;
        public System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Button bparameters;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bopen;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveas;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrint;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiClean;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectall;
        private System.Windows.Forms.ToolStripMenuItem tsmiFormat;
        private System.Windows.Forms.ToolStripMenuItem tsmiFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiColorback;
        private System.Windows.Forms.ToolStripMenuItem tsmiReference;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAboutprogramm;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button bheip;
        private System.Windows.Forms.GroupBox gbparameters;
        public System.Windows.Forms.CheckBox cbcross_out;
        public System.Windows.Forms.CheckBox cbplus_or_minus;
        public System.Windows.Forms.CheckBox cbquotion_marks;
        public System.Windows.Forms.CheckBox cbreplace_the_letter;
        public System.Windows.Forms.CheckBox cbwhitespace;
    }
}

