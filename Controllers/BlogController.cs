using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyTestApp.Controllers.Resources;
using MyTestApp.Models;

namespace MyTestApp.Controllers
{
    [Route("api/Blog")]
    public class BlogController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly BlogDbContext _dbcontext;

        public BlogController(IMapper mapper,BlogDbContext dbContext)
        {
            _mapper=mapper;
            _dbcontext=dbContext;
        }

        public async Task<IEnumerable<BlogResource>> GetBlogs(){
            var blogList= await _dbcontext.Blogs.ToListAsync();

            return _mapper.Map<IEnumerable<Blog>,IEnumerable<BlogResource>>(blogList);

        }
    }
}