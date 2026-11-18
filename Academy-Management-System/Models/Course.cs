using System;

namespace Academy_Management_System.Models;

public class Course: BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Student> Students { get; set; }
    public Course()
    {
        Id = 0;
        Name = string.Empty;
        Description = string.Empty;
        Students = new List<Student>();
    }
}
