Nuget Packages
------------------------------------------
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.SqlServer


Generate new database models
-----------------------------

Tools/Package manager/Console =>
Scaffold-DbContext "Data Source = LAPTOP-6OVEOOKP; Initial Catalog = School; Integrated Security = True;Pooling=True;MultipleActiveResultSets=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models\Database -NoPluralize -Context SchoolContext

Remove empty constructor
Remove OnConfiguring


Scaffold-DbContext "Data Source = LAPTOP-6OVEOOKP; Initial Catalog = School2; Integrated Security = True;Pooling=True;MultipleActiveResultSets=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models\Database -NoPluralize -Context SchoolContext
