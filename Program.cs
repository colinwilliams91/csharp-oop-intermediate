using System;
using csharp_oop_intermediate.Engine;
using csharp_oop_intermediate.Engine.Services;

//Console.WriteLine();
//Console.WriteLine($"Stopwatch Assignment Begin Here:");

//Console.WriteLine(Stopwatch.Start());

//Console.WriteLine(Stopwatch.Stop());

//Console.WriteLine(Stopwatch.Start());

//Console.WriteLine(Stopwatch.Stop());

//Stopwatch.Start();

//Console.WriteLine();
//Console.WriteLine($"Press Enter to stop the Stopwatch");
//Console.ReadLine();

//Stopwatch.Stop();

//Console.WriteLine("---");
//Console.WriteLine($"Social Post Assignment Begin Here:");

//Post one = new Post("My name is Colin", "I am an application developer for the Louisiana Department of Health CDC SHHP.");

//Console.WriteLine(one.Title);
//Console.WriteLine(one.Description);
//Console.WriteLine(one.CreatedAt);

//one.Upvote();
//Console.WriteLine(one.Votes);
//one.Upvote();
//Console.WriteLine(one.Votes);
//one.Downvote();
//Console.WriteLine(one.Votes);
//one.Upvote();
//Console.WriteLine(one.Votes);
//one.Upvote();

//Console.WriteLine(one.Votes);

Console.WriteLine();
Console.WriteLine("Please press enter to continue...");
Console.ReadLine();

Console.WriteLine("Workflow Engine Challenge Begin:");
Console.WriteLine();

var videoEncodingActivities = new List<IActivity> { new Upload(), new Request(), new Emailer(), new Update() };
var videoEncodingWorkflow = new Workflow(videoEncodingActivities);

WorkflowEngine.Run(videoEncodingWorkflow);
