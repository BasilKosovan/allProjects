using System.Collections.Generic;


namespace FactoryMethod {
	public abstract class Document {
		private List<Page> _pages = new List<Page>();

		public Document() {
			this.CreatePages();
		}

		public List<Page> Pages {
			get { return _pages; }
		}

		// Factory Method
		public abstract void CreatePages();
	}
}