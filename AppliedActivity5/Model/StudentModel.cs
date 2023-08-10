using System;
using SQLite;
namespace AppliedActivity5.Modal;

[Table("Students")]
public class StudentModel
{
    [PrimaryKey, AutoIncrement]
    public int StudentID { get; set; }

    [Column("student_name")]
    public String StudentName { get; set; }

    [Column("student_number")]
    public String StudentNumber { get; set; }

    [Column("address")]
    public String Address { get; set; }

    [Column("age")]
    public int Age { get; set; }  
}

