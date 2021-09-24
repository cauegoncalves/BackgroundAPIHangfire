using System.Threading.Tasks;

namespace BackgroundAPIHangfire.Services
{
    public interface IJobService
    {

        Task Execute();

    }
}
