using System;
using System.Collections.Generic;
using System.Linq;
using EventManagement.Data;
using Microsoft.AspNetCore.Components;

namespace EventManagement.Pages
{
    public partial class Events
    {
        [Inject]
        public ApplicationDbContext Context { get; set; }

        public List<EventDefinition> EventItems { get; set; }

        public bool IsGridView { get; set; }

        protected override void OnInitialized()
        {
            EventItems = Context.Events.ToList();
        }

        public void DeleteEvent(EventDefinition item)
        {
            Context.Events.Remove(item);
            Context.SaveChanges();
            EventItems.Remove(item);
        }
    }
}
