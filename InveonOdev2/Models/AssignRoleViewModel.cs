public class AssignRoleViewModel
{
    public string UserId { get; set; } 
    public List<UserViewModel> Users { get; set; } 
    public List<RoleViewModel> Roles { get; set; } 
}

public class UserViewModel
{
    public string Id { get; set; } 
    public string Email { get; set; } 
}

public class RoleViewModel
{
    public string RoleName { get; set; } 
    public bool IsSelected { get; set; } 
}
