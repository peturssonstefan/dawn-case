namespace aperture_case.Models; 

public class User {
    public User(string email, string password, string fullname)
    {
        Email = email;
        Password = password;
        Fullname = fullname;
    }

    public string Email { get; }
    public string Password { get; }
    public string Fullname { get; }
}