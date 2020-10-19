using System;
using System.Collections.Generic;
using System.Linq;
using EventManagement.Data;
using Microsoft.AspNetCore.Components;

namespace EventManagement.Pages
{
    public partial class EditEvent
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public ApplicationDbContext Context { get; set; }

        public EventDefinition EventItem { get; set; } = new EventDefinition();

        [Parameter]
        public int Id { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            EventItem = Context.Events.FirstOrDefault(e => e.Id == Id);
        }

        public void SaveEvent()
        {
            Context.Events.Update(EventItem);
            Context.SaveChanges();

            NavigationManager.NavigateTo("/events");
        }
    }
}
