using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
	class Program {
		class MyClass {
			private MyClass(int a) {
				Console.WriteLine("i am private ");
			}


		}
		static void Main(string[] args) {
			object[] paramValues = new object[] { 42 };
			Type[] paramTypes = new Type[] { typeof(int) };

			Type t = typeof(MyClass);
			var ctor = t.GetConstructor(
				BindingFlags.Instance | BindingFlags.NonPublic,
				null, paramTypes, null);
			var inst = (MyClass)ctor.Invoke(paramValues);

			Console.ReadLine();

		}
	}
}
