using KHPortal.Domain.Entities;

namespace KHPortal.Domain.Repositories
{
    public interface IArticleRepository
    {
        void Submit(Article article);
        List<Article> Review(int categoryId);
        void Approve(List<int> articleIds);
        void Reject(List<int> articleIds);
        List<Article> Browse(int categoryId);

    }
}
