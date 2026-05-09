using System;

namespace TaskManagementSystem.Domain.Entities
{
    // Changed to 'public' so other layers can see it [1]
    public class TaskItem
    {
        public int Id { get; set; } // Primary Key

        // Required fields for the Task Management System [2]
        public string TaskTitle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Priority { get; set; } = "Medium"; // Low, Medium, High
        public DateTime DueDate { get; set; }
        public string Status { get; set; } = "Pending"; // For pending/completed filtering
        public string AssignedTo { get; set; } = string.Empty;
    }
}