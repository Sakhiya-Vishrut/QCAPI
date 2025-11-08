using QCLorence.Common;
using QCLorence.Domain.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCLorence.Service.Inspectionplaces
{
    [TransientDependency(ServiceType = typeof(IInspectionplaceRepository))]
    internal class InspectionplaceRepository : IInspectionplaceRepository
    {
        private readonly ApplicationDbContext _context;
        public InspectionplaceRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
