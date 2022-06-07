using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        public DataContext Context { get; set; }
        public ActivitiesController(DataContext context)
        {
            this.Context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await this.Context.Activities.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id)//get single activity
        {
            return await this.Context.Activities.FindAsync(id);
        }

    }
}