﻿using Crud.Infraestructure.Domain.Entities;

namespace Crud.Application.Interfaces;

/// <summary>
/// IServiceUsers
/// </summary>
/// <remarks>This class cannot be inherited.</remarks>
public interface IServiceUsers
{
    /// <summary>
    /// Create.
    /// </summary>
    /// <param name="obj"></param>
    /// <paramref name=""/>
    /// <returns></returns>
    /// <remarks></remarks>
    /// <exception cref=""></exception>
    /// <seealso href=""></seealso>
    /// <returns></returns>
    Task Create(Users obj);

    /// <summary>
    /// Read.
    /// </summary>
    /// <param name=""></param>
    /// <paramref name=""/>
    /// <returns></returns>
    /// <remarks></remarks>
    /// <exception cref=""></exception>
    /// <seealso href=""></seealso>
    /// <returns></returns>
    Task<IEnumerable<Users>> Read();

    /// <summary>
    /// Update.
    /// </summary>
    /// <param name="obj"></param>
    /// <paramref name=""/>
    /// <returns></returns>
    /// <remarks></remarks>
    /// <exception cref=""></exception>
    /// <seealso href=""></seealso>
    /// <returns></returns>
    Task Update(Users obj);

    /// <summary>
    /// Delete.
    /// </summary>
    /// <param name="id"></param>
    /// <paramref name=""/>
    /// <returns></returns>
    /// <remarks></remarks>
    /// <exception cref=""></exception>
    /// <seealso href=""></seealso>
    /// <returns></returns>
    Task Delete(int id);
}