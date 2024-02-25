using ContactsConsoleAPI.Business;
using ContactsConsoleAPI.Business.Contracts;
using ContactsConsoleAPI.Data.Models;
using ContactsConsoleAPI.DataAccess;
using ContactsConsoleAPI.DataAccess.Contrackts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsConsoleAPI.IntegrationTests.NUnit
{
    public class IntegrationTests
    {
        private TestContactDbContext dbContext;
        private IContactManager contactManager;

        [SetUp]
        public void SetUp()
        {
            this.dbContext = new TestContactDbContext();
            this.contactManager = new ContactManager(new ContactRepository(this.dbContext));
        }


        [TearDown]
        public void TearDown()
        {
            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Dispose();
        }


        //positive test
        [Test]
        public async Task AddContactAsync_ShouldAddNewContact()
        {
            var newContact = new Contact()
            {
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                Address = "Anything for testing address",
                Contact_ULID = "1ABC23456HH", //must be minimum 10 symbols - numbers or Upper case letters
                Email = "test@gmail.com",
                Gender = "Male",
                Phone = "0889933779"
            };

            await contactManager.AddAsync(newContact);

            var dbContact = await dbContext.Contacts.FirstOrDefaultAsync(c => c.Contact_ULID == newContact.Contact_ULID);

            Assert.NotNull(dbContact);
            Assert.AreEqual(newContact.FirstName, dbContact.FirstName);
            Assert.AreEqual(newContact.LastName, dbContact.LastName);
            Assert.AreEqual(newContact.Phone, dbContact.Phone);
            Assert.AreEqual(newContact.Email, dbContact.Email);
            Assert.AreEqual(newContact.Address, dbContact.Address);
            Assert.AreEqual(newContact.Contact_ULID, dbContact.Contact_ULID);
        }

        //Negative test
        [Test]
        public async Task AddContactAsync_TryToAddContactWithInvalidCredentials_ShouldThrowException()
        {
            var newContact = new Contact()
            {
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                Address = "Anything for testing address",
                Contact_ULID = "1ABC23456HH", //must be minimum 10 symbols - numbers or Upper case letters
                Email = "invalid_Mail", //invalid email
                Gender = "Male",
                Phone = "0889933779"
            };

            var ex = Assert.ThrowsAsync<ValidationException>(async () => await contactManager.AddAsync(newContact));
            var actual = await dbContext.Contacts.FirstOrDefaultAsync(c => c.Contact_ULID == newContact.Contact_ULID);

            Assert.IsNull(actual);
            Assert.That(ex?.Message, Is.EqualTo("Invalid contact!"));

        }

        [Test]
        public async Task DeleteContactAsync_WithValidULID_ShouldRemoveContactFromDb()
        {
            var newContact = new Contact()
            {
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                Address = "Anything for testing address",
                Contact_ULID = "1ABC23456HH", //must be minimum 10 symbols - numbers or Upper case letters
                Email = "test@gmail.com",
                Gender = "Male",
                Phone = "0889933779"
            };

            await contactManager.AddAsync(newContact);

            var actual = await dbContext.Contacts.FirstOrDefaultAsync();
            Assert.IsNotNull(actual);

            await contactManager.DeleteAsync(newContact.Contact_ULID);
            actual = await dbContext.Contacts.FirstOrDefaultAsync();

            // Assert
            Assert.IsNull(actual);
            
        }

        [Test]
        public async Task DeleteContactAsync_TryToDeleteWithNullOrWhiteSpaceULID_ShouldThrowException()
        {
            // Arrange
            Assert.ThrowsAsync<ArgumentException>(async () => await contactManager.DeleteAsync(""));
            // Act

            // Assert
           // Assert.Inconclusive("Test not implemented yet.");
        }

        [Test]
        public async Task GetAllAsync_WhenContactsExist_ShouldReturnAllContacts()
        {
            // Arrange
            var newContact = new Contact()
            {
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                Address = "Anything for testing address",
                Contact_ULID = "1ABC23456HH", //must be minimum 10 symbols - numbers or Upper case letters
                Email = "test@gmail.com",
                Gender = "Male",
                Phone = "0889933779"
            };
            var newContact2 = new Contact()
            {
                FirstName = "TestFirstName2",
                LastName = "TestLastName2",
                Address = "Anything for testing address",
                Contact_ULID = "1ABC23456HA", //must be minimum 10 symbols - numbers or Upper case letters
                Email = "test@gmail.com",
                Gender = "Male",
                Phone = "0889933778"
            };
            await contactManager.AddAsync(newContact2);
            await contactManager.AddAsync(newContact);


            // Act
            var result = await contactManager.GetAllAsync();
            var specificContact = await dbContext.Contacts.FirstOrDefaultAsync(c => c.Contact_ULID == "1ABC23456HA");

            // Assert
            Assert.NotNull(result);
            Assert.That(specificContact.Contact_ULID, Is.EqualTo(newContact2.Contact_ULID));
            Assert.That(result.Count(), Is.EqualTo(2));

        }

        [Test]
        public async Task GetAllAsync_WhenNoContactsExist_ShouldThrowKeyNotFoundException()
        {
            // Arrange
            Assert.ThrowsAsync<KeyNotFoundException>(() => contactManager.GetAllAsync());
            // Act

            // Assert
            //Assert.Inconclusive("Test not implemented yet.");
        }

        [Test]
        public async Task SearchByFirstNameAsync_WithExistingFirstName_ShouldReturnMatchingContacts()
        {
            // Arrange
            // Arrange
            var newContact = new Contact()
            {
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                Address = "Anything for testing address",
                Contact_ULID = "1ABC23456HH", //must be minimum 10 symbols - numbers or Upper case letters
                Email = "test@gmail.com",
                Gender = "Male",
                Phone = "0889933779"
            };

            // Act
            await contactManager.AddAsync(newContact);
            var firstContact = await dbContext.Contacts.FirstOrDefaultAsync(c => c.FirstName == "TestFirstName");
            // Assert
            Assert.NotNull(firstContact);
            Assert.That(firstContact.FirstName, Is.EqualTo("TestFirstName"));
            Assert.That(firstContact.LastName, Is.EqualTo("TestLastName"));
            Assert.That(firstContact.Contact_ULID, Is.EqualTo("1ABC23456HH"));


        }

        [Test]
        public async Task SearchByFirstNameAsync_WithNonExistingFirstName_ShouldThrowKeyNotFoundException()
        {
            // Arrange
            var newContact = new Contact()
            {
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                Address = "Anything for testing address",
                Contact_ULID = "1ABC23456HH", //must be minimum 10 symbols - numbers or Upper case letters
                Email = "test@gmail.com",
                Gender = "Male",
                Phone = "0889933779"
            };

            // Act
            await contactManager.AddAsync(newContact);
            // Act

            // Assert
            Assert.ThrowsAsync<KeyNotFoundException>(async () => await dbContext.Contacts.FirstOrDefaultAsync(c => c.FirstName == "Georgi"));
        }

        [Test]
        public async Task SearchByLastNameAsync_WithExistingLastName_ShouldReturnMatchingContacts()
        {
            // Arrange

            // Act

            // Assert
            Assert.Inconclusive("Test not implemented yet.");
        }

        [Test]
        public async Task SearchByLastNameAsync_WithNonExistingLastName_ShouldThrowKeyNotFoundException()
        {
            // Arrange

            // Act

            // Assert
            Assert.Inconclusive("Test not implemented yet.");
        }

        [Test]
        public async Task GetSpecificAsync_WithValidULID_ShouldReturnContact()
        {
            // Arrange

            // Act

            // Assert
            Assert.Inconclusive("Test not implemented yet.");
        }

        [Test]
        public async Task GetSpecificAsync_WithInvalidULID_ShouldThrowKeyNotFoundException()
        {
            // Arrange

            // Act

            // Assert
            Assert.Inconclusive("Test not implemented yet.");
        }

        [Test]
        public async Task UpdateAsync_WithValidContact_ShouldUpdateContact()
        {
            // Arrange

            // Act

            // Assert
            Assert.Inconclusive("Test not implemented yet.");
        }

        [Test]
        public async Task UpdateAsync_WithInvalidContact_ShouldThrowValidationException()
        {
            // Arrange

            // Act

            // Assert
            Assert.Inconclusive("Test not implemented yet.");
        }
    }
}
