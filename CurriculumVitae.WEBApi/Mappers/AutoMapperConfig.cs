using AutoMapper;
using CurriculumVitae.Domain.Models;
using CurriculumVitae.WEBApi.Models;

namespace CurriculumVitae.WEBApi.Mappers
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.CreateMap<Domain.Models.Profile, ProfileViewModel>();
                x.CreateMap<Address, AddressViewModel>();
                x.CreateMap<Career, CareerViewModel>();
                x.CreateMap<Contact, ContactViewModel>();
                x.CreateMap<Education, EducationViewModel>();
                x.CreateMap<Entity, EntityViewModel>();
                x.CreateMap<ExperienceDetail, ExperienceDetailViewModel>();
                x.CreateMap<Experience, ExperienceViewModel>();
                x.CreateMap<GenericDetail, GenericDetailViewModel>();
                x.CreateMap<Interest, InterestViewModel>();
                x.CreateMap<Language, LanguageViewModel>();
                x.CreateMap<Project, ProjectViewModel>();
                x.CreateMap<Skill, SkillViewModel>();

                x.CreateMap<ProfileViewModel, Domain.Models.Profile>();
                x.CreateMap<AddressViewModel, Address>();
                x.CreateMap<CareerViewModel, Career>();
                x.CreateMap<ContactViewModel, Contact>();
                x.CreateMap<EducationViewModel, Education>();
                x.CreateMap<EntityViewModel, Entity>();
                x.CreateMap<ExperienceDetailViewModel, ExperienceDetail>();
                x.CreateMap<ExperienceViewModel, Experience>();
                x.CreateMap<GenericDetailViewModel, GenericDetail>();
                x.CreateMap<InterestViewModel, Interest>();
                x.CreateMap<LanguageViewModel, Language>();
                x.CreateMap<ProjectViewModel, Project>();
                x.CreateMap<SkillViewModel, Skill>();
            });

        }
    }
}