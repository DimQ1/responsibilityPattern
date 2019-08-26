using System;

namespace Patterns
{
    public class DevOpsEngineer: IHandler
    {
        private IHandler nextPersonToHandleWork;

        public void HandelOverWhenDone(IHandler handler)
        {
            this.nextPersonToHandleWork = handler;
        }

        public void Handle(Requirement requirement)
        {
            requirement.OperationsDone.Add(nameof(DevOpsEngineer));
        }
    }
}