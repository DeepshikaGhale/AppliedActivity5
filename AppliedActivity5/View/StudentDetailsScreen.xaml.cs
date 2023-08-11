using System.Collections.ObjectModel;
using AppliedActivity5.Modal;
using AppliedActivity5.ViewModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AppliedActivity5.View;

public partial class StudentDetailsScreen : ContentPage
{
    private StudentModel studentModel;
    private StudentViewModel _viewModel;

    public StudentDetailsScreen(StudentModel student)
	{
		InitializeComponent();
		BindingContext = student;
        studentModel = student;
        _viewModel = new StudentViewModel(Navigation);
	}

    private async void DeleteStudentDetails(object obj, EventArgs e)
    {

        int result = _viewModel.deleteStudentDetails(studentModel.StudentID);
        if (result == 1) {
            await Navigation.PopAsync();
        }
    }
}
