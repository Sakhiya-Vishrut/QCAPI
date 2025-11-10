using QCLorence.Domain;
using QCLorence.Domain.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCLorence.Service.Inspectionplaces
{
    public interface IInspectionplaceRepository
    {
        List<InspactionPlaceDTO> GetInspactionPlace();

        Task<bool> AddPlace(Inspectionplace model);

        Inspectionplace DeletePlace(int id);

        Inspectionplace getPlace(int id);

        Inspectionplace UpdateDate(int id, Inspectionplace model);
    }
}
