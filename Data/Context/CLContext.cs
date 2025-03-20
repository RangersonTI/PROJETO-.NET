using System;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Data.Context{
    public class CLContext: DbContext
    {
        public DbSet<Cliente> Clientes {get; set;}

        public CLContext(DbContextOptions options): base(options){
            
        }
    }

}

