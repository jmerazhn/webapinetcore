using System;
using System.Collections.Generic;

namespace WebApiSapBo.Models;

public partial class User
{
    public int Iduser { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public short Rol { get; set; }

    public string Estado { get; set; }

    public string UserSap { get; set; }

    public string PasswSap { get; set; }
}
