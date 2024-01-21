using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Application.Features.UserFeatures.CreateUser
{

    public sealed record CreateUserResponse
    {
        public Guid Id { get; set; }
     
    }
}
