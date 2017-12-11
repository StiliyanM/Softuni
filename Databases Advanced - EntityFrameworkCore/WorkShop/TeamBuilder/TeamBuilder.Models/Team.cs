using System.Collections.Generic;

namespace TeamBuilder.Models
{
    public class Team
    {
        public Team()
        {
            this.Invitations = new List<Invitation>();
            this.EventTeams = new List<EventTeam>();
            this.Members = new List<UserTeam>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Acronym { get; set; }

        public int CreatorId { get; set; }
        public User Creator { get; set; }

        public ICollection<EventTeam> EventTeams { get; set; }

        public ICollection<UserTeam> Members { get; set; }

        public ICollection<Invitation> Invitations { get; set; }
    }
}
