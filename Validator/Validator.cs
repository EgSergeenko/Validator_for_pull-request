using System;
using System.Collections.Generic;
using System.Linq;

namespace Validator
{
    public class Validator
    {
        private List<Student> _students = new List<Student>();

        private List<bool> _results = new List<bool>();

        private string RightAnswer;
        public Validator(string rightanswer)
        {
            RightAnswer = rightanswer;
        }
        public void AddStudent(Student student)
        {
            bool unique = true;
            for (int i = 0; i < _students.Count(); i++)
            {
                if (_students[i] == student)
                {
                    unique = false;
                    break;
                }
            }
            if (unique)
            {
                _students.Add(student);
                _results.Add(false);
            }
        }
        public void Validate(Student student)
        {
            for (int i = 0; i < _students.Count(); i++)
            {
                if (_students[i].Id == student.Id)
                {
                    if (student.Task.Text == RightAnswer)
                    {
                        _results[i] = true;
                    }
                }
            }
        }
        public void ValidateAll()
        {
            for (int i = 0; i < _students.Count(); i++)
            {
                if (_students[i].Task.Text == RightAnswer)
                {
                    _results[i] = true;
                }
            }
        }
        public Tuple<bool, bool> Check(Student student)
        {
            bool existence = false;
            bool success = false;
            for (int i = 0; i < _students.Count(); i++)
            {
                if (_students[i] == student)
                {
                    existence = true;
                    success = _students[i].Task.Text == RightAnswer;

                }
            }
            return Tuple.Create(existence, success);
        }
    }
}
