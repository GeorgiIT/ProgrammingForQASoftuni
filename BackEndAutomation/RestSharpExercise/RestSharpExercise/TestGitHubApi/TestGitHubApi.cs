using RestSharpServices;
using System.Net;
using System.Reflection.Emit;
using System.Text.Json;
using RestSharp;
using RestSharp.Authenticators;
using NUnit.Framework.Internal;
using RestSharpServices.Models;
using System;

namespace TestGitHubApi
{
    public class TestGitHubApi
    {
        private GitHubApiClient client;
        private static string repo;
        private static int lastCreatedIssueNumber;
        private static long lastCreatedCommentId;

        [SetUp]
        public void Setup()
        {            
            client = new GitHubApiClient("https://api.github.com/repos/testnakov/", "GeorgiIT", "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");
            repo = "test-nakov-repo";
        }


        [Test, Order (1)]
        public void Test_GetAllIssuesFromARepo()
        {
            //Arrange


            //Act
            var issues = client.GetAllIssues(repo);

            //Assert
            Assert.That(issues, Has.Count.GreaterThan(0), "There should be more than one issue.");

            foreach (Issue issue in issues) 
            {
                Assert.That(issue.Id, Is.GreaterThan(0), "Id should be grater than 0");
                Assert.That(issue.Number, Is.GreaterThan(0), "Number should be grater than 0");
                Assert.That(issue.Title, Is.Not.Empty, "Title should not be empty");
            }


        }

        [Test, Order (2)]
        public void Test_GetIssueByValidNumber()
        {
            int issueNumber = 1;

            var issue = client.GetIssueByNumber(repo, issueNumber);

            Assert.That(issue, Is.Not.Null, "The response should contain issue date.");
            Assert.That(issue.Id, Is.GreaterThan(0), "Id should be grater than 0");
            Assert.That(issue.Number, Is.EqualTo(issueNumber), "Number should be equal.");
            Assert.That(issue.Title, Is.Not.Empty, "Title should not be empty");
        }
        
        [Test, Order (3)]
        public void Test_GetAllLabelsForIssue()
        {
            //Arrange
            int issueNumber = 6;

            //Act
            var labels = client.GetAllLabelsForIssue(repo, issueNumber);

            //Assert
            Assert.NotNull(labels, "The labels shouldn't be null.");
            Assert.That(labels.Count, Is.GreaterThan(0), "Labels should be grater than 0.");

            foreach(var label in labels)
            {
                Assert.That(label.Id, Is.GreaterThan(0), "Id should be grater than 0.");
                Assert.That(label.Name, Is.Not.Null, "Name should not be null.");

                Console.WriteLine($"Label: {label.Id} - Name: {label.Name}");
            }
        }

        [Test, Order (4)]
        public void Test_GetAllCommentsForIssue()
        {
            //Arrange
            int issueNumber = 6;

            //Act
            var comments = client.GetAllCommentsForIssue(repo, issueNumber);

            //Assert
            Assert.NotNull(comments, "The labels shouldn't be null.");
            Assert.That(comments.Count, Is.GreaterThan(0), "Labels should be grater than 0.");

            foreach (var c in comments)
            {
                Assert.That(c.Id, Is.GreaterThan(0), "Id should be grater than 0.");
                Assert.That(c.Body, Is.Not.Null, "Name should not be null.");

                Console.WriteLine($"Label: {c.Id} - Body: {c.Body}");
            }
        }

        [Test, Order(5)]
        public void Test_CreateGitHubIssue()
        {
            //Arrange
            string title = "Georgi Todorov Issue";
            string body = "Back-end Automation course 10/03/2024";

            //Act
            var issue = client.CreateIssue(repo, title, body);

            //Assert
            Assert.Multiple(() =>
            {
                
                Assert.That(issue.Id, Is.GreaterThan(0), "Id should be grater than 0.");
                Assert.That(issue.Number, Is.GreaterThan(0), "Number should be grater than 0.");
                Assert.That(issue.Title, Is.EqualTo(title), "Title should be the same.");
                Assert.That(issue.Title, Is.Not.Empty, "Name shouldn't be empty.");
            });
            Console.WriteLine(issue.Number);
            lastCreatedIssueNumber = issue.Number;

        }

        [Test, Order (6)]
        public void Test_CreateCommentOnGitHubIssue()
        {
            //Arrange
            int issueNumber = 6293;
            string body = "Leaving comment on my issue";

            //Act

            var comment = client.CreateCommentOnGitHubIssue(repo, issueNumber, body);


            //Assert
            Assert.That(comment.Body, Is.EqualTo(body));

            Console.WriteLine(comment.Id);
            lastCreatedCommentId = comment.Id;


        }

        [Test, Order (7)]
        public void Test_GetCommentById()
        {
            var comment = client.GetCommentById(repo, lastCreatedCommentId);

            Assert.That(comment.Id, Is.EqualTo(lastCreatedCommentId)); 
        }


        [Test, Order (8)]
        public void Test_EditCommentOnGitHubIssue()
        {
            var commentId = 1991915371;
            string body = "new edited body";

            var comment = client.EditCommentOnGitHubIssue(repo, commentId, body);

            Assert.That(comment.Body, Is.EqualTo(body));
            Assert.NotNull(comment);

        }

        [Test, Order (9)]
        public void Test_DeleteCommentOnGitHubIssue()
        {
            var commentId = 1991915371;

            bool comment = client.DeleteCommentOnGitHubIssue(repo, commentId);

            Assert.IsTrue(comment);
        }


    }
}

