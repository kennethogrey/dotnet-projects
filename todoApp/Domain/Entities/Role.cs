namespace Domain.Entities;

public class Role : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Permission> Permissions { get; set; }
    public ICollection<RolePermission> RolePermissions { get; set; }
    public ICollection<User> Users { get; set; }
    public ICollection<UserRole> UserRoles { get; set; }
}