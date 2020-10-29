using System;

namespace miniPT_4_Student_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            String Lname;
            String Fname;
            String Mname;
            Double age = 0;
            Double Glevel = 0;
            String school;
            String section;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("//(Welcome to Student Information Code)\\");
                Console.WriteLine();

                    Console.WriteLine(" [SAMPLE: Bendigosa, Cyrus Mydwyn Diaz]");
                    Console.WriteLine("========================================");
                    Console.WriteLine("1. Enter your Family Name: ");
                    Lname = Convert.ToString(Console.ReadLine());
                    Console.WriteLine();

                        Console.WriteLine("2. Enter your First Name: ");
                        Fname = Convert.ToString(Console.ReadLine());
                        Console.WriteLine();

                            Console.WriteLine("3. Enter your Middle Name: ");
                            Mname = Convert.ToString(Console.ReadLine());
                            Console.WriteLine();

                                Console.WriteLine("4. Enter your Age: ");
                                age = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine();

                                    Console.WriteLine(" [SAMPLE: Notre Dame of Cotabato]");
                                    Console.WriteLine("==================================");
                                    Console.WriteLine("5. Enter your School: ");
                                    school = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine();

                                        Console.WriteLine("6. Enter your Grade Level: ");
                                        Glevel = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine();

                                            Console.WriteLine("7. Enter your Section: ");
                                            section = Convert.ToString(Console.ReadLine());
                                            Console.WriteLine();
                                            Console.WriteLine();

                    Console.WriteLine("     STUDENT INFORMATION");
                    Console.WriteLine("    -----------------------");
     
                    Console.WriteLine("    $-Name: {0} {1} {2}",Lname, Fname, Mname);
                    Console.WriteLine("    $-Age: {3}",age);
                    Console.WriteLine("    $-School: {4}",school);
                    Console.WriteLine("    $-Section: {5}-{6}",Glevel, section);
                    Console.WriteLine();
                    Console.WriteLine("PRESS ANY 'KEY' TO EXIT");
                    Console.ReadLine();
        }
    }
}
