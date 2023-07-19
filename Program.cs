using System;
using System.IO;
////File handling in document management system
namespace Assignment10
{
    public class Operations
    {
        static void CreateFile(string fileName, string content)
        {
            try
            {
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.Write(content);
                }
                Console.WriteLine($"File '{fileName}' created successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in file creation {ex.Message}");
            }
        }

        static void ReadFile(string fileName)
        {
            try
            {
                string content = File.ReadAllText(fileName);
                Console.WriteLine($"Content of file '{fileName}':\n{content}");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File '{fileName}' not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in file reading {ex.Message}");
            }
        }

        static void AppendToFile(string fileName, string content)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    sw.Write(content);
                }
                Console.WriteLine($"Content appended to file '{fileName}' successfully.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File '{fileName}' not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in  file appending {ex.Message}");
            }
        }

        static void DeleteFile(string fileName)
        {
            try
            {
                File.Delete(fileName);
                Console.WriteLine($"File '{fileName}' deleted successfully.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File '{fileName}' not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in  file deleting {ex.Message}");
            }

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("****CHOOSE AN OPERATION****");
                    Console.WriteLine("\n 1.Create\n 2.Read \n 3.Append \n 4.Delete");
                    Console.WriteLine("\n Enter your choice:");

                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter file name: ");
                            string createFileName = Console.ReadLine();
                            Console.Write("Enter file content: ");
                            string content = Console.ReadLine();
                            CreateFile(createFileName, content);
                            break;

                        case 2:
                            Console.Write("Enter file name to read: ");
                            string readFileName = Console.ReadLine();
                            ReadFile(readFileName);
                            break;

                        case 3:
                            Console.Write("Enter file name to append: ");
                            string appendFileName = Console.ReadLine();
                            Console.Write("Enter content to append: ");
                            string appendContent = Console.ReadLine();
                            AppendToFile(appendFileName, appendContent);
                            break;

                        case 4:
                            Console.Write("Enter file name to delete: ");
                            string deleteFileName = Console.ReadLine();
                            DeleteFile(deleteFileName);
                            break;

                      
                        default:
                            Console.WriteLine("Invalid choice!!!!");
                            break;

                    }

                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();

                }
            }

        }
    }
}
