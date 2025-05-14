//namespace _05_13_CSharp
//{
//    #region readonly struct
//    //readonly struct RGBColor
//    //{
//    //    public readonly byte R;
//    //    public readonly byte G;
//    //    public readonly byte B;
//    //    public RGBColor(byte r, byte g, byte b)
//    //    {
//    //        R = r;
//    //        G = g;
//    //        B = b;
//    //    }
//    //}
//    #endregion
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            #region readonly struct
//            //RGBColor Red = new RGBColor(255, 0, 0);
//            //RGBColor Green = new RGBColor(0, 255, 0);
//            //RGBColor Blue = new RGBColor(0, 0, 255);
//            #endregion
//            #region tuple
//            //튜플 tuple

//            //var tuple = (123, 456);
//            //Console.WriteLine($"{tuple.Item1}, {tuple.Item2}");
//            //var tuple2 = (Name: "서예지", Age: 35);
//            //Console.WriteLine($"{tuple2.Name}, {tuple2.Age}");
//            //var tuple3 = (Name: "유아인", Age: 38, Address: "서울시");
//            //var (name, age, address) = tuple3;
//            //Console.WriteLine($"이름 : {name}, 나이 : {age}, 주소 : {address}");
//            //var num = (Name: "김문수", Age: 75);
//            //var (Name, _) = num;
//            //Console.WriteLine($"이름 : {Name}");

//            //var (name2, age2) = ("서예지", 35);
//            //Console.WriteLine($"이름 : {name2}, 나이 : {age2}");
//            #endregion
//            #region tuple2
//            //var unnamed = ("슈퍼맨", 9999);
//            //var named = (Name: "배트맨", Age: 46);
//            //Console.WriteLine($"{named.Name} ,{named.Age}");
//            //named = unnamed;
//            //Console.WriteLine($"{named.Name} ,{named.Age}");
//            #endregion

//            var a = ("슈퍼맨", 9999);
//            Console.WriteLine($"{a.Item1} {a.Item2}");
//            var b = (Name: "배트맨", Age: 46);
//            Console.WriteLine($"{b.Name} {b.Age}");
//            var (name, age) = b;
//            var (name2, age2) = ("서예지", 35);
//            Console.WriteLine($"이름: {name2}, 나이: {age2}");
//            b = a;
//            Console.WriteLine($"{b.Name} {b.Age}");
//        }
//    }
//}
