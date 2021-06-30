using System;
using System.Collections.Generic;
using System.Text;

namespace GaussGun
{
    class MathPhysics
    {
        const int RoFe = 7800;//кг/м3
        const float Mo = 0.00000125f;//константа магнитной постоянной
        const float Rud = 0.01724f;//удельное сопротивление проводника
        public float I_tok;//ток
        public int W_row;//витки
        public float L_long;//длинна
        public float D_solinoid_small;//внутренний диаметр катушки, 
        public float D_solinoid_big;//наружный диаметр катушки,
        public float D_gun;//диаметр ствола,
        public float Dp;// диаметр проводника
        public float DpF;// диаметр проводника в изоляции
        public float Lp;//длинна проводника
        public float U_v;//напряжение
        public float P_wt;// потребляемая мощность мощность
        public float E_Dzh;//энергия удара на расстоянии 0.1мS
        public float R_resist;//сопротивление проводника
        public double B_magnet;//В-вектор магнитной индукции
        public double F_n;//сила в ньютанах
        public float MassBullet;
        private float S_long;//Длинна рабочего разгона снаряда
        public double Speed0;//начальная скорость
        public double Speed;//начальная скорость
        public double F_fr;//емкость фарат
        public double T_c;//время разряда
        string err_string = "err";
        public string textOut = " ";
        bool err_flag = false;
        float l_provod(float D1, float D2, float Ll, float D_p)//D1 big, D2 small длинна проводника
        {
            float result = 0;
            float Pi = 3.1415f;
            float L_D_s = ((D1 + D2) / 2) * Pi;//находим среднее значение длинны окружности
            float temp;
            temp = (D1 - D2) / 2;//находим высоту укладки слоев
            temp = temp / D_p;
            int Lyer_solin = (int)temp;
            float tempW = 0;
            tempW = Ll / D_p;
            int winding = (int)tempW;
            W_row = Lyer_solin * winding;
            result = (Lyer_solin * winding * L_D_s) / 1000;
            return result;
        }
        static float ResistSolinoid(float D_p, float L_p)
        {
            float result = 0;
            float s = ((D_p / 2) * (D_p / 2)) * 3.1415f;
            result = (Rud * L_p) / s;
            return result;
        }
        private void calculate_pow(float V, float I)
        {
            P_wt = V * I;
        }
        private double calculate_induc(int w, double Db)//w-колво витков Db-диаметр катушки
        {
            double r = Db / 2;
            double s = 3.1415f * r * r;
            return Mo * (w * w * s) / 2;
        }
        private double calculate_B_magnet(float I, float Li)//I-ток, Li-индуктивность
        {
            return I * I * Li / 2;
        }
        private double calculate_F_n()//рассчет силы в ньютонах
        {
            double B=2,//B - индукция насыщения железа = 2 Тл
                H,//Магнитное поле идеального соленоида: H = N I / L
                S,//- площадь сечения подвижного сердечника
                tmp;
            int N = W_row;
            H = N*I_tok / L_long;
            tmp = D_gun / 2;
            S = tmp * tmp * 3.1415;
            return B * H * S/3;
        }
        private double calculate_T_c()
        {
            return R_resist * F_fr;
        }
        private float mathSLong(float S) { return S / 2; }
        private double mathSpeed()
        {
            double DeltaSpeed = 0;
            double a_us= F_n / MassBullet;
            float sLong = (L_long / 2) /1000;
            double tempSpeed = 2 * a_us * sLong;
            DeltaSpeed = Math.Sqrt(tempSpeed)+ Speed0;
            return DeltaSpeed; 
        }
        void MassBull(float LongSol)
        {
            float rad = D_gun / 2;
            rad = rad / 1000;
            float tempLong = LongSol / 1000;// L_long
            float V_ob= rad* rad*3.1415f* tempLong;
            MassBullet = V_ob* RoFe*1000;
        }
        private void FinishMath()
        {
            Lp = l_provod(D_solinoid_big, D_solinoid_small, L_long, DpF*2+ Dp);//длинна проводника
            R_resist = ResistSolinoid(Dp, Lp);
            I_tok = U_v / R_resist;
            calculate_pow(U_v, I_tok);
            B_magnet = calculate_B_magnet(I_tok, (float)calculate_induc(W_row, D_solinoid_big));//магнитный поток
            F_n = calculate_F_n();
            T_c = calculate_T_c();
            MassBull(L_long);
            Speed = mathSpeed();
        }
        public void Str_Out_result()
        {
            if (err_flag)
            { textOut = err_string; err_string = "Err0"; err_flag = false; }
            else
            {
                FinishMath();
                string TimeStr = Ed_Izm(T_c, "c");
                string c_fr = Ed_Izm(F_fr, "Ф");
                string F_n_str = Ed_Izm(F_n, "H");
                string SpeedStr = Speed + "м/с";
                textOut = "мощность= " + P_wt + "\n  Напряжение= " + U_v + "\n  ток= " + I_tok;
                textOut += "\n  количество витков= " + W_row + "\n  длинна проводника= " + Lp + "м";
                textOut += "\n  сопротивление катушки= " + R_resist + " Ом " + " \n вектор магнитной индукции=" + B_magnet;
                textOut += "\n  сила втягивания= " + F_n_str + "\n  конденсатор= " + c_fr + "  Время разряда=" + TimeStr;
                textOut += "\n  Начальная скорость снаряда= " + SpeedStr;
            }
        }
        
        public float CheckErrF(string str)
        {
            float data = 0;
            try
            {
                data = Convert.ToSingle(str);
                return data;
            }
            catch (FormatException ex)
            {
                err_string += ex.Message;
                err_flag = true;
            }
            return data;
        }
        public double CheckErrD(string str)
        {
            double data = 0;
            try
            {
                data = Convert.ToSingle(str);
                return data;
            }
            catch (FormatException ex)
            {
                err_string += ex.Message;
                err_flag = true;
            }
            return data;
        }
        public int CheckErrI(string str)
        {
            int data = 0;
            try
            {
                data = Convert.ToInt32(str);
                return data;
            }
            catch (FormatException ex)
            {
                err_string += ex.Message;
                err_flag = true;
            }
            return data;
        }
        double math_Ed_Izm(double get_dateMath, int pow)
        {
            double tempD = 0;
            if (pow == 0)
            { tempD = get_dateMath; }
            else
            {
                tempD = get_dateMath * Math.Pow(10, -pow) * 100;
                int tempi = (int)tempD;
                tempD = tempi;
                tempD = tempD / 100;
            }
            return tempD;
        }
        string Ed_Izm(double get_date, string EdIzm)
        {
            string tempStr = "0";
            string[] dec = { "p", "n", "mk", "m", " ", "K", "M", "G", "T" };
            for (int i = 4; i >= -4; i--)
            {
                double compar = Math.Pow(10, i * 3);
                if (get_date > compar)
                {
                    double returnIzm;
                    if (i == 0) { returnIzm = get_date; }
                    else
                    {
                        returnIzm = math_Ed_Izm(get_date, i * 3);
                    }
                    int key = i + 4;
                    string strT = dec[key];
                    return returnIzm + strT + EdIzm;
                }
            }
            return tempStr;
        }
        public double Ed_Izm_D(double get_date)
        {
            double returnIzm=0;
            for (int i = 4; i >= -4; i--)
            {
                double compar = Math.Pow(10, i * 3);
                if (get_date > compar)
                {
                    if (i == 0) { returnIzm = get_date; }
                    else
                    {
                        returnIzm = math_Ed_Izm(get_date, i * 3);
                    }
                    return returnIzm;
                }
            }
            return returnIzm;
        }
    }
}
