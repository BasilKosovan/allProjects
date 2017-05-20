using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication3 {
	class Program {
		struct MyStruct {
		}

		public static void DoWork(object data) {
			Console.WriteLine("Static thread procedure. Data='{0}'",
				data);
		}
		static void doNothing(int a) {
			for (int i = 0; i < 1000; i++) {
				System.Console.WriteLine("Hello");

			}
		}

		public static async Task<int> MyMethodAsync() {
			Task<int> longRunningTask = LongRunningOperationAsync();
			// independent work which doesn't need the result of LongRunningOperationAsync can be done here

			//and now we call await on the task 
			int result = await longRunningTask;
			return result;
		}

		public static async Task<int> LongRunningOperationAsync() // assume we return an int from this long running operation 
		{
			await Task.Delay(1000); //1 seconds delay
			return 1;
		}

		static void Main(string[] args) {
			var t = MyMethodAsync();
			t.Wait();

			var task = Task<string>.Factory.StartNew(() => {
				Thread.Sleep(1000);
				Console.WriteLine("qweq");
				return string.Empty;
			});


			
			System.Console.ReadLine();
		}
	}
}
