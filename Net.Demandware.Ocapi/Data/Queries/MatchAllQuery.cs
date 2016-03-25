namespace Net.Demandware.Ocapi.Data.Queries
{
    /// <summary>
    /// Represents a query that matches all documents.
    /// </summary>
    /// <remarks>
    /// A match all query simply matches all documents (namespace and document type). This query comes in handy if you just want to filter a search result or really do not have any constraints.
    /// <example>
    ///     query: {
    ///         match_all_query: {}
    ///     }
    /// </example>
    /// </remarks>
    public sealed class MatchAllQuery
    {
    }
}
