using aperture_case.Models;
using aperture_case.Services;
using aperture_case.Util;
using Microsoft.AspNetCore.Mvc;

namespace aperture_case.Controllers;

[ApiController]
[Route("[controller]")]
public class ActivationCodeController : ControllerBase
{
    private IActivationCodeService service;  
    private readonly ILogger<ActivationCodeController> logger;
    public ActivationCodeController(ILogger<ActivationCodeController> logger, IActivationCodeService service)
    {
        this.service = service; 
        this.logger = logger;
    }

    [HttpGet(Name = "GetActivationCode")]
    public ResultWithValue<ActivationCode> Get()
    {
        var key = NullUtil.GetValueOrDefault<string>(Request.Headers["AccessKey"].ToString(), ""); 
        return this.service.GetActivationCode(key); 
    }
}
