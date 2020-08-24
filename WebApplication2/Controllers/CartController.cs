using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos.CartDtos;
using API.Repositories.CartRepo;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/cart")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartRepo _repository;
        private readonly IMapper _mapper;

        public CartController(ICartRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/cart
        [HttpGet]
        public ActionResult<IEnumerable<CartReadDto>> GetAllItems()
        {
            var allItems = _repository.GetAllItems();

            return Ok(_mapper.Map<IEnumerable<CartReadDto>>(allItems));
        }
    }
}
