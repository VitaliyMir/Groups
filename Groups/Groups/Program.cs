using System;
using System.Collections.Generic;

namespace Groups
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a group manager
            GroupManagerEntity groupManager = new GroupManagerEntity();

            // Create a few groups
            GroupEntity groupA = new GroupEntity("Group A");
            GroupEntity groupB = new GroupEntity("Group B");
            groupManager.AddGroup(groupA);
            groupManager.AddGroup(groupB);

            // Create some students
            StudentEntity student1 = new StudentEntity("John Doe", 20, 1);
            StudentEntity student2 = new StudentEntity("Jane Doe", 19, 2);

            // Add students to group A
            groupA.AddStudent(student1);
            groupA.AddStudent(student2);

            // Find a group by name and display its students
            GroupEntity searchedGroup = groupManager.FindGroupByName("Group A");
            Console.WriteLine($"Students in {searchedGroup.Name}:");
            foreach (var student in searchedGroup.Students)
            {
                Console.WriteLine($"- {student.Name}");
            }

            // Create a teacher and assign a subject to them
            TeacherEntity teacher = new TeacherEntity("Mr. Smith", 45);
            SubjectEntity subject = new SubjectEntity("Mathematics", teacher);

            // Output the teacher's subject
            Console.WriteLine($"{teacher.Name} teaches {subject.Name}");
        }
    }
}