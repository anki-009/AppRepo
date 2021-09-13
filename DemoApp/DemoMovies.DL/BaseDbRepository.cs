using System;

namespace DemoMovies.DL
{
    public class BaseDbRepository
    {
        protected AppDBContext DemoMoviesDBContext { get; set; }

        protected BaseDbRepository(AppDBContext context)
        {
            DemoMoviesDBContext = context;
        }
    }
}
