using System;
using System.Collections.Generic;
using System.Linq;
using EventManagement.Data;
using Microsoft.AspNetCore.Components;

namespace EventManagement.Pages
{
    public partial class AddEvent
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public ApplicationDbContext Context { get; set; }

        public EventDefinition EventItem { get; set; } = new EventDefinition();

        public void SaveEvent()
        {
            Context.Events.Add(EventItem);
            Context.SaveChanges();

            NavigationManager.NavigateTo("/events");
        }
    }
}
