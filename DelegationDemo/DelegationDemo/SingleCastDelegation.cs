using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegationDemo
{
    public class SingleCastDelegation
    {
        delegate void DelegatesOperations(int x, int y);

        public void Delegates()
        {
            DelegatesOperations[] obj ={
                new DelegatesOperations(Operation.Add)};

            for (int i = 0; i < obj.Length; i++)
            {
                obj[i](2, 6);
                obj[i](4, 5);
            }
        }
    }
}
