using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{
    public interface IHandler
    {
        void Handle(Requirement requirement);

        void HandelOverWhenDone(IHandler handler);
    }
}
