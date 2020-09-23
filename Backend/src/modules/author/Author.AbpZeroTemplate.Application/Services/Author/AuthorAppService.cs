using System.Linq;
using System.Linq.Dynamic.Core;
using System.Collections.Generic;
using BukStore.AbpZeroTemplate.Helpers;
using BukStore.AbpZeroTemplate.Sessions;
using Author.AbpZeroTemplate.Application.Share.Author.Dto;
using Microsoft.AspNetCore.Builder;
using Abp.Application.Services;
using Abp.Runtime.Session;
using System.Threading.Tasks;
using BukStore.AbpZeroTemplate.Sessions.Dto;

namespace Author.AbpZeroTemplate.Web.Core.Author
{
    public interface IAuthorAppService : IApplicationService
    {
 
        IDictionary<string, object> AUTHOR_Insert(AuthorInsertDto input);
        IDictionary<string, object> AUTHOR_Del(int Ma);
        List<AuthorSearchDto> AUTHOR_Search(AuthorSearchDto input);


    }
    public class AuthorAppService : BaseService, IAuthorAppService
    {
        public AuthorAppService()
        {

        }
    
        public IDictionary<string, object> AUTHOR_Insert(AuthorInsertDto input)
        {
            return procedureHelper.GetData<dynamic>("AUTHOR_Insert", input).FirstOrDefault();
        }

        public IDictionary<string, object> AUTHOR_Del(int Ma)
        {
            return procedureHelper.GetData<dynamic>("AUTHOR_Del", new
            {
                Ma = Ma
            }).FirstOrDefault();
        }
        public List<AuthorSearchDto> AUTHOR_Search(AuthorSearchDto input)
        {
            return procedureHelper.GetData<AuthorSearchDto>("AUTHOR_Search", input);
        }
    
    }
}
