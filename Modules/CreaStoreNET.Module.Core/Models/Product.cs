using CreaStoreNET.Infrastructure.Domain.Models;

namespace CreaStoreNET.Module.Core.Models {
    public class Product : Entity {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
