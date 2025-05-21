﻿using WebsiteBanHang.Models;

namespace WebsiteBanHang.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        private List<Category> _categoryList;
        public MockCategoryRepository()
        {
            _categoryList = new List<Category>
        {
         new Category { Id = 1, Name = "Kamenrider" },
         new Category { Id = 2, Name = "Sieu Nhan" },
         // Thêm các category khác

           };
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryList;
        }
    }
}
