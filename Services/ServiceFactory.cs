using aperture_case.Config;
using aperture_case.Datalayer;

namespace aperture_case.Services;

public class ServiceFactory : IServiceFactory
{
    private IConfig config;
    private readonly IStorageClient storageClient;

    public ServiceFactory(IConfig config, IStorageClient storageClient)
    {
        this.config = config;
        this.storageClient = storageClient;
    }

    public IActivationCodeService GetActivationCodeService()
    {
        return new ActivationCodeService(config, storageClient); 
    }
}