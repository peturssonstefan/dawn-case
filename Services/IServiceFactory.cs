namespace aperture_case.Services;

public interface IServiceFactory {
    public IActivationCodeService GetActivationCodeService(); 

    public IUserService GetUserService(IActivationCodeService acService); 
}