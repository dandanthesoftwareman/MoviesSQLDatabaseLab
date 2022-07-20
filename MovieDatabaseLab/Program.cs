using MovieDatabaseLab;
using MovieDatabaseLab.Models;
//PopulateMoivesDB();

bool runProgram = true;

while (runProgram)
{
    Console.WriteLine("What would you like to search by? Genre or Title?");
    while (true)
    {
        string response = Console.ReadLine();
        if (response.ToLower() == "genre")
        {
            SearchByGenre();
            break;
        }
        else if (response.ToLower() == "title")
        {
            SearchByTitle();
            break;
        }
        else
        {
            Console.WriteLine("Enter Genre or Title please");
        }
    }
    Console.WriteLine("Continue? y/n");
    string choice = Console.ReadLine();
    if(choice.ToLower() == "n")
    {
        Console.WriteLine("Goodbye!");
        runProgram = false;
    }
    else
    {
        continue;
    }
}






static void SearchByGenre()
{
    Console.WriteLine("Please enter a genre");
    string choice = Console.ReadLine();
    using (MoviesDBContext context = new MoviesDBContext())
    {
        List<Movie> movieList = context.Movies.Where(m => m.Genre.ToLower() == choice.ToLower()).ToList();
        foreach(Movie m in movieList)
        {
            Console.WriteLine($"{m.Title}, {m.Genre}, {m.Runtime} Minutes long");
        }
    }
}

static void SearchByTitle()
{
    Console.WriteLine("Please enter a Title");
    string choice = Console.ReadLine();
    using (MoviesDBContext context = new MoviesDBContext())
    {
        List<Movie> movieList = context.Movies.Where(m => m.Title.ToLower() == choice.ToLower()).ToList();
        foreach (Movie m in movieList)
        {
            Console.WriteLine($"{m.Title}, {m.Genre}, {m.Runtime} Minutes long");
        }
    }
}

//Populate MoiviesDB
static void PopulateMoivesDB()
{
    using(MoviesDBContext context = new MoviesDBContext())
    {
        Movie mov1 = new Movie()
        {
            Title = "Finding Nemo",
            Genre = "Animated",
            Runtime = 140
        };
        Movie mov2 = new Movie()
        {
            Title = "Avatar",
            Genre = "Animated",
            Runtime = 240
        };
        Movie mov3 = new Movie()
        {
            Title = "The Iron Giant",
            Genre = "Animated",
            Runtime = 126
        };
        Movie mov4 = new Movie()
        {
            Title = "The Fast and the Furious",
            Genre = "Action",
            Runtime = 147
        };
        Movie mov5 = new Movie()
        {
            Title = "2 Fast 2 Furious",
            Genre = "Action",
            Runtime = 140
        };
        Movie mov6 = new Movie()
        {
            Title = "Highchool Musical",
            Genre = "Musical",
            Runtime = 138
        };
        Movie mov7 = new Movie()
        {
            Title = "Highchool Musical 2",
            Genre = "Musical",
            Runtime = 151
        };
        Movie mov8 = new Movie()
        {
            Title = "A Quiet Place",
            Genre = "Horror",
            Runtime = 130
        };
        Movie mov9 = new Movie()
        {
            Title = "Friday the 13th",
            Genre = "Horror",
            Runtime = 135
        };
        Movie mov10 = new Movie()
        {
            Title = "She's the Man",
            Genre = "Comedy",
            Runtime = 145
        };
        Movie mov11 = new Movie()
        {
            Title = "Pirates of the Caribbean",
            Genre = "Adventure",
            Runtime = 223
        };
        Movie mov12 = new Movie()
        {
            Title = "Pirates of the Caribbean: Dead Man's Chest",
            Genre = "Adventure",
            Runtime = 231
        };
        context.Add(mov1);
        context.Add(mov2);
        context.Add(mov3);
        context.Add(mov4);
        context.Add(mov5);
        context.Add(mov6);
        context.Add(mov7);
        context.Add(mov8);
        context.Add(mov9);
        context.Add(mov10);
        context.Add(mov11);
        context.Add(mov12);

        //List<Movie> list = new List<Movie>()
        //{
        //    new Movie()
        //    {
        //        Title = "",
        //        Genre = "",
        //        Runtime = 0
        //    },
        //    new Movie()
        //    {
        //        Title = "",
        //        Genre = "",
        //        Runtime = 0
        //    },
        //};

        //context.Movies.AddRange(list);
        context.SaveChanges();
    }
}
