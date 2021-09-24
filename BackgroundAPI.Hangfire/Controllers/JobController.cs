using BackgroundAPIHangfire.Services;
using Hangfire;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BackgroundAPIHangfire.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {

        private readonly IBackgroundJobClient _backgroundJob;

        public JobController(IBackgroundJobClient backgroundJob)
        {
            _backgroundJob = backgroundJob;
        }

        [HttpPost]
        public IActionResult StartJob()
        {
            _backgroundJob.Enqueue<IJobService>(j => j.Execute());

            return Ok();
        }

    }
}
