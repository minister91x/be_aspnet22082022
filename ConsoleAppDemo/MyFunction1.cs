using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    public class MyFunction1
    {
        int a = 0;
        public int MF_CongHaiSo(int a, int b)
        {
            return a + b;
        }

        public double MF_CongHaiSo(double a, double b)
        {
            return a + b;
        }


        public float MF_CongHaiSo(float a, float b)
        {
            return a + b;
        }
        public void MF_CongHaiSo(int a)
        {
            a = a * a;


        }

        public void MF_CongHaiSoThamChieu(ref int a)
        {
            a = 100;
        }


        public void MF_CongHaiSoThamChieu_Out(out int a)
        {
            a = 1000;
        }



        public void HoanVi<T>(ref T a, ref T b)
        {
            T tmp = a;
            a = b;
            b = tmp;
        }

       

    }
}
