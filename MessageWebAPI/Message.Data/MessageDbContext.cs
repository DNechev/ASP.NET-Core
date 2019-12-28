using Message.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Message.Data
{
    public class MessageDbContext : DbContext
    {
        public DbSet<Message.Domain.Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }

        public MessageDbContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}
