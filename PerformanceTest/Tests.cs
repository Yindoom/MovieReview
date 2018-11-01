using System;
using MovieReview;
using Xunit;
using MovieReview = MovieReview.MovieReview;

namespace PerformanceTest
{
    public class Tests
    {
        [Fact]
        public void TestTopNMoviesPerformance()
        {
            var m = new global::MovieReview.MovieReview();
            
            DateTime start = DateTime.Now;
            m.TopNMovies(1);
            DateTime stop = DateTime.Now;
            Double time = (stop - start).TotalSeconds;
            Assert.True(time < 4);
        }

        [Fact]
        public void TestMoviesGivenHighestRatingPerformance()
        {
            var m = new global::MovieReview.MovieReview();
            
            DateTime start = DateTime.Now;
            m.MoviesGivenHighestRating();
            DateTime stop = DateTime.Now;
            Double time = (stop - start).TotalSeconds;
            Assert.True(time < 4);
            Console.Write(time);
        }
    }
}