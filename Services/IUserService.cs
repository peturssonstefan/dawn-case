using aperture_case.Models;

namespace aperture_case.Services; 

public interface IUserService {
    public UserResult AddUser(User user, int accessCode); 
}