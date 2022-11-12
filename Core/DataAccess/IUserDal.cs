using Core.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Core.DataAccess
{
    public interface IUserDal : IEntityRepository<User>
    {
        //List<OperationClaim> GetClaims(User user);
        List<OperationClaim> GetClaims(User user);
    }
}
