using System;
using System.Collections.Generic;

namespace MovieReview
{
    public class MovieReview : IMovieReview
    {
        public List<Review> reviews = new List<Review>();
        public int ReviewsFromReviewer(int n)
        {
            int numberCount = 0;
            foreach (var review in reviews)
            {
                if (review.Reviewer == n)
                {
                    numberCount++;
                }
            }

            return numberCount;
        }

        public double AverageReviewerRating(int n)
        {
            double sum = 0;
            double count = 0;
            foreach (var rev in reviews)
            {
                if (rev.Reviewer == n)
                {
                    sum += rev.Grade;
                    count++;
                }
            }

            double avg = sum / count;
            return avg;
        }

        public int TimesReviewerHasGivenRating(int n, int g)
        {
            throw new System.NotImplementedException();
        }

        public int TimesMovieReviewed(int n)
        {
            throw new System.NotImplementedException();
        }

        public double AverageMovieRating(int n)
        {
            throw new System.NotImplementedException();
        }

        public int TimesMovieGivenGrade(int n)
        {
            throw new System.NotImplementedException();
        }

        public int[] MoviesGivenHighestRating()
        {
            throw new System.NotImplementedException();
        }

        public int[] MostReviewsReviewer()
        {
            throw new System.NotImplementedException();
        }

        public int[] TopNMovies(int n)
        {
            throw new System.NotImplementedException();
        }

        public int[] MoviesReviewedByReviewer(int n)
        {
            throw new System.NotImplementedException();
        }

        public int[] ReviewersReviewedMovieDecreasing(int n)
        {
            throw new System.NotImplementedException();
        }
    }
}