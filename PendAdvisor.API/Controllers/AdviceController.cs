using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PendAdvisor.API.DTOs;
using PendAdvisorModel;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading.Tasks;

namespace PendAdvisor.API.Controllers
{
   [ApiController]
   [Route("api/[controller]")]
   [SwaggerTag("Leverages trained ML model to provide recommendation on handling pended claims.")]
   public class AdviceController : ControllerBase
   {
      private readonly IMapper _mapper;

      public AdviceController(IMapper mapper)
      {
         _mapper = mapper;
      }


      /// <summary>
      /// Consume the trained ML model to provide advice for a given claim.
      /// </summary>
      /// <param name="claim">A claim to obtaine advice on.</param>
      /// <returns>The recommendation, i.e. predicted values with corresponding scores.</returns>
      /// <response code="200">OK - the recommendation is returned in the response body.</response>
      /// <response code="400">Bad Request - empty or bad data posted.</response>
      [HttpPost]
      [ProducesResponseType(StatusCodes.Status200OK)]
      [ProducesResponseType(StatusCodes.Status400BadRequest)]
      public IActionResult ObtainPendAdvice([FromBody] ClaimData claim)
      {
         if (!ModelState.IsValid) return BadRequest();
         //For simplicity, the entire client logic is implemented inside the controller
         var modelInput = _mapper.Map<ModelInput>(claim);
         var modelOutput = PendPredictor.PredictEx(modelInput);
         var adviceData = _mapper.Map<AdviceData>(modelOutput);
         adviceData.ClaimID = claim.ClaimID;
         return Ok(adviceData);
      }
   }
}
