using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Model
{
    class PaymentData
    {
        public string PaymentId { get; set; }

        public string ProcesingCurrency { get; set; }

        public string PayoutCurrency { get; set; }

        public DateTime RequestedOn { get; set; }

        public string ChannelName { get; set; }

        public string Reference { get; set; }

        public string PaymentMethod { get; set; }

        public string CardType { get; set; }

        public string CardCategory { get; set; }

        public string IssuerCountry { get; set; }

        public string MerchantCountry { get; set; }

        public string MID { get; set; }

        public string ActionType { get; set; }

        public string ActionId { get; set; }

        public DateTime ProcessedOn { get; set; }

        public string ResponseCode { get; set; }

        public string ResponseDescription { get; set; }

        public string BreakdownType { get; set; }

        public DateTime BreakdownDate { get; set; }

        public decimal ProcessingCurrencyAmount { get; set; }

        public decimal PayoutCurrencyAmount { get; set; }

        public string Region { get; set; }

    }
}