using System;
using System.Collections.Generic;

namespace cineSistem.Models;

public partial class Pelicula
{
    public int IdPelicula { get; set; }

    public string? Nomb { get; set; }

    public string? Desc { get; set; }

    public string? Direc { get; set; }

    public string? Genero { get; set; }

    public string? Imagen { get; set; }

    public virtual ICollection<RankingPelicula> RankingPeliculas { get; set; } = new List<RankingPelicula>();
}
