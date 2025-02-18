using KHPortal.Domain.DTO;

namespace KHPortal.Domain.Managers
{
    public class ArticleManager : IArticleManager
    {
        public void Approve(List<int> articleIds)
        {
            throw new NotImplementedException();
        }

        public List<ArticleBrowseDTO> Browse(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Reject(List<int> articleIds)
        {
            throw new NotImplementedException();
        }

        public List<ArticleReviewDTO> Review(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Submit(ArticleSubmitDTO articleSubmitDto)
        {
            throw new NotImplementedException();
        }
    }
}
