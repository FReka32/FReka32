using Microsoft.EntityFrameworkCore;
namespace Blog.Models
{
    public class BloggerContext : DbContext
    {
        public BloggerContext(DbContextOptions<BloggerContext> options) : base(options) { }

        DbSet<Blogger> Bloggers { get; set; } = null!;
    }
}
