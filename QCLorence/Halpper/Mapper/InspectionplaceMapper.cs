using AutoMapper;
using QCLorence.Domain;
using QCLorence.Domain.DataModel;
using static QCLorence.ViewModel.InspectionplaceViewmodel;

namespace QCLorence.Halpper.Mapper
{
    public static class InspectionplaceMapper
    {
        public static List<InspectionplaceDetails> ToModel(this List<InspactionPlaceDTO> entity)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<InspactionPlaceDTO, InspectionplaceDetails>()
                    .ForMember(dest => dest.InspectionplaceId, mo => mo.MapFrom(src => src.inspectionplace.InspectionplaceId))
                    .ForMember(dest => dest.PlaseName, mo => mo.MapFrom(src => src.inspectionplace.PlaseName))
                    .ForMember(dest => dest.Description, mo => mo.MapFrom(src => src.inspectionplace.Description));
            });
            IMapper mapper = config.CreateMapper();
            return mapper.Map<List<InspactionPlaceDTO>, List<InspectionplaceDetails>>(entity);
        }

        public static Inspectionplace ToModel(this InspectionplaceDetails entity)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<InspectionplaceDetails, Inspectionplace>()
                    .ForMember(dest => dest.InspectionplaceId, mo => mo.MapFrom(src => src.InspectionplaceId))
                    .ForMember(dest => dest.PlaseName, mo => mo.MapFrom(src => src.PlaseName))
                    .ForMember(dest => dest.Description, mo => mo.MapFrom(src => src.Description));
            });
            IMapper mapper = config.CreateMapper();
            return mapper.Map<InspectionplaceDetails, Inspectionplace>(entity);
        }
        public static InspectionplaceDetails ToModel(this Inspectionplace entity)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Inspectionplace, InspectionplaceDetails>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<Inspectionplace, InspectionplaceDetails>(entity);
        }

    }
}
