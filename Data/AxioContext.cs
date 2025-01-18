using API_AXIO.AxioModels;
using Microsoft.EntityFrameworkCore;

public partial class AxioContext : DbContext
{
    public AxioContext()
    {
    }
    public AxioContext (DbContextOptions<AxioContext> options) : base(options)
    {
    }
    public virtual DbSet<NewsAxio> NewsAxio { get; set;}


}
