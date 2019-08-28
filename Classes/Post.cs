using System;

namespace Classes
{
    internal class Post
    {
        private readonly DateTime _created;
        private int _voteCount;
        private string Title { get; }
        private string Description { get; }

        public void VoteUp()
        {
            _voteCount++;
        }
        public void VoteDown()
        {
            if (_voteCount > 0)
                _voteCount--;
            else
                throw (new InvalidOperationException("Cannot move vote count below 0"));
        }
        public void Display()
        {
            Console.WriteLine($"_title:          {Title}\n" +
                              $"Description:    {Description}\n" +
                              $"Time Created:   {_created}\n" +
                              $"Vote Count:     {_voteCount}");
        }

        public Post()
        {
            _created = DateTime.Now;
            _voteCount = 0;
        }

        public Post(string title, string description) : this()
        {
            Title = title;
            Description = description;
        }
    }
}
