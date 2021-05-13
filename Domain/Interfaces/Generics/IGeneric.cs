﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Generics
{
    public interface IGeneric<T> where T : class
    {
        Task Add(T Objecto);

        Task Update(T Objecto);
        Task Delete(T Objecto);

        Task<T> GetTEntityById(int Id);
        Task<List<T>> List();


    }
}
