using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using CreaStoreNET.Infrastructure.Domain.Models;

namespace CreaStoreNET.Module.Core.Models {
    public sealed class Role : IdentityRole<Guid>, IEntity<Guid> {
        public Role(string name) {
            Name = name;
        }
    }
}
