using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    [PublicAPI]
    public static class BatchEnumerator
    {
        public delegate Task<Batch<T>> RetrieveBatch<T>(string? skip, CancellationToken cancellationToken);
        
        public static async IAsyncEnumerable<T> AllItems<T>(RetrieveBatch<T> batchResponse, string? initialSkip = null, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            // ReSharper disable once MethodSupportsCancellation
            await foreach (var batch in AllPages(batchResponse, initialSkip).WithCancellation(cancellationToken))
            {
                if (batch.Data != null)
                {
                    foreach (var item in batch.Data)
                    {
                        yield return item;
                    }
                }
                else
                {
                    yield break;
                }
            }
        }
            
        public static async IAsyncEnumerable<Batch<T>> AllPages<T>(RetrieveBatch<T> batchResponse, string? initialSkip = null, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            if (cancellationToken.IsCancellationRequested) yield break;
            var batch = await batchResponse(initialSkip, cancellationToken);
            yield return batch;

            while (batch.HasNext())
            {
                if (cancellationToken.IsCancellationRequested) yield break;
                batch = await batchResponse(batch.Next, cancellationToken);
                yield return batch;
            }
        }
    }
}