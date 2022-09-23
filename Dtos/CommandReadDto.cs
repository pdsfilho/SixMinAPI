using System.ComponentModel.DataAnnotations;

namespace SixMinAPI.Dtos
{
    public class CommandReadDto
    {
        public int Id {get;set;}
        public string? HotTo{get;set;}
        public string? Platform { get; set; }
        public string? CommandLine { get; set; }
    }
}