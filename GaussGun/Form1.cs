using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaussGun
{
    public partial class Form1 : Form
    {
        /*
                 * !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                 * рассчет под цилиндр
                 * добавить поле диапазона и шага
                 * расчитать конечную скорось
                 * добавить графики на OpenGl
                 */
        //420y X 580x
        MathPhysics mathPhysics_Static = new MathPhysics();
        MathSteps mathSteps = new MathSteps();
        static Bitmap bmp;
        protected Graphics graph;
        Pen penG, penB, penR;
        double[] data_graf1 = new double[3];
        double[] data_graf2 = new double[3];
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(1500, 1500);
            graph = Graphics.FromImage(bmp);
            radioButton1.Checked = true;
            comboBox1.Text = "Изменяемое 1";
            comboBox1.Items.AddRange(new object[]{
            "Напряжение V", "Длинна катушки", "Диаметр катушки внешний", "Диаметр катушки внутренний",
                "Диаметр ствола-снаряда", "Диаметр провода", "толщина изаляции", "Емкость конденсатора"
            });
            comboBox1.SelectedIndex = 0;
            comboBox2.Text = "Изменяемое 2";
            comboBox2.Items.AddRange(new object[]{
            "Напряжение V", "Длинна катушки", "Диаметр катушки внешний", "Диаметр катушки внутренний",
                "Диаметр ствола-снаряда", "Диаметр провода", "толщина изаляции", "Емкость конденсатора"
            });
            comboBox2.SelectedIndex = 5;
            comboBox3.Text = "Расчитываемое 1";
            comboBox3.Items.AddRange(new object[]{
            "мощность", "Напряжение", "ток","N витков","L проводника","R катушки",
                "вектор магн. индукции","сила втягивания","конденсатор","T разряда","Начальная V снаряда"
            });
            comboBox3.SelectedIndex = 10;
            comboBox4.Text = "Расчитываемое 2";
            comboBox4.Items.AddRange(new object[]{
            "мощность", "Напряжение", "ток","N витков","L проводника","R катушки",
                "вектор магн. индукции","сила втягивания","конденсатор","T разряда","Начальная V снаряда"
            });
            comboBox4.SelectedIndex = 7;
            
        }
        
        private void GetData()
        {
            mathPhysics_Static.U_v = mathPhysics_Static.CheckErrF(textBoxVolt.Text);//вольт
            mathPhysics_Static.DpF = mathPhysics_Static.CheckErrF(textBoxDpF.Text);//толщина изаляции
            mathPhysics_Static.F_fr = mathPhysics_Static.CheckErrD(textBoxCondens.Text);//конденсатор
            mathPhysics_Static.D_solinoid_small = mathPhysics_Static.CheckErrF(textBoxD_solinoid_small.Text);//внутренний диаметр катушки, 
            mathPhysics_Static.D_solinoid_big = mathPhysics_Static.CheckErrF(textBoxD_b.Text);//наружный диаметр катушки,
            mathPhysics_Static.L_long = mathPhysics_Static.CheckErrF(textBoxLongSolinoid.Text);//длинна катушки
            mathPhysics_Static.D_gun = mathPhysics_Static.CheckErrF(textBoxDGun.Text);//диаметр ствола снаряда
            mathPhysics_Static.Dp = mathPhysics_Static.CheckErrF(textBoxDp.Text);//"Диаметр провода"
            mathPhysics_Static.Speed0 = mathPhysics_Static.CheckErrD(textBoxSpeed0.Text);
            data_graf1[0] = mathPhysics_Static.CheckErrD(textBoxListStart1.Text);
            data_graf1[1] = mathPhysics_Static.CheckErrD(textBoxListStop1.Text);
            data_graf1[2] = mathPhysics_Static.CheckErrD(textBoxListStep1.Text);
            data_graf2[0] = mathPhysics_Static.CheckErrD(textBoxListStart2.Text);
            data_graf2[1] = mathPhysics_Static.CheckErrD(textBoxListStop2.Text);
            data_graf2[2] = mathPhysics_Static.CheckErrD(textBoxListStep2.Text);
        }
        private void Out_result()
        {
            GetData();
            if (radioButton1.Checked)
            {
                mathPhysics_Static.Str_Out_result();
                textBoxOut.Text = mathPhysics_Static.textOut;
            }
            else
            {
                graph.Clear(Color.Black);
                draw();
                pictureBoxGraf.Image = bmp;
            }

        }
        void draw()
        {
            int x_start1=0, x_stop1=580, y_start1 = 400, y_fin1 = 400, x_step1 = 0, y_step1 = 0;
            int x_start2 = 0, x_stop2 = 580, y_start2 = 400, y_fin2 = 400, x_step2 = 0, y_step2 = 0;
            y_step1 = (int)data_graf1[2] * 10;
            y_step2 = (int)data_graf2[2] * 10;
            x_step1 = (int)(580/(data_graf1[1]/ data_graf1[2]));
            x_step2 = (int)(580/(data_graf2[1] / data_graf2[2]));


            if (data_graf1[2] <0.001 || data_graf2[2] < 0.001)
            {
                textBoxOut.Text = "Слишком малый шаг или равен 0";
                return;
            }
            GetData();
            set_data_Changes(comboBox1.SelectedIndex, data_graf1[1]);
            mathPhysics_Static.Str_Out_result();
            double coof1=420/get_data_Changes(comboBox3.SelectedIndex);
            for (double i= data_graf1[0];i< data_graf1[1];i+= data_graf1[2])
            {
                set_data_Changes(comboBox1.SelectedIndex, i);
                mathPhysics_Static.Str_Out_result();
                y_fin1 = 400-(int)(get_data_Changes(comboBox3.SelectedIndex)* coof1);
                draw_lin(x_start1, x_step1, y_start1, y_fin1, 0);//зеленая
                y_start1=y_fin1;
                x_start1 += x_step1;
            }
            GetData();
            set_data_Changes(comboBox2.SelectedIndex, data_graf2[1]);
            mathPhysics_Static.Str_Out_result();
            double coof2 = 420 / get_data_Changes(comboBox4.SelectedIndex);
            for (double i = data_graf2[0]; i < data_graf2[1]; i += data_graf2[2])
            {
                set_data_Changes(comboBox2.SelectedIndex , i);
                mathPhysics_Static.Str_Out_result();
                y_fin2 = 400 - (int)(get_data_Changes(comboBox4.SelectedIndex)* coof2);
                draw_lin(x_start2, x_step2, y_start2, y_fin2, 1);//синяя
                y_start2= y_fin2;
                x_start2 += x_step2;
            }
        }
        void set_data_Changes(int Get,double data)
        {
            switch(Get)//изменяемое
            {
                case 0://"Напряжение V"
                    mathPhysics_Static.U_v =(float) data;
                    break;
                case 1://"Длинна катушки"
                    mathPhysics_Static.L_long = (float)data;
                    break;
                case 2://"Диаметр катушки внешний"
                    mathPhysics_Static.D_solinoid_big = (float)data;
                    break;
                case 3://"Диаметр катушки внутренний"
                    mathPhysics_Static.D_solinoid_small = (float)data;
                    break;
                case 4://"Диаметр ствола-снаряда"
                    mathPhysics_Static.D_gun = (float)data;
                    break;
                case 5://"Диаметр провода"
                    mathPhysics_Static.Dp = (float)data;
                    break;
                case 6://"толщина изаляции"
                    mathPhysics_Static.DpF = (float)data;
                    break;
                case 7://"Емкость конденсатора"
                    mathPhysics_Static.F_fr = data;
                    break;
            }
        }
        double get_data_Changes(int Get)
        {
            double data_get_data_Changes=0;
            switch (Get)//изменяемое
            {
                case 0://"мощность"
                    data_get_data_Changes = mathPhysics_Static.P_wt;
                    break;
                case 1://"Напряжение"
                    data_get_data_Changes = mathPhysics_Static.U_v;
                    break;
                case 2://"ток"
                    data_get_data_Changes = mathPhysics_Static.I_tok;
                    break;
                case 3://"N витков"
                    data_get_data_Changes = mathPhysics_Static.W_row;
                    break;
                case 4://"L проводника"
                    data_get_data_Changes = mathPhysics_Static.Lp;
                    break;
                case 5://"R катушки"
                    data_get_data_Changes = mathPhysics_Static.R_resist;
                    break;
                case 6://"вектор магн. индукции"
                    data_get_data_Changes = mathPhysics_Static.B_magnet;
                    break;
                case 7://"сила втягивания"
                    data_get_data_Changes = mathPhysics_Static.Ed_Izm_D(mathPhysics_Static.F_n) * 10;
                    break;
                case 8://"конденсатор"
                    data_get_data_Changes = mathPhysics_Static.Ed_Izm_D(mathPhysics_Static.F_fr) * 10;
                    break;
                case 9://"T разряда"
                    data_get_data_Changes = mathPhysics_Static.Ed_Izm_D(mathPhysics_Static.T_c) * 10;
                    break;
                case 10://"Начальная V снаряда"
                    data_get_data_Changes = mathPhysics_Static.Speed;
                    break;
            }
            return data_get_data_Changes;
        }
        void draw_lin(int x_start, int x_step, int y_start, int y_fin, int pen_graf)
        {
            penG = new Pen(Color.Green, 2);
            penB = new Pen(Color.Blue, 2);
            int step_gaf = x_start + x_step;
            if (step_gaf > 580) step_gaf = 580;
            if (y_fin > 420) y_fin = 420;
            if (y_fin < 0) y_fin = 0;
            if(pen_graf==0)
            { graph.DrawLine(penG, x_start, y_start, step_gaf, y_fin); }
            else
            { graph.DrawLine(penB, x_start, y_start, step_gaf, y_fin); }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Out_result();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Tok_tag_Click(object sender, EventArgs e)
        {

        }

        private void Pow_name_Click(object sender, EventArgs e)
        {

        }

        private void N_block_name_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBoxOut_TextChanged(object sender, EventArgs e)//поле для вывода
        {
            
        }

        private void textBoxTok_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
        }
    }
}
