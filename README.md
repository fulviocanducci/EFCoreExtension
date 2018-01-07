# Extension for SQL SERVER - EF Core 2.0.1


# Setting

```csharp
using Microsoft.EntityFrameworkCore;

namespace Ralms.Microsoft.EntityFrameworkCore.Tests
{
    public class SampleContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.CreateFunctionDateDiff();
        }
    }
}
```

# Sample

```csharp
var list = db
    .People
    .Where(p => EFCore.DateDiff(DatePart.day, DateTime.Now, p.Birthday) < 1)
    .ToList();
```