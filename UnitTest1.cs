
// using Microsoft.Playwright;
// using NUnit.Framework;

// namespace PlaywrightDemo;

// public class Tests
// {
//     [Test]
//     public async Task Test1()
//     {
//         // Step 1: Create Playwright
//         using var playwright = await Playwright.CreateAsync();

//         // Step 2: Launch the browser
//         await using var browser = await playwright.Chromium.LaunchAsync(
//             new BrowserTypeLaunchOptions
//             {
//                 Headless = false,
//                 SlowMo = 1000
//             });

//         // Step 3: Create a page
//         var page = await browser.NewPageAsync();

//         // Step 4: Navigate to SauceDemo
//         await page.GotoAsync("https://www.saucedemo.com/");

//         // Step 5: Enter username and password
//         await page.Locator("[data-test='username']")
//                   .FillAsync("standard_user");

//         await page.Locator("[data-test='password']")
//                   .FillAsync("secret_sauce");

//         // Step 6: Click Login
//         await page.Locator("[data-test='login-button']")
//                   .ClickAsync();

//         // Step 7: Verify successful login
//         var isExist = await page.Locator(".title")
//                                  .Filter(new() { HasText = "Products" })
//                                  .IsVisibleAsync();

//         Assert.That(isExist, Is.True,
//             "Login failed: Products page was not displayed.");
//     }
// }
