namespace aperture_case.Models;

public class Result {
    public Result(bool success, string errorMessage = "")
    {
        this.Success = success; 
        this.ErrorMessage = errorMessage;  
    }

    public bool Success { get; set; }
    public string ErrorMessage { get; set; }

}


public class ResultWithValue<T> : Result {

    public ResultWithValue(T? value, bool success, string errorMessage = ""): base(success, errorMessage)
    {
        if(success){
            this.Value = value; 
        }
    }
    public T? Value { get; private set; }
}

public class UserResult : Result {

    public UserResult(bool success, bool acCheck ,bool pwCheck, bool emailCheck, string errorMesssage = ""): base(success, errorMesssage)
    {
        this.PasswordCheckPassed = pwCheck; 
        this.EmailCheckPassed = emailCheck; 
        this.ActivationCodePassed = acCheck; 
    }

    public bool PasswordCheckPassed { get; }
    public bool EmailCheckPassed { get; }
    public bool ActivationCodePassed { get; }
}