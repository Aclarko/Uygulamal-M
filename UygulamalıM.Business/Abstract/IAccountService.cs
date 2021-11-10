﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UygulamalıM.Dto.Dto;

namespace UygulamalıM.Business.Abstract
{
    public interface IAccountService
    {
        bool CheckUser(AccountDto account);

        bool CreateUser(AccountDto account);
    }
}
