using Entity.Models;
using Entity.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IMenuRepository
    {
        Task<List<Menucategory>> GetCategoriesAsync();
        Task<List<Menuitem>> GetItemsByCategoryAsync(int categoryId);
        Task<(List<Menuitem> Items, int TotalItems)> GetItemsByCategoryPaginatedAsync(int categoryId, int page, int pageSize, string searchTerm);
        Task AddCategoryAsync(Menucategory category);
        Task<int> AddItemAsync(MenuItemViewModel item);
        Task<Menuitem> GetItemAsync(int id);
        Task<List<Itemandmodifiergroup>> GetItemModifierGroupsAsync(int itemId);
        Task UpdateItemAsync(MenuItemViewModel model);
        Task UpdateItemModifierGroupsAsync(int itemId, List<ModifierGroupSelection> modifierGroups);
        Task DeleteItemAsync(int id);
        Task DeleteCategoryAsync(int id);
        Task DeleteItemsAsync(List<int> itemIds);
        Task<Menucategory> GetCategoryAsync(int id);
        Task UpdateCategoryAsync(Menucategory category);
        Task AddModifierGroupsToItemAsync(int itemId, List<ModifierGroupSelection> modifierGroups);
    }

}