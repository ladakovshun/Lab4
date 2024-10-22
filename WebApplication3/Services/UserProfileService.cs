using WebApplication3.Models; 

namespace WebApplication3.Services
{
    public class UserProfileService
    {
        private readonly List<UserProfile> _userProfiles = new()
        {
            new UserProfile { Id = 1, Name = "Kovshun Lada", Email = "kovshun.lada@gmail.com" },
            new UserProfile { Id = 2, Name = "Harlamova Olena", Email = "harlam.olen@example.com" },
            // Додайте інші профілі за потреби
        };

        public UserProfile GetUserProfile(int id)
        {
            return _userProfiles.FirstOrDefault(profile => profile.Id == id); // Повернення профілю за ID
        }
    }
}

