using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Domain.Entities;

namespace Application.Features.UserFeatures.CreateUser
{

    public sealed record CreateUserRequest(
      string UserName,
      string Mobile,
      string Email) : IRequest<CreateUserResponse>;


}
