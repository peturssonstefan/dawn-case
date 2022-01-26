namespace aperture_case.Config; 

public class KeyConf {

    public KeyConf(string adminKey, string testKey)
    {
        this.AdminKey = adminKey; 
        this.TestKey = testKey; 
    }
    public string AdminKey { get; set; }    

    public string TestKey { get; set; }
}   