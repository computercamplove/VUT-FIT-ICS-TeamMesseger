﻿using System;
using System.Collections.Generic;
using System.Text;
using ICS.Project.BL.Models;

namespace ICS.Project.BL.Messages
{
    public class UserLoggedMessage : IMessage
    {
        public UserModel User { get; set; }
    }
}