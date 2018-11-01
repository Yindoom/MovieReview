using System;
using System.Collections.Generic;
using System.Linq;
using MovieReview;
using Xunit;
using MovieReview = MovieReview.MovieReview;

namespace MovieReviewTest
{
    public class Tests
    {
        private global::MovieReview.MovieReview m;

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        public void TestReviewsFromReviewer(int n)
        {   
            var list = new List<Review>();
            m = new global::MovieReview.MovieReview(list);
            list.Clear();
            for (int i = 0; i < n; i++)
            {
                list.Add(new Review()
                {
                    Reviewer = 1,
                    Grade = n,
                    Movie = n,
                    Date = DateTime.Now
                });
            }

            m.reviews = list;

            Assert.True(m.ReviewsFromReviewer(1) == n);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1.5)]
        [InlineData(3, 2)]
        [InlineData(4, 2.5)]
        [InlineData(5, 3)]
        [InlineData(6, 3.5)]
        [InlineData(7, 4)]
        [InlineData(8, 4.5)]
        [InlineData(9, 5)]
        public void TestAverageReviewerRating(int n, double d)
        {
            var list = new List<Review>();
            m = new global::MovieReview.MovieReview(list);
            list.Clear();
            for (int i = 0; i < n; i++)
            {
                list.Add(new Review()
                {
                    Reviewer = 1,
                    Grade = i + 1,
                    Movie = n,
                    Date = DateTime.Now
                });
            }

            m.reviews = list;

            Assert.True(m.AverageReviewerRating(1) == d);
        }

        [Fact]
        public void TestAverageReviewerRating2()
        {
            var list = new List<Review>();
            m = new global::MovieReview.MovieReview(list);
            list.Clear();
            for (int i = 0; i < 4; i++)
            {
                list.Add(new Review()
                {
                    Reviewer = 1,
                    Grade = i + 1,
                    Movie = 1,
                    Date = DateTime.Now
                });
            }

            m.reviews = list;

            Assert.True(m.AverageReviewerRating(1) == 2.5);
        }

        [Fact]
        public void TestTimesReviewerHasGivenRating()
        {
            var list = new List<Review>();
            m = new global::MovieReview.MovieReview(list);
            list.Clear();
            for (int i = 0; i < 4; i++)
            {
                list.Add(new Review()
                {
                    Reviewer = 1,
                    Grade = 1,
                    Movie = 1,
                    Date = DateTime.Now
                });
            }

            m.reviews = list;

            Assert.True(m.TimesReviewerHasGivenRating(1, 1) == 4);
        }

