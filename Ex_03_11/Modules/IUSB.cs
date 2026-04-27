using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_11.Modules
{
    public interface IUSB
    {
        void SendData();

        void ReceiveData();
    }
}