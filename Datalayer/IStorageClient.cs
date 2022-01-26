using aperture_case.Models;

namespace aperture_case.Datalayer; 

public interface IStorageClient {
    public Result StoreActivationCode(ActivationCode code);

    public ResultWithValue<ActivationCode> GetActivationCode(int acCode); 
}