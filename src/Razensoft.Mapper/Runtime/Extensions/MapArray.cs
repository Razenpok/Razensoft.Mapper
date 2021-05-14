using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Razensoft.Mapper
{
    public static partial class MapperExtensions
    {
        /// <summary>
        /// Maps the collection of <typeparamref name="TSource"/> into an array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSourceCollection">The type of the source collection.</typeparam>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="sourceCollection">The source collection.</param>
        /// <param name="destinationCollection">The destination collection.</param>
        /// <returns>An array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="sourceCollection"/> is
        /// <c>null</c>.</exception>
        public static TDestination[] MapArray<TSourceCollection, TSource, TDestination>(
            this IMapper<TSource, TDestination> mapper,
            TSourceCollection sourceCollection,
            TDestination[] destinationCollection)
            where TSourceCollection : IEnumerable<TSource>
            where TDestination : new()
        {
            if (mapper == null)
            {
                throw new ArgumentNullException(nameof(mapper));
            }

            if (sourceCollection == null)
            {
                throw new ArgumentNullException(nameof(sourceCollection));
            }

            if (destinationCollection == null)
            {
                throw new ArgumentNullException(nameof(destinationCollection));
            }

            var i = 0;
            foreach (var item in sourceCollection)
            {
                var destination = new TDestination();
                mapper.Map(item, destination);
                destinationCollection[i] = destination;
                ++i;
            }

            return destinationCollection;
        }

        /// <summary>
        /// Maps the list of <typeparamref name="TSource"/> into an array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static TDestination[] MapArray<TSource, TDestination>(
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

            var destination = new TDestination[source.Count];
            for (var i = 0; i < source.Count; ++i)
            {
                var sourceItem = source[i];
                var destinationItem = new TDestination();
                mapper.Map(sourceItem, destinationItem);
                destination[i] = destinationItem;
            }

            return destination;
        }

        /// <summary>
        /// Maps the collection of <typeparamref name="TSource"/> into an array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static TDestination[] MapArray<TSource, TDestination>(
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

            var destination = new TDestination[source.Count];
            for (var i = 0; i < source.Count; ++i)
            {
                var sourceItem = source[i];
                var destinationItem = new TDestination();
                mapper.Map(sourceItem, destinationItem);
                destination[i] = destinationItem;
            }

            return destination;
        }

        /// <summary>
        /// Maps the array of <typeparamref name="TSource"/> into an array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static TDestination[] MapArray<TSource, TDestination>(
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

            var destination = new TDestination[source.Length];
            for (var i = 0; i < source.Length; ++i)
            {
                var sourceItem = source[i];
                var destinationItem = new TDestination();
                mapper.Map(sourceItem, destinationItem);
                destination[i] = destinationItem;
            }

            return destination;
        }

        /// <summary>
        /// Maps the enumerable of <typeparamref name="TSource"/> into an array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static TDestination[] MapArray<TSource, TDestination>(
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

            var destination = new TDestination[source.Count()];
            var i = 0;
            foreach (var sourceItem in source)
            {
                var destinationItem = new TDestination();
                mapper.Map(sourceItem, destinationItem);
                destination[i] = destinationItem;
                ++i;
            }

            return destination;
        }
        /// <summary>
        /// Maps the collection of <typeparamref name="TSource"/> into an array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSourceCollection">The type of the source collection.</typeparam>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="sourceCollection">The source collection.</param>
        /// <param name="destinationCollection">The destination collection.</param>
        /// <returns>An array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="sourceCollection"/> is
        /// <c>null</c>.</exception>
        public static TDestination[] MapArray<TSourceCollection, TSource, TDestination>(
            this IImmutableMapper<TSource, TDestination> mapper,
            TSourceCollection sourceCollection,
            TDestination[] destinationCollection)
            where TSourceCollection : IEnumerable<TSource>
        {
            if (mapper == null)
            {
                throw new ArgumentNullException(nameof(mapper));
            }

            if (sourceCollection == null)
            {
                throw new ArgumentNullException(nameof(sourceCollection));
            }

            if (destinationCollection == null)
            {
                throw new ArgumentNullException(nameof(destinationCollection));
            }

            var i = 0;
            foreach (var item in sourceCollection)
            {
                var destination = mapper.Map(item);
                destinationCollection[i] = destination;
                ++i;
            }

            return destinationCollection;
        }

        /// <summary>
        /// Maps the list of <typeparamref name="TSource"/> into an array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static TDestination[] MapArray<TSource, TDestination>(
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

            var destination = new TDestination[source.Count];
            for (var i = 0; i < source.Count; ++i)
            {
                var sourceItem = source[i];
                var destinationItem = mapper.Map(sourceItem);
                destination[i] = destinationItem;
            }

            return destination;
        }

        /// <summary>
        /// Maps the collection of <typeparamref name="TSource"/> into an array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static TDestination[] MapArray<TSource, TDestination>(
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

            var destination = new TDestination[source.Count];
            for (var i = 0; i < source.Count; ++i)
            {
                var sourceItem = source[i];
                var destinationItem = mapper.Map(sourceItem);
                destination[i] = destinationItem;
            }

            return destination;
        }

        /// <summary>
        /// Maps the array of <typeparamref name="TSource"/> into an array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static TDestination[] MapArray<TSource, TDestination>(
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

            var destination = new TDestination[source.Length];
            for (var i = 0; i < source.Length; ++i)
            {
                var sourceItem = source[i];
                var destinationItem = mapper.Map(sourceItem);
                destination[i] = destinationItem;
            }

            return destination;
        }

        /// <summary>
        /// Maps the enumerable of <typeparamref name="TSource"/> into an array of
        /// <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <returns>An array of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static TDestination[] MapArray<TSource, TDestination>(
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

            var destination = new TDestination[source.Count()];
            var i = 0;
            foreach (var sourceItem in source)
            {
                var destinationItem = mapper.Map(sourceItem);
                destination[i] = destinationItem;
                ++i;
            }

            return destination;
        }
    }
}