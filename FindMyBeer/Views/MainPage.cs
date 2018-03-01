using System.Collections.Generic;
using FindMyBeer.Views;
using Xamarin.Forms;

namespace FindMyBeer
{
	public class MainPage : TabbedPage
	{
		public MainPage()
		{
			var pages = new List<Page> { new StylesPage(), new AboutPage() };

			foreach (var page in pages)
			{
				var navigationPage = new NavigationPage(page) { Title = page.Title, Icon = page.Icon };
				Children.Add(navigationPage);
			}
		}

		protected override void OnCurrentPageChanged()
		{
			base.OnCurrentPageChanged();
			Title = CurrentPage?.Title;
			Icon = CurrentPage?.Icon;
		}
	}
}
