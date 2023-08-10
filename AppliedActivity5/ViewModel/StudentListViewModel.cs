using System.Collections.ObjectModel;
using AppliedActivity5.Modal;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppliedActivity5.View;

internal partial class StudentListViewModel: ObservableObject
{
    

    public StudentListViewModel() {
        
    }

    //traces the changes in student model list
    //don't have to write the getter and setter for the property
    [ObservableProperty]
    private ObservableCollection<StudentModel> studentObservableCollection = new ();

    [ObservableProperty]
    private string studentName;

    [ObservableProperty]
    private string studentNumber;

    public void getAllStudents()
    {
        //App.StudentRepo.GetAll();
        foreach (var student in App.StudentRepository.GetAllStudent())
        {
            StudentObservableCollection.Add(student);
        }
        Console.WriteLine(StudentObservableCollection);
    }


}