﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }
    [Required(ErrorMessage = "A duração do filme é obrigatório")]
    [Range(70, 600, ErrorMessage = "A duração não pode ser menor que 70, nem maior que 600")]
    public int Duracao { get; set; }
}
