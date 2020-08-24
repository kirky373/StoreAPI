using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using API.Dtos.InventoryItemsDtos;
using API.Models;
using API.Repositories.InventoryItemsRepo;
using API.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/inventoryitems")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryRepo _repository;
        private readonly IMapper _mapper;



        public InventoryController(IInventoryRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/inventoryitems
        [HttpGet]
        public ActionResult <IEnumerable<InventoryItemsReadDto>> GetAllItems()
        {
            var allItems = _repository.GetAllItems();

            return Ok(_mapper.Map<IEnumerable <InventoryItemsReadDto>>(allItems));
        }

        //GET api/inventoryitems/{id}
        [HttpGet("{id}", Name="GetItemById")]
        public ActionResult <InventoryItemsReadDto> GetItemById(int id)
        {
            var item = _repository.GetItemById(id);

            if(item != null)
            {
                return Ok(_mapper.Map<InventoryItemsReadDto>(item));
            }
            else
            {
                return NotFound();
            }
        }

        //POST api/inventoryitems/add
        [HttpPost]
        public ActionResult<InventoryItemsReadDto> CreateItem( InventoryItemsCreateDto inventoryItemsCreateDto)
        {
            if (ModelState.IsValid)
            {
                var inventoryItemModel = _mapper.Map<InventoryItems>(inventoryItemsCreateDto);
                _repository.CreateItem(inventoryItemModel);
                _repository.SaveChanges();

                var inventoryItemsReadDto = _mapper.Map<InventoryItemsReadDto>(inventoryItemModel);
                //return Ok(inventoryItemsReadDto);
                return CreatedAtRoute(nameof(GetItemById), new { inventoryItemsReadDto.Id }, inventoryItemsReadDto);
            }

            return NotFound();
        }

        //PUT api/inventoryitems/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateItem(int id, InventoryItemsUpdateDto inventoryItemsUpdateDto)
        {
            var itemModelFromRepo = _repository.GetItemById(id);
            if (itemModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(inventoryItemsUpdateDto, itemModelFromRepo);
            //Redudancy call
            _repository.UpdateItem(itemModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //DELETE api/inventoryitems/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteItem(int id)
        {
            var itemModelFromRepo = _repository.GetItemById(id);
            if (itemModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteItem(itemModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}
