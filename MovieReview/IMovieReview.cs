namespace MovieReview
{
    public interface IMovieReview
    {
        int ReviewsFromReviewer(int n);
        double AverageReviewerRating(int n);
        int TimesReviewerHasGivenRating(int n, int g);
        int TimesMovieReviewed(int n);
        double AverageMovieRating(int n);
        int TimesMovieGivenGrade(int n, int g);
        int[] MoviesGivenHighestRating();
        int MostReviewsReviewer();
        int[] TopNMovies(int n);
        int[] MoviesReviewedByReviewer(int n);
        int[] ReviewersReviewedMovieDecreasing(int n);
    }
}