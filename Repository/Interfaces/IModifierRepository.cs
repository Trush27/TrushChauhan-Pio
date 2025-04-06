using Entity.Models;
using Entity.ViewModel;
namespace Repository.Interfaces;

public interface IModifierRepository
{
    Task<List<Modifiergroup>> GetModifierGroupsAsync();
    Task<List<Modifier>> GetModifiersByGroupAsync(int modifierGroupId);
    Task<(List<Modifier> Modifiers, int TotalItems)> GetModifiersByGroupPaginatedAsync(int modifierGroupId, int page, int pageSize, string searchTerm);
    Task AddModifierAsync(Modifier modifier, int modifierGroupId);
    Task<int> AddModifierGroupAsync(Modifiergroup modifierGroup);
    Task<List<Modifier>> GetAllModifiersAsync(int page = 1, int pageSize = 10, string search = "");
    Task AddModifiersToGroupAsync(int modifierGroupId, List<int> modifierIds);
    Task DeleteModifierGroupAsync(int id);
    Task RemoveModifierFromGroupAsync(int modifierGroupId, int modifierId);
    Task DeleteModifiersFromGroupAsync(int modifierGroupId, List<int> modifierIds);
    Task<int> GetAllModifiersCountAsync(string search = "");
    Task<Modifiergroup> GetModifierGroupAsync(int id);
    Task UpdateModifierGroupAsync(Modifiergroup group);
    Task<Modifier> GetModifierAsync(int id);
    Task UpdateModifierAsync(ModifierViewModel modifier);
}
