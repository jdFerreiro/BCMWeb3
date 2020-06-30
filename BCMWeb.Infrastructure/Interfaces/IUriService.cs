using BCMWeb.Core.QueryFilters;
using System;

namespace BCMWeb.Infrastructure.Interfaces
{
    public interface IUriService
    {
        Uri GetPaginationUri(PaginationFilter filter, string actionUrl);
    }
}
