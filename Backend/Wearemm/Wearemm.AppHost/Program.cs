
var builder = DistributedApplication.CreateBuilder(args);

// Cria o serviço do Postgres e configura o PgAdmin
var postgres = builder.AddPostgres("postgres")
                      .WithPgAdmin(pgAdmin => pgAdmin.WithHostPort(5050));

// Adiciona os bancos de dados ao mesmo serviço Postgres
var catalogDatabase = postgres.AddDatabase("catalog");

// Adiciona o projeto e referencia o banco necessário
var exampleProject = builder.AddProject<Projects.Wearemm_Catalog>("appcatalog")
                            .WithReference(catalogDatabase);

builder.AddProject<Projects.Wearemm_Catalog_MigrationService>("migrations")
    .WithReference(postgres)
    .WaitFor(postgres);

builder.AddProject<Projects.Wearemm_Catalog_MigrationService>("wearemm-catalog-migrationservice");

builder.Build().Run();
