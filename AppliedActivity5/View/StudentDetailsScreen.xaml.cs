using System.Collections.ObjectModel;
using AppliedActivity5.Modal;
using AppliedActivity5.ViewModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AppliedActivity5.View;

public partial class StudentDetailsScreen : ContentPage
{
    
    public StudentDetailsScreen(StudentModel student)
	{
		InitializeComponent();
		BindingContext = student;
	}
}
