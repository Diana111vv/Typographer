
namespace Test_Типограф_
{
    partial class Edited_text
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbeditedtext = new System.Windows.Forms.RichTextBox();
            this.bclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbeditedtext
            // 
            this.rtbeditedtext.Location = new System.Drawing.Point(28, 32);
            this.rtbeditedtext.Name = "rtbeditedtext";
            this.rtbeditedtext.ReadOnly = true;
            this.rtbeditedtext.Size = new System.Drawing.Size(741, 337);
            this.rtbeditedtext.TabIndex = 0;
            this.rtbeditedtext.Text = "";
            // 
            // bclear
            // 
            this.bclear.Location = new System.Drawing.Point(28, 385);
            this.bclear.Name = "bclear";
            this.bclear.Size = new System.Drawing.Size(138, 41);
            this.bclear.TabIndex = 3;
            this.bclear.Text = "Очистить";
            this.bclear.UseVisualStyleBackColor = true;
            this.bclear.Click += new System.EventHandler(this.bclear_Click);
            // 
            // Edited_text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bclear);
            this.Controls.Add(this.rtbeditedtext);
            this.Name = "Edited_text";
            this.Text = "Edited_text";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bclear;
        public System.Windows.Forms.RichTextBox rtbeditedtext;
    }
}