﻿using System;
using System.Collections.Generic;
using Rental.DTOs.ItemDTOs;

namespace MyRental.Services.ItemServices
{
    public interface IItemService
    {
        public IEnumerable<ItemListDTO> GetItemList();
        public ItemListDTO GetItemDetail(int id);
        public ItemListDTO Get(int id);
        public void Post(string value);
    }
}
