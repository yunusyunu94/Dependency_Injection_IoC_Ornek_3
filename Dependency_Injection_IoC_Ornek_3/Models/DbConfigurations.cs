namespace Dependency_Injection_IoC_Ornek_3.Models
{
    public class DbConfigurations
    {
        public int Id { get; set; }
        public Guid OperationId { get; set; }

        public DbConfigurations()
        {
            OperationId = Guid.NewGuid();
        }
    }
}
