namespace AppliedActivity5;
using AppliedActivity5.View;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new StudentListScreen() );	
	}

    
	private void OnAddStudentClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddStudentScreen());
    }
}


