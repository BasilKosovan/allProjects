// Contravariant interface.
using System;
using System.Collections;
using System.Collections.Generic;

delegate void TestDelegate(string message);

interface Itest {
	void f();
}

interface Itest2 {
	void f();
}

class MyClass : Itest, Itest2 {
	public void f() {
		throw new NotImplementedException();
	}

	void Itest2.f() {
		throw new NotImplementedException();
	}
}
interface IContravariant<in A> {
	int MyProperty { get; set; }
	event TestDelegate df;

}

class A {
	public delegate void TestDelegate(string message);
	ArrayList arr = new ArrayList { 1, 2, 3 };
	List<object> a = new List<object> { 1, 2, 3, new object() };


	public void farr() {

		var  m = arr.ToArray(typeof(int));
		Console.WriteLine(m.GetType());


		for (int i = 0; i < arr.Count; i++) {
			Console.Write("Count " + arr[i].GetType());
			Console.WriteLine("Count " + arr.Capacity);
			//Console.WriteLine("     Capacity " + students.Capacity);

		}

	}

	class StudentName {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int ID { get; set; }
	}
	Dictionary<int, int> intDict = new Dictionary<int, int>();
	Dictionary<int, StudentName> students = new Dictionary<int, StudentName>()
	  {
		{ 111, new StudentName {FirstName="Sachin", LastName="Karnik", ID=211}},
		{ 112, new StudentName {FirstName="Dina", LastName="Salimzianova", ID=317}},
		{ 113, new StudentName {FirstName="Andy", LastName="Ruth", ID=198}}
	};

	public void f() {
		var st = new StudentName { FirstName = "Andy", LastName = "Ruth", ID = 198 };

		for (int i = 0; i < 100; i++) {
			Console.Write("Count " + students.Count);
			//Console.WriteLine("     Capacity " + students.Capacity);
			intDict.Add(i, 4);

		}

	}
}

class B : A {

}

// Extending contravariant interface.
//interface IExtContravariant<in A> : IContravariant<A> { }

// Implementing contravariant interface.
class Sample<A> //: IContravariant<A> 
	{
}

class Program {
	static void Main() {


		A inst = new A();
		inst.farr();


		A inst2 = new A();

		var a = inst ?? inst2;
		var aaa = null ?? inst2;


		inst.f();

		Console.ReadLine();

		//IContravariant<Object> iobj = new Sample<Object>();
		//IContravariant<B> istr = new Sample<A>();

		// You can assign iobj to istr because
		// the IContravariant interface is contravariant.
		//istr = iobj;
	}
}