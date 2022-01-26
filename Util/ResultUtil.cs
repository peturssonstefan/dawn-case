using System.Linq; 
using aperture_case.Models;
namespace aperture_case.Util; 

public static class ResultUtil {
    public static string JoinResultsMsg(List<Result> results){
        return results.Aggregate("", (acc, val) => {
            return val.Success ? acc : acc + "\n" + val.ErrorMessage; 
        }); 
    }
}