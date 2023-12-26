﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebLabsV05.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {

    }
}

namespace WebLabsV05.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public byte[] AvatarImage { get; set; }
    }
}

public class ApplicationUser : IdentityUser
{
    public byte[] AvatarImage { get; set; }
}