namespace TheBeautyForum.Web.ViewModels.User
{
    public class UserViewModel
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? ProfilePictureUrl { get; set; }

        public string? Email { get; set; }

        public string? Role { get; set; }
    }
}
