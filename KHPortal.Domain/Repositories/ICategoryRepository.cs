using KHPortal.Domain.Entities;

namespace KHPortal.Domain.Repositories
{
    public interface ICategoryRepository
    {
        void Create(Category category);
        List<Category> GetAll();
    }
}
