using AspNetCore.Hashids.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;

namespace AspNetCore.Hashids.Options
{
    public class ConfigureJsonOptions(
        IHttpContextAccessor httpContextAccessor,
        IServiceProvider serviceProvider
    ) : IConfigureOptions<JsonOptions>
    {
        private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;
        private readonly IServiceProvider _serviceProvider = serviceProvider;

        public void Configure(JsonOptions options)
        {
            options.JsonSerializerOptions.Converters.Add(
                new DependencyInjectionJsonConverter(_httpContextAccessor, _serviceProvider)
            );
        }
    }
}
