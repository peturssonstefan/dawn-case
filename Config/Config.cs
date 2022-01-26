namespace aperture_case.Config;

public class Config : IConfig
{
    public Config(string adminKey, string testKey)
    {
        this.KeyConf = new KeyConf(adminKey, testKey);  
    }

    public KeyConf KeyConf { get; set; }

}