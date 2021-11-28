using System;

namespace Lab3.HomeWorks
{
    /// <summary>
    /// Класс для реализации метода сравнения объектов
    /// </summary>
    public class ClassTest : IComparable
    {
        private string name = "";

        public ClassTest(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get; set; }

        public override bool Equals(object? obj)
        {
            ClassTest classtest = (ClassTest)obj;
            if (classtest != null)
            {
                return this.Name == classtest.Name && this.Age == classtest.Age;
                
            }
                
            else
            {
                return false;
            }
        }

        public int CompareTo(object? obj)
        {
            ClassTest classTest = (ClassTest)obj;
            if (classTest != null)
            {
                if (this.Age > classTest.Age)
                {
                    return 1;
                }
                if (this.Age < classTest.Age)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new Exception("Невозможно сравнить два объекта");
            }
        }
    }
}