using Microsoft.Playwright;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Text.Json;

namespace PlaywrightDemo;

public class ApiTests
{
    [Test]
    public async Task GetPost_ShouldReturnSuccess()
    {
        using var playwright = await Playwright.CreateAsync();
        var api = await playwright.APIRequest.NewContextAsync();

        try
        {
            // Send GET request
            var response = await api.GetAsync(
                "https://jsonplaceholder.typicode.com/posts/1");

            // Verify status code
            Assert.That(response.Status, Is.EqualTo(200));

            // Read response body
            var body = await response.TextAsync();

            // Verify response data
            Assert.That(body, Does.Contain("\"id\": 1"));

            // Release response resources
            await response.DisposeAsync();
        }
        finally
        {
            await api.DisposeAsync();
        }
    }

    [Test]
    public async Task CreatePost_ShouldReturnSuccess()
    {
        using var playwright = await Playwright.CreateAsync();
        var api = await playwright.APIRequest.NewContextAsync();

        try
        {
            // Prepare POST request data
            var postData = new
            {
                title = "Learning API Automation",
                body = "I am learning the POST method.",
                userId = 1
            };

            // Send POST request
            var response = await api.PostAsync(
                "https://jsonplaceholder.typicode.com/posts",
                new APIRequestContextOptions
                {
                    DataObject = postData
                });

            // Verify status code
            Assert.That(response.Status, Is.EqualTo(201));

            // Read and display response body
            var body = await response.TextAsync();
            Console.WriteLine(body);

            // Verify returned data
            Assert.That(body, Does.Contain("Learning API Automation"));

            // Release response resources
            await response.DisposeAsync();
        }
        finally
        {
            await api.DisposeAsync();
        }
    }
    [Test]
    public async Task GetPost_ShouldValidateJsonFields()
    {
        using var playwright = await Playwright.CreateAsync();
        var api = await playwright.APIRequest.NewContextAsync();

        try
        {
            // 1. Send a GET request
            var response = await api.GetAsync(
                "https://jsonplaceholder.typicode.com/posts/1");

            // 2. Check the status code
            Assert.That(response.Status, Is.EqualTo(200));

            // 3. Read the response body
            var body = await response.TextAsync();

            // 4. Parse the JSON response
            using var json = JsonDocument.Parse(body);

            // 5. Extract individual JSON fields
            var root = json.RootElement;

            int id = root.GetProperty("id").GetInt32();
            string title = root.GetProperty("title").GetString()!;
            int userId = root.GetProperty("userId").GetInt32();

            // 6. Validate each field
            Assert.That(id, Is.EqualTo(1));
            Assert.That(title, Is.Not.Empty);
            Assert.That(userId, Is.EqualTo(1));
        }
        finally
        {
            await api.DisposeAsync();
        }
    }
}