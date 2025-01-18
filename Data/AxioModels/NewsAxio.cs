using System;
using System.Collections.Generic;

namespace API_AXIO.AxioModels;

public partial class NewsAxio
{
    public Guid NewsAxioId { get; set; }
    public string NewsAxioMessageContent { get; set; } = null!;
    public string? NewsAxioTitle { get; set; }
    public DateTime NewsAxioCreatedAt { get; set; }
    public Guid NewsAxioCreatedBy { get; set; }
    public DateTime? NewsAxioDateUpdated { get; set; }
    public bool NewsAxioIsDeleted { get; set; }

}
