using API.Dtos;
using API.Dtos.InventoryItemsDtos;
using API.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Profiles
{
    public class InventoryItemsProfile : Profile
    {
        public InventoryItemsProfile()
        {
            CreateMap<InventoryItems, InventoryItemsReadDto>();
            CreateMap<InventoryItemsCreateDto, InventoryItems>();
            CreateMap<InventoryItemsUpdateDto, InventoryItems>();
        }
    }
}
