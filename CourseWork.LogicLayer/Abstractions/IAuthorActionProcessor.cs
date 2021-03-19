﻿using System.Collections.Generic;
using System.Threading.Tasks;
using CourseWork.Shared.Dtos;
using CourseWork.Shared.Models;

namespace CourseWork.LogicLayer.Abstractions
{
    public interface IAuthorActionProcessor
    {
        Task CreateAuthor(AuthorDto authorDto);
        Task UpdateAuthorById(string authorId, AuthorDto authorDto);
        Task<UserModel> GetAuthorById(string authorId);
        Task<IEnumerable<UserModel>> GetAllAuthors();
    }
}