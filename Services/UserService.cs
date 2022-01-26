using aperture_case.Datalayer;
using aperture_case.Models;

namespace aperture_case.Services;

public class UserService : IUserService
{
    private IActivationCodeService activationCodeService;
    private readonly IStorageClient storageClient;

    public UserService(IActivationCodeService activationCodeService, IStorageClient storageClient)
    {
        this.activationCodeService = activationCodeService;
        this.storageClient = storageClient;
    }

    public UserResult AddUser(User user, int accessCode)
    {
        var acCheck = this.activationCodeService.IsActivationCodeValid(accessCode);
        var pwCheck = Util.UserUtil.VerifyPassword(user.Password); 
        var emailCheck = Util.UserUtil.VerifyEmail(user.Email); 

        if(acCheck.Success){
            if(pwCheck.Success && emailCheck.Success) {
                var storageResult = storageClient.StoreUser(user);
                return new UserResult(storageResult.Success, acCheck.Success, pwCheck.Success, emailCheck.Success, storageResult.ErrorMessage); 
            }
            return new UserResult(false, acCheck.Success, pwCheck.Success, emailCheck.Success, Util.ResultUtil.JoinResultsMsg(new List<Result>(){pwCheck, emailCheck})); 
        }

        return new UserResult(false, acCheck.Success, pwCheck.Success, emailCheck.Success, Util.ResultUtil.JoinResultsMsg(new List<Result>(){acCheck, pwCheck, emailCheck})); 

    }
}