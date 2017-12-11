using AutoMapper;
using Instagraph.Models;

namespace Instagraph.App
{
    using DataProcessor;
    public class InstagraphProfile : Profile
    {
        public InstagraphProfile()
        {
            CreateMap<UserDto, User>()
                .ForMember(dest => dest.ProfilePicture,
                   pp => pp.UseValue<Picture>(null));

            CreateMap<FollowersDto, UserFollower>()
                .ForMember(dest => dest.User,
                u => u.UseValue<User>(null))
                .ForMember(dest => dest.Follower,
                u => u.UseValue<User>(null));

        }
    }
}
