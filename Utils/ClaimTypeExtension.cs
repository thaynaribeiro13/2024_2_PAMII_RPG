using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RpgApi.Utils
{
    public static class ClaimTypeExtension
    {
        public static int UserID(this ClaimsPrincipal user){
            var id =
            user.Claims
            .FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;

            return int.Parse(id);
        }
    }
}