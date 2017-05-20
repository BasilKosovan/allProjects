using System;

namespace Program2 {
	class Program {

		public struct S : IDisposable {
			private bool dispose;
			public void Dispose() {
				dispose = true;
			}
			public bool GetDispose() {
				return dispose;
			}
		}

		public class TestClass : IDisposable {
			private bool dispose;
			public void Dispose() {
				dispose = true;
			}
			public bool GetDispose() {
				return dispose;
			}
		}

		public class Test {
			public Test() {
			}

			public const int a = 1;

			public void Print() {

				try {
					throw new Exception();
				} catch (Exception) {
					Console.Write("9");
					throw new Exception();
				} finally {
					Console.Write("2");
				}
			}
		}
		static void Main(string[] args) {





			//try {
			//	throw new Exception();
			//} catch (Exception) {
			//	Console.Write("9");
			//	throw new Exception();
			//} finally {
			//	Console.Write("2");
			//}
			//Console.WriteLine(s.GetDispose());


			//var TestClass = new TestClass();


			//using (TestClass) {
			//	Console.WriteLine(TestClass.GetDispose());
			//}
			//Console.WriteLine(TestClass.GetDispose());
			//Console.ReadLine();

			//var s1 = string.Format("{0}{1}", "abc", "cba");
			//var s2 = "abc" + "cba";
			//var s3 = "abccba";

			//Console.WriteLine(s1 == s2);
			//Console.WriteLine((object)s1 == (object)s2);
			//Console.WriteLine(s2 == s3);
			//Console.WriteLine((object)s2 == (object)s3);


			//var test = new Test();
			//Console.WriteLine( Test.a);


			//try {
			//	test.Print();
			//} catch (Exception) {
			//	Console.Write("5");
			//} finally {
			//	Console.Write("4");
			//}
			//Console.ReadLine();



			//if (true || true && true) 
			//Console.WriteLine(1);
			//if (true || false && true)
			//	Console.WriteLine(2);
			//if (true || true && false)
			//	Console.WriteLine(3);
			//if (true || false && false)
			//	Console.WriteLine(4);

			//var s = new S();
			//using (s) {
			//	Console.WriteLine(s.GetDispose());
			//}
			//Console.WriteLine(s.GetDispose());
			Console.ReadLine();
		}
	}
}
