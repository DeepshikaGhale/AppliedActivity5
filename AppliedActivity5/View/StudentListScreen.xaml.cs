using AndroidX.Lifecycle;
using AppliedActivity5.Modal;

namespace AppliedActivity5.View;

public partial class StudentListScreen : ContentPage
{
    private StudentListViewModel _viewModel;

	public StudentListScreen()
	{
		InitializeComponent();
        _viewModel = new StudentListViewModel();
        BindingContext = _viewModel;
    }

    private async void StudentList_ItemSelected(object obj, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;
        StudentModel selctedStudent = e.SelectedItem as StudentModel;
        await Navigation.PushAsync(new StudentDetailsScreen(selctedStudent));

    }

    protected override void OnAppearing() {
        base.OnAppearing();
        //loads the data
        _viewModel.getAllStudents();
    }
}
