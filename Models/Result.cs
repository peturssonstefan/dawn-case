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