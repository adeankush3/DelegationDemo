using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegationDemo
{
    public class MultiCastDelegation
    {
        delegate void DelegatesOperations(int x, int y);

        public void DelegatesMul()
        {
            DelegatesOperations obj = Operation.Add;
            obj += Operation.Multiplication;

            obj(2, 6);
            obj(4, 5);
        }
    }
}
