using aperture_case.Models;

namespace aperture_case.Datalayer;

public class StorageClient : IStorageClient
{
    private List<User> userDB;

    private List<ActivationCode> activationCodeDB;

    public StorageClient()
    {
        this.userDB = new List<User>(); 
        this.activationCodeDB = new List<ActivationCode>(); 
    }

    public ResultWithValue<ActivationCode> GetActivationCode(int acCode)
    {
        var code = this.activationCodeDB.FirstOrDefault(x => x.Code == acCode); 
        if(code != null){
            if((DateTime.Now - code.Date).TotalHours < 1){
                return new ResultWithValue<ActivationCode>(code, true); 
            }
            return new ResultWithValue<ActivationCode>(code, false, "Activation code expired."); 
        }
        return new ResultWithValue<ActivationCode>(null, false, "Invalid activation code"); 
    }

    public Result StoreActivationCode(ActivationCode code)
    {
        activationCodeDB.Add(code); 
        return new Result(true);
    }

    public Result StoreUser(User user) {
        userDB.Add(user); 
        return new Result(true); 
    }
}