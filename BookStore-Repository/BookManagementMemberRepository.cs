using BookStore_Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Repository
{
    public class BookManagementMemberRepository
    {
        public BookManagementMember? Get(string email)
        {
            BookManagement2023DbContext dbcontext = new BookManagement2023DbContext();
                return dbcontext.BookManagementMembers.FirstOrDefault(x => x.Email == email);
        }
    }
}
