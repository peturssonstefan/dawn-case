namespace aperture_case.Models; 

public class ActivationCode {

    public ActivationCode(int code)
    {
        this.Code = code;
        this.Date = DateTime.Now; 
    }

    public ActivationCode()
    {
        var rand = new Random(); 
        this.Code = rand.Next(100000, 1000000); 
        this.Date = DateTime.Now;
    }

    public int Code { get; set; }
    public DateTime Date { get; }
}