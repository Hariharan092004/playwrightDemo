using Microsoft.Playwright;

namespace PlaywrightDemo;

public class LoginPage
{
    private readonly IPage _page;

    // Receive the browser page from the test
    public LoginPage(IPage page)
    {
        _page = page;
    }

    // Keep the login page locators in one place
    private ILocator UsernameInput => _page.Locator("[data-test='username']");
    private ILocator PasswordInput => _page.Locator("[data-test='password']");
    private ILocator LoginButton => _page.Locator("[data-test='login-button']");

    //Group the Login action into one reusable method
    public async Task LoginAsync(String username, String password)
    {
        await UsernameInput.FillAsync(username);
        await PasswordInput.FillAsync(password);
        await LoginButton.ClickAsync();
    }
}