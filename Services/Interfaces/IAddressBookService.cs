using ContactPro.Models;

namespace ContactPro.Services.Interfaces
{
    public interface IAddressBookService
    {
        public Task AddContactToCategoryAsync(int categoryId, int contactId);

        // Add Method: add to a list of CategoryIds
        public Task AddContactToCategoriesAsync(IEnumerable<int> categoryIds, int contactId);

        public Task<bool> IsContactInCategory(int categoryId, int contactId);
        public Task<IEnumerable<Category>> GetAppUserCategoriesAsync(string appUserId);

        // Add method to remove form all Categories
        public Task RemoveAllContactCategoriesAsync(int contactId);

    }
}
