using API_AXIO.AxioModels;
using AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<NewsDTO, NewsAxio>();
    }
}