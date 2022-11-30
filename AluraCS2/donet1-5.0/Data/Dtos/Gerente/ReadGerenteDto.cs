using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FilmesAPI.Models;

namespace FilmesApi.Data.Dtos.Gerente
{
    public class ReadGerenteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Cinema> Cinema { get; set; }
    }
}
