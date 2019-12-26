using Eventures.Domain;
using Eventures.Models.BindingModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.Models.ModelValidation
{
    public class EventsDateValidation : AbstractValidator<EventCreateBindingModel>
    {
        public EventsDateValidation()
        {
            RuleFor(model => model.End).GreaterThan(model => model.Start);
        }
    }
}
