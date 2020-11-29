using AutoMapper;
using PendAdvisor.API.DTOs;
using PendAdvisorModel;
using System.Linq;

namespace PendAdvisor.API
{
   public class MappingProfile : Profile
   {
      public MappingProfile()
      {
         CreateMap<ClaimData, ModelInput>();

         CreateMap<ModelOutputEx, AdviceData>()
            .ForMember(ad => ad.AdvisedAction, o => o.MapFrom(mo => mo.Action))
            .ForMember(ad => ad.AdviceScore, o => o.MapFrom(ml => ml.ActionsAndScores[0].Score))  // ActionsAndScores is ordered by score
            .ForMember(ad => ad.ActionsAndScores, o => o.MapFrom(ml => ml.ActionsAndScores.Select(t => new { t.Action, t.Score })));  // ActionsAndScores in ModelOutputEx are tuples, which do not serialize well
      }
   }
}