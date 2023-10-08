using ChecksWrapperApi.Wrapper;

using Microsoft.Extensions.Options;

using Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IConfigureOptions<ChecksWrapperOptions>>(provider =>
    new ConfigureOptions<ChecksWrapperOptions>(options =>
        provider.GetRequiredService<IConfiguration>().GetRequiredSection("ChecksWrapper").Bind(options)));
builder.Services.AddTransient<ChecksWrapperHandler>();
builder.Services.AddRefitClient<IChecksWrapper>()
        .ConfigureHttpClient((provider, options) =>
            options.BaseAddress = provider.GetRequiredService<IOptionsMonitor<ChecksWrapperOptions>>().CurrentValue.Endpoint)
        .AddHttpMessageHandler<ChecksWrapperHandler>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
