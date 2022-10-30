using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskOne.DTOs;
using TaskOne.Model;
using TaskOne.Repositories;

namespace TaskOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        readonly ITaskRepository _repo;
        readonly IMapper _mapper;
        public TaskController(ITaskRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> Create(TaskRequestDto request)
        {
            var map = _mapper.Map<Tasks>(request);
            var result=await _repo.Create(map);
            if(result)
                return Ok();
            return BadRequest(result);
        }

        [HttpGet("Id")]
        public async Task<ActionResult> GetATask(int Id)
        {
            var task = await _repo.GetByIdAsync(Id);
            var result = _mapper.Map<TaskResponseDto>(task);
           return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult> GetAllTask()
        {
            var task = await _repo.GetAllAsync();
            var result = _mapper.Map<List<TaskResponseDto>>(task);
            return Ok(result);
        }
    }
}
