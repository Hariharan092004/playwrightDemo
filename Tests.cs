// using Microsoft.Playwright;
// using NUnit.Framework;

// namespace PlaywrightDemo;
// public class Tests
// {
//     [Test]
//     public async Task Test1()
//     {
//         using var playwright = await Playwright.CreateAsync();
//         await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
//         {
//             Headless = true
//         });
//         var page = await browser.NewPageAsync();
//         var loginPage = new LoginPage(page);
//         // Navigate to the login page
//         await page.GotoAsync("https://www.saucedemo.com/");
//         // Perform login using the LoginPage class
//         await loginPage.LoginAsync("problem_user", "secret_sauce");
//         // Verify the actual result
//         await Assertions.Expect(page.Locator(".title")).ToHaveTextAsync("Products");
//     }
// }