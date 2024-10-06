using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe.Core.Storage
{
    public interface IDataBase
    {

        void Store<T>(T Data);

        Type Read<T>(string path);

    }
}
