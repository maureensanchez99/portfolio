using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace involvement.Components.Pages {
    public class InvolvementBase : ComponentBase {
        public class InvolvementDetails {
            public string Event { get; set; } = string.Empty;
            public string Date { get; set; } = string.Empty;
            public string Position { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
            public string ImagePath { get; set; } = string.Empty;
            public string Type { get; set; } = string.Empty;
        }

        protected List<InvolvementDetails> volunteer = new List<InvolvementDetails> {
            new InvolvementDetails {
                Event = "Hotel Operations Efficiency System",
                Date = "Course",
                Position = "A web application that serves as a platform to improve management efficiency for hotels.",
                Description = "https://github.com/CSC-3380-Fall-2024/Team-7",
                ImagePath = "",
                Type = "LSU"
            }
        };
    }
}