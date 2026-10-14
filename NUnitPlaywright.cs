using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;
using NUnit.Framework;
namespace PlaywrightDemo;

public class NUnitPlaywright : PageTest
{
    [Test]
    public async Task Test1()
    {
        await Page.GotoAsync("https://www.saucedemo.com/");

        await Page.Locator("[data-test='username']")
            .FillAsync("standard_user");

        await Page.Locator("[data-test='password']")
            .FillAsync("secret_sauce");

        await Page.Locator("[data-test='login-button']")
            .ClickAsync();

        await Expect(Page.Locator(".title"))
            .ToHaveTextAsync("Products");
    }
}