﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.EA
{
    public interface ISpecimenFactory<T> where T : ISpecimen<T>
    {
        T CreateSpecimen();
    }
}