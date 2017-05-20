using System;

namespace ConsoleApplication2 {
	class Program {
		//public delegate int PerformCalculation(int x, int y);
		abstract class IInterfaces {

		}
		abstract class IInterfaces2 {

		}

		class MyClass: IInterfaces, IInterface {

		}
		interface IInterface {

		}



		static void Main(string[] args) {
			//int[] a = new int[10];
			//Array d = new bool[10];
			//Array d2 = new bool[10];
			//int intInst = 10;
			//object ob = intInst;
			//int UnboxInst = (int)ob;
			dynamic dynamicInst;
			int a;
			a = 10;
			dynamicInst = 10;
			//object obkectInst;

			dynamicInst = 10;
			Console.WriteLine(dynamicInst.GetType());
			dynamicInst = "df";
			Console.WriteLine(dynamicInst.GetType());

		}
	}
}
