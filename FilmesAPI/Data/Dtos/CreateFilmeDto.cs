using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O titulo informado é invalido verifique se ele não está vazio")]
    public string? Titulo { get; set; }
    [Required(ErrorMessage = "O Genero informado é invalido verifique se ele não está vazio")]
    public string? Genero { get; set; }
    [Required (ErrorMessage = "A duração do filme é invalida")]
    [Range(70, 300, ErrorMessage = " A duração é invalida lembre-se que tem que ser maior ou igual a 70 minutos")]
    public int Duracao { get; set; }
    
}