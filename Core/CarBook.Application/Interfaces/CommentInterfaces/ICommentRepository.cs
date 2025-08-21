using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.CommentInterfaces
{
    public interface ICommentRepository<T> where T : class
    {
        T GetById(int id);
        List<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetCommentsByBlogId(int id);
        int GetCountCommentByBlog(int id);
    }
}
