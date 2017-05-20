namespace FactoryMethod {
	public class Resume : Document {
		// Factory Method implementation
		public override void CreatePages() {
			Pages.Add(new SkillsPage());
			Pages.Add(new EducationPage());
			Pages.Add(new ExperiencePage());
		}
	}

	public class Report : Document {
		// Factory Method implementation
		public override void CreatePages() {
			Pages.Add(new IntroductionPage());
			Pages.Add(new ResultsPage());
			Pages.Add(new ConclusionPage());
			Pages.Add(new SummaryPage());
			Pages.Add(new BibliographyPage());
		}
	}
}