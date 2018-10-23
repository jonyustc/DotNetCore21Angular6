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

        [HttpPost]
        public async Task<IActionResult> CreatePost([FromBody] PostResource post){
            if(!ModelState.IsValid){
                return BadRequest(ModelState);
            }

            var mapPost=_iMapper.Map<PostResource,Post>(post);
            _context.Posts.Add(mapPost);
            await _context.SaveChangesAsync();
            return Ok(mapPost);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPost(int id){
            var post=await _context.Posts.FindAsync(id);
            if(post==null){
                return NotFound();
            }

            var postResource=_iMapper.Map<Post,PostResource>(post);
            return Ok(postResource);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePost(int id,[FromBody] PostResource post){
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            
            var postInDb= await _context.Posts.FindAsync(id);
            if(postInDb==null)
                return NotFound();
            
            _iMapper.Map<PostResource,Post>(post,postInDb);
            await _context.SaveChangesAsync();
            return Ok(postInDb);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(int id){
            var post=await _context.Posts.FindAsync(id);
            if(post==null)
                return NotFound();
            
            _context.Remove(post);
            await _context.SaveChangesAsync();
            return Ok(id);
        }
    }
}