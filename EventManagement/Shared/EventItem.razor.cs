using System;
using EventManagement.Data;
using Microsoft.AspNetCore.Components;

namespace EventManagement.Shared
{
    public partial class EventItem
    {
        [Parameter]
        public EventDefinition Event { get; set; }
    }
}
