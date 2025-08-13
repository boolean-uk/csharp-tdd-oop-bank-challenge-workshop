using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.phonecarrier.Abstract;
using workshop.phonecarrier.Enums;

namespace workshop.phonecarrier.Concrete.Plans
{
    public class PayAsYouGo : PhoneCarrierAccount
    {
        public PayAsYouGo()
        {
            ContractLength = ContractLength.PAYG;
        }
        public override void MakePayment()
        {
                
        }
    }
}
