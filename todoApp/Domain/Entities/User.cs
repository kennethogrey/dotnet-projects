namespace Domain.Entities;

public class User : BaseEntity
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool IsActive { get; set; }
    public ICollection<Role> Roles { get; set; }
    public ICollection<UserRole> UserRoles { get; set; }
    public ICollection<Todo> Todos { get; set; }
}