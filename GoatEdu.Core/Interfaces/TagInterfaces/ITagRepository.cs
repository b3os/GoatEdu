using GoatEdu.Core.Interfaces.GenericInterfaces;
using GoatEdu.Core.Models;
using GoatEdu.Core.QueriesFilter;

namespace GoatEdu.Core.Interfaces.TagInterfaces;

public interface ITagRepository : IRepository<Tag>
{
    Task<List<Tag>> GetTagByFilters(TagQueryFilter queryFilter); 

    Task<List<string?>> GetTagNameByNameAsync(List<string?> tagName);
    Task SoftDelete(List<Guid> guids);
}