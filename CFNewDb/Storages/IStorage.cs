using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFNewDb
{
    /// <summary>
    /// Describes main logic of storage.
    /// </summary>
    public interface IStorage<T>
    {
        /// <summary>
        /// Save entities in a specified storage.
        /// </summary>
        void Save(IEnumerable<T> entity);

        /// <summary>
        /// Load entities from a specified storage.
        /// </summary>
        T[] Load();
    }
}
