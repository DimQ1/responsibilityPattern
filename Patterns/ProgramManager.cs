namespace Patterns
{
    public class ProgramManager : IHandler
    {
        private IHandler nextPersonToHandleWork;

        public void HandelOverWhenDone(IHandler handler)
        {
            this.nextPersonToHandleWork = handler;
        }

        public void Handle(Requirement requirement)
        {
            requirement.OperationsDone.Add(nameof(ProgramManager));
            this.nextPersonToHandleWork.Handle(requirement);
        }
    }
}