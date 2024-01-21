using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Application.Features.UserFeatures.GetUser
{

    public sealed record GetUserResponse
    {
        public Guid Id { get; set; }
        public  string Username { get; set; }
        public  string Name { get; set; }
        public  string NameEn { get; set; }
        public  string Email { get; set; }
        public DateTime? Birthdate { get; set; }
        public double? Salary { get; set; }
        public string? FCM { get; set; }
        public string? IDNumber { get; set; }
        public string Mobile { get; set; } = null!;
        public string? errorMsg { get; set; } = string.Empty!;
        public int? resultCode { get; set; } = 0;


    }
}
