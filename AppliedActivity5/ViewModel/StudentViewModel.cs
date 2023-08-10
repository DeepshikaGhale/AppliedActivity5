using System;
using System.Collections.ObjectModel;
using AppliedActivity5.Modal;
using AppliedActivity5.View;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppliedActivity5.ViewModel;

internal partial class StudentViewModel: ObservableObject
{
	private INavigation _navigation;

	public Command GoToListCommand { get; }

    public StudentViewModel(INavigation navigation)
	{
		this._navigation = navigation;
		GoToListCommand = new Command(GoToList);

    }

    private async void GoToList(object obj)
    {
        await this._navigation.PushAsync(new StudentListScreen());
    }

    [ObservableProperty]
	private string studentName;

	[ObservableProperty]
	private string address;

	[ObservableProperty]
	private int studentAge;

	[ObservableProperty]
	private string studentNumber;

	private StudentModel student;

	[RelayCommand]
	private void addStudent()
	{
		student = new StudentModel
		{
			StudentName = StudentName,
			StudentNumber = StudentNumber,
			Age = StudentAge,
			Address = Address
        };

		App.StudentRepository.AddStudent(
			student
			);
	}

   


}

