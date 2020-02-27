using Soccer.Web.Data.Entities;
using Soccer.Web.Interfaces;
using Soccer.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soccer.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        public TeamEntity ToTeamEntity(TeamViewModel model, string path, bool isNew)
        {
            return new TeamEntity
            {
                //Si es = es nuevo, de lo contrario es una actualizacion
                Id = isNew ? 0 : model.Id,
                LogoPath = path,
                Name = model.Name
            };
        }

        public TeamViewModel ToTeamViewModel(TeamEntity teamEntity)
        {
            return new TeamViewModel
            {
                Id = teamEntity.Id,
                LogoPath = teamEntity.LogoPath,
                Name = teamEntity.Name
            };
        }

        public TournamentEntity ToTournamentEntity(TournamentViewModel model, string path, bool isNew)
        {
            return new TournamentEntity
            {
                Id = isNew ? 0 : model.Id, //Si es = es nuevo, de lo contrario es una actualizacion
                EndDate = model.EndDate.ToUniversalTime(),
                Groups = model.Groups,                
                IsActive = model.IsActive,
                LogoPath = path,
                Name = model.Name,
                StartDate = model.StartDate.ToUniversalTime()
            };
        }

        public TournamentViewModel ToTournamentViewModel(TournamentEntity tournamentEntity)
        {
            return new TournamentViewModel
            {
                Id = tournamentEntity.Id,
                EndDate = tournamentEntity.EndDate,
                Groups = tournamentEntity.Groups,
                IsActive = tournamentEntity.IsActive,
                LogoPath = tournamentEntity.LogoPath,
                Name = tournamentEntity.Name,
                StartDate = tournamentEntity.StartDate
            };
        }
    }
}
