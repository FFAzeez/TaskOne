using AutoMapper;
using TaskOne.Model;

namespace TaskOne.DTOs.Map
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<Tasks, TaskRequestDto>().ReverseMap();
            CreateMap<Tasks, TaskResponseDto>().ReverseMap();
        }
    }
}
