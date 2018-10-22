using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyTestApp.Controllers.Resources;
using MyTestApp.Models;

namespace MyTestApp.Controllers
{
    [Route("api/Post")]
    public class PostController : ControllerBase
    {
        private readonly IMapper _iMapper;
        private readonly BlogDbContext _context;
        public PostController(IMapper iMapper,BlogDbContext context)
        {
            _iMapper=iMapper;
            _context=context;
        }

        public async Task<IEnumerable<PostResource>> GetPosts(){
            var posts = await _context.Posts.Include(x=>x.Blog).ToListAsync();
            return _iMapper.Map<IEnumerable<Post>,IEnumerable<PostResource>>(posts);
        }
    }
}