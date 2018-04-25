namespace Forum.App.Commands
{
    using Contracts;
    using System;

    public class SubmitCommand : ICommand
    {
        private ISession session;
        private IPostService postService;

        public SubmitCommand(ISession session, IPostService postService)
        {
            this.session = session;
            this.postService = postService;
        }

        public IMenu Execute(params string[] args)
        {
            string replyContent = args[0];
            int postId = int.Parse(args[1]);
            int authorId = this.session.UserId;

            if (string.IsNullOrWhiteSpace(replyContent))
            {
                throw new ArgumentException("Invalide reply!");
            }

            this.postService.AddReplyToPost(postId, replyContent, authorId);

            return this.session.Back();
        }
    }
}
