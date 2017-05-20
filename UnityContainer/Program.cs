using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace UnityContainerNameSpace {
	class Program {
		interface IInterface {
			void connect();

		}

		class SimpleProvider : IInterface {
			public void connect() {
				Console.WriteLine("Connecting...");
			}
		}

		class MyClass {
			public IInterface MyProperty { get; set; }

			public int? property { get; set; }


			public void getData() {

				MyProperty.connect();
				Console.WriteLine("data");
			}


			public MyClass(IInterface _MyProperty) {

			MyProperty = _MyProperty;
			}
		}
		 static void func(ref int? id) {
			Console.WriteLine("func");
		}

		static void func2(int? id) {
			Console.WriteLine("func");
		}



		static void Main(string[] args) {

			int? a = 20;
			MyClass MyClassInstance = new MyClass(new SimpleProvider());
			MyClassInstance.property = 10;

			func2(MyClassInstance.property);

			MyClassInstance.getData();

			UnityContainer container = new UnityContainer();

			container.RegisterType<IInterface, SimpleProvider>();

			var MyClassInstance2 = container.Resolve<IInterface>();
			MyClassInstance2.connect();

			Console.ReadLine();

		}
	}
}
