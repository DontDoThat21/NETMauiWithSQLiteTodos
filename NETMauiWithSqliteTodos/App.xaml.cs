using NET7MauiWithSqliteTodos.Views;

namespace NET7MauiWithSqliteTodos;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new TodoListPage())
		{
			BarTextColor = Color.FromRgb(255, 255, 255),
			BarBackgroundColor = Color.FromRgb(0, 122, 255)
		};
	}
}
