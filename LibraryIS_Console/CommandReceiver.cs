using LIS.Entities;
using LIS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryIS_Console
{
    public class CommandReceiver
    {
        BookService bookService;
        BorrowService borrowService;

        public CommandReceiver()
        {
            bookService = new BookService();
            borrowService = new BorrowService();
        }

        public void Start()
        {
            string command = "";
            do {
                command = Console.ReadLine();

                if (command.Equals("books")) {
                    ShowBookList();
                } else if (command.Equals("borrows")) {
                    ShowBorrowList();
                } else {
                    Console.WriteLine("Unknown command. Write books or borrows to show list.");
                }
            } while (!command.Equals("exit"));
        }

        private void ShowBookList()
        {
            List<Book> books = bookService.GetAll();
            foreach(Book b in books) {
                Console.WriteLine(b.ToString());
            }
        }

        private void ShowBorrowList()
        {
            List<Borrow> borrows = borrowService.GetAll();
            foreach (Borrow b in borrows) {
                Console.WriteLine(b.ToString());
            }
        }
    }
}
