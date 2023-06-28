using openAPI.ViewModels;

namespace openAPI.Interfaces
{
    public interface IChatInterface
    {

        string TurboChat(TurboModel model);
        string OtherChat(TurboModel model);
        
    }
}
