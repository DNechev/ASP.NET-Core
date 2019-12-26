using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Message.Data;
using Message.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Message.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class
        MessagesController : ControllerBase
    {
        private readonly MessageDbContext context;

        public MessagesController(MessageDbContext context)
        {
            this.context = context;
        }

        [HttpGet(Name = "All")]
        [Route("all")]
        public async Task<ActionResult<IEnumerable<Domain.Message>>> AllOrderedByCreatedOn()
        {
            List<Domain.Message> messages = this.context.Messages.OrderBy(message => message.CreatedOn).ToList();

            return messages;
        }

        [HttpPost(Name ="Create")]
        [Route("create")]
        public async Task<ActionResult> Create(CreateBindingModel model)
        {
            Domain.Message message = new Domain.Message
            {
                User = model.User,
                Content = model.Content,
                CreatedOn = DateTime.UtcNow
            };

            await this.context.Messages.AddAsync(message);
            await this.context.SaveChangesAsync();

            return this.Ok();
        }
    }
}