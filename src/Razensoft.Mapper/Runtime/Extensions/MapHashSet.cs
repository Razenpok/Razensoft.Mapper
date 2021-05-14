using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Razensoft.Mapper
{
    public static partial class MapperExtensions
    {
        /// <summary>
        /// Maps the list of <typeparamref name="TSource"/> into a hash set of <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>A hash set of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static HashSet<TDestination> MapHashSet<TSource, TDestination>(
            this IMapper<TSource, TDestination> mapper,
            List<TSource> source)
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

            var destination = new HashSet<TDestination>();
            foreach (var sourceItem in source)
            {
                var destinationItem = new TDestination();
                mapper.Map(sourceItem, destinationItem);
                destination.Add(destinationItem);
            }

            return destination;
        }

        /// <summary>
        /// Maps the collection of <typeparamref name="TSource"/> into a hash set of <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>A hash set of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static HashSet<TDestination> MapHashSet<TSource, TDestination>(
            this IMapper<TSource, TDestination> mapper,
            Collection<TSource> source)
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

            var destination = new HashSet<TDestination>();
            foreach (var sourceItem in source)
            {
                var destinationItem = new TDestination();
                mapper.Map(sourceItem, destinationItem);
                destination.Add(destinationItem);
            }

            return destination;
        }

        /// <summary>
        /// Maps the array of <typeparamref name="TSource"/> into a hash set of <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>A hash set of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static HashSet<TDestination> MapHashSet<TSource, TDestination>(
            this IMapper<TSource, TDestination> mapper,
            TSource[] source)
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

            var destination = new HashSet<TDestination>();
            foreach (var sourceItem in source)
            {
                var destinationItem = new TDestination();
                mapper.Map(sourceItem, destinationItem);
                destination.Add(destinationItem);
            }

            return destination;
        }

        /// <summary>
        /// Maps the enumerable of <typeparamref name="TSource"/> into a hash set of <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>A hash set of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static HashSet<TDestination> MapHashSet<TSource, TDestination>(
            this IMapper<TSource, TDestination> mapper,
            IEnumerable<TSource> source)
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

            var destination = new HashSet<TDestination>();
            foreach (var sourceItem in source)
            {
                var destinationItem = new TDestination();
                mapper.Map(sourceItem, destinationItem);
                destination.Add(destinationItem);
            }

            return destination;
        }

        /// <summary>
        /// Maps the list of <typeparamref name="TSource"/> into a hash set of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>A hash set of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static HashSet<TDestination> MapHashSet<TSource, TDestination>(
            this IImmutableMapper<TSource, TDestination> mapper,
            List<TSource> source)
        {
            if (mapper == null)
            {
                throw new ArgumentNullException(nameof(mapper));
            }

            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            var destination = new HashSet<TDestination>();
            foreach (var sourceItem in source)
            {
                var destinationItem = mapper.Map(sourceItem);
                destination.Add(destinationItem);
            }

            return destination;
        }

        /// <summary>
        /// Maps the collection of <typeparamref name="TSource"/> into a hash set of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>A hash set of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static HashSet<TDestination> MapHashSet<TSource, TDestination>(
            this IImmutableMapper<TSource, TDestination> mapper,
            Collection<TSource> source)
        {
            if (mapper == null)
            {
                throw new ArgumentNullException(nameof(mapper));
            }

            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            var destination = new HashSet<TDestination>();
            foreach (var sourceItem in source)
            {
                var destinationItem = mapper.Map(sourceItem);
                destination.Add(destinationItem);
            }

            return destination;
        }

        /// <summary>
        /// Maps the array of <typeparamref name="TSource"/> into a hash set of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>A hash set of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static HashSet<TDestination> MapHashSet<TSource, TDestination>(
            this IImmutableMapper<TSource, TDestination> mapper,
            TSource[] source)
        {
            if (mapper == null)
            {
                throw new ArgumentNullException(nameof(mapper));
            }

            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            var destination = new HashSet<TDestination>();
            foreach (var sourceItem in source)
            {
                var destinationItem = mapper.Map(sourceItem);
                destination.Add(destinationItem);
            }

            return destination;
        }

        /// <summary>
        /// Maps the enumerable of <typeparamref name="TSource"/> into a hash set of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>A hash set of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static HashSet<TDestination> MapHashSet<TSource, TDestination>(
            this IImmutableMapper<TSource, TDestination> mapper,
            IEnumerable<TSource> source)
        {
            if (mapper == null)
            {
                throw new ArgumentNullException(nameof(mapper));
            }

            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            var destination = new HashSet<TDestination>();
            foreach (var sourceItem in source)
            {
                var destinationItem = mapper.Map(sourceItem);
                destination.Add(destinationItem);
            }

            return destination;
        }
    }
}