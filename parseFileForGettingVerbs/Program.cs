using System;
using System.IO;
using System.Text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace parseFileForGettingVerbs {
	class Program {
		static void Main(string[] args) {
			string pathToPdfVerbs = @"C:\Users\basil\Desktop\New folder (3)\tableVerbs.pdf";
			string result = ExtractTextFromPdf(pathToPdfVerbs);
			var strList = result.Split('.');

			string mydocpath = @"C:\Users\basil\OneDrive\Документы\visual studio 2015\Projects\DesignPatterns\BasilCompany\PostDeployment.sql";

			using (StreamWriter outputFile = new StreamWriter(mydocpath)) {

				foreach (var str in strList) {
					var words = str.Split(' ');
					outputFile.Write(@"INSERT INTO [word].[Dictionary] VALUES(");
					foreach (var word in words) {
						if (word == string.Empty)
							continue;
						outputFile.Write(@"'" + word + @"',");
					}
					outputFile.WriteLine(@");'");
				}

			}

			Console.WriteLine(result);
			Console.ReadLine();
		}

		public static string ExtractTextFromPdf(string path) {
			using (PdfReader reader = new PdfReader(path)) {
				StringBuilder text = new StringBuilder();

				for (int i = 1; i <= reader.NumberOfPages; i++) {
					text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
				}

				return text.ToString();
			}
		}
	}
}
