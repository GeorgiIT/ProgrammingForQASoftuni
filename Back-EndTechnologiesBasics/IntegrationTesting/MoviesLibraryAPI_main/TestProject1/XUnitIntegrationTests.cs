using MongoDB.Driver;
using MoviesLibraryAPI.Controllers;
using MoviesLibraryAPI.Controllers.Contracts;
using MoviesLibraryAPI.Data.Models;
using MoviesLibraryAPI.Services;
using MoviesLibraryAPI.Services.Contracts;
using System.ComponentModel.DataAnnotations;

namespace MoviesLibraryAPI.XUnitTests
{
    public class XUnitIntegrationTests : IClassFixture<DatabaseFixture>
    {
        private readonly MoviesLibraryXUnitTestDbContext _dbContext;
        private readonly IMoviesLibraryController _controller;
        private readonly IMoviesRepository _repository;

        public XUnitIntegrationTests(DatabaseFixture fixture)
        {
            _dbContext = fixture.DbContext;
            _repository = new MoviesRepository(_dbContext.Movies);
            _controller = new MoviesLibraryController(_repository);

            InitializeDatabaseAsync().GetAwaiter().GetResult();
        }

        private async Task InitializeDatabaseAsync()
        {
            await _dbContext.ClearDatabaseAsync();
        }

        [Fact]
        public async Task AddMovieAsync_WhenValidMovieProvided_ShouldAddToDatabase()
        {
            // Arrange
            var movie = new Movie
            {
                Title = "Test Movie",
                Director = "Test Director",
                YearReleased = 2022,
                Genre = "Action",
                Duration = 120,
                Rating = 7.5
            };

            // Act
            await _controller.AddAsync(movie);

            // Assert
            var resultMovie = await _dbContext.Movies.Find(m => m.Title == "Test Movie").FirstOrDefaultAsync();
            Assert.NotNull(resultMovie);
            Assert.Equal("Test Movie", resultMovie.Title);
            Assert.Equal("Test Director", resultMovie.Director);
            Assert.Equal(2022, resultMovie.YearReleased);
            Assert.Equal("Action", resultMovie.Genre);
            Assert.Equal(120, resultMovie.Duration);
            Assert.Equal(7.5, resultMovie.Rating);
        }

        [Fact]
        public async Task AddMovieAsync_WhenInvalidMovieProvided_ShouldThrowValidationException()
        {
            // Arrange
            var invalidMovie = new Movie
            {
                Director = "Test Director",
                YearReleased = 2022,
                Genre = "Action",
                Duration = 120,
                Rating = 7.5
                // Provide an invalid movie object, e.g., without a title or other required fields
            };

            // Act and Assert
            Assert.ThrowsAsync<ValidationException>(() => _controller.AddAsync(invalidMovie));
        }

        [Fact]
        public async Task DeleteAsync_WhenValidTitleProvided_ShouldDeleteMovie()
        {
            // Arrange
            var movie = new Movie
            {
                Title = "Test Movie",
                Director = "Test Director",
                YearReleased = 2020,
                Genre = "Action",
                Duration = 120,
                Rating = 7.5
            };
            var movie2 = new Movie
            {
                Title = "Test Movie2",
                Director = "Test Director2",
                YearReleased = 2020,
                Genre = "Action",
                Duration = 120,
                Rating = 5
            };
            // Act
            await _controller.AddAsync(movie);
            await _controller.AddAsync(movie2);
            // Assert
            // The movie should no longer exist in the database
            _controller.DeleteAsync(movie.Title);
            var deletedMovie = await _dbContext.Movies.Find(m => m.Title == movie.Title).FirstOrDefaultAsync();

            var result = await _controller.GetAllAsync();

            Assert.Single(result);
            Assert.DoesNotContain(deletedMovie, result);


        }


        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public async Task DeleteAsync_WhenTitleIsNull_ShouldThrowArgumentException(string title)
        {
            // Act and Assert
            Assert.ThrowsAsync<ArgumentException>(() => _controller.DeleteAsync(title));
        }

        //[Fact]
        //public async Task DeleteAsync_WhenTitleIsEmpty_ShouldThrowArgumentException()
        //{
        //    // Act and Assert            
        //}

        [Fact]
        public async Task DeleteAsync_WhenTitleDoesNotExist_ShouldThrowInvalidOperationException()
        {

            // Act and Assert
            Assert.ThrowsAsync<InvalidOperationException>(() => _controller.DeleteAsync("Dune"));
        }

