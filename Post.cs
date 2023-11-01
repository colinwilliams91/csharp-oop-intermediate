using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Post
{
    private int _votes;
    private DateTime _createdAt;

    public DateTime CreatedAt { get { return _createdAt.Date; } }
    public int Votes { get { return _votes; } private set { _votes = value; } }
    public string Title { get; }
    public string Description { get; }

    public Post(string title, string description)
    {
        _createdAt = DateTime.Now;
        _votes = 0;

        Title = title;
        Description = description;
    }

    public void Upvote()
    {
        _votes++;
    }

    public void Downvote()
    {
        if (Votes > 0)
        {
            _votes--;
        }
    }
}
