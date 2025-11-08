using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QCLorence.Service.Inspectionplaces;

namespace QCLorence.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InspectionplaceController : ControllerBase
    {
        private readonly IInspectionplaceRepository _inspectionplaceRepository;
        public InspectionplaceController(IInspectionplaceRepository inspectionplaceRepository)
        {
            _inspectionplaceRepository = inspectionplaceRepository;
        }
    }
}