        [Fact]
        public async Task GetAllAsync_WhenNoMoviesExist_ShouldReturnEmptyList()
        {
            // Act
            var result = await _controller.GetAllAsync();

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public async Task GetAllAsync_WhenMoviesExist_ShouldReturnAllMovies()
        {
            // Arrange
            var movie = new Movie
            {
                Title = "Test Movie",
                Director = "Test Director",
                YearReleased = 2020,
                Genre = "Action",
                Duration = 120,
                Rating = 7.5
            };
            var movie2 = new Movie
            {
                Title = "Test Movie2",
                Director = "Test Director2",
                YearReleased = 2020,
                Genre = "Action",
                Duration = 120,
                Rating = 5
            };
            // Act
            await _controller.AddAsync(movie);
            await _controller.AddAsync(movie2);
            var result = await _controller.GetAllAsync();

            // Assert
            Assert.Equal(2, result.Count());

        }

        [Fact]
        public async Task GetByTitle_WhenTitleExists_ShouldReturnMatchingMovie()
        {
            // Arrange
            var movie = new Movie
            {
                Title = "Test Movie",
                Director = "Test Director",
                YearReleased = 2020,
                Genre = "Action",
                Duration = 120,
                Rating = 7.5
            };
            var movie2 = new Movie
            {
                Title = "Test Movie2",
                Director = "Test Director2",
                YearReleased = 2020,
                Genre = "Action",
                Duration = 120,
                Rating = 5
            };
            // Act
            await _controller.AddAsync(movie);
            await _controller.AddAsync(movie2);

            var result = await _controller.SearchByTitleFragmentAsync("2");


            // Assert
            Assert.Equal(result.First().Title, movie2.Title);
        }

        [Fact]
        public async Task GetByTitle_WhenTitleDoesNotExist_ShouldReturnNull()
        {
            // Arrange
            var movie = new Movie
            {
                Title = "Test Movie",
                Director = "Test Director",
                YearReleased = 2020,
                Genre = "Action",
                Duration = 120,
                Rating = 7.5
            };
            var movie2 = new Movie
            {
                Title = "Test Movie2",
                Director = "Test Director2",
                YearReleased = 2020,
                Genre = "Action",
                Duration = 120,
                Rating = 5
            };
            // Act
            await _controller.AddAsync(movie);
            await _controller.AddAsync(movie2);

            var result = await _controller.GetByTitle("Dune");


            // Assert
            Assert.Null(result);
        }


        [Fact]
        public async Task SearchByTitleFragmentAsync_WhenTitleFragmentExists_ShouldReturnMatchingMovies()
        {
            // Arrange
            var movie = new Movie
            {
                Title = "Test Movie",
                Director = "Test Director",
                YearReleased = 2020,
                Genre = "Action",
                Duration = 120,
                Rating = 7.5
            };
            var movie2 = new Movie
            {
                Title = "Test Movie2",
                Director = "Test Director2",
                YearReleased = 2020,
                Genre = "Action",
                Duration = 120,
                Rating = 5
            };
            // Act
            await _controller.AddAsync(movie);
            await _controller.AddAsync(movie2);
            var result = await _controller.SearchByTitleFragmentAsync("Test Movie2");

            Assert.Equal(result.First().Title, movie2.Title);
        }

        [Fact]
        public async Task SearchByTitleFragmentAsync_WhenNoMatchingTitleFragment_ShouldThrowKeyNotFoundException()
        {

            // Act and Assert\
            Assert.ThrowsAsync<KeyNotFoundException>(() => _controller.SearchByTitleFragmentAsync("Dune"));
        }

        [Fact]
        public async Task UpdateAsync_WhenValidMovieProvided_ShouldUpdateMovie()
        {
            // Arrange
            var movie = new Movie
            {
                Title = "Test Movie",
                Director = "Test Director",
                YearReleased = 2020,
                Genre = "Action",
                Duration = 120,
                Rating = 7.5
            };

            // Act
            await _controller.AddAsync(movie);

            movie.Title = "BEST MOVIE";
            await _controller.UpdateAsync(movie);

            // Assert
            Assert.Equal(movie.Title, "BEST MOVIE");
        }

        [Fact]
        public async Task UpdateAsync_WhenInvalidMovieProvided_ShouldThrowValidationException()
        {
            // Arrange
            var movie = new Movie
            {
                Title = "Test Movie",
                Director = "Test Director",
                YearReleased = 2020,
                Genre = "Action",
                Duration = 120,
                Rating = 7.5
            };

            // Act
            await _controller.AddAsync(movie);

            movie.Title = null;

            // Act and Assert
            Assert.ThrowsAsync<ValidationException>(() => _controller.UpdateAsync(movie));
        }
    }
}
