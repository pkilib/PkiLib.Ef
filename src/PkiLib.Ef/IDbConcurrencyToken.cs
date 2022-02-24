namespace Org.PkiLib.Ef
{
    /// <summary>
    /// Entity concurrency token in database, represented by <see cref="T"/>
    /// </summary>
    /// <typeparam name="T">Concurrency token type</typeparam>
    public interface IDbConcurrencyToken<out T>
    {
        /// <summary>
        /// Entity concurrency token in database
        /// </summary>
        T DbConcurrencyToken { get; }
    }
}