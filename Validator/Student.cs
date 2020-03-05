using System;

namespace Validator
{
    public class Student
    {
        public string Name;
        public Guid Id;
        public Task Task;
        public String Group;

        public Student(string name)
        {
            Id = new Guid();
            Name = name;
        }
        public void DoTask(string text)
        {
            Task = new Task(text);
        }
    }
}
