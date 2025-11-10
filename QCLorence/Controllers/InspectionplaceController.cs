using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Protocol;
using QCLorence.Halpper.Mapper;
using QCLorence.Service.Inspectionplaces;
using QCLorence.ViewModel;

namespace QCLorence.Controllers
{
    [Route("api/QCLorence")]
    [ApiController]
    public class InspectionplaceController : ControllerBase
    {
        private readonly IInspectionplaceRepository _inspectionplaceRepository;
        public InspectionplaceController(IInspectionplaceRepository inspectionplaceRepository)
        {
            _inspectionplaceRepository = inspectionplaceRepository;
        }

        [HttpGet]
        public IActionResult GetInspactionPlace()
        {
            var model = new InspectionplaceViewmodel();

            return Ok(model.inspectionplaceDetailsList = _inspectionplaceRepository.GetInspactionPlace().ToModel());
        }

        [HttpPost]
        public IActionResult AddInspactionPlace([FromBody] InspectionplaceViewmodel model)
        {
            if (model == null || model.inspectionplaceDetails == null)
                return BadRequest("Invalid input data.");

            var isSuccess = _inspectionplaceRepository.AddPlace(model.inspectionplaceDetails.ToModel());
            return Ok(new { success = isSuccess });
        }

        [HttpGet("{id}")]
        public IActionResult GetIdwisePlace(int id)
        {
            var model = new InspectionplaceViewmodel();

            model.inspectionplaceDetails = _inspectionplaceRepository.getPlace(id).ToModel();

            return Ok(model);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePlace(int id, [FromBody] InspectionplaceViewmodel model)
        {
            var updated = _inspectionplaceRepository.UpdateDate(id, model.inspectionplaceDetails.ToModel());

            return Ok(updated);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteInspactionPlace(int id)
        {
            var model = new InspectionplaceViewmodel();

            model.inspectionplaceDetails = _inspectionplaceRepository.DeletePlace(id).ToModel();

            return Ok(model);
        }
    }
}
