﻿using System;

Console.WriteLine($"Stopwatch Assignment Begin Here:");

//Console.WriteLine(Stopwatch.Start());

//Console.WriteLine(Stopwatch.Stop());

//Console.WriteLine(Stopwatch.Start());

//Console.WriteLine(Stopwatch.Stop());

Stopwatch.Start();

Stopwatch.Stop();

Console.WriteLine("---");

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
