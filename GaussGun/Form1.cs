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
        MathPhysics mathPhysics_Static = new MathPhysics();
        MathSteps mathSteps = new MathSteps();
        static Bitmap bmp;
        protected Graphics graph;
        Pen penG, penB;
        double data_changeable_start, data_changeable_finish;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(1500, 1500);
            graph = Graphics.FromImage(bmp);
            comboBox1.Text = "Изменяемое 1";
            checkBox1.Checked = true;
            comboBox1.Items.AddRange(new object[]{
            "Напряжение V", "Длинна катушки", "Диаметр катушки внешний", "Диаметр катушки внутренний",
                "Диаметр ствола-снаряда", "Диаметр провода", "толщина изаляции", "Емкость конденсатора"
            });
            comboBox1.SelectedIndex = 0;
            comboBox2.Text = "Расчитываемое 1";
            comboBox2.Items.AddRange(new object[]{
            "мощность", "Напряжение", "ток","N витков","L проводника","R катушки",
                "вектор магн. индукции","сила втягивания","конденсатор","T разряда","Начальная V снаряда"
            });
            comboBox2.SelectedIndex = 10;
            comboBox3.Text = "Расчитываемое 2";
            comboBox3.Items.AddRange(new object[]{
            "мощность", "Напряжение", "ток","N витков","L проводника","R катушки",
                "вектор магн. индукции","сила втягивания","конденсатор","T разряда","Начальная V снаряда"
            });
            comboBox3.SelectedIndex = 7;
            
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
            data_changeable_start = mathPhysics_Static.CheckErrD(textBoxListStart1.Text);
            data_changeable_finish = mathPhysics_Static.CheckErrD(textBoxListStop1.Text);
        }
        private void Out_result()
        {
            GetData();
            if (checkBox1.Checked)
            {
                mathPhysics_Static.Str_Out_result();
                textBoxOut.Text = mathPhysics_Static.textOut;
            }
            else
            {
                graph.Clear(Color.Black);
                draw_graf();
                pictureBoxGraf.Image = bmp;
            }
        }
        void draw_graf()
        {
            GetData();

            set_data_Changes(comboBox1.SelectedIndex, data_changeable_finish);
            mathPhysics_Static.Str_Out_result();
            draw_graf_line(data_changeable_start, data_changeable_finish, comboBox2.SelectedIndex, 0);
            draw_graf_line(data_changeable_start, data_changeable_finish, comboBox3.SelectedIndex, 1);
        }
        void draw_graf_line(double start_data,double end_data,int select, int color)
        {
            int finX = 500;
            if (start_data>= end_data) { textBoxOut.Text = "неверный диапозон, начальное значение не должно быть больше конечного"; }
            else
            {
                double delta_data = end_data - start_data;
                double step_data_x = delta_data/ finX;
                int y_start = 0, y_fin_step = 1;
                for (int i = 0; i < finX+1; i++)
                {
                    set_data_Changes(comboBox1.SelectedIndex, i* step_data_x);
                    mathPhysics_Static.Str_Out_result();
                    y_fin_step = (int)get_data_Changes(select);
                    draw_lin(i, 1, y_start, y_fin_step, color);
                    y_start = y_fin_step;
                }
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
            y_start = 400 - y_start;
            y_fin = 400 - y_fin;
            if (step_gaf > 580) step_gaf = 580;
            if (y_fin > 420) y_fin = 420;
            if (y_fin < 0) y_fin = 1;
            if (y_start < 0) y_start = 0;
            if (y_start > 420) y_start = 420;
            if (pen_graf==0)
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
    }
}
