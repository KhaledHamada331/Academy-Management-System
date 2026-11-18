using System;
using Academy_Management_System.Common;

namespace Academy_Management_System.Models;

public class Student: BaseEntity
{
    public string Name { get; set; } 
    public string Email { get; set; } 
    public string PhoneNumber { get; set; } 
    public List<Course> Courses { get; set; } 
    public Student()
    {
        Id = 0 ;
        Name = string.Empty;
        Email = string.Empty;
        PhoneNumber = string.Empty;
        Courses = new List<Course>();
    }
}
