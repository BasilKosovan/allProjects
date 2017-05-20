using System;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;

/// <summary>
/// Demonstrates how to work with SqlConnection objects
/// </summary>
class SqlConnectionDemo {
	static void Main() {
		int[] a = null;


		DataContext s = new DataContext("sdfsdf");
		Tuple<int> aT= new Tuple<int>(3);
		aT = new Tuple<int>(4);



		// 1. Instantiate the connection
		SqlConnection conn = new SqlConnection(
			"Data Source=localhost;Initial Catalog=FlexService.Glued.Database;User ID=sa;Password=1111;MultipleActiveResultSets=True;Application name=GLUED");

		SqlDataReader rdr = null;

		try {
			// 2. Open the connection
			conn.Open();

			// 3. Pass the connection to a command object
			SqlCommand cmd = new SqlCommand("select * from Customers", conn);

			//
			// 4. Use the connection
			//

			// get query results
			rdr = cmd.ExecuteReader();

			// print the CustomerID of each record
			while (rdr.Read()) {
				Console.WriteLine(rdr[0]);
			}
		} finally {
			// close the reader
			if (rdr != null) {
				rdr.Close();
			}

			// 5. Close the connection
			if (conn != null) {
				conn.Close();
			}
		}
	}
}