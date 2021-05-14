using System;

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
        /// <returns>The mapped object of type <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper" /> or <paramref name="source" /> is
        /// <c>null</c>.</exception>
        public static TDestination Map<TSource, TDestination>(
            this IMapper<TSource, TDestination> mapper,
            TSource source)
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
            mapper.Map(source, destination);
            return destination;
        }

        /// <summary>
        /// Maps the specified source object to a new object with a type of <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source object.</typeparam>
        /// <typeparam name="TDestination">The type of the destination object.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source object.</param>
        /// <returns>The mapped object of type <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper" /> or <paramref name="source" /> is
        /// <c>null</c>.</exception>
        public static TDestination Map<TSource, TDestination>(
            this IImmutableMapper<TSource, TDestination> mapper,
            TSource source)
        {
            if (mapper == null)
            {
                throw new ArgumentNullException(nameof(mapper));
            }

            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            return mapper.Map(source);
        }
    }
}