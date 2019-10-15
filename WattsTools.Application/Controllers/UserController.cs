using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using WattsTools.Domain.Entity;
using WattsTools.Domain.Interface.Services;
using WattsTools.Services.Services;

namespace WattsTools.Application.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService = new UserService();

        //public UserController(IUserService userService)
        //{
        //    _userService = userService;
        //}

        [HttpGet("{id}")]
        public User Get(Guid id)
        {
            try
            {
                var response = _userService.Get(id);

                if (response == null)
                {
                    Response.StatusCode = 204;
                    return null;
                }

                return response;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        [HttpPost]
        public User Insert([FromBody] User user)
        {
            try
            {
                var response = _userService.Insert(user);

                if (response == null)
                {
                    Response.StatusCode = 400;
                    return null;
                }

                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
