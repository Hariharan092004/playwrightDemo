using Microsoft.Playwright;
using NUnit.Framework;
using System.Text.Json;
namespace PlaywrightDemo;

public class RestfulBookerTests
{
    // [Test]
    // public async Task HealthCheck_ShouldRespondSuccessfully()
    // {
    //     using var playwright = await Playwright.CreateAsync();
    //     var api = await playwright.APIRequest.NewContextAsync();

    //     try
    //     {
    //         var response = await api.GetAsync(
    //             "https://restful-booker.herokuapp.com/ping");

    //         Assert.That(response.Status, Is.EqualTo(201));
    //     }
    //     finally
    //     {
    //         await api.DisposeAsync();
    //     }
    // }
    
    // [Test]
    // public async Task GetBookingIds_ShouldReturnSuccess()
    // {
    //     using var playwright = await Playwright.CreateAsync();
    //     var api = await playwright.APIRequest.NewContextAsync();

    //     try
    //     {
    //         // Send a GET request to retrieve booking IDs
    //         var response = await api.GetAsync(
    //            // "https://restful-booker.herokuapp.com/booking");
    //             "https://restful-booker.herokuapp.com/booking/1");


    //         // Verify that the API returned HTTP 200
    //         Assert.That(response.Status, Is.EqualTo(200));

    //         // Read the response body
    //         var body = await response.TextAsync();

    //         // Print the response so we can inspect it
    //         Console.WriteLine(body);
    //     }
    //     finally
    //     {
    //         await api.DisposeAsync();
    //     }
    // }
    
    // [Test]
    // public async Task CreateBooking_ShouldReturnCreatedBooking()
    // {
    //     using var playwright = await Playwright.CreateAsync();
    //     var api = await playwright.APIRequest.NewContextAsync();

    //     try
    //     {
    //         var bookingData = new
    //         {
    //             firstname = "Hari",
    //             lastname = "Test",
    //             totalprice = 250,
    //             depositpaid = true,
    //             bookingdates = new
    //             {
    //                 checkin = "2027-01-10",
    //                 checkout = "2027-01-12"
    //             },
    //             additionalneeds = "Breakfast"
    //         };

    //         var response = await api.PostAsync(
    //             "https://restful-booker.herokuapp.com/booking",
    //             new APIRequestContextOptions
    //             {
    //                 DataObject = bookingData
    //             });

    //         Assert.That(response.Status, Is.EqualTo(200));

    //         var body = await response.TextAsync();
    //         Console.WriteLine(body);

    //         Assert.That(body, Does.Contain("Hari"));
    //         Assert.That(body, Does.Contain("Test"));
    //     }
    //     finally
    //     {
    //         await api.DisposeAsync();
    //     }
    // }
    
    // [Test]
    // public async Task CreateToken_ShouldReturnSuccess()
    // {
    //     using var playwright = await Playwright.CreateAsync();
    //     var api = await playwright.APIRequest.NewContextAsync();

    //     try
    //     {
    //         var credentials = new
    //         {
    //             username = "admin",
    //             password = "password123"
    //         };

    //         var response = await api.PostAsync(
    //             "https://restful-booker.herokuapp.com/auth",
    //             new APIRequestContextOptions
    //             {
    //                 DataObject = credentials
    //             });

    //         Assert.That(response.Status, Is.EqualTo(200));

    //         var body = await response.TextAsync();
    //         Console.WriteLine(body);

    //         Assert.That(body, Does.Contain("token"));
    //     }
    //     finally
    //     {
    //         await api.DisposeAsync();
    //     }
    // }
    

    // [Test]
    // public async Task UpdateBooking_ShouldReplaceBookingDetails()
    // {
    //     using var playwright = await Playwright.CreateAsync();
    //     var api = await playwright.APIRequest.NewContextAsync();

    //     try
    //     {
    //         // 1. Get an authentication token
    //         var credentials = new
    //         {
    //             username = "admin",
    //             password = "password123"
    //         };

    //         var authResponse = await api.PostAsync(
    //             "https://restful-booker.herokuapp.com/auth",
    //             new APIRequestContextOptions
    //             {
    //                 DataObject = credentials
    //             });

    //         Assert.That(authResponse.Status, Is.EqualTo(200));

    //         var authBody = await authResponse.TextAsync();
    //         using var authJson = JsonDocument.Parse(authBody);
    //         var token = authJson.RootElement
    //             .GetProperty("token").GetString();

    //         Assert.That(token, Is.Not.Null.And.Not.Empty);

    //         // 2. Create a booking to update
    //         var initialBooking = new
    //         {
    //             firstname = "Hari",
    //             lastname = "BeforeUpdate",
    //             totalprice = 200,
    //             depositpaid = true,
    //             bookingdates = new
    //             {
    //                 checkin = "2027-01-10",
    //                 checkout = "2027-01-12"
    //             },
    //             additionalneeds = "Breakfast"
    //         };

    //         var createResponse = await api.PostAsync(
    //             "https://restful-booker.herokuapp.com/booking",
    //             new APIRequestContextOptions
    //             {
    //                 DataObject = initialBooking
    //             });

    //         Assert.That(createResponse.Status, Is.EqualTo(200));

