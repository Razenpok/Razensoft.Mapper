#if RAZENSOFT_MAPPER_UNITASK_SUPPORT
#if NET5_0 || NETSTANDARD2_1
using System;
using System.Threading;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Razensoft.Mapper
{
    public static partial class MapperExtensions
    {
        /// <summary>
        /// Maps the <see cref="IAsyncEnumerable{TSource}"/> into <see cref="IAsyncEnumerable{TDestination}"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source asynchronous enumerable.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An <see cref="IAsyncEnumerable{TDestination}"/> collection.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async IAsyncEnumerable<TDestination> MapEnumerableAsync<TSource, TDestination>(
            this IMapper<TSource, TDestination> mapper,
            IAsyncEnumerable<TSource> source,
            [EnumeratorCancellation] CancellationToken cancellationToken = default)
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

            await foreach (var sourceItem in source.ConfigureAwait(false).WithCancellation(cancellationToken))
            {
                var destinationItem = new TDestination();
                mapper.Map(sourceItem, destinationItem);
                yield return destinationItem;
            }
        }

        /// <summary>
        /// Maps the <see cref="IAsyncEnumerable{TSource}"/> into <see cref="IAsyncEnumerable{TDestination}"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source asynchronous enumerable.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An <see cref="IAsyncEnumerable{TDestination}"/> collection.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async IAsyncEnumerable<TDestination> MapEnumerableAsync<TSource, TDestination>(
            this IImmutableMapper<TSource, TDestination> mapper,
            IAsyncEnumerable<TSource> source,
            [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            if (mapper == null)
            {
                throw new ArgumentNullException(nameof(mapper));
            }

            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            await foreach (var sourceItem in source.ConfigureAwait(false).WithCancellation(cancellationToken))
            {
                var destinationItem = mapper.Map(sourceItem);
                yield return destinationItem;
            }
        }
        /// <summary>
        /// Maps the <see cref="IAsyncEnumerable{TSource}"/> into <see cref="IAsyncEnumerable{TDestination}"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source asynchronous enumerable.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An <see cref="IAsyncEnumerable{TDestination}"/> collection.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async IAsyncEnumerable<TDestination> MapEnumerableAsync<TSource, TDestination>(
            this IAsyncMapper<TSource, TDestination> mapper,
            IAsyncEnumerable<TSource> source,
            [EnumeratorCancellation] CancellationToken cancellationToken = default)
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

            await foreach (var sourceItem in source.ConfigureAwait(false).WithCancellation(cancellationToken))
            {
                var destinationItem = new TDestination();
                await mapper.MapAsync(sourceItem, destinationItem, cancellationToken).ConfigureAwait(false);
                yield return destinationItem;
            }
        }

        /// <summary>
        /// Maps the <see cref="IAsyncEnumerable{TSource}"/> into <see cref="IAsyncEnumerable{TDestination}"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source asynchronous enumerable.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An <see cref="IAsyncEnumerable{TDestination}"/> collection.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async IAsyncEnumerable<TDestination> MapEnumerableAsync<TSource, TDestination>(
            this IAsyncImmutableMapper<TSource, TDestination> mapper,
            IAsyncEnumerable<TSource> source,
            [EnumeratorCancellation] CancellationToken cancellationToken = default)
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

            await foreach (var sourceItem in source.ConfigureAwait(false).WithCancellation(cancellationToken))
            {
                var destinationItem = await mapper.MapAsync(sourceItem, cancellationToken).ConfigureAwait(false);
                yield return destinationItem;
            }
        }
    }
}
#endif
#endif