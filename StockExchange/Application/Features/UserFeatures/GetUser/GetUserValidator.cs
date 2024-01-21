using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.UserFeatures.GetUser
{
    public sealed class GetUserValidator : AbstractValidator<GetUserRequest>
    {
        public GetUserValidator() {
            RuleFor(x => x.Username).NotEmpty().WithMessage("UserNameRequired");
        }
    }
}
