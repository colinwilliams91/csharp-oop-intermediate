using System;

Console.WriteLine($"Stopwatch Assignment Begin Here:");

//Console.WriteLine(Stopwatch.Start());

//Console.WriteLine(Stopwatch.Stop());

//Console.WriteLine(Stopwatch.Start());

//Console.WriteLine(Stopwatch.Stop());

Stopwatch.Start();

Thread.Sleep(1000);

Stopwatch.Stop();

Console.WriteLine("---");
Console.WriteLine($"Social Post Assignment Begin Here:");

Post one = new Post("My name is Colin", "I am an application developer for the Louisiana Department of Health CDC SHHP.");

Console.WriteLine(one.Title);
Console.WriteLine(one.Description);
Console.WriteLine(one.CreatedAt);

one.Upvote();
Console.WriteLine(one.Votes);
one.Upvote();
Console.WriteLine(one.Votes);
one.Downvote();
Console.WriteLine(one.Votes);
one.Upvote();
Console.WriteLine(one.Votes);
one.Upvote();

Console.WriteLine(one.Votes);
