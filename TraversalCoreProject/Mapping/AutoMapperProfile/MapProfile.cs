using AutoMapper;
using DTOLayer.DTOs.AnnouncemetDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using EntityLayer.Concrete;

namespace TraversalCoreProject.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncemetAddDTO, Announcemet>().ReverseMap();
            //CreateMap<Announcemet, AnnouncemetAddDTO>();

            CreateMap<AppUserRegisterDTO, AppUser>().ReverseMap();

            CreateMap<AppUserLoginDTO, AppUser>().ReverseMap();

            CreateMap<AnnouncemetListDTO, Announcemet>().ReverseMap();

            CreateMap<AnnouncemetUpdateDTO, Announcemet>().ReverseMap();

        }
    }
}
