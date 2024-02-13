codealong to https://www.youtube.com/watch?v=AopeJjkcRvU

- docker run -e "ACCEPT_EULA=1" -e "MSSQL_SA_PASSWORD=MyPass@word" -e "MSSQL_PID=Developer" -e "MSSQL_USER=SA" -p - 1433:1433 -d --name=sql
 
- mcr.microsoft.com/azure-sql-edgehttps://stackoverflow.com/questions/45382536/- how-to-enable-migrations-in-visual-studio-for-mac

- dotnet ef database update
- dotnet ef migrations add AddCategoryTableToDb
- dotnet ef migrations add SeedCategoryTable
- dotnet-aspnet-codegenerator area Admin
- dotnet ef migrations add --verbose --project Bulky.DataAccess AddProductTableToDb --startup-project BulkyWeb

- dotnet ef database update --verbose --project Bulky.DataAccess --startup-project BulkyWeb
- dotnet ef migrations add --verbose --project Bulky.DataAccess AddForeignKeyForCategoryProductRelation - --startup-project BulkyWeb
- dotnet ef migrations remove --verbose --project Bulky.DataAccess --startup-project BulkyWeb
- dotnet ef migrations add --verbose --project Bulky.DataAccess AddIdentityTables --startup-project BulkyWeb
- dotnet ef migrations add --verbose --project Bulky.DataAccess ExtendIdentityUser --startup-project BulkyWeb
- dotnet ef database update --verbose --project Bulky.DataAccess --startup-project BulkyWeb
