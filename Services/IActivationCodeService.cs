using aperture_case.Models; 
namespace aperture_case.Services {
    public interface IActivationCodeService {
        public ResultWithValue<ActivationCode> GetActivationCode(string key); 
        public Result IsActivationCodeValid(int activationCode); 
        
    }
}