using aperture_case.Models;

namespace Aperture.Datalayer; 

public interface IStorageClient {
    public Result StoreActivationCode(ActivationCode code);

    public ResultWithValue<ActivationCode> GetActivationCode(int acCode); 
}