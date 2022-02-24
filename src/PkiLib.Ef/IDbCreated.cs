using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Org.PkiLib.Ef
{
    /// <summary>
    /// Entity created date and time in database, represented by <see cref="T"/>
    /// </summary>
    /// <typeparam name="T">Date and time type</typeparam>
    public interface IDbCreated<out T>
    {
        /// <summary>
        /// Entity created date and time in database
        /// </summary>
        T DbCreated { get; }
    }
}
