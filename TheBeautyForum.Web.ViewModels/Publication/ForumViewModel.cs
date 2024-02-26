﻿using TheBeautyForum.Web.ViewModels.Studio;

namespace TheBeautyForum.Web.ViewModels.Publication
{
    public class ForumViewModel
    {
        public Guid PublicationId { get; set; }

        public string? UserFirstName { get; set; }

        public string? UserLastName { get; set; }

        public string? UserProfilePic { get; set; }

        public Guid PostUserId { get; set; }

        public Guid StudioId { get; set; }

        public string? PostUserProfilePic { get; set; }

        public string? UserName { get; set; }

        public string? StudioName { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public int LikeCount { get; set; }

        public int CommentCount { get; set; }

        public DateTime DatePosted { get; set; }

        public CreatePublicationViewModel? Post { get; set; }

        public ICollection<StudioForumViewModel> Studios { get; set; }
            = new List<StudioForumViewModel>();
    }
}