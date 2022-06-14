using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Security.Claims;
using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using BugNet.Data;
using AutoMapper;
using BugNet.Dtos;

namespace BugNet.Controllers
{

    [ApiController]
    [Route("/api/user")]
    [Authorize(AuthenticationSchemes = "Identity.Application, Bearer")]
    public class UserController : ControllerBase
    {
        private readonly IIdentityAPIRepo _repository;
        private readonly IMapper _mapper;

        public UserController(IIdentityAPIRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CommandReadUserDto>> GetAllCommands()
        {
            var users = _repository.GetAllUsers();
            return Ok(_mapper.Map<IEnumerable<CommandReadUserDto>>(users));
        }
    }

}