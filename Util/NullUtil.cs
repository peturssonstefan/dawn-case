namespace aperture_case.Util; 

public static class NullUtil {
    public static T GetValueOrDefault<T>(T? value, T def) {
        return value == null ? def : value; 
    }  
}