using BCMWeb.Core.QueryFilters;
using BCMWeb.Infrastructure.Interfaces;
using System;

namespace BCMWeb.Infrastructure.Services
{
    public class UriService : IUriService
    {
        private readonly string _baseUri;
        public UriService(string baseUri)
        {
            _baseUri = baseUri;
        }

        public Uri GetPaginationUri(PaginationFilter filter, string actionUrl)
        {
            string _baseUrl = $"{_baseUri}{actionUrl}";
            return new Uri(_baseUrl);
        }
    }
}
