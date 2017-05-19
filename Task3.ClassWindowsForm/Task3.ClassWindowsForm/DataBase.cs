using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.ClassWindowsForm
{
    class DataBase
    {
        public static List<DataBase> dataBase = new List<DataBase>();
        public string name;
        public string surname;
        public int id;
        public int course;

        public DataBase(string _name, string _surname, int _id, int _course)
        {
            name = _name;
            surname = _surname;
            id = _id;
            course = _course;
        }

        public override string ToString()
        {
            // Необходимо вывести все данные, которые должен видеть пользователь при вызове меода Console.WriteLine(student);	
            return "Name: " + name + "\n" + "Surname: " + surname + "\n" + "ID: " + id + "\n" + "Course: " + course + "\n";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            DataBase p = (DataBase)obj;
            return (id == p.id);
        }
        public override int GetHashCode()
        {
            return id;
        }
    }
}
