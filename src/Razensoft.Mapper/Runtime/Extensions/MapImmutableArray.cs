#if NET5_0
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;

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
        /// <returns>An immutable array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static ImmutableArray<TDestination> MapImmutableArray<TSource, TDestination>(
            this IMapper<TSource, TDestination> mapper,
            List<TSource> source)
            where TDestination : new() =>
            ImmutableArray.Create(mapper.MapArray(source));

        /// <summary>
        /// Maps the collection of <typeparamref name="TSource"/> into an immutable array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An immutable array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static ImmutableArray<TDestination> MapImmutableArray<TSource, TDestination>(
            this IMapper<TSource, TDestination> mapper,
            Collection<TSource> source)
            where TDestination : new() =>
            ImmutableArray.Create(mapper.MapArray(source));

        /// <summary>
        /// Maps the array of <typeparamref name="TSource"/> into an immutable array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An immutable array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static ImmutableArray<TDestination> MapImmutableArray<TSource, TDestination>(
            this IMapper<TSource, TDestination> mapper,
            TSource[] source)
            where TDestination : new() =>
            ImmutableArray.Create(mapper.MapArray(source));

        /// <summary>
        /// Maps the enumerable of <typeparamref name="TSource"/> into an immutable array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An immutable array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static ImmutableArray<TDestination> MapImmutableArray<TSource, TDestination>(
            this IMapper<TSource, TDestination> mapper,
            IEnumerable<TSource> source)
            where TDestination : new() =>
            ImmutableArray.Create(mapper.MapArray(source));

        /// <summary>
        /// Maps the list of <typeparamref name="TSource"/> into an immutable list of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An immutable list of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static ImmutableList<TDestination> MapImmutableList<TSource, TDestination>(
            this IMapper<TSource, TDestination> mapper,
            List<TSource> source)
            where TDestination : new() =>
            ImmutableList.Create(mapper.MapArray(source));

        /// <summary>
        /// Maps the collection of <typeparamref name="TSource"/> into an immutable list of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An immutable list of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static ImmutableList<TDestination> MapImmutableList<TSource, TDestination>(
            this IMapper<TSource, TDestination> mapper,
            Collection<TSource> source)
            where TDestination : new() =>
            ImmutableList.Create(mapper.MapArray(source));

        /// <summary>
        /// Maps the array of <typeparamref name="TSource"/> into an immutable list of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An immutable list of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static ImmutableList<TDestination> MapImmutableList<TSource, TDestination>(
            this IMapper<TSource, TDestination> mapper,
            TSource[] source)
            where TDestination : new() =>
            ImmutableList.Create(mapper.MapArray(source));

        /// <summary>
        /// Maps the enumerable of <typeparamref name="TSource"/> into an immutable list of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An immutable list of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static ImmutableList<TDestination> MapImmutableList<TSource, TDestination>(
            this IMapper<TSource, TDestination> mapper,
            IEnumerable<TSource> source)
            where TDestination : new() =>
            ImmutableList.Create(mapper.MapArray(source));

        /// <summary>
        /// Maps the list of <typeparamref name="TSource"/> into an immutable array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An immutable array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static ImmutableArray<TDestination> MapImmutableArray<TSource, TDestination>(
            this IImmutableMapper<TSource, TDestination> mapper,
            List<TSource> source) =>
            ImmutableArray.Create(mapper.MapArray(source));

        /// <summary>
        /// Maps the collection of <typeparamref name="TSource"/> into an immutable array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An immutable array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static ImmutableArray<TDestination> MapImmutableArray<TSource, TDestination>(
            this IImmutableMapper<TSource, TDestination> mapper,
            Collection<TSource> source) =>
            ImmutableArray.Create(mapper.MapArray(source));

        /// <summary>
        /// Maps the array of <typeparamref name="TSource"/> into an immutable array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An immutable array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static ImmutableArray<TDestination> MapImmutableArray<TSource, TDestination>(
            this IImmutableMapper<TSource, TDestination> mapper,
            TSource[] source) =>
            ImmutableArray.Create(mapper.MapArray(source));

        /// <summary>
        /// Maps the enumerable of <typeparamref name="TSource"/> into an immutable array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An immutable array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static ImmutableArray<TDestination> MapImmutableArray<TSource, TDestination>(
            this IImmutableMapper<TSource, TDestination> mapper,
            IEnumerable<TSource> source) =>
            ImmutableArray.Create(mapper.MapArray(source));

        /// <summary>
        /// Maps the list of <typeparamref name="TSource"/> into an immutable list of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An immutable list of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static ImmutableList<TDestination> MapImmutableList<TSource, TDestination>(
            this IImmutableMapper<TSource, TDestination> mapper,
            List<TSource> source) =>
            ImmutableList.Create(mapper.MapArray(source));

        /// <summary>
        /// Maps the collection of <typeparamref name="TSource"/> into an immutable list of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An immutable list of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static ImmutableList<TDestination> MapImmutableList<TSource, TDestination>(
            this IImmutableMapper<TSource, TDestination> mapper,
            Collection<TSource> source) =>
            ImmutableList.Create(mapper.MapArray(source));

        /// <summary>
        /// Maps the array of <typeparamref name="TSource"/> into an immutable list of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An immutable list of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static ImmutableList<TDestination> MapImmutableList<TSource, TDestination>(
            this IImmutableMapper<TSource, TDestination> mapper,
            TSource[] source) =>
            ImmutableList.Create(mapper.MapArray(source));

        /// <summary>
        /// Maps the enumerable of <typeparamref name="TSource"/> into an immutable list of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An immutable list of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static ImmutableList<TDestination> MapImmutableList<TSource, TDestination>(
            this IImmutableMapper<TSource, TDestination> mapper,
            IEnumerable<TSource> source) =>
            ImmutableList.Create(mapper.MapArray(source));
    }
}
#endif