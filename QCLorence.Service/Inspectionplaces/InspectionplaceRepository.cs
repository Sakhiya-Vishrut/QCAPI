using QCLorence.Common;
using QCLorence.Domain;
using QCLorence.Domain.DataContext;
using QCLorence.Domain.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCLorence.Service.Inspectionplaces
{
    //[TransientDependency(ServiceType = typeof(IInspectionplaceRepository))]
    public class InspectionplaceRepository : IInspectionplaceRepository
    {
        private readonly ApplicationDbContext _context;
        public InspectionplaceRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<InspactionPlaceDTO> GetInspactionPlace()
        {
            var list = _context.Inspectionplaces.Where(x => x.DeletedDate == null).ToList();

            var placelist = list.Select(p => new InspactionPlaceDTO
            {
                inspectionplace = p,
            }).ToList();

            return placelist;
        }

        public async Task<bool> AddPlace(Inspectionplace model)
        {
            try
            {
                DateTime CurrentDate = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"));
                if (model == null) return false;
                else
                {
                    if (model.InspectionplaceId == default)
                    {
                        model.CreatedDate = CurrentDate;
                        model.ModifiedDate = CurrentDate;

                        _context.Inspectionplaces.Add(model);
                    }
                    _context.SaveChangesAsync();
                }
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public Inspectionplace DeletePlace(int id)
        {
            try
            {
                DateTime CurrentDate = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"));

                var place = _context.Inspectionplaces.Where(x => x.InspectionplaceId == id && x.DeletedDate == null).FirstOrDefault();

                place.DeletedDate = CurrentDate;
                _context.Update(place);
                _context.SaveChangesAsync();

                return place;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }

        public Inspectionplace getPlace(int id)
        {
            var placeid = _context.Inspectionplaces.Where(x => x.InspectionplaceId == id && x.DeletedDate == null).FirstOrDefault();

            return placeid;
        }

        public Inspectionplace UpdateDate(int id, Inspectionplace model)
        {
            DateTime CurrentDate = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"));

            var place = _context.Inspectionplaces.Where(x => x.InspectionplaceId == id && x.DeletedDate == null).FirstOrDefault();

            place.PlaseName = model.PlaseName;
            place.Description = model.Description;
            place.ModifiedDate = CurrentDate;
            _context.SaveChangesAsync();
            return place;
        }
    }
}
