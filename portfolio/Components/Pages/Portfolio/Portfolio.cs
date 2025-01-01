using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace portfolio.Components.Pages {
    public class PortfolioBase : ComponentBase {
        public class ProjectSource {
            public string Title { get; set; } = string.Empty;
            public string Type { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
            public string Link { get; set; } = string.Empty;
        }

        protected List<ProjectSource> projectSources = new List<ProjectSource> {
            new ProjectSource {
                Title = "Hotel Operations Efficiency System",
                Type = "Course",
                Description = "A web application that serves as a platform to improve management efficiency for hotels.",
                Link = "https://github.com/CSC-3380-Fall-2024/Team-7"
            },
            new ProjectSource {
                Title = "Pocket Travel",
                Type = "Hackathon",
                Description = "A web application that helps travelers be knowledgeable and aware of variables they need to know while traveling in foreign countries.",
                Link = "https://github.com/maureensanchez99/Pocket-Travel"
            },
            new ProjectSource {
                Title = "Sustain Me",
                Type = "Hackathon",
                Description = "A website that is created to encourage people to be more cautious in their actions to be more environmentally friendly (a sustainable lifestyle).",
                Link = "https://github.com/maureensanchez99/AthenaHacks2020"
            },
            new ProjectSource {
                Title = "Studybuddy",
                Type = "Course",
                Description = "C++ application to help students find others in their classes looking for people to study with.",
                Link = "https://github.com/maureensanchez99/AthenaHacks2020"
            },
            new ProjectSource {
                Title = "Wheel of Fortune clone",
                Type = "Course",
                Description = "A text based application for a multiplayer Wheel of Fortune game.",
                Link = "https://github.com/maureensanchez99/AthenaHacks2020"
            }
        };
    }
}