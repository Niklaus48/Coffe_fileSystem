using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe.Core.Storage
{
    public interface IDataBase
    {

        void Store<T>(T Data) where T : new();

        Task<ICollection<T>> Read<T>(Predicate<T> match) where T : new();

    }
}
