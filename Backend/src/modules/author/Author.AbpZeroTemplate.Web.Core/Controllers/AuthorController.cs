using Abp.AspNetCore.Mvc.Controllers;
using Abp.Dependency;
using Author.AbpZeroTemplate.Application.Share.Author.Dto;
using Author.AbpZeroTemplate.Web.Core.Author;
using BukStore.AbpZeroTemplate.Sessions.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Author.AbpZeroTemplate.Application.Controllers
{
    [Route("api/[controller]/[action]")]
    public class AuthorController : AbpController
    {
        private readonly IAuthorAppService AuthorAppService;

        public AuthorController(IAuthorAppService AuthorAppService)
        {
            this.AuthorAppService = AuthorAppService;
        }
        [HttpPost]
        public IDictionary<string, object> AUTHOR_Insert([FromBody]AuthorInsertDto input)
        {
            return AuthorAppService.AUTHOR_Insert(input);
        }
     
        [HttpPost]
        public IDictionary<string, object> AUTHOR_Del(int Ma)
        {
            return AuthorAppService.AUTHOR_Del(Ma);
        }
   
        [HttpPost]
        public List<AuthorSearchDto> AUTHOR_Search([FromBody]AuthorSearchDto input)
        {
            return AuthorAppService.AUTHOR_Search(input);
        }

    }
}
