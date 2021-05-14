#if RAZENSOFT_MAPPER_UNITASK_SUPPORT
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using Cysharp.Threading.Tasks;

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
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A hash set of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async UniTask<HashSet<TDestination>> MapHashSetAsync<TSource, TDestination>(
            this IAsyncMapper<TSource, TDestination> mapper,
            List<TSource> source,
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

            var sourceCount = source.Count;
            var tasks = new UniTask[sourceCount];
            var destination = new HashSet<TDestination>();
            for (var i = 0; i < sourceCount; ++i)
            {
                var sourceItem = source[i];
                var destinationItem = new TDestination();
                destination.Add(destinationItem);
                tasks[i] = mapper.MapAsync(sourceItem, destinationItem, cancellationToken);
            }

            await UniTask.WhenAll(tasks);

            return destination;
        }

        /// <summary>
        /// Maps the collection of <typeparamref name="TSource"/> into a hash set of <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A hash set of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async UniTask<HashSet<TDestination>> MapHashSetAsync<TSource, TDestination>(
            this IAsyncMapper<TSource, TDestination> mapper,
            Collection<TSource> source,
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

            var sourceCount = source.Count;
            var tasks = new UniTask[sourceCount];
            var destination = new HashSet<TDestination>();
            for (var i = 0; i < sourceCount; ++i)
            {
                var sourceItem = source[i];
                var destinationItem = new TDestination();
                destination.Add(destinationItem);
                tasks[i] = mapper.MapAsync(sourceItem, destinationItem, cancellationToken);
            }

            await UniTask.WhenAll(tasks);

            return destination;
        }

        /// <summary>
        /// Maps the array of <typeparamref name="TSource"/> into a hash set of <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A hash set of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async UniTask<HashSet<TDestination>> MapHashSetAsync<TSource, TDestination>(
            this IAsyncMapper<TSource, TDestination> mapper,
            TSource[] source,
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

            var sourceCount = source.Length;
            var tasks = new UniTask[sourceCount];
            var destination = new HashSet<TDestination>();
            for (var i = 0; i < sourceCount; ++i)
            {
                var sourceItem = source[i];
                var destinationItem = new TDestination();
                destination.Add(destinationItem);
                tasks[i] = mapper.MapAsync(sourceItem, destinationItem, cancellationToken);
            }

            await UniTask.WhenAll(tasks);

            return destination;
        }

        /// <summary>
        /// Maps the enumerable of <typeparamref name="TSource"/> into a hash set of <typeparamref name="TDestination"/>.
        /// </summary>
        /// <typeparam name="TSource">The type of the source objects.</typeparam>
        /// <typeparam name="TDestination">The type of the destination objects.</typeparam>
        /// <param name="mapper">The mapper.</param>
        /// <param name="source">The source objects.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A hash set of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async UniTask<HashSet<TDestination>> MapHashSetAsync<TSource, TDestination>(
            this IAsyncMapper<TSource, TDestination> mapper,
            IEnumerable<TSource> source,
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

            var sourceCount = source.Count();
            var tasks = new UniTask[sourceCount];
            var destination = new HashSet<TDestination>();
            var i = 0;
            foreach (var sourceItem in source)
            {
                var destinationItem = new TDestination();
                destination.Add(destinationItem);
                tasks[i] = mapper.MapAsync(sourceItem, destinationItem, cancellationToken);
                ++i;
            }

            await UniTask.WhenAll(tasks);

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
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A hash set of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async UniTask<HashSet<TDestination>> MapHashSetAsync<TSource, TDestination>(
            this IAsyncImmutableMapper<TSource, TDestination> mapper,
            List<TSource> source,
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

            var sourceCount = source.Count;
            var tasks = new UniTask<TDestination>[sourceCount];
            var destination = new HashSet<TDestination>();
            for (var i = 0; i < sourceCount; ++i)
            {
                var sourceItem = source[i];
                tasks[i] = mapper.MapAsync(sourceItem, cancellationToken);
            }

            await UniTask.WhenAll(tasks);

            foreach (var task in tasks)
            {
#pragma warning disable VSTHRD103 // Call async methods when in an async method.
                destination.Add(task.GetAwaiter().GetResult());
#pragma warning restore VSTHRD103 // Call async methods when in an async method.
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
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A hash set of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async UniTask<HashSet<TDestination>> MapHashSetAsync<TSource, TDestination>(
            this IAsyncImmutableMapper<TSource, TDestination> mapper,
            Collection<TSource> source,
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

            var sourceCount = source.Count;
            var tasks = new UniTask<TDestination>[sourceCount];
            var destination = new HashSet<TDestination>();
            for (var i = 0; i < sourceCount; ++i)
            {
                var sourceItem = source[i];
                tasks[i] = mapper.MapAsync(sourceItem, cancellationToken);
            }

            await UniTask.WhenAll(tasks);

            foreach (var task in tasks)
            {
#pragma warning disable VSTHRD103 // Call async methods when in an async method.
                destination.Add(task.GetAwaiter().GetResult());
#pragma warning restore VSTHRD103 // Call async methods when in an async method.
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
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A hash set of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async UniTask<HashSet<TDestination>> MapHashSetAsync<TSource, TDestination>(
            this IAsyncImmutableMapper<TSource, TDestination> mapper,
            TSource[] source,
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

            var sourceCount = source.Length;
            var tasks = new UniTask<TDestination>[sourceCount];
            var destination = new HashSet<TDestination>();
            for (var i = 0; i < sourceCount; ++i)
            {
                var sourceItem = source[i];
                tasks[i] = mapper.MapAsync(sourceItem, cancellationToken);
            }

            await UniTask.WhenAll(tasks);

            foreach (var task in tasks)
            {
#pragma warning disable VSTHRD103 // Call async methods when in an async method.
                destination.Add(task.GetAwaiter().GetResult());
#pragma warning restore VSTHRD103 // Call async methods when in an async method.
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
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A hash set of <typeparamref name="TDestination"/>.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="mapper"/> or <paramref name="source"/> is
        /// <c>null</c>.</exception>
        public static async UniTask<HashSet<TDestination>> MapHashSetAsync<TSource, TDestination>(
            this IAsyncImmutableMapper<TSource, TDestination> mapper,
            IEnumerable<TSource> source,
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

            var sourceCount = source.Count();
            var tasks = new UniTask<TDestination>[sourceCount];
            var destination = new HashSet<TDestination>();
            var i = 0;
            foreach (var sourceItem in source)
            {
                tasks[i] = mapper.MapAsync(sourceItem, cancellationToken);
                ++i;
            }

            await UniTask.WhenAll(tasks);

            foreach (var task in tasks)
            {
#pragma warning disable VSTHRD103 // Call async methods when in an async method.
                destination.Add(task.GetAwaiter().GetResult());
#pragma warning restore VSTHRD103 // Call async methods when in an async method.
            }

            return destination;
        }
    }
}
#endif