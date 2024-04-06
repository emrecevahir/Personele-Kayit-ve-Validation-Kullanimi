using System;
using System.Collections.Generic;

namespace Validation.DMO;

public partial class User
{
    public int Id { get; set; }

    public string IdentityNo { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Age { get; set; }
}
