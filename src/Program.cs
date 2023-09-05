// Copyright (c) The Parus RX Authors. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.AddDaprClient();
builder.Services.AddDaprEventBus();

string provider = builder.Configuration["Database:Provider"] ?? string.Empty;
string connectionString = builder.Configuration["Database:ConnectionString"] ?? string.Empty;
switch(provider)
{
    case "Oracle":
        builder.Services
            .AddDataAccess(options => options.UseOracle(connectionString))
            .AddOracleParusRxStores();
        break;
    case "Postgres":
        builder.Services
            .AddDataAccess(options => options.UsePostgreSql(connectionString))
            .AddPostgresParusRxStore();
        break;
    default:
        throw new NotSupportedException($"""Database provider "{provider}" is not supported.""");
}

builder.Services.AddHealthChecks()
    .AddCheck("self", () => HealthCheckResult.Healthy());

var app = builder.Build();

app.UseCloudEvents();
app.MapSubscribeHandler();

app.MapHealthChecks("/health", new HealthCheckOptions { Predicate = _ => true });
app.MapHealthChecks("/liveness", new HealthCheckOptions { Predicate = _ => _.Name.Contains("self") });

app.Run();

public partial class Program { }