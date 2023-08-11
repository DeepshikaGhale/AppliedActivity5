using System;
using AppliedActivity5.Modal;
using SQLite;

namespace AppliedActivity5.Repository;

public class StudentRepo
{
    private SQLiteConnection connection;
    public string StatusMessage { get; set; }

    private void Init()
    {
        if (connection is not null)
            return;
        connection = new SQLiteConnection(Constant.DatabasePath);
        connection.CreateTable<StudentModel>();
    }

    //adds student to the sqlite
    public void AddStudent(StudentModel student) {
        int result = 0;

        try
        {
            Init();
            result = connection.Insert(student);
            StatusMessage = $"{result} Student added successfully!";
            Console.WriteLine(StatusMessage + result);
        }
        catch (Exception e){
            StatusMessage = e.Message;
            Console.WriteLine(StatusMessage);
        }
    }

    //gets all the student data from the table
    public List<StudentModel>  GetAllStudent() {
        try
        {
            Init(); //runs the connection to get all the students table information
            return connection.Table<StudentModel>().ToList();
        }
        catch (Exception e)
        {
            StatusMessage = $"Error: {e.Message}";
        }
        return null;
    }

    //update student 
    public void UpdateStudent(StudentModel student) {
        int result = 0;

        try {
            Init();
            result = connection.Update(student);
            StatusMessage = $"{result} Student updated successfully!";
            Console.WriteLine(StatusMessage + result);
        }
        catch (Exception e)
        {
            StatusMessage = $"Error: {e.Message}";
        }
    }

    //delete student
    public int DeleteStudent(int studentID)
    {
        int result = 0;

        try
        {
            Init();
            result = connection.Delete<StudentModel>(studentID);
            StatusMessage = $"{result} Student deleted successfully!";
            Console.WriteLine(StatusMessage + result);
            return result;
        }
        catch (Exception e)
        {
            StatusMessage = $"Error: {e.Message}";
        }

        return result;
    }
}

