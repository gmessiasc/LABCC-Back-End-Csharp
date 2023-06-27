﻿namespace LABCC.BackEnd.Domain.Entities.EntidadesBase.Interfaces;
public interface IBaseRepository<TEntity, TParams> 
                                          where TEntity : AggregateRoot
                                          where TParams : IParams
{
  IQueryable<TEntity> Select(TParams param);
  Task Insert(TEntity obj);
  Task Update(long id, TParams obj);
  Task Delete(long id);
}
