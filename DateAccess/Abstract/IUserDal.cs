﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DateAccess.Abstract
{
   public interface IUserDal :IEntityRepository<User>
    {
    }
}