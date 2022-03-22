using System;
using Microsoft.EntityFrameworkCore; 




namespace ChallengeApi.Models
{
    public class ContactsContext : DbContext
    {
        public ContactsContext (DbContextOptions<ContactsContext> options) 
            : base(options)
        {
        }
        public DbSet<Contacts> Contacts { get; set; }
    }
}
