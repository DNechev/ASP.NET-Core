﻿using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.Infrastructure.Filters
{
    public class AdminActivityLoggerFilter : IActionFilter
    {
        private readonly ILogger<AdminActivityLoggerFilter> logger;

        public AdminActivityLoggerFilter(ILogger<AdminActivityLoggerFilter> _logger)
        {
            this.logger = _logger;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            if(context.ActionDescriptor.DisplayName.Contains("EventsController") &&
                context.ActionDescriptor.DisplayName.Contains("Create"))
            {
                this.logger.LogInformation("123");
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
        }
    }
}
