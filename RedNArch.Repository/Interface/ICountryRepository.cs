﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedNArch.Model.Model;
using RedNArch.Repository.Interface;

namespace RedNArch.Repository.Interface
{
    public interface ICountryRepository : IGenericRepository<Country>
    {
        Country GetById(int Id);
    }
}
