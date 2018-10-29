using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MovieReview
{
    public class MovieReview : IMovieReview
    {
        public IEnumerable<Review> reviews = new List<Review>();
        public int ReviewsFromReviewer(int n)
        {
            
            return reviews.Count(r => r.Reviewer == n);
        }

        public double AverageReviewerRating(int n)
        {
            double sum = 0;
            var list = reviews.Where(r => r.Reviewer == n).ToList();
            double count = list.Count;
            foreach (var rev in list)
            {
                sum += rev.Grade;
            }

            double avg = sum / count;
            return avg;
        }

        public int TimesReviewerHasGivenRating(int n, int g)
        {
            return reviews.Count(r => r.Reviewer == n && r.Grade == g);
        }

        public int TimesMovieReviewed(int n)
        {
            return reviews.Count(r => r.Movie == n);
        }

        public double AverageMovieRating(int n)
        {
            var list = reviews.Where(r => r.Movie == n).ToList();
            double count = list.Count;
            double rate = 0;
            foreach (var rev in list)
            {
                rate += rev.Grade;
            }

            return rate / count;
        }

        public int TimesMovieGivenGrade(int n, int g)
        {
            return reviews.Count(r => r.Movie == n && r.Grade == g);
        }

        public int[] MoviesGivenHighestRating()
        {
            var list = reviews.OrderByDescending(r => r.Grade).Where( r => r.Grade == 5).ToList();
            int[] arr = new int[list.Count];
            int i = 0;
            foreach (var rev in list)
            {
                arr[i] = rev.Movie;
                i++;
            }

            return arr;
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