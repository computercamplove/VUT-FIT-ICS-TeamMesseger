﻿using System;
using System.Collections.Generic;
using System.Text;
using ICS.Project.BL.Models;

namespace ICS.Project.BL.Messages
{
    public class UserWantsToSearchText : IMessage
    {
        public string SearchedText { get; set; }
    }
}
