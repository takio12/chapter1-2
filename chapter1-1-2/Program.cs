using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter1_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass {X=2,Y=4 };
            MyStruct myStruct = new MyStruct { X = 5, Y=4};
            PrintObjcts(myClass, myStruct);
                       
        }
        /* 1.2.4
          MainメソッドのmyClass変数には、オブジェクトへの参照が格納されている。
          そのため、引数obj1には、MainメソッドのMyClassオブジェクトへの参照が渡ってくるので、
          obj1のプロパティの値を変更すると、変数 myClassが指す、MyClassオブジェクトが変更されることになる。
          一方、obj2には、MainメソッドのmyStructオブジェクトのコピーが渡ってくるので、
          obj2のプロパティの値を変更しても、myStructオブジェクトには影響しない。
          
           問題文は、PrintObjects と指定していますが、
           同一クラス内にコードを書いているため、PrintObjectsTwice として実装しています。
        */
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        public static void PrintObjcts(MyClass obj1, MyStruct obj2)
        {
            obj1.X *= 2;
            obj1.Y *= 2;
            obj2.X *= 2;
            obj2.Y *= 2;
            Console.WriteLine($"MYClass(X,Y):  {obj1.X},{obj1.Y}");
            Console.WriteLine($"MYStruct(X,Y): {obj2.X},{obj2.Y}");
        }
    
    }
    class MyClass
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    struct MyStruct
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

}
