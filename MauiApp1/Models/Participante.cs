using System;
using System.Collections.Generic;

namespace MauiApp1.Models;

public partial class Participante
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public int? Idade { get; set; }

    public int? CidadeId { get; set; }

    public string? Genero { get; set; }

}
