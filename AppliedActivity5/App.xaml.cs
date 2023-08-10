using AppliedActivity5.Repository;

namespace AppliedActivity5;

public partial class App : Application
{
	public static StudentRepo StudentRepository { get; private set; }
	public App(StudentRepo repo)
	{
		InitializeComponent();

		MainPage = new AppShell();

		StudentRepository = repo;
	}
}

