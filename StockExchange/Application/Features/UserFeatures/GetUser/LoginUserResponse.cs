using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Application.Features.UserFeatures.GetUser
{

    public sealed record LoginUserResponse
    {
        public Guid Id { get; set; }
        public  string Username { get; set; }
        public  string Email { get; set; }
        public string Status { get; set; }
        public string ErrorMessage { get; set; }
        public int ErrorCode { get; set; }





    }
}
