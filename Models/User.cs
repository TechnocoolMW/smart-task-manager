using System.Collections.Generic;

namespace SmartTaskManager.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Role { get; set; } = "User";
        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}