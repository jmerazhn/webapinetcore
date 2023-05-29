using System;
using System.Collections.Generic;

namespace WebApiSapBo.Models;

public partial class Sociedad
{
    public int Id { get; set; }

    public string DataBaseServer { get; set; }

    public string LicenseServer { get; set; }

    public string LicensePort { get; set; }

    public string DataBaseName { get; set; }

    public string UserDb { get; set; }

    public string PasswordDb { get; set; }

    public string UserSap { get; set; }

    public string PasswordSap { get; set; }
}
