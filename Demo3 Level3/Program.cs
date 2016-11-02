using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_Level3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Level3 (1)
            Cup cup4 = new Cup();
            int capacity = (int)cup4.Capacity;
            Console.WriteLine("杯子容积为:{0}", (int)cup4.Capacity);//double强制转换为int
            Console.Write("{0}=", capacity);
            cup4.GetPrimeFactors(capacity);
            Console.WriteLine();
            #endregion

            #region Level3 (2)
            Cup cup5 = new Cup() { WaterVolume = 56 };
            Console.WriteLine("杯子有{0}个漏洞",cup5.leak);
            cup5.GetTimesAtEmpty((int)cup5.Capacity, (int)cup5.leak);
            Console.WriteLine("总的倒水次数为{0}",cup5.count);
            #endregion
            Console.ReadKey();
        }
    }
}
