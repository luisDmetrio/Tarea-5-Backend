using System;
using System.Collections.Generic;

#nullable disable

namespace loginBackend5.DataAcces
{
    public partial class UsuarioLog
    {
        public int Iduser { get; set; }
        public string NombreUser { get; set; }
        public string EmailUser { get; set; }
        public string PasswordUser { get; set; }
    }
}
