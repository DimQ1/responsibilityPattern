namespace Patterns
{
    public class QAEngineer: IHandler
    {
        private IHandler nextPersonToHandleWork;

        public void HandelOverWhenDone(IHandler handler)
        {
            this.nextPersonToHandleWork = handler;
        }

        public void Handle(Requirement requirement)
        {
            requirement.OperationsDone.Add(nameof(QAEngineer));
            this.nextPersonToHandleWork.Handle(requirement);
        }
    }
}