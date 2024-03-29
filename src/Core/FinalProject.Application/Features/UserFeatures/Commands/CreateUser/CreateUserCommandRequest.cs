﻿using FinalProject.Application.DTOs.User;
using FinalProject.Application.Wrappers.Base;
using MediatR;

namespace FinalProject.Application.Features.UserFeatures.Commands.CreateUser
{
    public class CreateUserCommandRequest : IRequest<BaseResponse<UserCommandDto>>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
