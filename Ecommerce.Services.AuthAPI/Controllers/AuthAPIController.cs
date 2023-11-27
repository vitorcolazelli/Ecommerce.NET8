﻿using Ecommerce.Services.AuthAPI.Models;
using Ecommerce.Services.AuthAPI.Models.Dto;
using Ecommerce.Services.AuthAPI.Services.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Services.AuthAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {
        private readonly IAuthService _authService;
        protected ResponseDto _response;

        public AuthAPIController(IAuthService authService)
        {
            _authService = authService;
            _response = new();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterationRequestDto model)
        {
            var errorMessage = await _authService.Register(model);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                _response.IsSuccess = false;
                _response.Message = errorMessage;

                return BadRequest(_response);
            }

            return Ok(_response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto model)
        {
            var loginReponse = await _authService.Login(model);

            if (loginReponse.User == null)
            {
                _response.IsSuccess = false;
                _response.Message = "Username or password is incorrect";

                return BadRequest(_response);
            }

            _response.Result = loginReponse;
            return Ok(_response);
        }

        [HttpPost("assignRole")]
        public async Task<IActionResult> AssignRole([FromBody] RegisterationRequestDto model)
        {
            var assignRoleSuccessfull = await _authService.AssignRole(model.Email, model.Role.ToUpper());

            if (!assignRoleSuccessfull)
            {
                _response.IsSuccess = false;
                _response.Message = "Error Encountered";

                return BadRequest(_response);
            }

            return Ok(_response);
        }
    }
}
