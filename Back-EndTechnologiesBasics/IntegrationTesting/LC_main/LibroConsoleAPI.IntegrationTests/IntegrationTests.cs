using LibroConsoleAPI.Business.Contracts;
using LibroConsoleAPI.Data.Models;
using LibroConsoleAPI.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace LibroConsoleAPI.IntegrationTests
{
    public class IntegrationTests : IClassFixture<BookManagerFixture>
    {
        private readonly Business.BookManager _bookManager;
        private readonly TestLibroDbContext _dbContext;

        public IntegrationTests(BookManagerFixture fixture)
        {
            _bookManager = fixture.BookManager;
            _dbContext = fixture.DbContext;
        }

        [Fact]
        public async Task AddBookAsync_ShouldAddBook()
        {
            // Arrange
            var newBook = new Book
            {
                Title = "Test Book",
                Author = "John Doe",
                ISBN = "1234567890123",
                YearPublished = 2021,
                Genre = "Fiction",
                Pages = 100,
                Price = 19.99
            };

            // Act
            await _bookManager.AddAsync(newBook);

            // Assert
            var bookInDb = await _dbContext.Books.FirstOrDefaultAsync(b => b.ISBN == newBook.ISBN);
            Assert.NotNull(bookInDb);
            Assert.Equal("Test Book", bookInDb.Title);
            Assert.Equal("John Doe", bookInDb.Author);
        }
        [Fact]
        public async Task AddBookAsync_WhenPassInvalidTitle_ShouldThrowExeption()
        {
            // Arrange
            var newBook = new Book
            {
                Title = new string('A',300),
                Author = "John Doe",
                ISBN = "1234567890123",
                YearPublished = 2021,
                Genre = "Fiction",
                Pages = 100,
                Price = 19.99
            };

            // Act
            var exception = Assert.ThrowsAsync<ValidationException>(() => _bookManager.AddAsync(newBook));

            // Assert
            
            Assert.Equal("Book is invalid.", exception.Result.Message);
            
        }

        [Fact]
        public async Task AddBookAsync_TryToAddBookWithInvalidCredentials_ShouldThrowException()
        {
            // Arrange
            var newBook = new Book
            {
                Title = "Dune",
                Author = new string('a', 260),
                ISBN = "1234567890123",
                YearPublished = 2021,
                Genre = "Fiction",
                Pages = 100,
                Price = 19.99
            };

            // Act
            var exception = Assert.ThrowsAsync<ValidationException>(() => _bookManager.AddAsync(newBook));

            // Assert

            Assert.Equal("Book is invalid.", exception.Result.Message);
        }

        [Fact]
        public async Task DeleteBookAsync_WithValidISBN_ShouldRemoveBookFromDb()
        {
            //// Arrange
            //var newBook = new Book
            //{
            //    Title = "Dune",
            //    Author = "Frank Herbert",
            //    ISBN = "1234567890123",
            //    YearPublished = 2021,
            //    Genre = "Fiction",
            //    Pages = 100,
            //    Price = 19.99
            //};

            //// Act
            //await _bookManager.AddAsync(newBook);
            await DatabaseSeeder.SeedDatabaseAsync(_dbContext, _bookManager);
            await _bookManager.DeleteAsync("9780312857753");
            // Assert
            var bookInDb =_dbContext.Books.ToList();
            Assert.Equal(9, bookInDb.Count);
            
        }
        [Fact]
        public async Task DeleteBookAsync_TryToDeleteWithNullOrWhiteSpaceISBN_ShouldThrowException()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public async Task GetAllAsync_WhenBooksExist_ShouldReturnAllBooks()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public async Task GetAllAsync_WhenNoBooksExist_ShouldThrowKeyNotFoundException()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public async Task SearchByTitleAsync_WithValidTitleFragment_ShouldReturnMatchingBooks()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public async Task SearchByTitleAsync_WithInvalidTitleFragment_ShouldThrowKeyNotFoundException()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public async Task GetSpecificAsync_WithValidIsbn_ShouldReturnBook()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public async Task GetSpecificAsync_WithInvalidIsbn_ShouldThrowKeyNotFoundException()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public async Task UpdateAsync_WithValidBook_ShouldUpdateBook()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public async Task UpdateAsync_WithInvalidBook_ShouldThrowValidationException()
        {
            // Arrange

            // Act

            // Assert
        }

    }
}
