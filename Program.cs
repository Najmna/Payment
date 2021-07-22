using Payment.Library;
using Payment.Model;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Payment
{
    class Program
    {
        enum Benelux
        {
            BE, // Belgium
            NL, // Netherlands 
            LU  // Luxembourg 
        }

        static void Main(string[] args)
        {
            try
            {
                Parser parser = new Parser();

                IEnumerable<PaymentData> payments = parser.CSV(@"C:\paymentData.csv");

                Console.WriteLine($"Number of approved Mastercard transactions from the Benelux: {payments.Where(i => i.PaymentMethod.Equals("MASTERCARD")).Where(i => i.ActionType.Equals("Authorization") && i.ResponseDescription.Equals("Approved")).Where(i => i.IssuerCountry.Equals(Enum.GetName(typeof(Benelux), Benelux.BE)) || i.IssuerCountry.Equals(Enum.GetName(typeof(Benelux), Benelux.LU)) || i.IssuerCountry.Equals(Enum.GetName(typeof(Benelux), Benelux.NL))).Count()}");

                Console.WriteLine("Transactions:");

                var transaction = payments.Where(i => i.PaymentMethod.Equals("MASTERCARD")).Where(i => i.ActionType.Equals("Authorization") && i.ResponseDescription.Equals("Approved"));

                // Transaction from Belgium.
                var belgium = transaction.Where(i => i.IssuerCountry.Equals(Enum.GetName(typeof(Benelux), Benelux.BE))).FirstOrDefault();

                Console.WriteLine(belgium == null ? "There are no transanctions from Belgium" : $"Country: {belgium.IssuerCountry} Payment ID: {belgium.PaymentId}");

                // Transaction from Netherlands.
                var netherlands = transaction.Where(i => i.IssuerCountry.Equals(Enum.GetName(typeof(Benelux), Benelux.NL))).FirstOrDefault();

                Console.WriteLine(netherlands == null ? "There are no transanctions from Netherlands" : $"Country: {netherlands.IssuerCountry} Payment ID: {netherlands.PaymentId}");

                // Transaction from Luxembourg.
                var luxembourg = transaction.Where(i => i.IssuerCountry.Equals(Enum.GetName(typeof(Benelux), Benelux.LU))).FirstOrDefault();

                Console.WriteLine(luxembourg == null ? "There are no transanctions from Luxembourg" : $"Country: {luxembourg.IssuerCountry} Payment ID: {luxembourg.PaymentId}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} Please Check the Document!");
            }

            Console.ReadLine();
        }

        
    }
}
