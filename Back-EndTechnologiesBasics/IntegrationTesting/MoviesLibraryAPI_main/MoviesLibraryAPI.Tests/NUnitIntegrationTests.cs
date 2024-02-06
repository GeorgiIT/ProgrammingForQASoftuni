using DnsClient;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MoviesLibraryAPI.Controllers;
using MoviesLibraryAPI.Controllers.Contracts;
using MoviesLibraryAPI.Data.Models;
using MoviesLibraryAPI.Services;
using MoviesLibraryAPI.Services.Contracts;
using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesLibraryAPI.Tests
{
    [TestFixture]
    public class NUnitIntegrationTests
    {
        private MoviesLibraryNUnitTestDbContext _dbContext;
        private IMoviesLibraryController _controller;
        private IMoviesRepository _repository;
        IConfiguration _configuration;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
        }

        [SetUp]
        public async Task Setup()
        {
            string dbName = $"MoviesLibraryTestDb_{Guid.NewGuid()}";
            _dbContext = new MoviesLibraryNUnitTestDbContext(_configuration, dbName);

            _repository = new MoviesRepository(_dbContext.Movies);
            _controller = new MoviesLibraryController(_repository);
        }

        [TearDown]
        public async Task TearDown()
        {
            await _dbContext.ClearDatabaseAsync();
        }

        [Test]
        public async Task AddMovieAsync_WhenValidMovieProvided_ShouldAddToDatabase()
        {
            // Arrange
            var movie = new Movie
            {
                Title = "Test Movie",
                Director = "Test Director",
                YearReleased = 2022,
                Genre = "Action",
                Duration = 86,
                Rating = 7.5
            };

            // Act
            await _controller.AddAsync(movie);

            // Assert
            var resultMovie = await _dbContext.Movies.Find(m => m.Title == "Test Movie").FirstOrDefaultAsync();
            Assert.IsNotNull(resultMovie);
        }

        [Test]
        public async Task AddMovieAsync_WhenInvalidMovieProvided_ShouldThrowValidationException()
        {
            // Arrange
            var invalidMovie = new Movie
            {
                Director = "Test Director",
                YearReleased = 2022,
                Genre = "Action",
                Duration = 86,
                Rating = 7.5
            };

            // Act and Assert
            // Expect a ValidationException because the movie is missing a required field
            var exception = Assert.ThrowsAsync<ValidationException>(() => _controller.AddAsync(invalidMovie));
        }

        [Test]
        public async Task DeleteAsync_WhenValidTitleProvided_ShouldDeleteMovie()
        {
            // Arrange
            var movie = new Movie
            {
                Title = "Test Movie",
                Director = "Test Director",
                YearReleased = 2022,
                Genre = "Action",
                Duration = 86,
                Rating = 7.5
            };
            var movie2 = new Movie
            {
                Title = "Goodfellas",
                Director = "Great One",
                YearReleased = 1989,
                Genre = "Crime",
                Duration = 134,
                Rating = 8.8
            };

            // Act
            await _controller.AddAsync(movie);
            await _controller.AddAsync(movie2);

            await _controller.DeleteAsync(movie.Title);

            var result = await _controller.GetAllAsync();

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.First().Title, Is.EqualTo("Goodfellas"));
        
        }


        [Test]
        [TestCase(null)]
        [TestCase("")]
        public async Task DeleteAsync_WhenTitleIsNull_ShouldThrowArgumentException(string movie)
        {
            // Act and Assert
            Assert.ThrowsAsync<ArgumentException>(() => _controller.DeleteAsync(movie));
        }

        [Test]
        public async Task DeleteAsync_WhenTitleDoesNotExist_ShouldThrowInvalidOperationException()
        {
            // Arrange
            var movie = new Movie
            {
                Title = "Test Movie",
                Director = "Test Director",
                YearReleased = 2022,
                Genre = "Action",
                Duration = 86,
                Rating = 7.5
            };

            await _controller.AddAsync(movie);
            movie.Title = null;
            // Act and Assert
            Assert.ThrowsAsync<ArgumentException>(() => _controller.DeleteAsync(movie.Title), "Title cannot be empty.");
        }

        [Test]
        public async Task GetAllAsync_WhenNoMoviesExist_ShouldReturnEmptyList()
        {
            // Act
            var result = await _controller.GetAllAsync();

            // Assert
            Assert.IsEmpty(result);
        }

        [Test]
        public async Task GetAllAsync_WhenMoviesExist_ShouldReturnAllMovies()
        {
            // Arrange
            var movie = new Movie
            {
                Title = "Test Movie",
                Director = "Test Director",
                YearReleased = 2022,
                Genre = "Action",
                Duration = 86,
                Rating = 7.5
            };

            // Act
            await _controller.AddAsync(movie);
            // Arrange
            var movie2 = new Movie
            {
                Title = "Dictator",
                Director = "Test Director",
                YearReleased = 2022,
                Genre = "Comedy",
                Duration = 126,
                Rating = 8.5
            };

            // Act
            await _controller.AddAsync(movie2);

            var result = await _controller.GetAllAsync();

            Assert.IsNotEmpty(result);
            Assert.That(result.Count, Is.EqualTo(2));
        }

        [Test]
        public async Task GetByTitle_WhenTitleExists_ShouldReturnMatchingMovie()
        {
            // Arrange
            var movie = new Movie
            {
                Title = "Test Movie",
                Director = "Test Director",
                YearReleased = 2022,
                Genre = "Action",
                Duration = 86,
                Rating = 7.5
            };

            // Act
            await _controller.AddAsync(movie);
            // Arrange
            var movie2 = new Movie
            {
                Title = "Dictator",
                Director = "Test Director",
                YearReleased = 2022,
                Genre = "Comedy",
                Duration = 126,
                Rating = 8.5
            };

            // Act
            await _controller.AddAsync(movie2);

            var findMovieByName = await _controller.SearchByTitleFragmentAsync(movie2.Title);


            // Assert
            Assert.That(findMovieByName.Count, Is.EqualTo(1));
            Assert.NotNull(findMovieByName);
            Assert.That(findMovieByName.First().Title, Is.EqualTo("Dictator"));
        }

        [Test]
        public async Task GetByTitle_WhenTitleDoesNotExist_ShouldReturnNull()
        {
            // Arrange
            var movie = new Movie
            {
                Title = "Test Movie",
                Director = "Test Director",
                YearReleased = 2022,
                Genre = "Action",
                Duration = 86,
                Rating = 7.5
            };

            // Act
            await _controller.AddAsync(movie);
            // Arrange
            var movie2 = new Movie
            {
                Title = "Dictator",
                Director = "Test Director",
                YearReleased = 2022,
                Genre = "Comedy",
                Duration = 126,
                Rating = 8.5
            };

            // Act
            await _controller.AddAsync(movie2);

            Assert.ThrowsAsync<KeyNotFoundException>(() =>  _controller.SearchByTitleFragmentAsync("Dune"), "No movies found.");

            
        }


        [Test]
        public async Task SearchByTitleFragmentAsync_WhenTitleFragmentExists_ShouldReturnMatchingMovies()
        {
            // Arrange
            var movie = new Movie
            {
                Title = "Test Movie",
                Director = "Test Director",
                YearReleased = 2022,
                Genre = "Action",
                Duration = 86,
                Rating = 7.5
            };

            // Act
            await _controller.AddAsync(movie);
            // Arrange
            var movie2 = new Movie
            {
                Title = "Dictator",
                Director = "Test Director",
                YearReleased = 2022,
                Genre = "Comedy",
                Duration = 126,
                Rating = 8.5
            };

            // Act
            await _controller.AddAsync(movie2);

            //Assert 
            var result = await _controller.SearchByTitleFragmentAsync("Test");

            Assert.NotNull(result);
            Assert.That(result.First().Title, Is.EqualTo("Test Movie"));
        }

        [Test]
        public async Task SearchByTitleFragmentAsync_WhenNoMatchingTitleFragment_ShouldThrowKeyNotFoundException()
        {
            // Arrange
            var movie = new Movie
            {
                Title = "Test Movie",
                Director = "Test Director",
                YearReleased = 2022,
                Genre = "Action",
                Duration = 86,
                Rating = 7.5
            };

            // Act
            await _controller.AddAsync(movie);
            // Arrange
            var movie2 = new Movie
            {
                Title = "Dictator",
                Director = "Test Director",
                YearReleased = 2022,
                Genre = "Comedy",
                Duration = 126,
                Rating = 8.5
            };

            // Act
            await _controller.AddAsync(movie2);

            //Assert 
            Assert.ThrowsAsync<KeyNotFoundException>(() => _controller.SearchByTitleFragmentAsync("Dune"), "No movies found.");

        }

        [Test]
        public async Task UpdateAsync_WhenValidMovieProvided_ShouldUpdateMovie()
        {
            // Arrange
            var movie = new Movie
            {
                Title = "Test Movie",
                Director = "Test Director",
                YearReleased = 2022,
                Genre = "Action",
                Duration = 86,
                Rating = 7.5
            };

            // Act
            await _controller.AddAsync(movie);
            // Arrange
            var movie2 = new Movie
            {
                Title = "Dictator",
                Director = "Test Director",
                YearReleased = 2022,
                Genre = "Comedy",
                Duration = 126,
                Rating = 8.5
            };

            await _controller.AddAsync(movie2);

            // Modify the movie
            movie.Title = "Title UPDATED";
            // Act
            await _controller.UpdateAsync(movie);
            var result = await _controller.SearchByTitleFragmentAsync("UPDATED");
            
            // Assert
            Assert.NotNull(result);
            Assert.That(result.First().Title, Is.EqualTo("Title UPDATED"));
        }

        [Test]
        public async Task UpdateAsync_WhenInvalidMovieProvided_ShouldThrowValidationException()
        {
            // Arrange
            // Movie without required fields
            // Arrange
            var invalidMovie = new Movie
            {
                Director = "Test Director",
                YearReleased = 2022,
                Genre = "Action",
                Duration = 86,
                Rating = 7.5
            };

            var exception = Assert.ThrowsAsync<ValidationException>(() => _controller.AddAsync(invalidMovie));

            // Act and Assert
        }


        [OneTimeTearDown]
        public async Task OneTimeTearDown()
        {
            await _dbContext.ClearDatabaseAsync();
        }
    }
}
