using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace portfolio.Components.Pages {
    public class InvolvementBase : ComponentBase {
        public class InvolvementDetails {
            public string Event { get; set; } = string.Empty;
            public string Date { get; set; } = string.Empty;
            public string Group { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
            public string ImagePath { get; set; } = string.Empty;
            public string Type { get; set; } = string.Empty;
        }

        protected List<InvolvementDetails> volunteerDetails = new List<InvolvementDetails>
        {
            new InvolvementDetails
            {
                Event = "Geaux Big 2024",
                Date = "March 2024",
                Group = "EDA",
                Description = "Was assigned to help out at the LSU Hilltop Arboretum",
                ImagePath = "/images/volunteer/EDA_Geaux_Big_2024.jpg",
                Type = "LSU"
            }
        };
    }
}