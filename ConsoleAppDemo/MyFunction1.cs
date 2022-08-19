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


    }
}
