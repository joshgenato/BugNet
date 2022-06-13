using System.ComponentModel.DataAnnotations;

namespace BugNet.Dtos
{
    public class CommandReadUserDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}