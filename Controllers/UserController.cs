using aperture_case.Models;
using aperture_case.Services;
using aperture_case.Util;
using Microsoft.AspNetCore.Mvc;

namespace aperture_case.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{

    private IUserService service;  
    private readonly ILogger<UserController> logger;

    public UserController(ILogger<UserController> logger, IUserService service)
    {
        this.service = service; 
        this.logger = logger;
    }

    [HttpPost(Name = "User")]
    public UserResult PostUser([FromBody]NewUserModel request)
    {
        return this.service.AddUser(request.User, request.Code); 
    }
}
