using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using Payment.Model;

namespace Payment.Library
{
    class Parser
    {
        public IEnumerable<PaymentData> CSV(string filePath)
        {
            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                DataTable data = SetDataTable();

                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                string[] headers = parser.ReadFields();

                while (!parser.EndOfData)
                {
                    string[] field = parser.ReadFields();

                    if (field.Where(i => i.Length != 0).Count().Equals(0)) // Just in case there are any empty row before the end.
                    {
                        continue;
                    }

                    PaymentData paymentData = new PaymentData();

                    paymentData.PaymentId = Regex.Escape(field[0]);
                    paymentData.ProcesingCurrency = Regex.Escape(field[1]);
                    paymentData.PayoutCurrency = Regex.Escape(field[2]);
                    paymentData.RequestedOn = Convert.ToDateTime(field[3]);
                    paymentData.ChannelName = Regex.Escape(field[4]);
                    paymentData.Reference = Regex.Escape(field[5]);
                    paymentData.PaymentMethod = Regex.Escape(field[6]);
                    paymentData.CardType = Regex.Escape(field[7]);
                    paymentData.CardCategory = Regex.Escape(field[8]);
                    paymentData.IssuerCountry = Regex.Escape(field[9]);
                    paymentData.MerchantCountry = Regex.Escape(field[10]);
                    paymentData.MID = Regex.Escape(field[11]);
                    paymentData.ActionType = Regex.Escape(field[12]);
                    paymentData.ActionId = Regex.Escape(field[13]);
                    paymentData.ProcessedOn = Convert.ToDateTime(field[14]);
                    paymentData.ResponseCode = Regex.Escape(field[15]);
                    paymentData.ResponseDescription = Regex.Escape(field[16]);
                    paymentData.BreakdownType = Regex.Escape(field[17]);
                    paymentData.BreakdownDate = Convert.ToDateTime(field[18]);
                    paymentData.ProcessingCurrencyAmount = Convert.ToDecimal(field[19]);
                    paymentData.PayoutCurrencyAmount = Convert.ToDecimal(field[20]);
                    paymentData.Region = Regex.Escape(field[21]);

                    data.Rows.Add(new object[] {
                            paymentData.PaymentId,
                            paymentData.ProcesingCurrency,
                            paymentData.PayoutCurrency,
                            paymentData.RequestedOn,
                            paymentData.ChannelName,
                            paymentData.Reference,
                            paymentData.PaymentMethod,
                            paymentData.CardType,
                            paymentData.CardCategory,
                            paymentData.IssuerCountry,
                            paymentData.MerchantCountry,
                            paymentData.MID,
                            paymentData.ActionType,
                            paymentData.ActionId,
                            paymentData.ProcessedOn,
                            paymentData.ResponseCode,
                            paymentData.ResponseDescription,
                            paymentData.BreakdownType,
                            paymentData.BreakdownDate,
                            paymentData.ProcessingCurrencyAmount,
                            paymentData.PayoutCurrencyAmount,
                            paymentData.Region
                        });
                }

                return data.AsEnumerable().Select(row => new PaymentData
                {
                    PaymentId = row["PaymentId"].ToString(),
                    ProcesingCurrency = row["ProcesingCurrency"].ToString(),
                    PayoutCurrency = row["PayoutCurrency"].ToString(),
                    RequestedOn = Convert.ToDateTime(row["RequestedOn"]),
                    ChannelName = row["ChannelName"].ToString(),
                    Reference = row["Reference"].ToString(),
                    PaymentMethod = row["PaymentMethod"].ToString(),
                    CardType = row["CardType"].ToString(),
                    CardCategory = row["CardCategory"].ToString(),
                    IssuerCountry = row["IssuerCountry"].ToString(),
                    MerchantCountry = row["MerchantCountry"].ToString(),
                    MID = row["MID"].ToString(),
                    ActionType = row["ActionType"].ToString(),
                    ActionId = row["ActionId"].ToString(),
                    ProcessedOn = Convert.ToDateTime(row["ProcessedOn"]),
                    ResponseCode = row["ResponseCode"].ToString(),
                    ResponseDescription = row["ResponseDescription"].ToString(),
                    BreakdownType = row["BreakdownType"].ToString(),
                    BreakdownDate = Convert.ToDateTime(row["BreakdownDate"]),
                    ProcessingCurrencyAmount = Convert.ToDecimal(row["ProcessingCurrencyAmount"]),
                    PayoutCurrencyAmount = Convert.ToDecimal(row["PayoutCurrencyAmount"]),
                    Region = row["Region"].ToString()
                });
            }
        }

        private static DataTable SetDataTable()
        {
            DataTable data = new DataTable();

            data.Columns.Add("PaymentId", typeof(string));
            data.Columns.Add("ProcesingCurrency", typeof(string));
            data.Columns.Add("PayoutCurrency", typeof(string));
            data.Columns.Add("RequestedOn", typeof(DateTime));
            data.Columns.Add("ChannelName", typeof(string));
            data.Columns.Add("Reference", typeof(string));
            data.Columns.Add("PaymentMethod", typeof(string));
            data.Columns.Add("CardType", typeof(string));
            data.Columns.Add("CardCategory", typeof(string));
            data.Columns.Add("IssuerCountry", typeof(string));
            data.Columns.Add("MerchantCountry", typeof(string));
            data.Columns.Add("MID", typeof(string));
            data.Columns.Add("ActionType", typeof(string));
            data.Columns.Add("ActionId", typeof(string));
            data.Columns.Add("ProcessedOn", typeof(DateTime));
            data.Columns.Add("ResponseCode", typeof(string));
            data.Columns.Add("ResponseDescription", typeof(string));
            data.Columns.Add("BreakdownType", typeof(string));
            data.Columns.Add("BreakdownDate", typeof(string));
            data.Columns.Add("ProcessingCurrencyAmount", typeof(decimal));
            data.Columns.Add("PayoutCurrencyAmount", typeof(decimal));
            data.Columns.Add("Region", typeof(string));

            return data;
        }
    }
}
