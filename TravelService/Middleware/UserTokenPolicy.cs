﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace TravelService.Middleware
{
    public class UserTokenPolicy : AuthorizationHandler<UserTokenPolicyRequirement>
    {
        //private readonly IAccountRepository _accountRepository;
        //public UserTokenPolicy(IAccountRepository accountRepository)
        //{
        //    this._accountRepository = accountRepository;
        //}

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, UserTokenPolicyRequirement requirement)
        {
            var mvcContext = context.Resource as Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext;
            if (mvcContext == null)
            {
                context.Fail();
                return;
            }

            var headers = mvcContext?.HttpContext?.Request?.Headers;
            if (headers == null)
            {
                context.Fail();
                return;
            }
            else
            {
                var token = headers["Authorization"];
                var rawVal = token.FirstOrDefault();
                var tokenVal = rawVal?.Replace("Basic ", "");

                if (tokenVal == null)
                {
                    context.Fail();
                    return;
                }

                if (await this.IsValidToken(tokenVal))
                {
                    context.Succeed(requirement);
                    return;
                }

                context.Fail();
            }
        }

        private Task<bool> IsValidToken(string token)
        {
            //var account = await this._accountRepository.FindByToken(token);
            //return account != null;
            return Task.FromResult(true);
        }
    }
}
