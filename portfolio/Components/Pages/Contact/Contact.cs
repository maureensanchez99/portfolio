using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace portfolio.Components.Pages {
    public class ContactBase : ComponentBase {
        public class LinkSource {
            public string Icon { get; set; } = string.Empty;
            public string Link { get; set; } = string.Empty;
        }

        public class ContactSource : ComponentBase {
            public string Contact { get; set; } = string.Empty;
            public string Type { get; set; } = string.Empty;
        }

        protected List<LinkSource> linkSources = new List<LinkSource> {
            new LinkSource {
                Icon = "/images/general/linkedin.png",
                Link = "https://www.linkedin.com/in/maureen-sanchez/"
            },
            new LinkSource {
                Icon = "/images/general/youtube.png",
                Link = "https://www.youtube.com/@maureensanchez99"
            }
        };

        protected List<ContactSource> contactSources = new List<ContactSource> {
            new ContactSource {
                Contact = "maureen.sanchez99@gmail.com",
                Type = "Personal Email"
            },
            new ContactSource {
                Contact = "msanc57@lsu.edu",
                Type = "School Email"
            }
        };
    }
}