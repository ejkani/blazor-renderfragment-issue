var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.RenderFragmentIssue>("renderfragmentissue");

builder.Build().Run();
