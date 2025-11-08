using System;
using System.Collections.Generic;

namespace QCLorence.Domain.DataModel;

public partial class Inspectionplace
{
    public int InspectionplaceId { get; set; }

    public string? PlaseName { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public DateTime? DeletedDate { get; set; }
}
