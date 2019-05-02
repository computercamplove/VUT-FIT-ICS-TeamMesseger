﻿using System;
using System.Collections.Generic;
using System.Text;
using ICS.Project.BL.Annotations;
using ICS.Project.BL.Models;

namespace ICS.Project.BL.Messages
{
    public class SelectedTeamMessage : IMessage
    {
        [CanBeNull] public TeamModel Team { get; set; }
    }
}
