using aperture_case.Models;

namespace aperture_case.Datalayer;

public class StorageClient : IStorageClient
{
    private List<ActivationCode> activationCodeDB;

    public StorageClient()
    {
        this.activationCodeDB = new List<ActivationCode>(); 
    }

    public ResultWithValue<ActivationCode> GetActivationCode(int acCode)
    {
        throw new NotImplementedException(); 
    }

    public Result StoreActivationCode(ActivationCode code)
    {
        activationCodeDB.Add(code); 
        return new Result(true);
    }
}