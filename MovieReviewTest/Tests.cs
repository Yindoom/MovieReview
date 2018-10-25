using System;
using MovieReview;
using Xunit;

namespace MovieReviewTest
{
    public class Tests
    {
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
            MovieReview.MovieReview m = new MovieReview.MovieReview();
            for (int i = 0; i < n; i++)
            {
                m.reviews.Add(new Review()
                {
                    Reviewer = 1,
                    Grade = n,
                    Movie = n,
                    Date = DateTime.Now
                });
            }

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
            MovieReview.MovieReview m = new MovieReview.MovieReview();
            for (int i = 0; i < n; i++)
            {
                m.reviews.Add(new Review()
                {
                    Reviewer = 1,
                    Grade = i + 1,
                    Movie = n,
                    Date = DateTime.Now
                });
            }

            Assert.True(m.AverageReviewerRating(1) == d);
        }

        [Fact]
        public void TestAverageReviewerRating2()
        {
            MovieReview.MovieReview m = new MovieReview.MovieReview();
            for (int i = 0; i < 4; i++)
            {
                m.reviews.Add(new Review()
                {
                    Reviewer = 1,
                    Grade = i + 1,
                    Movie = 1,
                    Date = DateTime.Now
                });
            }

            Assert.True(m.AverageReviewerRating(1) == 2.5);
        }
    }
}