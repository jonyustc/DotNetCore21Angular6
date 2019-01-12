using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyTestApp.Controllers.Resources;
using MyTestApp.Models;

namespace MyTestApp.Controllers {

    [Route ("/api/authors")]
    public class AuthorsController : ControllerBase {
        private readonly BlogDbContext context;
        private readonly IMapper mapper;
        public AuthorsController (IMapper mapper, BlogDbContext context) {
            this.mapper = mapper;
            this.context = context;

        }

        [HttpGet]
        public async Task<IEnumerable<AuthorResourcs>> GetAuthors () {
            var authors = await context.Authors.ToListAsync ();
            return mapper.Map<IEnumerable<Author>, IEnumerable<AuthorResourcs>> (authors);
        }

    }
}