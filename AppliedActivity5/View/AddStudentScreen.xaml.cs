using AppliedActivity5.ViewModel;

namespace AppliedActivity5.View;

public partial class AddStudentScreen : ContentPage
{
	public AddStudentScreen()
	{
		InitializeComponent();
		BindingContext = new StudentViewModel(Navigation);
	}

   

}
