using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using productAPI.Data;
using productAPI.DTOs;
using productAPI.Models;

namespace productAPI.Controllers
{
    // /product
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo _repository;
        private readonly IMapper _mapper;

        public ProductController(IProductRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;            
        }

        // GET /products
        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> GetAllProducts()
        {
            var products = _repository.GetProducts();

            return Ok(_mapper.Map<IEnumerable<ProductDTO>>(products));
        }

        // POST /product/{id}
        [HttpGet("{id}", Name = "GetProductById")]
        public ActionResult<ProductDTO> GetProductById(int id)
        {
            var product = _repository.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ProductDTO>(product));
        }

        // POST /product
        [HttpPost]
        public ActionResult<ProductDTO> CreateProduct(CreateProductRequest request)
        {
            var productModel = _mapper.Map<ProductModel>(request);
            _repository.CreateProduct(productModel);
            _repository.SaveChanges();

            var prodReadDTO = _mapper.Map<ProductDTO>(productModel);

            return CreatedAtRoute(nameof(GetProductById), new { Id = prodReadDTO.Id }, prodReadDTO);
        }

        // PUT /product/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, UpdateProductRequest productDTO)
        {
            var productFromRepo = _repository.GetProductById(id);

            if (productFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(productDTO, productFromRepo);
            _repository.UpdateProduct(productFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        //DELETE /product/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            var product = _repository.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            _repository.DeleteProduct(product);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}