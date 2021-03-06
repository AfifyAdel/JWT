﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JWT.Domain.Services
{
    interface ITokenService
    {
        public string GenerateAccessToken(ClaimsIdentity claims);
        public string GenerateRefreshToken();
        public ClaimsPrincipal GetClaimsFromExpiredToken(string token);
    }
}
