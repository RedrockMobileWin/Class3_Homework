using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_Level3
{
    public class Cup
    {
        static Cup()
        {
            bottom_area = Console.WindowWidth * Console.WindowHeight;
        }//静态构造函数，将bottom_area的值改变为Console.WindowWidth和Console.WindowHeight的乘积(在创建第一个实例或引用任何静态成员之前，将自动调用静态构造函数来初始化类)
        private double height = 20, weight = 20;//无函数为其赋值，赋初值为20
        public Cup()
        {
            this.height = 20;
            this.weight = 20;
        }//不含参数的构造函数
        public Cup(double Height):this()
        {
            this.height = Height;
        }//含有一个参数的构造函数
        private static readonly double bottom_area;//将bottom_area声明成静态只读字段
        public int count = 0;
        public int leak;//新的int类型的字段 leak ，表示杯子的漏洞数
        public void GetPrimeFactors(int num)
        {
            int i, j;
            for (i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    j = num / i;
                    if (j == 1)
                    {
                        Console.Write(i);
                        return;
                    }
                    else
                    {
                        Console.Write("{0}*", i);
                        GetPrimeFactors(j);
                        break;
                    }
                }
            }
        }//分解杯子实例容积的质因数
        public void GetTimesAtEmpty(int capacity, int leak)
        {
            int remaining = capacity;
            if (capacity < 136)
            {
                return;
            }
            if (remaining > 0)
            {
                count = count + remaining / 136;
                GetTimesAtEmpty(capacity / 3, leak);
            }
        }//计算倒水的次数
        public double WaterVolume
        {
            get
            {
                return leak * 7;
            }
            set
            {
                leak = (int)value / 7;
            }
        }//double类型的属性WaterVolume，表示杯子中水的体积。为其赋值时，将该值除以7后赋值给leak。该属性的返回值为leak乘以7的结果
        public double Capacity
        {
            get
            {
                return height * bottom_area;
            }
        }
        public bool IsEmpty
        {
            get
            {
                if (weight > 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
