﻿using System;
using System.Collections.Generic;

namespace cineSistem.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
}
