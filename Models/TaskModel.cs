using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class TaskModel
    {
        // The task ID
        public int Id { get; set; }

        // The task description
        [Display(Name = "Task Description")]
        public string TaskDescription { get; set; }

        // The task due date
        [Display(Name = "Task Due Date")]
        // Data annotation ensures no time data is needed - just date
        [DataType(DataType.Date)]
        public DateTime TaskDueDate { get; set; }

        // Indication as to whether the task is completed
        [Display(Name = "Task Completed")]
        public bool TaskCompleted { get; set; }
    }
}
