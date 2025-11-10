namespace QCLorence.ViewModel
{
    public class InspectionplaceViewmodel
    {
        public InspectionplaceViewmodel()
        {
            inspectionplaceDetailsList = new List<InspectionplaceDetails>();
            inspectionplaceDetails = new InspectionplaceDetails();
        }
        public List<InspectionplaceDetails> inspectionplaceDetailsList { get; set; }
        public InspectionplaceDetails inspectionplaceDetails { get; set; }
        public class InspectionplaceDetails
        {
            public int InspectionplaceId { get; set; }

            public string? PlaseName { get; set; }

            public string? Description { get; set; }
        }
    }
}
