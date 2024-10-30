using BookStore_Repository;
using BookStore_Repository.Entities;

namespace Services
{
    public class BookService
    {
        private BookRepository _repo = new BookRepository();
        public List<Book> GetAllBooks()
        {
            return _repo.GetAll();
        }
    }
}