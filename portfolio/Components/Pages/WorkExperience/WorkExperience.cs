using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace portfolio.Components.Pages {
    public class WorkBase : ComponentBase {
        public class TimelineEvent {
            public string TimeWorked { get; set; } = string.Empty;
            public string Company { get; set;} = string.Empty;
            public string Position { get; set;} = string.Empty;
            public string Description { get; set; } = string.Empty;
        }

        protected List<TimelineEvent> timelineEvents = new List<TimelineEvent> {
            new TimelineEvent { 
                TimeWorked = "June 2018 - July 2019", 
                Company = "Target", 
                Position = "Cashier", 
                Description = ""    
            },   
            new TimelineEvent { 
                TimeWorked = "June 2018 - July 2019", 
                Company = "Cabrillo College", 
                Position = "Inter-Club Council Secretary", 
                Description = ""    
            },
            new TimelineEvent { 
                TimeWorked = "June 2018 - July 2019", 
                Company = "Hartnell College STEM Internship Program", 
                Position = "Cashier", 
                Description = ""    
            },
            new TimelineEvent { 
                TimeWorked = "June 2018 - July 2019", 
                Company = "NASA & California Space Grant", 
                Position = "Cashier", 
                Description = ""    
            },
            new TimelineEvent { 
                TimeWorked = "June 2018 - July 2019", 
                Company = "Campus Crossings", 
                Position = "Cashier", 
                Description = ""    
            },
            new TimelineEvent { 
                TimeWorked = "June 2018 - July 2019", 
                Company = "Campus Crossings", 
                Position = "Cashier", 
                Description = ""    
            }
        };
    }
}