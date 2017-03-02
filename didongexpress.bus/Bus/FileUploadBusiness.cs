using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using didongexpress.repos;

namespace didongexpress.bus.Bus
{
    public interface IFileUploadBusiness : IBusiness
    {

    }

    public class FileUploadBusiness : Business, IFileUploadBusiness
    {
        public FileUploadBusiness(IUnitOfWork unit) : base(unit)
        {
        }
    }
}
