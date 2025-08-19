- For the Connection String
```
"ConnectionStrings": {
    "SportsStoreConnection": "Data Source=localdb\\SQLEXPRESS;Initial Catalog=testProducts;Integrated Security=true;TrustServerCertificate=yes;Pooling=False" 
}

```


- Install the EF Core CLI tools (once per machine): before `dotnet ef migrations add Initial `

```
> dotnet tool install --global dotnet-ef

```
