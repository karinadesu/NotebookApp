using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookApp
{
    public class ActionsWithNotebook
    {
        
        static List<Note> allContacts = new List<Note>();

        public void CreateNewNote(Note newPerson) //Добавить запись
        {
            
            allContacts.Add(newPerson);
            foreach (Note contact in allContacts)
            {
                Console.WriteLine(contact);
            }
        }
        public void EditNote(int id) //Редактировать запись
        {
            Note wantToEdit = allContacts.Find(note => note.id == id);
            Console.WriteLine("This is your note №" + id);
            Console.WriteLine(wantToEdit);
            bool editing = true;
            while (editing)
            {
                Console.WriteLine("Please, choose the item you would like to edit.");
                Console.WriteLine("1. Last Name.");
                Console.WriteLine("2. Name.");
                Console.WriteLine("3. Patronymic.");
                Console.WriteLine("4. Phone.");
                Console.WriteLine("5. Country.");
                Console.WriteLine("6. Birthday.");
                Console.WriteLine("7. Organization.");
                Console.WriteLine("8. Post.");
                Console.WriteLine("9. Notice.");
                Console.WriteLine("10. Exit.");
                int text = Int32.Parse(Console.ReadLine());
                switch (text)
                {
                    case 1:
                        Console.WriteLine("Enter new last name");
                        string newLastName = Console.ReadLine();
                        wantToEdit.lastName = newLastName;
                        continue;
                    case 2:
                        Console.WriteLine("Enter new name");
                        string newName = Console.ReadLine();
                        wantToEdit.name = newName;
                        continue;
                    case 3:
                        Console.WriteLine("Enter new patronymic");
                        string newfName = Console.ReadLine();
                        wantToEdit.fname = newfName;
                        continue;
                    case 4:
                        Console.WriteLine("Enter new phone");
                        string newPhone = Console.ReadLine();
                        wantToEdit.phone = newPhone;
                        continue;
                    case 5:
                        Console.WriteLine("Enter new country");
                        string newCountry = Console.ReadLine();
                        wantToEdit.country = newCountry;
                        continue;
                    case 6:
                        Console.WriteLine("Enter new birthday");
                        string newBirthDate = Console.ReadLine();
                        DateTime myDate = Convert.ToDateTime(newBirthDate);
                        wantToEdit.birthDate = myDate;
                        continue;
                    case 7:
                        Console.WriteLine("Enter new organization");
                        string newOrganization = Console.ReadLine();
                        wantToEdit.organization = newOrganization;
                        continue;
                    case 8:
                        Console.WriteLine("Enter new post");
                        string newPost = Console.ReadLine();
                        wantToEdit.post = newPost;
                        continue;
                    case 9:
                        Console.WriteLine("Enter new notice");
                        string newNotice = Console.ReadLine();
                        wantToEdit.notice = newNotice;
                        continue;
                    case 10:
                        editing = false;
                        break;
                }
            }
        }
        public void DeleteNote(int id) //Удалить запись
        {
            Note wantToDelete = allContacts.Find(note => note.id==id);
            allContacts.Remove(wantToDelete);
        }
        public void ReadNote() //Вывести последнюю добавленную запись
        {
            Note newPerson = allContacts[allContacts.Count - 1];
            Console.WriteLine(newPerson);
        }
        public void ShowAllNotes() //Показать все записи
        {
            foreach (Note smallNote in allContacts)
            {
                Console.WriteLine(smallNote.ShowSmallNote());
            }
        }
    }
}