        [Fact]
        public void TestTimesMovieReviewed()
        {
            var list = new List<Review>();
            m = new global::MovieReview.MovieReview(list);
            list.Clear();
            for (int i = 0; i < 4; i++)
            {
                list.Add(new Review()
                {
                    Reviewer = 1,
                    Grade = 1,
                    Movie = 1,
                    Date = DateTime.Now
                });
            }

            m.reviews = list;

            Assert.True(m.TimesMovieReviewed(1) == 4);
            
        }
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1.5)]
        [InlineData(3, 2)]
        [InlineData(4, 2.5)]
        [InlineData(5, 3)]
        [InlineData(6, 3.5)]
        [InlineData(7, 4)]
        [InlineData(8, 4.5)]
        [InlineData(9, 5)]
        public void TestAverageMovieRating(int n, double g)
        {
            var list = new List<Review>();
            m = new global::MovieReview.MovieReview(list);
            list.Clear();
            for (int i = 0; i < n; i++)
            {
                list.Add(new Review()
                {
                    Reviewer = 1,
                    Grade = i+1,
                    Movie = 1,
                    Date = DateTime.Now
                });
            }

            m.reviews = list;

            Assert.True(m.AverageMovieRating(1) == g);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(3, 3, 3)]
        public void TestMovieGivenGrade(int n, int g, int exp)
        {
            var list = new List<Review>();
            m = new global::MovieReview.MovieReview(list);
            list.Clear();
            for (int i = 0; i < n; i++)
            {
                list.Add(new Review()
                {
                    Reviewer = 1,
                    Grade = g,
                    Movie = 1,
                    Date = DateTime.Now
                });
            }

            m.reviews = list;

            Assert.True(m.TimesMovieGivenGrade(1, g) == exp);
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(5, 2)]
        public void TestMoviesGivenHighestGrade(int n, int exp)
        {
            var list = new List<Review>();
            m = new global::MovieReview.MovieReview(list);
            list.Clear();
            for (int i = 0; i < n; i++)
            {
                list.Add(new Review()
                {
                    Reviewer = 1,
                    Grade = 5,
                    Movie = 1,
                    Date = DateTime.Now
                });
            }
            for (int i = 0; i < n; i++)
            {
                list.Add(new Review()
                {
                    Reviewer = 1,
                    Grade = 5,
                    Movie = 2,
                    Date = DateTime.Now
                });
            }

            m.reviews = list;

            Assert.True(m.MoviesGivenHighestRating().Length == exp);
        }

        public void TestMoviesGivenHighestGrade2()
        {
            var list = new List<Review>();
            m = new global::MovieReview.MovieReview(list);
            list.Clear();
            for (int i = 0; i < 5; i++)
            {
                list.Add(new Review()
                {
                    Reviewer = 1,
                    Grade = 5,
                    Movie = 1,
                    Date = DateTime.Now
                });
            }

            for (int i = 0; i < 5; i++)
            {
                list.Add(new Review()
                {
                    Reviewer = 1,
                    Grade = 5,
                    Movie = 2,
                    Date = DateTime.Now
                });

            }

            for (int i = 0; i < 5; i++)
            {
                list.Add(new Review()
                {
                    Reviewer = 1,
                    Grade = 5,
                    Movie = 3,
                    Date = DateTime.Now
                });

                m.reviews = list;

                Assert.True(m.MoviesGivenHighestRating().Length == 3);
            }
        }

        [Fact]
        public void TestMostReviewsReviewer()
        {
            
            var list = new List<Review>();
            m = new global::MovieReview.MovieReview(list);
            list.Clear();
            for (int i = 0; i < 3; i++)
            {
                list.Add(new Review()
                {
                    Reviewer = 1,
                    Grade = 5,
                    Movie = 1,
                    Date = DateTime.Now
                });
            }

            for (int i = 0; i < i-1; i++)
            {
                list.Add(new Review()
                {
                    Reviewer = 2,
                    Grade = 5,
                    Movie = 1,
                    Date = DateTime.Now
                });  
            }

            m.reviews = list;

            Assert.True(m.MostReviewsReviewer() == 1);
        }

        [Fact]
        public void TestMoviesReviewedByReviewer()
        {
            var list = new List<Review>();
            m = new global::MovieReview.MovieReview(list);
            list.Clear();
            for (int i = 0; i < 4; i++)
            {
                list.Add(new Review()
                {
                    Reviewer = 1,
                    Grade = 5,
                    Movie = i+1,
                    Date = DateTime.Now
                });
            }

            m.reviews = list;

            Assert.True(m.MoviesReviewedByReviewer(1).Length == 4);
        }

        [Fact]
        public void TestTopNMovies()
        {
            var list = new List<Review>();
            m = new global::MovieReview.MovieReview(list);
            list.Clear();
            for (int i = 0; i < 4; i++)
            {
                list.Add(new Review()
                {
                    Reviewer = 1,
                    Grade = 5,
                    Movie = i+1,
                    Date = DateTime.Now
                });
            }

            m.reviews = list;
            Assert.True(m.TopNMovies(3).Length == 3);
        }

        [Fact]
        public void TestReviewersReviewedMovieDecreasing()
        {
            var list = new List<Review>();
            m = new global::MovieReview.MovieReview(list);
            list.Clear();
            for (int i = 0; i < 4; i++)
            {
                list.Add(new Review()
                {
                    Reviewer = 1,
                    Grade = 5,
                    Movie = 1,
                    Date = DateTime.Now
                });
            }

            m.reviews = list;
            Assert.True(m.ReviewersReviewedMovieDecreasing(1).Length == 4);
        }
    }
}