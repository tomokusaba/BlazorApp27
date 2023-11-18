var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BlazorApp27>("blazorapp27");

builder.Build().Run();
