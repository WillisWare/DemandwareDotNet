using Net.Demandware.Ocapi.BaseModels;
using Net.Demandware.Ocapi.Shop.Models;

namespace Net.Demandware.Ocapi.Shop
{
    /// <summary>
    /// Represents a customer payment instrument result.
    /// </summary>
    /// <remarks>The payment data contained is masked where needed for security purposes.</remarks>
    public sealed class CustomerPaymentInstrumentResult : BaseResult<CustomerPaymentInstrument>
    {
    }
}
