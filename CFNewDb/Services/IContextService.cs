using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFNewDb.Services
{
    /// <summary>
    /// Description of main logic of service.
    /// </summary>
    /// <typeparam name="T">An entity.</typeparam>
    interface IContextService<T>
    {
        /// <summary>
        /// Adds entity to database.
        /// </summary>
        void Add(T entity);

        /// <summary>
        /// Removes entity from database.
        /// </summary>
        void Remove(T entity);

        /// <summary>
        /// Update entity from database.
        /// </summary>
        void Update(T toChange, T toSet);

        /// <summary>
        /// Imports information from database to storage.
        /// </summary>
        void SaveToStorage(IStorage<T> storage);

        /// <summary>
        /// Exports information from database to storage.
        /// </summary>
        void LoadFromStorage(IStorage<T> storage);
    }
}
