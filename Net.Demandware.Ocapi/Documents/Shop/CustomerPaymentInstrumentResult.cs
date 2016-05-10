using Net.Demandware.Ocapi.Documents.Base;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a customer payment instrument result.
    /// </summary>
    /// <remarks>The payment data contained is masked where needed for security purposes.</remarks>
    public sealed class CustomerPaymentInstrumentResult : BaseResult<CustomerPaymentInstrument>
    {
    }
}
