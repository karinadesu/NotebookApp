using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NotebookApp
{
    class Notebook
    {
        
        static void Main(string[] args)
        {
            ActionsWithNotebook notes = new ActionsWithNotebook();
            Console.WriteLine("~~~Welcome to NoteBook!~~~");

            int id = 0;
            bool makeNote = true;
            while (makeNote)
            {
                
                Console.WriteLine("Select the number of command that you want to do.");
                Console.WriteLine("1. Add a note.");
                Console.WriteLine("2. Edit a note.");
                Console.WriteLine("3. Delete a note.");
                Console.WriteLine("4. Read an added note.");
                Console.WriteLine("5. Show all notes.");
                Console.WriteLine("6. Close NoteBook.");
                try
                {

                int input = Int32.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:                            // Add a note
                        Console.Clear();
                        Console.WriteLine("Alright! Write down some information about a person.");
                        string lastName = null;
                        bool check = true;
                            while (check)
                            {
                                Console.Write("\nLast Name*: ");
                                lastName = Console.ReadLine();
                                
                                if (String.IsNullOrWhiteSpace(lastName))
                                {
                                    Console.WriteLine("\nThis field is required.");
                                    continue;
                                }
                                else if (!lastName.All(Char.IsLetter))
                                {
                                    Console.WriteLine("Only letter is valid");
                                    continue;
                                }
                                else
                                {
                                    check = false;
                                    break;
                                }
                            }

                            check = true;
                            string name = null;
                            while (check)
                            {
                                Console.Write("\nName*: ");
                                name = Console.ReadLine();

                                if (String.IsNullOrWhiteSpace(name))
                                {
                                    Console.WriteLine("\nThis field is required.");
                                    continue;
                                }
                                else if (!name.All(Char.IsLetter))
                                {
                                    Console.WriteLine("\nOnly letter is valid");
                                    continue;
                                }
                                else
                                {
                                    check = false;
                                    break;
                                }
                            }

                            string fname = null;
                            check = true;
                            while (check)
                            {
                                Console.Write("\nPatronymic: ");
                                fname = Console.ReadLine();

                                if (!fname.All(Char.IsLetter))
                                {
                                    Console.WriteLine("\nOnly letter is valid");
                                    continue;
                                }
                                else
                                {
                                    check = false;
                                    break;
                                }
                            }
                            

                            check = true;
                            string phone=null;
                            while (check)
                            {
                                Console.Write("\nPhone*: ");
                                phone = Console.ReadLine();

                                if (String.IsNullOrWhiteSpace(phone))
                                {
                                    Console.WriteLine("\nThis field is required.");
                                    continue;
                                }
                                else if(!phone.All(Char.IsDigit))
                                {
                                    Console.WriteLine("\nOnly digits is valid");
                                    continue;
                                }
                                else
                                {
                                    check = false;
                                    break;
                                }
                            }
                            
                            string country = null;
                            check = true;
                            while (check)
                            {
                                Console.Write("\nCountry*: ");
                                country = Console.ReadLine();

                                if (String.IsNullOrWhiteSpace(country))
                                {
                                    Console.WriteLine("\nThis field is required.");
                                    continue;
                                }
                                else if (!country.All(Char.IsLetter))
                                {
                                    Console.WriteLine("Only letter is valid");
                                    continue;
                                }
                                else
                                {
                                    check = false;
                                    break;
                                }
                            }

                        Console.Write("\nBirthday(dd/mm/yy): ");
                        string birthDate = Console.ReadLine();
                        DateTime myDate = Convert.ToDateTime(birthDate);

                        Console.Write("\nOrganization: ");
                        string organization = Console.ReadLine();

                        Console.Write("\nPost: ");
                        string post = Console.ReadLine();

                        Console.Write("\nNotice: ");
                        string notice = Console.ReadLine();

                        Note newPerson = new Note(lastName, name, phone, country);

                        newPerson.fname = fname;
                        newPerson.birthDate = myDate;
                        newPerson.organization = organization;
                        newPerson.post = post;
                        newPerson.notice = notice;
                        id++;
                        newPerson.id = id;
                        notes.CreateNewNote(newPerson);
                        Console.Clear();
                        continue;

                    case 2: //Edit
                        Console.WriteLine("Write down the number of a note you want to edit.");
                        int editid = Int32.Parse(Console.ReadLine());
                        notes.EditNote(editid);

                        continue;

                    case 3: //Delete
                        Console.WriteLine("Write down the number of a note you want to remove.");
                        int deleteid = Int32.Parse(Console.ReadLine());
                        notes.DeleteNote(deleteid);
                        continue;

                    case 4: //Read
                        notes.ReadNote();
                        continue;

                    case 5: //Show all
                        notes.ShowAllNotes();
                        continue;

                    case 6: //Close
                        Console.Clear();
                        Console.WriteLine("~~~Good bye!~~~");
                        break;
                    default:
                            Console.WriteLine("\nThere is no such option.");
                            break;
                }
                }
                catch (Exception)
                {

                    Console.WriteLine("\n ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n  You have " +
                        "written something incorrectly. Please, try again.\n ~~~~~~~~~~" +
                        "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                    continue;
                }
                //input = "exit";
                makeNote = false;
            }
            Console.ReadKey();
        }

        private static bool IsNullOrWhiteSpace(long phone)
        {
            throw new NotImplementedException();
        }
    }
}
