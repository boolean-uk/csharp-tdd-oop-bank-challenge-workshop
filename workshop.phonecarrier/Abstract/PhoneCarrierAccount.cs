using workshop.phonecarrier.Concrete;
using workshop.phonecarrier.Enums;

namespace workshop.phonecarrier.Abstract;

public abstract class PhoneCarrierAccount
{
    private List<Payment> _payments = new List<Payment>();
    
    public List<Payment> GetPaymentHistory() => _payments;
    
    public Guid Id { get; set; }
    public Guid AccountNumber { get; set; } = Guid.NewGuid();
    public string PhoneNumber { get; set; }
    public string CustomerName { get; set; }
    public string CustomerCity { get; set; }
    public ContractLength ContractLength { get; set; }
    public bool RoamingEnabled { get; set; } = false;
    public virtual void MakePayment()
    {

    }

}
