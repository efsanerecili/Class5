using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Userin melumatlarini daxil et:");
            Console.WriteLine("1)User ID daxil et:");
            int userId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2)User fullname daxil et:");
            string userFullname = Console.ReadLine();
            Console.WriteLine("3)Userin balini daxil et:");
            int userPoint = Convert.ToInt32(Console.ReadLine());
            Student user = new Student(userId, userFullname, userPoint);

           
            Console.WriteLine("\nUser melumati:");
            user.StudentInfo();


            Console.WriteLine("\nQrup melumatlarini daxil et:");
            Console.WriteLine("Qrupun nomresini daxil et:");
            string groupNo = Console.ReadLine();
            Console.WriteLine("Telebe limitini daxil et:");
            int studentLimit = Convert.ToInt32(Console.ReadLine());
            Group group = new Group(groupNo, studentLimit);
            Console.WriteLine("Qrup yaradildi.");

            
            int choice;
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Melumatlari goster");
                Console.WriteLine("2. Yeni qrup yarat");
                Console.WriteLine("3. Emeliyyatlar");
                Console.WriteLine("0. Bitdi.");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        
                        

                        Console.WriteLine("\nUser melumatlari:");
                        user.StudentInfo();
                        Console.WriteLine("Qrup melumatlari:");
                        Console.WriteLine($"Group No: {group.GroupNo}, Student Limit: {group.StudentLimit}");
                        break;
                    case 2:
                        
                        Console.WriteLine("\nQrup melumatlari daxil et:");
                        Console.WriteLine("Qrupun nomresini daxil et:");
                        groupNo = Console.ReadLine();
                        Console.WriteLine("Telebe limitini daxil et:");
                        studentLimit = Convert.ToInt32(Console.ReadLine());
                        group = new Group(groupNo, studentLimit);
                        Console.WriteLine("Qrup yaradildi.");
                        break;
                    case 3:
                        
                        int operationChoice;
                        do
                        {
                            Console.WriteLine("\nEmeliyyatlar:");
                            Console.WriteLine("1.Qrupa telebe elave et");
                            Console.WriteLine("2.Qrupdaki butun telebeleri goster");
                            Console.WriteLine("0.Esas menuyuya qayit");
                            operationChoice = Convert.ToInt32(Console.ReadLine());

                            switch (operationChoice)
                            {
                                case 1:
                                   
                                    Console.WriteLine("\nTelebe melumatlarini daxil et:");
                                    Console.WriteLine("Telebe Id daxil et:");
                                    int newStudentId = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Telebenin fullname daxil et:");
                                    string newStudentFullname = Console.ReadLine();
                                    Console.WriteLine("Telebenin balini daxil et:");
                                    int newStudentPoint = Convert.ToInt32(Console.ReadLine());
                                    Student newStudent = new Student(newStudentId, newStudentFullname, newStudentPoint);
                                    group.AddStudent(newStudent);
                                    Console.WriteLine("Qrupa telebe elave olundu.");
                                    break;
                                case 2:
                                    Console.WriteLine("Qrupdaki butun telebeler:");
                                    foreach (var student in group.GetAllStudents())
                                    {
                                        student.StudentInfo();
                                    }
                                    break;
                                case 0:

                                    break;
                                default:
                                    Console.WriteLine("Yanlis secim. Zehmet olmasa yeniden daxil edin.");
                                    break;
                            }
                        } while (operationChoice != 0);
                        break;
                    case 0:
                        
                        Console.WriteLine("Proqram basa catdi.");
                        break;
                    default:
                        Console.WriteLine("Yanlis secim. Zehmet olmasa yeniden daxil edin.");
                        break;
                }
            } while (choice != 0);
        }
    }
}

