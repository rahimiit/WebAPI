using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace SampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleDataController : ControllerBase
    {
          
        public class Item
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }

    
        private static readonly List<Item> _items = new List<Item>
        {
            new Item { Id = 1, Name = "Item 1", Description = "Description 1" },
            new Item { Id = 2, Name = "Item 2", Description = "Description 2" },
            new Item { Id = 3, Name = "Item 3", Description = "Description 3" }
        };
         
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return _items;
        }
    }
}
