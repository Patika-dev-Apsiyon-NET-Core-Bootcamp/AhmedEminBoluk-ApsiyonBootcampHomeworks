using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModel;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository = null;
        private IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<bool> Add(CategoryViewModel category)
        {
            int id = _categoryRepository.Add(new Category { Name = category.Name, Description = category.Description, Status = category.Status, CreatedAt });
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CategoryViewModel> GetAll()
        {
            return _mapper.Map<List<CategoryViewModel>>(_categoryRepository.GetAll());
        }

        public CategoryViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(CategoryViewModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
