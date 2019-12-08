using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TaskManager.Models;

namespace TaskManager.Data
{
    // This class is needed to coordinate EF Core functionality (Create, Read, Update, Delete) for the Task model
    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext(DbContextOptions<TaskManagerContext> options)
            : base(options)
        {

        }

        // Will correspond to the rows of the table
        public DbSet<TaskModel> Task { get; set; }

    }
}
