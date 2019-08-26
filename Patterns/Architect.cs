namespace Patterns
{
    public class Architect : IHandler
    {
        private IHandler nextPersonToHandleWork;

        public void HandelOverWhenDone(IHandler handler)
        {
            this.nextPersonToHandleWork = handler;
        }

        public void Handle(Requirement requirement)
        {
            requirement.OperationsDone.Add(nameof(Architect));
            this.nextPersonToHandleWork.Handle(requirement);
        }
    }
}