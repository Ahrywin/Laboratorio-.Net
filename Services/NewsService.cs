

using API_AXIO.AxioModels;
using AutoMapper;

public class NewsService : INewsService
{
    private readonly AxioContext _context;
    private readonly IMapper _mapper;

    public NewsService(AxioContext context, IMapper mapper)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _mapper= mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<bool> SaveNews (NewsDTO newNews)
    {
        if (newNews == null)
        {
            throw new ArgumentNullException(nameof(newNews));
        }


            var news = _mapper.Map<NewsAxio>(newNews);
            news.NewsAxioId = Guid.NewGuid();
            news.NewsAxioIsDeleted = false;
            news.NewsAxioCreatedAt = DateTime.Now;
            
            _context.NewsAxio.Add(news);
           await  _context.SaveChangesAsync();
           return true;
        }    

}

public interface INewsService
{
     Task<bool> SaveNews (NewsDTO newNews);
}
 