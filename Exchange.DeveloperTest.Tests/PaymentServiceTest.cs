using Exchange.DeveloperTest.Services;
using Exchange.DeveloperTest.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearBank.DeveloperTest.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Make1000AmountBacsScheme() 
        {
            MakePaymentRequest mpr = new MakePaymentRequest
            {
                Amount = 1000m,
                CreditorAccountNumber = "11111",
                DebtorAccountNumber = "11111",
                PaymentDate = DateTime.Now,
                PaymentScheme = PaymentScheme.Bacs
            };
            PaymentService ps = new PaymentService();
            var a = ps.MakePayment(mpr);
            Assert.AreEqual(true, a.Success);
        }
        [TestMethod]
        public void Make10000AmountBacsScheme()
        {
            MakePaymentRequest mpr = new MakePaymentRequest
            {
                Amount = 10000m,
                CreditorAccountNumber = "11111",
                DebtorAccountNumber = "11111",
                PaymentDate = DateTime.Now,
                PaymentScheme = PaymentScheme.Bacs
            };
            PaymentService ps = new PaymentService();
            var a = ps.MakePayment(mpr);
            Assert.AreEqual(true, a.Success);
        }
        [TestMethod]
        public void Make1000AmountChapsScheme()
        {
            MakePaymentRequest mpr = new MakePaymentRequest
            {
                Amount = 1000m,
                CreditorAccountNumber = "11111",
                DebtorAccountNumber = "11111",
                PaymentDate = DateTime.Now,
                PaymentScheme = PaymentScheme.Chaps
            };
            PaymentService ps = new PaymentService();
            var a = ps.MakePayment(mpr);
            Assert.AreEqual(true, a.Success);
        }
        [TestMethod]
        public void Make10000AmountChapsScheme()
        {
            MakePaymentRequest mpr = new MakePaymentRequest
            {
                Amount = 10000m,
                CreditorAccountNumber = "11111",
                DebtorAccountNumber = "11111",
                PaymentDate = DateTime.Now,
                PaymentScheme = PaymentScheme.Chaps
            };
            PaymentService ps = new PaymentService();
            var a = ps.MakePayment(mpr);
            Assert.AreEqual(true, a.Success);
        }
        [TestMethod]
        public void Make1000AmountFasterPaymentsScheme()
        {
            MakePaymentRequest mpr = new MakePaymentRequest
            {
                Amount = 10000m,
                CreditorAccountNumber = "11111",
                DebtorAccountNumber = "11111",
                PaymentDate = DateTime.Now,
                PaymentScheme = PaymentScheme.FasterPayments
            };
            PaymentService ps = new PaymentService();
            var a = ps.MakePayment(mpr);
            Assert.AreEqual(true, a.Success);
        }
        [TestMethod]
        public void Make10000AmountFasterPaymentsScheme()
        {
            MakePaymentRequest mpr = new MakePaymentRequest
            {
                Amount = 10000m,
                CreditorAccountNumber = "11111",
                DebtorAccountNumber = "11111",
                PaymentDate = DateTime.Now,
                PaymentScheme = PaymentScheme.Chaps
            };
            PaymentService ps = new PaymentService();
            var a = ps.MakePayment(mpr);
            Assert.AreEqual(true, a.Success);
        }
        [TestMethod]
        public void MakeSoManyAmountBacsScheme()
        {
            MakePaymentRequest mpr = new MakePaymentRequest
            {
                Amount = 10000000000000000000000m,
                CreditorAccountNumber = "11111",
                DebtorAccountNumber = "11111",
                PaymentDate = DateTime.Now,
                PaymentScheme = PaymentScheme.Bacs
            };
            PaymentService ps = new PaymentService();
            var a = ps.MakePayment(mpr);
            Assert.AreEqual(true, a.Success);
        }
        [TestMethod]
        public void MakeNullAmountNullNumberBacsScheme()
        {
            MakePaymentRequest mpr = new MakePaymentRequest
            {
                Amount = 0m,
                CreditorAccountNumber = null, //Будет ошибка при выгрузке из БД
                DebtorAccountNumber = null, //Будет ошибка при выгрузке из БД
                PaymentDate = DateTime.Now,
                PaymentScheme = PaymentScheme.Bacs
            };
            PaymentService ps = new PaymentService();
            var a = ps.MakePayment(mpr);
            Assert.AreEqual(true, a.Success);
        }
    }
}
