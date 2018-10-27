using AutoMapper;
using MyTestApp.Controllers.Resources;
using MyTestApp.Models;

namespace MyTestApp.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Post,PostResource>()
            .ForMember(dest=>dest.BlogUrl,map=>map.MapFrom(src=>src.Blog.Url)); 
            CreateMap<PostResource,Post>();
            CreateMap<Blog,BlogResource>();
            CreateMap<BlogResource,Blog>();
            CreateMap<Author,AuthorResourcs>();
            CreateMap<AuthorResourcs,Author>();
            CreateMap<Book,BookResource>()
                .ForMember(dest=>dest.Author,map=>map.MapFrom(src=>src.Author.Name));
            CreateMap<BookResource,Book>();
        }
    }
}