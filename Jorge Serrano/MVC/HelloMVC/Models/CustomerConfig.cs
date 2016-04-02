using System.Data.Entity.ModelConfiguration;

namespace HelloMVC.Models
{
    public class CustomerConfig : EntityTypeConfiguration<Customer>
    {
        public CustomerConfig()
        {
            this.HasMany<CustomerDetail>(a => a.Details);
        }
    }
}