﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Features.UserFeatures.GetUser
{

    public sealed record GetUserRequest(
      string Username
   ) : IRequest<GetUserResponse>;


}