    //         var createBody = await createResponse.TextAsync();
    //         using var createJson = JsonDocument.Parse(createBody);
    //         int bookingId = createJson.RootElement
    //             .GetProperty("bookingid").GetInt32();

    //         // 3. Define the replacement booking details
    //         var updatedBooking = new
    //         {
    //             firstname = "Hari",
    //             lastname = "AfterUpdate",
    //             totalprice = 350,
    //             depositpaid = false,
    //             bookingdates = new
    //             {
    //                 checkin = "2027-02-10",
    //                 checkout = "2027-02-13"
    //             },
    //             additionalneeds = "Lunch"
    //         };

    //         // 4. Send PUT with the authentication token
    //         var updateResponse = await api.PutAsync(
    //             $"https://restful-booker.herokuapp.com/booking/{bookingId}",
    //             new APIRequestContextOptions
    //             {
    //                 DataObject = updatedBooking,
    //                 Headers = new Dictionary<string, string>
    //                 {
    //                     ["Cookie"] = $"token={token}"
    //                 }
    //             });

    //         // 5. Check the update response
    //         Assert.That(updateResponse.Status, Is.EqualTo(200));

    //         var updatedBody = await updateResponse.TextAsync();
    //         Console.WriteLine(updatedBody);

    //         Assert.That(updatedBody, Does.Contain("AfterUpdate"));
    //         Assert.That(updatedBody, Does.Contain("350"));
    //     }
    //     finally
    //     {
    //         await api.DisposeAsync();
    //     }
    // }


        [Test]
        public async Task UpdateBooking_ShouldPartiallyUpdateBookingDetails()
        {
            using var playwright = await Playwright.CreateAsync();
            var api = await playwright.APIRequest.NewContextAsync();

            try
            {
                // 1. Get an authentication token
                var credentials = new
                {
                    username = "admin",
                    password = "password123"
                };

                var authResponse = await api.PostAsync(
                    "https://restful-booker.herokuapp.com/auth",
                    new APIRequestContextOptions
                    {
                        DataObject = credentials
                    });

                Assert.That(authResponse.Status, Is.EqualTo(200));

                var authBody = await authResponse.TextAsync();

                using var authJson = JsonDocument.Parse(authBody);

                var token = authJson.RootElement
                    .GetProperty("token")
                    .GetString();

                Assert.That(token, Is.Not.Null.And.Not.Empty);

                // 2. Create the original booking
                var initialBooking = new
                {
                    firstname = "Hari",
                    lastname = "Haran",
                    totalprice = 200,
                    depositpaid = true,
                    bookingdates = new
                    {
                        checkin = "2027-01-10",
                        checkout = "2027-01-12"
                    },
                    additionalneeds = "Breakfast"
                };

                var createResponse = await api.PostAsync(
                    "https://restful-booker.herokuapp.com/booking",
                    new APIRequestContextOptions
                    {
                        DataObject = initialBooking
                    });

                Assert.That(createResponse.Status, Is.EqualTo(200));

                var createBody = await createResponse.TextAsync();

                using var createJson = JsonDocument.Parse(createBody);

                int bookingId = createJson.RootElement
                    .GetProperty("bookingid")
                    .GetInt32();

                Console.WriteLine($"Created Booking ID: {bookingId}");

                // 3. Specify only the fields to update
                var partialUpdate = new
                {
                    lastname = "Kishore",
                    totalprice = 350
                };

                // 4. Send PATCH with the authentication token
                var updateResponse = await api.PatchAsync(
                    $"https://restful-booker.herokuapp.com/booking/{bookingId}",
                    new APIRequestContextOptions
                    {
                        DataObject = partialUpdate,
                        Headers = new Dictionary<string, string>
                        {
                            ["Cookie"] = $"token={token}"
                        }
                    });

                // 5. Verify the PATCH response
                Assert.That(updateResponse.Status, Is.EqualTo(200));

                var updatedBody = await updateResponse.TextAsync();

                Console.WriteLine("PATCH Response:");
                Console.WriteLine(updatedBody);

                // 6. GET the booking to verify saved data
                var getResponse = await api.GetAsync(
                    $"https://restful-booker.herokuapp.com/booking/{bookingId}");

                Assert.That(getResponse.Status, Is.EqualTo(200));

                var finalBody = await getResponse.TextAsync();

                Console.WriteLine("GET Response:");
                Console.WriteLine(finalBody);

                // 7. Parse the retrieved JSON
                using var finalJson = JsonDocument.Parse(finalBody);

                var booking = finalJson.RootElement;

                // Verify updated fields
                Assert.That(
                    booking.GetProperty("lastname").GetString(),
                    Is.EqualTo("Kishore"));

                Assert.That(
                    booking.GetProperty("totalprice").GetInt32(),
                    Is.EqualTo(350));

                // Verify unchanged fields
                Assert.That(
                    booking.GetProperty("firstname").GetString(),
                    Is.EqualTo("Hari"));

                Assert.That(
                    booking.GetProperty("additionalneeds").GetString(),
                    Is.EqualTo("Breakfast"));

                Assert.That(
                    booking.GetProperty("depositpaid").GetBoolean(),
                    Is.True);

                Console.WriteLine("PATCH and GET verification passed!");
            }
            finally
            {
                await api.DisposeAsync();
            }
        }
    }




