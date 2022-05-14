
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
            this.bselectall = new System.Windows.Forms.Button();
            this.bclear = new System.Windows.Forms.Button();
            this.bexample = new System.Windows.Forms.Button();
            this.bhelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbText
            // 
            this.rtbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbText.Location = new System.Drawing.Point(58, 72);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(671, 262);
            this.rtbText.TabIndex = 0;
            this.rtbText.Text = "";
            // 
            // bprinting
            // 
            this.bprinting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bprinting.Location = new System.Drawing.Point(58, 354);
            this.bprinting.Name = "bprinting";
            this.bprinting.Size = new System.Drawing.Size(153, 41);
            this.bprinting.TabIndex = 1;
            this.bprinting.Text = "Типографировать";
            this.bprinting.UseVisualStyleBackColor = true;
            this.bprinting.Click += new System.EventHandler(this.bprinting_Click);
            // 
            // bselectall
            // 
            this.bselectall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bselectall.Location = new System.Drawing.Point(217, 354);
            this.bselectall.Name = "bselectall";
            this.bselectall.Size = new System.Drawing.Size(153, 41);
            this.bselectall.TabIndex = 2;
            this.bselectall.Text = "Выделить всё";
            this.bselectall.UseVisualStyleBackColor = true;
            this.bselectall.Click += new System.EventHandler(this.bselectall_Click);
            // 
            // bclear
            // 
            this.bclear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bclear.Location = new System.Drawing.Point(376, 354);
            this.bclear.Name = "bclear";
            this.bclear.Size = new System.Drawing.Size(153, 41);
            this.bclear.TabIndex = 3;
            this.bclear.Text = "Очистить";
            this.bclear.UseVisualStyleBackColor = true;
            this.bclear.Click += new System.EventHandler(this.bclear_Click);
            // 
            // bexample
            // 
            this.bexample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bexample.Location = new System.Drawing.Point(576, 354);
            this.bexample.Name = "bexample";
            this.bexample.Size = new System.Drawing.Size(153, 41);
            this.bexample.TabIndex = 4;
            this.bexample.Text = "Пример";
            this.bexample.UseVisualStyleBackColor = true;
            // 
            // bhelp
            // 
            this.bhelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bhelp.Location = new System.Drawing.Point(576, 12);
            this.bhelp.Name = "bhelp";
            this.bhelp.Size = new System.Drawing.Size(153, 41);
            this.bhelp.TabIndex = 5;
            this.bhelp.Text = "Помощь";
            this.bhelp.UseVisualStyleBackColor = true;
            this.bhelp.Click += new System.EventHandler(this.bhelp_Click);
            // 
            // Typographer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bhelp);
            this.Controls.Add(this.bexample);
            this.Controls.Add(this.bclear);
            this.Controls.Add(this.bselectall);
            this.Controls.Add(this.bprinting);
            this.Controls.Add(this.rtbText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Typographer";
            this.Text = "Типограф";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bprinting;
        private System.Windows.Forms.Button bselectall;
        private System.Windows.Forms.Button bclear;
        private System.Windows.Forms.Button bexample;
        private System.Windows.Forms.Button bhelp;
        public System.Windows.Forms.RichTextBox rtbText;
    }
}

