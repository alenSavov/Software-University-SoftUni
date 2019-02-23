using PhotoShare.Client.Core.Contracts;
using PhotoShare.Client.Utilities;
using PhotoShare.Services.Contracts;
using System;

namespace PhotoShare.Client.Core.Commands
{
    public class AddTagCommand : ICommand
    {
        private readonly ITagService tagService;

        public AddTagCommand(ITagService tagService)
        {
            this.tagService = tagService;
        }

        public string Execute(string[] args)
        {
            var tagName = args[0];

            var tagEexists = this.tagService.Exists(tagName);

            if (tagEexists)
            {
                throw new ArgumentException($"Tag {tagName} exists!");
            }

           tagName = tagName.ValidateOrTransform();

            var tag = this.tagService.AddTag(tagName);

            return $"Tag {tagName} was added successfully!";
        }
    }
}
