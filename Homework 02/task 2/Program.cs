using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[] {"Pero", "Mirche", "Trpche", "Boro", "Cvetko"};
            string[] studentsG2 = new string[] { "Jovanka", "Svetlana", "Paraskeva", "Petrana", "Zhivka" };

            Console.WriteLine("There are two groups of students, enter 1 or 2 to acces the student names of the group!");

            int number = int.Parse(Console.ReadLine());
            

            switch (number)
            {
                case 1:
                    for (int i = 0; i< studentsG1.Length; i++)
                    {
                        Console.WriteLine(studentsG1[i]);
                    }
                    break;
                case 2:
                    for (int i = 0; i < studentsG2.Length; i++)
                    {
                        Console.WriteLine(studentsG2[i]);
                    }
                    break;
                default:
                    Console.WriteLine("No student names in the sellected group.");
                    break;
            }
        }
    }
}
