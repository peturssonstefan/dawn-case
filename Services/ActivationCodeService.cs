using aperture_case.Config;
using aperture_case.Datalayer;
using aperture_case.Models;

namespace aperture_case.Services;

public class ActivationCodeService : IActivationCodeService
{
    private IConfig config;
    private readonly IStorageClient storageClient;

    public ActivationCodeService(IConfig config, IStorageClient storageClient)
    {
        this.config = config;
        this.storageClient = storageClient;
    }

    public ResultWithValue<ActivationCode> GetActivationCode(string key)
    {
        if(key == config.KeyConf.AdminKey){
            var code = new ActivationCode(); 
            var clientResult = storageClient.StoreActivationCode(code); 
            return new ResultWithValue<ActivationCode>(code, clientResult.Success, clientResult.ErrorMessage);  
        }
        
        return new ResultWithValue<ActivationCode>(null, false, "Provided key does not have sufficient privileges"); 
    }

    public Result IsActivationCodeValid(int code)
    {
        throw new NotImplementedException(); 
    }
}