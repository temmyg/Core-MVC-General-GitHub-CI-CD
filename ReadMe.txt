Database First run
dotnet ef dbcontext scaffold "Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=TrueServer=DESKTOP-H8IMEBU\\SQLEXPRESS;Database=LaunchDivision;Trusted_Connection=True;MultipleActiveResultSets=true;" Microsoft.EntityFrameworkCore.SqlServer -o Models

Code First 
dotnet ef migrations remove 
dotnet ef migrations add InitialCreate(can be any name)
dotnet ef migrations add launchmodel 
dotnet ef database update launchmodel
dotnet ef database update 

dotnet ef migrations script changetype
dotnet ef migrations script InitialCreate
dotnet ef migrations script InitialCreate changetype
dotnet ef migrations script 

