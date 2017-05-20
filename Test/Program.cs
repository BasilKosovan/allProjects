using System;
using FactoryMethod;
using AbstractFactoryNameSpace;

namespace Test {
	class Program {
		static void Main(string[] args) {
			//	int a = Console.Read();

			//	switch (a) {
			//		case 1:
			//			TestFactoryMethod();
			//			break;
			//		case 2:
			//			TestAbstractFactory();
			//			break;
			//		case 3:
			//			TestAbstractFactory();
			//		case 4:
			//			TestAbstractFactory();
			//			break;
			//		case 5:
			//			TestAbstractFactory();
			//			break;
			//		case 6:
			//			TestAbstractFactory();
			//			break;
			//	}
			//	Func



			// Wait for user
			Console.ReadKey();
		}


		static void TestFactoryMethod() {
			Document[] documents = new Document[2];

			documents[0] = new Resume();
			documents[1] = new Report();

			foreach (Document document in documents) {
				Console.WriteLine("\n" + document.GetType().Name + "--");
				foreach (Page page in document.Pages) {
					Console.WriteLine(" " + page.GetType().Name);
				}
			}
		}

		static void TestAbstractFactory() {
			// Abstract factory #1
			AbstractFactory factory1 = new ConcreteFactory1();
			Client client1 = new Client(factory1);
			client1.Run();

			// Abstract factory #2
			AbstractFactory factory2 = new ConcreteFactory2();
			Client client2 = new Client(factory2);
			client2.Run();
		}
	}
}
