using AutoMapper;
using PendAdvisor.API.DTOs;
using PendAdvisorModel;
using System;

namespace PendAdvisor.API
{
   public class MappingProfile : Profile
   {
      public MappingProfile()
      {
         CreateMap<ClaimData, ModelInput>();

         CreateMap<ModelOutput, AdviceData>()
            .ForMember(ad => ad.AdvisedAction, o => o.MapFrom(mo => mo.Action));
         //TODO: map remaining elements
         throw new NotImplementedException("Need translation from indices to actions in mo.Scores");
      }
   }
}