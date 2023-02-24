using Microsoft.AspNetCore.Mvc.Filters;

namespace CustomAuthAPI.Authentication;

public class ApiKeyAuthFilter : IAsyncAuthorizationFilter
{
	private readonly IConfiguration _configuration;

	public ApiKeyAuthFilter(IConfiguration configuration)
	{
		_configuration = configuration;
	}

	public Task OnAuthorizationAsync(AuthorizationFilterContext context)
	{
		throw new NotImplementedException();
	}
}