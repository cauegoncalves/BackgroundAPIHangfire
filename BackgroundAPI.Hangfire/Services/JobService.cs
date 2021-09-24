using System;
using System.Threading;
using System.Threading.Tasks;

namespace BackgroundAPIHangfire.Services
{
    public class JobService : IJobService
    {
        private Guid _jobId;

        public JobService()
        {
            _jobId = Guid.NewGuid();
        }

        public async Task Execute()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}] - [JobId: {_jobId}] - Job iteration {i}.");
                await Task.Delay(500);
            }
        }
    }
}
