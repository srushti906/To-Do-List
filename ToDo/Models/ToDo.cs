

using System.ComponentModel.DataAnnotations;

namespace ToDo.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = String.Empty;

        [DataType(DataType.MultilineText)]
        public string Details { get; set; } = String.Empty;

        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Display(Name = "Is Done")]
        public bool IsDone { get; set; }

        // Additional fields
        [Required]
        [Range(1, 3, ErrorMessage = "Priority must be between 1 (Low) and 3 (High).")]
        public int Priority { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; } = String.Empty;

        [DataType(DataType.DateTime)]
        [Display(Name = "Reminder Date")]
        public DateTime? ReminderDate { get; set; }

        [Display(Name = "Attachment")]
        public string? AttachmentPath { get; set; }

        public string? UserId { get; set; }

        [Display(Name = "Is Recurring")]
        public bool IsRecurring { get; set; }

        [Display(Name = "Recurring Interval (in Days)")]
        public int? RecurringInterval { get; set; }

        [Display(Name = "Tags")]
        public string Tags { get; set; } = String.Empty;

        [Range(0, 100)]
        [Display(Name = "Completion Percentage")]
        public int CompletionPercentage { get; set; } = 0;

        [Display(Name = "Estimated Duration (in hours)")]
        public double EstimatedDuration { get; set; }

        [Display(Name = "Task Color")]
        public string Color { get; set; } = "#FFFFFF";
    }
}

