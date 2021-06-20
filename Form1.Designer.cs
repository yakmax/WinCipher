
namespace WinCipher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox05 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox04 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox01 = new System.Windows.Forms.TextBox();
            this.textBox03 = new System.Windows.Forms.TextBox();
            this.textBox02 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox05);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox04);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox01);
            this.panel1.Controls.Add(this.textBox03);
            this.panel1.Controls.Add(this.textBox02);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 476);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Проверка на расшифровку";
            // 
            // textBox05
            // 
            this.textBox05.Location = new System.Drawing.Point(12, 393);
            this.textBox05.Multiline = true;
            this.textBox05.Name = "textBox05";
            this.textBox05.ReadOnly = true;
            this.textBox05.Size = new System.Drawing.Size(700, 70);
            this.textBox05.TabIndex = 5;
            this.textBox05.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Шифр";
            // 
            // textBox04
            // 
            this.textBox04.Location = new System.Drawing.Point(13, 299);
            this.textBox04.Multiline = true;
            this.textBox04.Name = "textBox04";
            this.textBox04.ReadOnly = true;
            this.textBox04.Size = new System.Drawing.Size(700, 70);
            this.textBox04.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Кодировка текста";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Текст";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ключ (будет повторятся если короткий)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox01
            // 
            this.textBox01.Location = new System.Drawing.Point(12, 27);
            this.textBox01.Multiline = true;
            this.textBox01.Name = "textBox01";
            this.textBox01.Size = new System.Drawing.Size(700, 70);
            this.textBox01.TabIndex = 1;
            this.textBox01.TextChanged += new System.EventHandler(this.textBox01_TextChanged);
            // 
            // textBox03
            // 
            this.textBox03.Location = new System.Drawing.Point(12, 208);
            this.textBox03.Multiline = true;
            this.textBox03.Name = "textBox03";
            this.textBox03.ReadOnly = true;
            this.textBox03.Size = new System.Drawing.Size(700, 70);
            this.textBox03.TabIndex = 3;
            this.textBox03.TextChanged += new System.EventHandler(this.textBox03_TextChanged);
            // 
            // textBox02
            // 
            this.textBox02.Location = new System.Drawing.Point(12, 118);
            this.textBox02.Multiline = true;
            this.textBox02.Name = "textBox02";
            this.textBox02.Size = new System.Drawing.Size(700, 70);
            this.textBox02.TabIndex = 2;
            this.textBox02.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 476);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Шифрование гаммированием";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox02;
        //private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox03;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox01;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox05;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox04;
        private System.Windows.Forms.Label label3;
    }
}

