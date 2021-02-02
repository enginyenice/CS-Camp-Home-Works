﻿using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : InMemoryBaseDal<Brand>
    {

        public override void Update(Brand entity)
        {
            Brand UpdateToBrand = _entities.SingleOrDefault(p => p.Id == entity.Id);
            UpdateToBrand.Name = entity.Name;
        }
    }
}