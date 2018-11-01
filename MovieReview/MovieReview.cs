using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace MovieReview
{
    public class MovieReview : IMovieReview
    {
        public IEnumerable<Review> reviews;
        public MovieReview()
        {
            JsonReader reader = new JsonReader();
            reviews = reader.LoadJson();
        }

        public MovieReview(List<Review> list)
        {
            reviews = list;
        }
        public int ReviewsFromReviewer(int n)
        {

            return reviews.Count(r => r.Reviewer == n);
        }

        public double AverageReviewerRating(int n)
        {
            var res = reviews.Where(r => r.Reviewer == n).Average(r => r.Grade);

            return res;
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
            var res = reviews.Where(r => r.Movie == n).Average(r => r.Grade);
            
            return res;
        }

        public int TimesMovieGivenGrade(int n, int g)
        {
            return reviews.Count(r => r.Movie == n && r.Grade == g);
        }

        public int[] MoviesGivenHighestRating()
        {            
            var list = reviews.Where(r => r.Grade == 5).GroupBy(r => r.Movie).OrderBy(
                r => r.Count()).ToArray();

            var amount = 0;
            var before = 0;
            for (int i = 0; i < list.Length; i++)
            {
                
                var now = list[0];
                if (now.Count() < before)
                {
                    amount = i+1;
                    break;
                   
                }
                amount = i+1;
                before = now.Count();
            }

            var all = list.Select(r => r.Key).Take(amount).ToArray();
            
            return all;
        }

        public int MostReviewsReviewer()
        {
            var result = reviews.GroupBy(r => r.Reviewer).
                OrderBy(r => r.Count()).Select(r => r.Key).FirstOrDefault();
            
            return result;
        }

        public int[] TopNMovies(int n)
        {
            var result = reviews.GroupBy(r => r.Movie).
                OrderBy(r => r.Average(g => g.Grade))
                .Select(r => r.Key)
                .Take(n).ToArray();
            return result;
        }

        public int[] MoviesReviewedByReviewer(int n)
        {
            var list = reviews.Where(r => r.Reviewer == n).Select(r => r.Movie).ToArray();

            return list;
        }

        public int[] ReviewersReviewedMovieDecreasing(int n)
        {
            var list = reviews.Where(r => r.Movie == n).OrderByDescending(
                r => r.Grade).ThenBy(r => r.Date).Select(r => r.Reviewer).ToArray();


            return list;
        }
    }
}