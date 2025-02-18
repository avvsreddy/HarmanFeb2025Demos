using KHPortal.Domain.DTO;

namespace KHPortal.Domain.Managers
{
    public interface IArticleManager
    {
        void Submit(ArticleSubmitDTO articleSubmitDto);
        List<ArticleReviewDTO> Review(int categoryId);
        void Approve(List<int> articleIds);
        void Reject(List<int> articleIds);
        List<ArticleBrowseDTO> Browse(int categoryId);
    }
}
