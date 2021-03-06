﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using ICS.Project.DAL.Entities.Base;

namespace ICS.Project.DAL.Entities
{
    public class UserInTeamEntity : EntityBase
    {
        [ForeignKey("UserEntity")] public Guid? UserId { get; set; }

        public UserEntity User { get; set; }

        [ForeignKey("TeamEntity")] public Guid? TeamId { get; set; }

        public TeamEntity Team { get; set; }
    }
}