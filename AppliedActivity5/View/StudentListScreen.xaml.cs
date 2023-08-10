using AppliedActivity5.Modal;

namespace AppliedActivity5.View;

public partial class StudentListScreen : ContentPage
{

	public StudentListScreen()
	{
		InitializeComponent();
        BindingContext = new StudentListViewModel();
	}

    private async void StudentList_ItemSelected(object obj, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;
        StudentModel selctedStudent = e.SelectedItem as StudentModel;
        await Navigation.PushAsync(new StudentDetailsScreen(selctedStudent));

    }

    private async void AddStudents(object sender, EventArgs e)
    {
       await Navigation.PushAsync(new AddStudentScreen());
    }
        
}
