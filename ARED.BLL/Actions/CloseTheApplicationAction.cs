using ARED.BLL.Interfaces;

namespace ARED.BLL.Actions
{
    public class CloseTheApplicationAction : IAction
    {
        public void Execute(string properties)
        {
           Environment.Exit(1);
        }
    }
}
