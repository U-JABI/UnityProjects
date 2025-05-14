using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_13_CSharp
{
    internal class MainApp
    {
        static double GetDiscountRate(object client)
        {
            return client switch //switch 식이라고 부른다.
            {
                ("학생", int n) when n < 18 => 0.2,    //학생 & 18세 미만
                ("학생", _) => 0.1, // 학생 & 18세 이상
                ("일반", int n) when n < 18 => 0.1,    //일반 & 18세 미만
                ("일반", _) => 0.05, // 일반 & 65세 이상
                _ => 0,
            };
            // case문을 사용하지 않고 패턴 매칭을 통해
            // switch문을 사용할 수 있다.
        }
        static void Main(string[] args)
        {
            var alice = (Job: "학생", Age: 17);
            var bob = (Job: "학생", Age: 23);
            var charlie = (Job: "일반", Age: 15);
            var dave = (Job: "일반", Age: 25);
            Console.WriteLine($"alice: {GetDiscountRate(alice)}");
            Console.WriteLine($"bob: {GetDiscountRate(bob)}");
            Console.WriteLine($"charlie: {GetDiscountRate(charlie)}");
            Console.WriteLine($"dave: {GetDiscountRate(dave)}");
        }
    }
}
