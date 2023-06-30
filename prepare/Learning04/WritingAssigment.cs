using System;

public class WrittingAssigment : Assignment
{
     private string _title = "";

     public WrittingAssigment( string studentName, string topic, string title): base(studentName, topic)
     {
        _title = title;
     }

     public string GetWrittingInformation()
     {
        return $"{_title} by {GetStudentName()}";
     }
}