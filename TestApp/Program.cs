using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp {
	class Reader {
		//	Library library = new Library();
		Lazy<Library> library = new Lazy<Library>();

		public void ReadBook() {
			library.Value.GetBook();
			Console.WriteLine("Читаем бумажную книгу");
		}

		public void ReadEbook() {
			Console.WriteLine("Читаем книгу на компьютере");
		}
	}

	class MyClass2<dynamic> {

	}

	class Library {
		private string[] books = new string[99];

		public void GetBook() {
			Console.WriteLine("Выдаем книгу читателю");
		}
	}

	class Program {
		public static int MyProperty { get; set; }
		public static  int MyProperty3 { get; set; }

		int a;
		readonly int qwe;
		public  int MyProperty23 { get; }

		public static dynamic MyProperty4 { get; }
		static void Main(string[] args) {
			Reader reader = new Reader();
			reader.ReadEbook();
			reader.ReadBook();
			dynamic dyn = new { q = 3 };
			dyn.q = 2;
			MyClass2<int> a = new MyClass2<int>();

			Console.WriteLine(2);

		}
	}
}
