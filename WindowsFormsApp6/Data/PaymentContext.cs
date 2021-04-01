using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.Models;

namespace WindowsFormsApp6.Data
{
    public class PaymentContext:DbContext
    {
        public PaymentContext() : base("Paymentdb")
        {

        }
        public DbSet<Payment> Payment { get; set; }
    }
}
