namespace Patterns
{
    public class SoftwareEngineer: IHandler
    {
        private IHandler nextPersonToHandleWork;

        public void HandelOverWhenDone(IHandler handler)
        {
            this.nextPersonToHandleWork = handler;
        }

        public void Handle(Requirement requirement)
        {
            requirement.OperationsDone.Add(nameof(SoftwareEngineer));
            this.nextPersonToHandleWork.Handle(requirement);
        }
    }
}