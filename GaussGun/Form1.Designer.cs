
namespace GaussGun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxVolt = new System.Windows.Forms.TextBox();
            this.Volt_name = new System.Windows.Forms.Label();
            this.Volt_teg = new System.Windows.Forms.Label();
            this.N_block_name = new System.Windows.Forms.Label();
            this.L_solinoid_name = new System.Windows.Forms.Label();
            this.textBoxLongSolinoid = new System.Windows.Forms.TextBox();
            this.Long_solinoid_tag = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxD_b = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxD_solinoid_small = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDGun = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDpF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxCondens = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSpeed0 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxListStart1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxListStop1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxListStep1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxListStart2 = new System.Windows.Forms.TextBox();
            this.textBoxListStop2 = new System.Windows.Forms.TextBox();
            this.textBoxListStep2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxGraf = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraf)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(960, 607);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxVolt
            // 
            this.textBoxVolt.Location = new System.Drawing.Point(404, 21);
            this.textBoxVolt.Name = "textBoxVolt";
            this.textBoxVolt.Size = new System.Drawing.Size(42, 23);
            this.textBoxVolt.TabIndex = 1;
            this.textBoxVolt.Text = "5";
            this.textBoxVolt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Volt_name
            // 
            this.Volt_name.AutoSize = true;
            this.Volt_name.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Volt_name.Location = new System.Drawing.Point(273, 32);
            this.Volt_name.Name = "Volt_name";
            this.Volt_name.Size = new System.Drawing.Size(77, 15);
            this.Volt_name.TabIndex = 2;
            this.Volt_name.Text = "Напряжение";
            this.Volt_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // Volt_teg
            // 
            this.Volt_teg.AutoSize = true;
            this.Volt_teg.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Volt_teg.Location = new System.Drawing.Point(452, 29);
            this.Volt_teg.Name = "Volt_teg";
            this.Volt_teg.Size = new System.Drawing.Size(14, 15);
            this.Volt_teg.TabIndex = 3;
            this.Volt_teg.Text = "V";
            this.Volt_teg.Click += new System.EventHandler(this.label2_Click);
            // 
            // N_block_name
            // 
            this.N_block_name.AutoSize = true;
            this.N_block_name.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.N_block_name.Location = new System.Drawing.Point(749, 29);
            this.N_block_name.Name = "N_block_name";
            this.N_block_name.Size = new System.Drawing.Size(167, 15);
            this.N_block_name.TabIndex = 10;
            this.N_block_name.Text = "Начальная скорость снаряда";
            this.N_block_name.Click += new System.EventHandler(this.N_block_name_Click);
            // 
            // L_solinoid_name
            // 
            this.L_solinoid_name.AutoSize = true;
            this.L_solinoid_name.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.L_solinoid_name.Location = new System.Drawing.Point(273, 71);
            this.L_solinoid_name.Name = "L_solinoid_name";
            this.L_solinoid_name.Size = new System.Drawing.Size(97, 15);
            this.L_solinoid_name.TabIndex = 12;
            this.L_solinoid_name.Text = "длинна катушки";
            // 
            // textBoxLongSolinoid
            // 
            this.textBoxLongSolinoid.Location = new System.Drawing.Point(404, 65);
            this.textBoxLongSolinoid.Name = "textBoxLongSolinoid";
            this.textBoxLongSolinoid.Size = new System.Drawing.Size(42, 23);
            this.textBoxLongSolinoid.TabIndex = 13;
            this.textBoxLongSolinoid.Text = "40";
            // 
            // Long_solinoid_tag
            // 
            this.Long_solinoid_tag.AutoSize = true;
            this.Long_solinoid_tag.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Long_solinoid_tag.Location = new System.Drawing.Point(452, 68);
            this.Long_solinoid_tag.Name = "Long_solinoid_tag";
            this.Long_solinoid_tag.Size = new System.Drawing.Size(25, 15);
            this.Long_solinoid_tag.TabIndex = 14;
            this.Long_solinoid_tag.Text = "мм";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(491, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "диаметр катушки внешн";
            // 
            // textBoxD_b
            // 
            this.textBoxD_b.Location = new System.Drawing.Point(636, 65);
            this.textBoxD_b.Name = "textBoxD_b";
            this.textBoxD_b.Size = new System.Drawing.Size(42, 23);
            this.textBoxD_b.TabIndex = 16;
            this.textBoxD_b.Text = "80";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(688, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "мм";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(752, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "диаметр катушки внутреннй";
            // 
            // textBoxD_solinoid_small
            // 
            this.textBoxD_solinoid_small.Location = new System.Drawing.Point(931, 65);
            this.textBoxD_solinoid_small.Name = "textBoxD_solinoid_small";
            this.textBoxD_solinoid_small.Size = new System.Drawing.Size(33, 23);
            this.textBoxD_solinoid_small.TabIndex = 19;
            this.textBoxD_solinoid_small.Text = "8";
            this.textBoxD_solinoid_small.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(970, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "мм";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(970, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "мм";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(754, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Диаметр ствола и снаряда";
            // 
            // textBoxDGun
            // 
            this.textBoxDGun.Location = new System.Drawing.Point(931, 100);
            this.textBoxDGun.Name = "textBoxDGun";
            this.textBoxDGun.Size = new System.Drawing.Size(30, 23);
            this.textBoxDGun.TabIndex = 23;
            this.textBoxDGun.Text = "6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(273, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ф провода";
            // 
            // textBoxDp
            // 
            this.textBoxDp.Location = new System.Drawing.Point(404, 105);
            this.textBoxDp.Name = "textBoxDp";
            this.textBoxDp.Size = new System.Drawing.Size(42, 23);
            this.textBoxDp.TabIndex = 25;
            this.textBoxDp.Text = "1";
            this.textBoxDp.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(452, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "мм";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(491, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "толщина изоляции";
            // 
            // textBoxDpF
            // 
            this.textBoxDpF.Location = new System.Drawing.Point(636, 102);
            this.textBoxDpF.Name = "textBoxDpF";
            this.textBoxDpF.Size = new System.Drawing.Size(42, 23);
            this.textBoxDpF.TabIndex = 28;
            this.textBoxDpF.Text = "0,1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(687, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "мм";
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(608, 348);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.Size = new System.Drawing.Size(439, 228);
            this.textBoxOut.TabIndex = 37;
            this.textBoxOut.Text = "1";
            this.textBoxOut.TextChanged += new System.EventHandler(this.textBoxOut_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(493, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 15);
            this.label11.TabIndex = 38;
            this.label11.Text = "конденсаторы";
            // 
            // textBoxCondens
            // 
            this.textBoxCondens.Location = new System.Drawing.Point(584, 21);
            this.textBoxCondens.Name = "textBoxCondens";
            this.textBoxCondens.Size = new System.Drawing.Size(127, 23);
            this.textBoxCondens.TabIndex = 39;
            this.textBoxCondens.Text = "0,00005";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(717, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 15);
            this.label12.TabIndex = 40;
            this.label12.Text = "F";
            // 
            // textBoxSpeed0
            // 
            this.textBoxSpeed0.Location = new System.Drawing.Point(931, 21);
            this.textBoxSpeed0.Name = "textBoxSpeed0";
            this.textBoxSpeed0.Size = new System.Drawing.Size(66, 23);
            this.textBoxSpeed0.TabIndex = 41;
            this.textBoxSpeed0.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(1022, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 15);
            this.label13.TabIndex = 42;
            this.label13.Text = "м/c";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButton1.Location = new System.Drawing.Point(608, 250);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 19);
            this.radioButton1.TabIndex = 43;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Одиночный";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButton2.Location = new System.Drawing.Point(608, 290);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 19);
            this.radioButton2.TabIndex = 44;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Комплекс";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label16.Location = new System.Drawing.Point(273, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 15);
            this.label16.TabIndex = 47;
            this.label16.Text = "Начальное значение 1";
            // 
            // textBoxListStart1
            // 
            this.textBoxListStart1.Location = new System.Drawing.Point(404, 148);
            this.textBoxListStart1.Name = "textBoxListStart1";
            this.textBoxListStart1.Size = new System.Drawing.Size(83, 23);
            this.textBoxListStart1.TabIndex = 48;
            this.textBoxListStart1.Text = "1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label17.Location = new System.Drawing.Point(493, 151);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 15);
            this.label17.TabIndex = 49;
            this.label17.Text = "Конечное значение 1";
            // 
            // textBoxListStop1
            // 
            this.textBoxListStop1.Location = new System.Drawing.Point(636, 147);
            this.textBoxListStop1.Name = "textBoxListStop1";
            this.textBoxListStop1.PlaceholderText = "1";
            this.textBoxListStop1.Size = new System.Drawing.Size(77, 23);
            this.textBoxListStop1.TabIndex = 50;
            this.textBoxListStop1.Text = "100";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label18.Location = new System.Drawing.Point(754, 151);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 15);
            this.label18.TabIndex = 51;
            this.label18.Text = "Шаг 1";
            // 
            // textBoxListStep1
            // 
            this.textBoxListStep1.Location = new System.Drawing.Point(816, 147);
            this.textBoxListStep1.Name = "textBoxListStep1";
            this.textBoxListStep1.Size = new System.Drawing.Size(100, 23);
            this.textBoxListStep1.TabIndex = 52;
            this.textBoxListStep1.Text = "5";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label19.Location = new System.Drawing.Point(273, 189);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(131, 15);
            this.label19.TabIndex = 53;
            this.label19.Text = "Начальное значение 2";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label20.Location = new System.Drawing.Point(493, 189);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(124, 15);
            this.label20.TabIndex = 54;
            this.label20.Text = "Конечное значение 2";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label21.Location = new System.Drawing.Point(754, 189);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 15);
            this.label21.TabIndex = 55;
            this.label21.Text = "Шаг 2";
            // 
            // textBoxListStart2
            // 
            this.textBoxListStart2.Location = new System.Drawing.Point(404, 186);
            this.textBoxListStart2.Name = "textBoxListStart2";
            this.textBoxListStart2.Size = new System.Drawing.Size(83, 23);
            this.textBoxListStart2.TabIndex = 56;
            this.textBoxListStart2.Text = "1";
            // 
            // textBoxListStop2
            // 
            this.textBoxListStop2.Location = new System.Drawing.Point(636, 185);
            this.textBoxListStop2.Name = "textBoxListStop2";
            this.textBoxListStop2.Size = new System.Drawing.Size(77, 23);
            this.textBoxListStop2.TabIndex = 57;
            this.textBoxListStop2.Text = "5";
            // 
            // textBoxListStep2
            // 
            this.textBoxListStep2.Location = new System.Drawing.Point(816, 185);
            this.textBoxListStep2.Name = "textBoxListStep2";
            this.textBoxListStep2.Size = new System.Drawing.Size(100, 23);
            this.textBoxListStep2.TabIndex = 58;
            this.textBoxListStep2.Text = "0,5";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(717, 225);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 23);
            this.comboBox1.TabIndex = 64;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(717, 255);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(189, 23);
            this.comboBox2.TabIndex = 65;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(717, 285);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(189, 23);
            this.comboBox3.TabIndex = 66;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(717, 315);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(189, 23);
            this.comboBox4.TabIndex = 67;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label22.Location = new System.Drawing.Point(913, 232);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(86, 15);
            this.label22.TabIndex = 68;
            this.label22.Text = "Изменяемое 1";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label23.Location = new System.Drawing.Point(913, 262);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(86, 15);
            this.label23.TabIndex = 69;
            this.label23.Text = "Изменяемое 2";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label24.Location = new System.Drawing.Point(913, 292);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(137, 15);
            this.label24.TabIndex = 70;
            this.label24.Text = "Расчитываемое 1 Green";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label25.Location = new System.Drawing.Point(913, 323);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(129, 15);
            this.label25.TabIndex = 71;
            this.label25.Text = "Расчитываемое 2 Blue";
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(592, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 100);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип расчета";
            // 
            // pictureBoxGraf
            // 
            this.pictureBoxGraf.Location = new System.Drawing.Point(12, 215);
            this.pictureBoxGraf.Name = "pictureBoxGraf";
            this.pictureBoxGraf.Size = new System.Drawing.Size(574, 415);
            this.pictureBoxGraf.TabIndex = 73;
            this.pictureBoxGraf.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.pictureBoxGraf);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxListStep2);
            this.Controls.Add(this.textBoxListStop2);
            this.Controls.Add(this.textBoxListStart2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBoxListStep1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxListStop1);
            this.Controls.Add(this.textBoxListStart1);
            this.Controls.Add(this.textBoxDGun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxD_solinoid_small);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxSpeed0);
            this.Controls.Add(this.N_block_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxDpF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxDp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxD_b);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Long_solinoid_tag);
            this.Controls.Add(this.textBoxLongSolinoid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxCondens);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Volt_teg);
            this.Controls.Add(this.textBoxVolt);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.L_solinoid_name);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.Volt_name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "GausGun";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Volt_name;
        private System.Windows.Forms.TextBox textBoxVolt;
        private System.Windows.Forms.Label Volt_teg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label N_block_name;
        private System.Windows.Forms.Label L_solinoid_name;
        private System.Windows.Forms.TextBox textBoxLongSolinoid;
        private System.Windows.Forms.Label Long_solinoid_tag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxD_b;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxD_solinoid_small;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDGun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDpF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxCondens;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSpeed0;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxListStart1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxListStop1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxListStep1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxListStart2;
        private System.Windows.Forms.TextBox textBoxListStop2;
        private System.Windows.Forms.TextBox textBoxListStep2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxGraf;
    }
}

