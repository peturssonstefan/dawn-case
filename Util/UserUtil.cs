using aperture_case.Models;

namespace aperture_case.Util; 

public static class UserUtil {

    public static Result VerifyPassword(string password){
        var success = password.Length >= 8; 
        return success ? new Result(true) : new Result(false, "Password does not meet criterias."); 
    }

    public static Result VerifyEmail(string email){
        var success = email.Contains('@'); 
        return success ? new Result(true) : new Result(false, "Email does not meet criterias."); 
    }

}