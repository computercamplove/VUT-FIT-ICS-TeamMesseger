﻿using System;
using System.Collections.Generic;
using ICS.Project.BL.Models;

namespace ICS.Project.BL.Repositories
{
    public interface IUsersRepository
    {
        IEnumerable<TeamModel> GetUserTeams(Guid userId);
        UserModel GetByEmail(string email);
        IEnumerable<UserModel> GetTeamMembers(Guid teamId);
        IList<UserModel> GetAll();
        UserModel GetById(Guid id);
        void Update(UserModel post);
        UserModel Add(UserModel post);
        void Remove(Guid id);
    }
}