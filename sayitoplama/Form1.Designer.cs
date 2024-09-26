namespace sayitoplama
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelsayi1 = new System.Windows.Forms.Label();
            this.labelsayi2 = new System.Windows.Forms.Label();
            this.labelSonuc = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonToplama = new System.Windows.Forms.Button();
            this.buttonCikarma = new System.Windows.Forms.Button();
            this.buttonBolme = new System.Windows.Forms.Button();
            this.buttonCarpma = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.matNetValue = new System.Windows.Forms.Label();
            this.matdvalue = new System.Windows.Forms.TextBox();
            this.fenNetValue = new System.Windows.Forms.Label();
            this.nethesaplabutton = new System.Windows.Forms.Button();
            this.netclbutton = new System.Windows.Forms.Button();
            this.matyvalue = new System.Windows.Forms.TextBox();
            this.fenyvalue = new System.Windows.Forms.TextBox();
            this.fendvalue = new System.Windows.Forms.TextBox();
            this.labelnet = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.bosvalue = new System.Windows.Forms.Label();
            this.buttonKare = new System.Windows.Forms.Button();
            this.buttonKareKok = new System.Windows.Forms.Button();
            this.netBosBasic = new System.Windows.Forms.Label();
            this.matbosText = new System.Windows.Forms.TextBox();
            this.fenbosText = new System.Windows.Forms.TextBox();
            this.puanText = new System.Windows.Forms.Label();
            this.faktButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 160);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(118, 116);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 29);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelsayi1
            // 
            this.labelsayi1.AutoSize = true;
            this.labelsayi1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsayi1.Location = new System.Drawing.Point(50, 116);
            this.labelsayi1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelsayi1.Name = "labelsayi1";
            this.labelsayi1.Size = new System.Drawing.Size(58, 22);
            this.labelsayi1.TabIndex = 4;
            this.labelsayi1.Text = "Sayı 1";
            this.labelsayi1.Click += new System.EventHandler(this.labelsayi1_Click);
            // 
            // labelsayi2
            // 
            this.labelsayi2.AutoSize = true;
            this.labelsayi2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsayi2.Location = new System.Drawing.Point(50, 167);
            this.labelsayi2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelsayi2.Name = "labelsayi2";
            this.labelsayi2.Size = new System.Drawing.Size(58, 22);
            this.labelsayi2.TabIndex = 5;
            this.labelsayi2.Text = "Sayı 2";
            this.labelsayi2.Click += new System.EventHandler(this.labelsayi2_Click);
            // 
            // labelSonuc
            // 
            this.labelSonuc.AutoSize = true;
            this.labelSonuc.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSonuc.Location = new System.Drawing.Point(50, 240);
            this.labelSonuc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSonuc.Name = "labelSonuc";
            this.labelSonuc.Size = new System.Drawing.Size(69, 22);
            this.labelSonuc.TabIndex = 6;
            this.labelSonuc.Text = "Sonuç :";
            this.labelSonuc.Click += new System.EventHandler(this.labelSonuc_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(292, 272);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(5);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(89, 29);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Temizle";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonToplama
            // 
            this.buttonToplama.Location = new System.Drawing.Point(292, 116);
            this.buttonToplama.Margin = new System.Windows.Forms.Padding(5);
            this.buttonToplama.Name = "buttonToplama";
            this.buttonToplama.Size = new System.Drawing.Size(89, 29);
            this.buttonToplama.TabIndex = 8;
            this.buttonToplama.Text = "+";
            this.buttonToplama.UseVisualStyleBackColor = true;
            this.buttonToplama.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCikarma
            // 
            this.buttonCikarma.Location = new System.Drawing.Point(292, 155);
            this.buttonCikarma.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCikarma.Name = "buttonCikarma";
            this.buttonCikarma.Size = new System.Drawing.Size(89, 29);
            this.buttonCikarma.TabIndex = 9;
            this.buttonCikarma.Text = "-";
            this.buttonCikarma.UseVisualStyleBackColor = true;
            this.buttonCikarma.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonBolme
            // 
            this.buttonBolme.Location = new System.Drawing.Point(292, 194);
            this.buttonBolme.Margin = new System.Windows.Forms.Padding(5);
            this.buttonBolme.Name = "buttonBolme";
            this.buttonBolme.Size = new System.Drawing.Size(89, 29);
            this.buttonBolme.TabIndex = 10;
            this.buttonBolme.Text = "%";
            this.buttonBolme.UseVisualStyleBackColor = true;
            this.buttonBolme.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonCarpma
            // 
            this.buttonCarpma.Location = new System.Drawing.Point(292, 233);
            this.buttonCarpma.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCarpma.Name = "buttonCarpma";
            this.buttonCarpma.Size = new System.Drawing.Size(89, 29);
            this.buttonCarpma.TabIndex = 11;
            this.buttonCarpma.Text = "x";
            this.buttonCarpma.UseVisualStyleBackColor = true;
            this.buttonCarpma.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 272);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.faktButton);
            this.groupBox1.Controls.Add(this.buttonKareKok);
            this.groupBox1.Controls.Add(this.buttonKare);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.labelsayi1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.buttonCarpma);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.buttonBolme);
            this.groupBox1.Controls.Add(this.labelsayi2);
            this.groupBox1.Controls.Add(this.buttonCikarma);
            this.groupBox1.Controls.Add(this.labelSonuc);
            this.groupBox1.Controls.Add(this.buttonToplama);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Location = new System.Drawing.Point(44, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 364);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gizli Hesap Makinesi";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(131, 66);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 17);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.puanText);
            this.groupBox2.Controls.Add(this.fenbosText);
            this.groupBox2.Controls.Add(this.matbosText);
            this.groupBox2.Controls.Add(this.netBosBasic);
            this.groupBox2.Controls.Add(this.bosvalue);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.labelnet);
            this.groupBox2.Controls.Add(this.fenyvalue);
            this.groupBox2.Controls.Add(this.fendvalue);
            this.groupBox2.Controls.Add(this.matyvalue);
            this.groupBox2.Controls.Add(this.netclbutton);
            this.groupBox2.Controls.Add(this.nethesaplabutton);
            this.groupBox2.Controls.Add(this.fenNetValue);
            this.groupBox2.Controls.Add(this.matNetValue);
            this.groupBox2.Controls.Add(this.matdvalue);
            this.groupBox2.Location = new System.Drawing.Point(546, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 327);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Puan/Net Hesaplama";
            this.groupBox2.Visible = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // matNetValue
            // 
            this.matNetValue.AutoSize = true;
            this.matNetValue.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matNetValue.Location = new System.Drawing.Point(20, 85);
            this.matNetValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.matNetValue.Name = "matNetValue";
            this.matNetValue.Size = new System.Drawing.Size(149, 22);
            this.matNetValue.TabIndex = 8;
            this.matNetValue.Text = "Mat D / Y Sayısı :";
            this.matNetValue.Click += new System.EventHandler(this.label1_Click);
            // 
            // matdvalue
            // 
            this.matdvalue.Location = new System.Drawing.Point(168, 82);
            this.matdvalue.Margin = new System.Windows.Forms.Padding(5);
            this.matdvalue.Name = "matdvalue";
            this.matdvalue.Size = new System.Drawing.Size(68, 29);
            this.matdvalue.TabIndex = 7;
            this.matdvalue.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // fenNetValue
            // 
            this.fenNetValue.AutoSize = true;
            this.fenNetValue.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fenNetValue.Location = new System.Drawing.Point(20, 136);
            this.fenNetValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.fenNetValue.Name = "fenNetValue";
            this.fenNetValue.Size = new System.Drawing.Size(145, 22);
            this.fenNetValue.TabIndex = 10;
            this.fenNetValue.Text = "Fen D / Y Sayısı :";
            this.fenNetValue.Click += new System.EventHandler(this.fenNetValue_Click);
            // 
            // nethesaplabutton
            // 
            this.nethesaplabutton.Location = new System.Drawing.Point(24, 186);
            this.nethesaplabutton.Margin = new System.Windows.Forms.Padding(5);
            this.nethesaplabutton.Name = "nethesaplabutton";
            this.nethesaplabutton.Size = new System.Drawing.Size(89, 29);
            this.nethesaplabutton.TabIndex = 14;
            this.nethesaplabutton.Text = "Hesapla";
            this.nethesaplabutton.UseVisualStyleBackColor = true;
            this.nethesaplabutton.Click += new System.EventHandler(this.nethesaplabutton_Click);
            // 
            // netclbutton
            // 
            this.netclbutton.Location = new System.Drawing.Point(123, 186);
            this.netclbutton.Margin = new System.Windows.Forms.Padding(5);
            this.netclbutton.Name = "netclbutton";
            this.netclbutton.Size = new System.Drawing.Size(89, 29);
            this.netclbutton.TabIndex = 14;
            this.netclbutton.Text = "Temizle";
            this.netclbutton.UseVisualStyleBackColor = true;
            this.netclbutton.Click += new System.EventHandler(this.netclbutton_Click);
            // 
            // matyvalue
            // 
            this.matyvalue.Location = new System.Drawing.Point(246, 82);
            this.matyvalue.Margin = new System.Windows.Forms.Padding(5);
            this.matyvalue.Name = "matyvalue";
            this.matyvalue.Size = new System.Drawing.Size(68, 29);
            this.matyvalue.TabIndex = 15;
            this.matyvalue.TextChanged += new System.EventHandler(this.matyvalue_TextChanged);
            // 
            // fenyvalue
            // 
            this.fenyvalue.Location = new System.Drawing.Point(246, 133);
            this.fenyvalue.Margin = new System.Windows.Forms.Padding(5);
            this.fenyvalue.Name = "fenyvalue";
            this.fenyvalue.Size = new System.Drawing.Size(68, 29);
            this.fenyvalue.TabIndex = 17;
            this.fenyvalue.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // fendvalue
            // 
            this.fendvalue.Location = new System.Drawing.Point(168, 133);
            this.fendvalue.Margin = new System.Windows.Forms.Padding(5);
            this.fendvalue.Name = "fendvalue";
            this.fendvalue.Size = new System.Drawing.Size(68, 29);
            this.fendvalue.TabIndex = 16;
            this.fendvalue.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // labelnet
            // 
            this.labelnet.AutoSize = true;
            this.labelnet.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnet.Location = new System.Drawing.Point(222, 189);
            this.labelnet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelnet.Name = "labelnet";
            this.labelnet.Size = new System.Drawing.Size(101, 22);
            this.labelnet.TabIndex = 14;
            this.labelnet.Text = "Net Sayısı :";
            this.labelnet.Click += new System.EventHandler(this.labelnet_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(337, 20);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 29);
            this.button3.TabIndex = 18;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // bosvalue
            // 
            this.bosvalue.AutoSize = true;
            this.bosvalue.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bosvalue.Location = new System.Drawing.Point(155, 220);
            this.bosvalue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.bosvalue.Name = "bosvalue";
            this.bosvalue.Size = new System.Drawing.Size(168, 22);
            this.bosvalue.TabIndex = 19;
            this.bosvalue.Text = "Toplam Boş Sayısı :";
            this.bosvalue.Click += new System.EventHandler(this.bosvalue_Click);
            // 
            // buttonKare
            // 
            this.buttonKare.Location = new System.Drawing.Point(292, 77);
            this.buttonKare.Margin = new System.Windows.Forms.Padding(5);
            this.buttonKare.Name = "buttonKare";
            this.buttonKare.Size = new System.Drawing.Size(89, 29);
            this.buttonKare.TabIndex = 14;
            this.buttonKare.Text = "karekök";
            this.buttonKare.UseVisualStyleBackColor = true;
            this.buttonKare.Click += new System.EventHandler(this.buttonKare_Click);
            // 
            // buttonKareKok
            // 
            this.buttonKareKok.Location = new System.Drawing.Point(193, 77);
            this.buttonKareKok.Margin = new System.Windows.Forms.Padding(5);
            this.buttonKareKok.Name = "buttonKareKok";
            this.buttonKareKok.Size = new System.Drawing.Size(89, 29);
            this.buttonKareKok.TabIndex = 15;
            this.buttonKareKok.Text = "kare";
            this.buttonKareKok.UseVisualStyleBackColor = true;
            this.buttonKareKok.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // netBosBasic
            // 
            this.netBosBasic.AutoSize = true;
            this.netBosBasic.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netBosBasic.Location = new System.Drawing.Point(322, 54);
            this.netBosBasic.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.netBosBasic.Name = "netBosBasic";
            this.netBosBasic.Size = new System.Drawing.Size(104, 22);
            this.netBosBasic.TabIndex = 20;
            this.netBosBasic.Text = "Boş Sayıları";
            this.netBosBasic.Visible = false;
            // 
            // matbosText
            // 
            this.matbosText.Enabled = false;
            this.matbosText.Location = new System.Drawing.Point(337, 82);
            this.matbosText.Margin = new System.Windows.Forms.Padding(5);
            this.matbosText.Name = "matbosText";
            this.matbosText.Size = new System.Drawing.Size(68, 29);
            this.matbosText.TabIndex = 21;
            this.matbosText.Visible = false;
            this.matbosText.TextChanged += new System.EventHandler(this.matbosText_TextChanged);
            // 
            // fenbosText
            // 
            this.fenbosText.Enabled = false;
            this.fenbosText.Location = new System.Drawing.Point(337, 133);
            this.fenbosText.Margin = new System.Windows.Forms.Padding(5);
            this.fenbosText.Name = "fenbosText";
            this.fenbosText.Size = new System.Drawing.Size(68, 29);
            this.fenbosText.TabIndex = 22;
            this.fenbosText.Visible = false;
            this.fenbosText.TextChanged += new System.EventHandler(this.fenbosText_TextChanged);
            // 
            // puanText
            // 
            this.puanText.AutoSize = true;
            this.puanText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puanText.Location = new System.Drawing.Point(263, 251);
            this.puanText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.puanText.Name = "puanText";
            this.puanText.Size = new System.Drawing.Size(60, 22);
            this.puanText.TabIndex = 23;
            this.puanText.Text = "Puan :";
            this.puanText.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // faktButton
            // 
            this.faktButton.Location = new System.Drawing.Point(54, 77);
            this.faktButton.Margin = new System.Windows.Forms.Padding(5);
            this.faktButton.Name = "faktButton";
            this.faktButton.Size = new System.Drawing.Size(129, 29);
            this.faktButton.TabIndex = 16;
            this.faktButton.Text = "faktöriyel";
            this.faktButton.UseVisualStyleBackColor = true;
            this.faktButton.Click += new System.EventHandler(this.faktButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 762);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelsayi1;
        private System.Windows.Forms.Label labelsayi2;
        private System.Windows.Forms.Label labelSonuc;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonToplama;
        private System.Windows.Forms.Button buttonCikarma;
        private System.Windows.Forms.Button buttonBolme;
        private System.Windows.Forms.Button buttonCarpma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label matNetValue;
        private System.Windows.Forms.TextBox matdvalue;
        private System.Windows.Forms.Label fenNetValue;
        private System.Windows.Forms.Button netclbutton;
        private System.Windows.Forms.Button nethesaplabutton;
        private System.Windows.Forms.TextBox matyvalue;
        private System.Windows.Forms.TextBox fenyvalue;
        private System.Windows.Forms.TextBox fendvalue;
        private System.Windows.Forms.Label labelnet;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label bosvalue;
        private System.Windows.Forms.Button buttonKare;
        private System.Windows.Forms.Button buttonKareKok;
        private System.Windows.Forms.Label netBosBasic;
        private System.Windows.Forms.TextBox fenbosText;
        private System.Windows.Forms.TextBox matbosText;
        private System.Windows.Forms.Label puanText;
        private System.Windows.Forms.Button faktButton;
    }
}

