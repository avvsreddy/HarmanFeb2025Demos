using KHPortal.Domain.DTO;

namespace KHPortal.Domain.Managers
{
    public interface ICategoryManager
    {
        void Create(CategoryDTO category);
        List<CategoryDTO> GetAll();
    }
}
