using System;
using System.Collections;
using System.Collections.Generic;


namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            ListStudent listStudent = new ListStudent();
           
       
            do
            {
                Console.WriteLine("Меню \r\n 1)Добавить элемент \r\n 2)Найти элемент \r\n 3)Удалить элемент \r\n 0) Закончить ");
                int x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Введите номер студента");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите имя студента");
                        string NameStudent = Console.ReadLine();
                        Console.WriteLine("Введите курс студента");
                        int course = Convert.ToInt32(Console.ReadLine());
                        Student student = new Student(id, NameStudent, course);
                        listStudent.AddStudent(student);
                        listStudent.ShowList();

                        break;
                    case 2:
                        string find = Console.ReadLine();
                        listStudent.FindStudent(find);
                        break;
                    case 3:
                        int index = Convert.ToInt32(Console.ReadLine());
                        listStudent.DeleteStudent(index);
                        listStudent.ShowList();
                        break;
                    case 0 :
                       Console.WriteLine("Конец");
                        break;
                    default:
                        Console.WriteLine("Нет такого");
                        break;
                }
            } while (true);

        }

        class ListStudent 
        {

            private Student[] list = new Student[0];
            private int len = 0;


            public void AddStudent(Student student)
            {
                Array.Resize(ref list, list.Length + 1);

                if (len < list.Length)
                {
                    this.list[len] = student;
                    this.len++;
                }
                
                
            }

            public void FindStudent(String NameStudent)
            {
                for (int i = 0; i < this.list.Length; i++)
                {
                    if (list[i].NameStudent == NameStudent)
                    {
                        Console.WriteLine($"Номер студента {list[i].Id}, Имя студента {list[i].NameStudent}, курс {list[i].course}");
                    }
                }
            }

            public void DeleteStudent(int index)
            {
                Student[] NewList = new Student[list.Length - 1];
                for (int i = 0; i < index; i++)
                {
                    NewList[i] = list[i];

                }

                for (int b = index + 1; b < list.Length; b++)
                {
                    NewList[b - 1] = list[b];
                }

                list = NewList;
            }

            public void ShowList()
            {
                for (int i = 0; i < list.Length; i++)
                {
                    Console.WriteLine($"Номер студента {list[i].Id}, Имя студента {list[i].NameStudent}, курс {list[i].course}");
                }
            }


           
        }

        class Student
        {
            public int Id;
            public string NameStudent;
            public int course;
           

            public Student(int id, string nameStudent, int course)
            {
                Id = id;
                NameStudent = nameStudent;
                this.course = course;
                
            }
            
        }

    }
}