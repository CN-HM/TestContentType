Serve.Run(RunOptions.Default
   .ConfigureBuilder(builder =>
    {
        builder.Services.AddControllers()
           .AddInject();

        builder.Services.AddRemoteRequest();
    })
   .Configure(app =>
    {
        app.UseRouting();
        app.UseInject(string.Empty);
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }));