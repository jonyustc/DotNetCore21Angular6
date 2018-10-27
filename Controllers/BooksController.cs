using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyTestApp.Controllers.Resources;
using MyTestApp.Models;

namespace MyTestApp.Controllers {

    [Route("/api/books")]
    public class BooksController : ControllerBase {
        private readonly BlogDbContext context;
        private readonly IMapper mapper;
        public BooksController (IMapper mapper, BlogDbContext context) {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<BookResource>> GetBooks(){
            var books=await this.context.Books.Include(x=>x.Author).ToListAsync();
            return mapper.Map<IEnumerable<Book>,IEnumerable<BookResource>>(books);
        }

    }
}