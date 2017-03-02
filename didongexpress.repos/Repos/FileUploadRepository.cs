using didongexpress.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace didongexpress.repos.Repos
{
    public interface IFileUploadRepository : IRepository<FileUpload, int>
    {

    }

    public class FileUploadRepository : GenericRepository<FileUpload, int>, IFileUploadRepository
    {
        public FileUploadRepository(ExpressDb db) : base(db)
        {
        }
    }
}
