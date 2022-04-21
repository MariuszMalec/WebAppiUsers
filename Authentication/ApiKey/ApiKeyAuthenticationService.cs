﻿using Microsoft.Extensions.Options;

namespace ApiWithAuhtentications.Authentication.ApiKey
{
    public class ApiKeyAuthenticationService : IApiKeyAuthenticationService
	{
		private readonly IOptions<ApiKeyAuthenticationOptions> _options;

		public ApiKeyAuthenticationService(IOptions<ApiKeyAuthenticationOptions> options)
		{
			_options = options;
		}

		public Task<bool> IsValidApiKey(string apiKey)
		{
			return string.IsNullOrWhiteSpace(_options.Value.ApiKey) 
				? Task.FromResult(true) 
				: Task.FromResult(_options.Value.ApiKey == apiKey);
		}
	}
}
