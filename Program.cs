// See https://aka.ms/new-console-template for more information
using System;

namespace first_example {
   class namespace_cl {
      public void func() {
         Console.WriteLine("Inside first_space");
         int a = 10;
         Console.WriteLine("value of A is: {0}", a);

      }
   }
}
namespace second_example {
   class namespace_cl {
      public void func() {
         Console.WriteLine();
         Console.WriteLine("Inside second_space");
         int a = 20;
         Console.WriteLine("Value of A is: {0}",a);
      }
   }
}


class TestClass {
   static void Main(string[] args) {
      first_example.namespace_cl fe = new first_example.namespace_cl();
      second_example.namespace_cl se = new second_example.namespace_cl();
      fe.func();
      se.func();
      Console.ReadKey();
   }
}
