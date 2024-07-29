
using System.Globalization;
using TestProject2.Entities;

string format = "dd/MM/yyyy HH:mm:ss";
CultureInfo cultureInfo = CultureInfo.InvariantCulture;

Comment commentOne = new Comment("Have a nice trip!");
Comment commentTwo = new Comment("Wow that's awesome!");

Post postOne = new Post(
    DateTime.ParseExact("21/06/2018 13:05:44", format, cultureInfo),
    "Traveling to New Zealand",
    "I'm going to visit this wonderful country!",
    12);

postOne.AddComment(commentOne);
postOne.AddComment(commentTwo);


Comment commentThree = new Comment("Good Night");
Comment commentFour = new Comment("May the Force be with you");

Post postTwo = new Post(
    DateTime.ParseExact("28/07/2018 23:14:19", format, cultureInfo),
    "Good Night Guys",
    "See you tomorrow",
    5);

postTwo.AddComment(commentThree);
postTwo.AddComment(commentFour);

Console.WriteLine(postOne.ToString());
Console.WriteLine();
Console.WriteLine(postTwo.ToString());