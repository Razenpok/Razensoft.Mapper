#if RAZENSOFT_MAPPER_UNITASK_SUPPORT
using System.Threading;
using Cysharp.Threading.Tasks;

namespace Razensoft.Mapper
{
    /// <summary>
    /// Maps an object of type <typeparamref name="TSource"/> to <typeparamref name="TDestination"/> asynchronously.
    /// </summary>
    /// <typeparam name="TSource">The type of the object to map from.</typeparam>
    /// <typeparam name="TDestination">The type of the object to map to.</typeparam>
    public interface IAsyncMapper<in TSource, in TDestination>
    {
        /// <summary>
        /// Maps the specified source object into the destination object.
        /// </summary>
        /// <param name="source">The source object to map from.</param>
        /// <param name="destination">The destination object to map to.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        UniTask MapAsync(TSource source, TDestination destination, CancellationToken cancellationToken = default);
    }
}
#endif