using System;

namespace Academy_Management_System.Models;

public class Instructor: BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public List<Course> Courses { get; set; }
    public Instructor()
    {
        Name = string.Empty;
        Email = string.Empty;
        PhoneNumber = string.Empty;
        Courses = new List<Course>();
    }
}
