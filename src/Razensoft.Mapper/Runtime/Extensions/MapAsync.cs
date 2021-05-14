#if RAZENSOFT_MAPPER_UNITASK_SUPPORT
using System;
using System.Threading;
using Cysharp.Threading.Tasks;

namespace Razensoft.Mapper
{
    public static partial class MapperExtensions
    {
        /// <summary>
        /// Maps the specified source object to a new object with a type of <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source object.</typeparam>
        /// <typeparam name="TDestination">The type of the destination object.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source object.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The mapped object of type <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper" /> or <paramref name="source" /> is
        /// <c>null</c>.</exception>
        public static async UniTask<TDestination> MapAsync<TSource, TDestination>(
            this IAsyncMapper<TSource, TDestination> mapper,
            TSource source,
            CancellationToken cancellationToken = default)
            where TDestination : new()
        {
            if (mapper == null)
            {
                throw new ArgumentNullException(nameof(mapper));
            }

            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            var destination = new TDestination();
            await mapper.MapAsync(source, destination, cancellationToken);
            return destination;
        }

        /// <summary>
        /// Maps the specified source object to a new object with a type of <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source object.</typeparam>
        /// <typeparam name="TDestination">The type of the destination object.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source object.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The mapped object of type <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper" /> or <paramref name="source" /> is
        /// <c>null</c>.</exception>
        public static async UniTask<TDestination> MapAsync<TSource, TDestination>(
            this IAsyncImmutableMapper<TSource, TDestination> mapper,
            TSource source,
            CancellationToken cancellationToken = default)
            where TDestination : new()
        {
            if (mapper == null)
            {
                throw new ArgumentNullException(nameof(mapper));
            }

            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            var destination = await mapper.MapAsync(source, cancellationToken);
            return destination;
        }
    }
}
#endif