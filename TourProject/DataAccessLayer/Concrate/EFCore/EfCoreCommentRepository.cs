using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessLayer.Concrate.EFCore.EfCoreRouteRepository;

namespace DataAccessLayer.Concrate.EFCore
{
    public class EfCoreCommentRepository : EfCoreGenericRepository<Comment, TurContext>, ICommentDal
    {

    }
}
