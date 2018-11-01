namespace MovieReview
{
    public interface IMovieReview
    {
        //returns the amount of reviews a reviewer (n) has made
        int ReviewsFromReviewer(int n);
        
        //returns the average rating a reviewer (n) has given
        double AverageReviewerRating(int n);
        
        //returns the number of times reviewer (n) has given the grade (g)
        int TimesReviewerHasGivenRating(int n, int g);
        
        //returns the number of reviews a movie (n) has received
        int TimesMovieReviewed(int n);
        
        //returns the average rating for movie (n)
        double AverageMovieRating(int n);
        
        //returns the number of times a movie (n) has received a given rating (g)
        int TimesMovieGivenGrade(int n, int g);
        
        //returns an array of the movie(s) with the most amount of 5 star ratings
        int[] MoviesGivenHighestRating();
        
        //returns the id of the reviewer with the most reviews 
        int MostReviewsReviewer();
        
        //returns an array with the top N movies, based on average rating
        int[] TopNMovies(int n);
        
        //returns an array of movies reviewed by reviewer (n),
        //sorted decreasing by rate, and then date
        int[] MoviesReviewedByReviewer(int n);
        
        //returns an array of reviewers that have reviewed a movie (n),
        //also sorted by decreasing rate and then date
        int[] ReviewersReviewedMovieDecreasing(int n);
    }
}