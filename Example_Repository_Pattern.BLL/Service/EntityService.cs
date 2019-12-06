using Example_Repository_Pattern.BLL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Repository_Pattern.BLL.Service
{
    public class EntityService
    {
        public EntityService()
        {
            _categoryService = new CategoryRepostitory();
            _appUserService = new AppUserRepository();
            _articleRepository = new ArticleRepository();
            _commentRepository = new CommentRepository();
            _likeRepostitory = new LikeRepostitory();
        }

        private CategoryRepostitory _categoryService;
        public CategoryRepostitory CategoryService
        {
            get { return _categoryService; }
            set { _categoryService = value; }
        }

        private ArticleRepository _articleRepository;
        
        public ArticleRepository ArticleService
        {
            get { return _articleRepository; }
            set { _articleRepository = value; }
        }
        private AppUserRepository _appUserService;
        public AppUserRepository AppUserService
        {
            get { return _appUserService; }
            set { _appUserService = value; }
        }
        private CommentRepository _commentRepository;
        public CommentRepository CommentService
        {
            get { return _commentRepository; }
            set { _commentRepository = value; }
        }

        private LikeRepostitory _likeRepostitory;
        public LikeRepostitory LikeService
        {
            get { return _likeRepostitory; }
            set { _likeRepostitory = value; }
        }
    }
}
