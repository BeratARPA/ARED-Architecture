namespace ARED.BLL.Interfaces
{
    public interface IEventHandler
    {
        Task HandleEventAsync(string eventData);
    }
}
