#if RAZENSOFT_MAPPER_UNITASK_SUPPORT
#if NET5_0
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Razensoft.Mapper
{
    public static partial class MapperExtensions
    {
        /// <summary>
        /// Maps the list of <typeparamref name="TSource"/> into an immutable array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An immutable array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async Task<ImmutableArray<TDestination>> MapImmutableArrayAsync<TSource, TDestination>(
            this IAsyncMapper<TSource, TDestination> mapper,
            List<TSource> source,
            CancellationToken cancellationToken = default)
            where TDestination : new() =>
            ImmutableArray.Create(await mapper.MapArrayAsync(source, cancellationToken).ConfigureAwait(false));

        /// <summary>
        /// Maps the collection of <typeparamref name="TSource"/> into an immutable array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An immutable array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async Task<ImmutableArray<TDestination>> MapImmutableArrayAsync<TSource, TDestination>(
            this IAsyncMapper<TSource, TDestination> mapper,
            Collection<TSource> source,
            CancellationToken cancellationToken = default)
            where TDestination : new() =>
            ImmutableArray.Create(await mapper.MapArrayAsync(source, cancellationToken).ConfigureAwait(false));

        /// <summary>
        /// Maps the array of <typeparamref name="TSource"/> into an immutable array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An immutable array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async Task<ImmutableArray<TDestination>> MapImmutableArrayAsync<TSource, TDestination>(
            this IAsyncMapper<TSource, TDestination> mapper,
            TSource[] source,
            CancellationToken cancellationToken = default)
            where TDestination : new() =>
            ImmutableArray.Create(await mapper.MapArrayAsync(source, cancellationToken).ConfigureAwait(false));

        /// <summary>
        /// Maps the enumerable of <typeparamref name="TSource"/> into an immutable array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An immutable array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async Task<ImmutableArray<TDestination>> MapImmutableArrayAsync<TSource, TDestination>(
            this IAsyncMapper<TSource, TDestination> mapper,
            IEnumerable<TSource> source,
            CancellationToken cancellationToken = default)
            where TDestination : new() =>
            ImmutableArray.Create(await mapper.MapArrayAsync(source, cancellationToken).ConfigureAwait(false));

        /// <summary>
        /// Maps the list of <typeparamref name="TSource"/> into an immutable list of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An immutable list of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async Task<ImmutableList<TDestination>> MapImmutableListAsync<TSource, TDestination>(
            this IAsyncMapper<TSource, TDestination> mapper,
            List<TSource> source,
            CancellationToken cancellationToken = default)
            where TDestination : new() =>
            ImmutableList.Create(await mapper.MapArrayAsync(source, cancellationToken).ConfigureAwait(false));

        /// <summary>
        /// Maps the collection of <typeparamref name="TSource"/> into an immutable list of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An immutable list of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async Task<ImmutableList<TDestination>> MapImmutableListAsync<TSource, TDestination>(
            this IAsyncMapper<TSource, TDestination> mapper,
            Collection<TSource> source,
            CancellationToken cancellationToken = default)
            where TDestination : new() =>
            ImmutableList.Create(await mapper.MapArrayAsync(source, cancellationToken).ConfigureAwait(false));

        /// <summary>
        /// Maps the array of <typeparamref name="TSource"/> into an immutable list of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An immutable list of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async Task<ImmutableList<TDestination>> MapImmutableListAsync<TSource, TDestination>(
            this IAsyncMapper<TSource, TDestination> mapper,
            TSource[] source,
            CancellationToken cancellationToken = default)
            where TDestination : new() =>
            ImmutableList.Create(await mapper.MapArrayAsync(source, cancellationToken).ConfigureAwait(false));

        /// <summary>
        /// Maps the enumerable of <typeparamref name="TSource"/> into an immutable list of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An immutable list of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async Task<ImmutableList<TDestination>> MapImmutableListAsync<TSource, TDestination>(
            this IAsyncMapper<TSource, TDestination> mapper,
            IEnumerable<TSource> source,
            CancellationToken cancellationToken = default)
            where TDestination : new() =>
            ImmutableList.Create(await mapper.MapArrayAsync(source, cancellationToken).ConfigureAwait(false));
        
        /// <summary>
        /// Maps the list of <typeparamref name="TSource"/> into an immutable array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An immutable array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async Task<ImmutableArray<TDestination>> MapImmutableArrayAsync<TSource, TDestination>(
            this IAsyncImmutableMapper<TSource, TDestination> mapper,
            List<TSource> source,
            CancellationToken cancellationToken = default)
            where TDestination : new() =>
            ImmutableArray.Create(await mapper.MapArrayAsync(source, cancellationToken).ConfigureAwait(false));

        /// <summary>
        /// Maps the collection of <typeparamref name="TSource"/> into an immutable array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An immutable array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async Task<ImmutableArray<TDestination>> MapImmutableArrayAsync<TSource, TDestination>(
            this IAsyncImmutableMapper<TSource, TDestination> mapper,
            Collection<TSource> source,
            CancellationToken cancellationToken = default)
            where TDestination : new() =>
            ImmutableArray.Create(await mapper.MapArrayAsync(source, cancellationToken).ConfigureAwait(false));

        /// <summary>
        /// Maps the array of <typeparamref name="TSource"/> into an immutable array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An immutable array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async Task<ImmutableArray<TDestination>> MapImmutableArrayAsync<TSource, TDestination>(
            this IAsyncImmutableMapper<TSource, TDestination> mapper,
            TSource[] source,
            CancellationToken cancellationToken = default)
            where TDestination : new() =>
            ImmutableArray.Create(await mapper.MapArrayAsync(source, cancellationToken).ConfigureAwait(false));

        /// <summary>
        /// Maps the enumerable of <typeparamref name="TSource"/> into an immutable array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An immutable array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async Task<ImmutableArray<TDestination>> MapImmutableArrayAsync<TSource, TDestination>(
            this IAsyncImmutableMapper<TSource, TDestination> mapper,
            IEnumerable<TSource> source,
            CancellationToken cancellationToken = default)
            where TDestination : new() =>
            ImmutableArray.Create(await mapper.MapArrayAsync(source, cancellationToken).ConfigureAwait(false));

        /// <summary>
        /// Maps the list of <typeparamref name="TSource"/> into an immutable list of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An immutable list of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async Task<ImmutableList<TDestination>> MapImmutableListAsync<TSource, TDestination>(
            this IAsyncImmutableMapper<TSource, TDestination> mapper,
            List<TSource> source,
            CancellationToken cancellationToken = default)
            where TDestination : new() =>
            ImmutableList.Create(await mapper.MapArrayAsync(source, cancellationToken).ConfigureAwait(false));

        /// <summary>
        /// Maps the collection of <typeparamref name="TSource"/> into an immutable list of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An immutable list of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async Task<ImmutableList<TDestination>> MapImmutableListAsync<TSource, TDestination>(
            this IAsyncImmutableMapper<TSource, TDestination> mapper,
            Collection<TSource> source,
            CancellationToken cancellationToken = default)
            where TDestination : new() =>
            ImmutableList.Create(await mapper.MapArrayAsync(source, cancellationToken).ConfigureAwait(false));

        /// <summary>
        /// Maps the array of <typeparamref name="TSource"/> into an immutable list of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An immutable list of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async Task<ImmutableList<TDestination>> MapImmutableListAsync<TSource, TDestination>(
            this IAsyncImmutableMapper<TSource, TDestination> mapper,
            TSource[] source,
            CancellationToken cancellationToken = default)
            where TDestination : new() =>
            ImmutableList.Create(await mapper.MapArrayAsync(source, cancellationToken).ConfigureAwait(false));

        /// <summary>
        /// Maps the enumerable of <typeparamref name="TSource"/> into an immutable list of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An immutable list of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async Task<ImmutableList<TDestination>> MapImmutableListAsync<TSource, TDestination>(
            this IAsyncImmutableMapper<TSource, TDestination> mapper,
            IEnumerable<TSource> source,
            CancellationToken cancellationToken = default)
            where TDestination : new() =>
            ImmutableList.Create(await mapper.MapArrayAsync(source, cancellationToken).ConfigureAwait(false));
    }
}
#endif
#endif