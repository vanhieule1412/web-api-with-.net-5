using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiwebwith.net5.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {

        }
        public List<TodoItem> TodoItemlist = new List<TodoItem>()
        {
            new TodoItem{Id =1, Name="H", IsComplete=true, Secret= "asdxc"},
            new TodoItem{Id =2, Name="HK", IsComplete=true, Secret= "zxcv"},
        };
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
