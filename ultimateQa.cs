using System;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System.Threading.Tasks;
namespace PlaywrightDemo
{
    public class ultimateQa: PageTest
    {
        // [Test]
        // public async Task pageLoadTest()
        // {
        //      // Navigate to the automation page
        //     await Page.GotoAsync("https://ultimateqa.com/automation");

        //     // Verify that the browser reached the expected URL
        //     await Expect(Page).ToHaveURLAsync(
        //         "https://ultimateqa.com/automation"
        //     );
        // }
        // [Test]
        // public async Task pageTitleTest()
        // {
        //     //Navigate to the automation page
        //     await Page.GotoAsync("https://ultimateqa.com/automation");
        //     // Verify the page title
        //     await Expect(Page).ToHaveTitleAsync(
        //          "Automation Practice | Ultimate QA"
        //     );
        // }
        // [Test]
        // public async Task pageHeadingTest()
        // {
        //     // Navigate to the automation page
        //     await Page.GotoAsync("https://ultimateqa.com/automation");

        //     // Verify the page heading
        //     var heading = Page.GetByRole(
        //         AriaRole.Heading,
        //         new() { Name = "Automation Practice", Exact = true }
        //     );

        //     await Expect(heading).ToBeVisibleAsync();
        // }
        // [Test]
        // public async Task interactionElementTest()
        // {
        //     // Navigate to the automation page
        //     await Page.GotoAsync("https://ultimateqa.com/automation");

        //     // Locate the link and click it
        //     await Page.GetByRole(AriaRole.Link, new() {Name = "Interactions with simple elements"}).ClickAsync();

        //     // Verify that the browser navigated to the expected URL
        //     await Expect(Page).ToHaveURLAsync("https://ultimateqa.com/simple-html-elements-for-automation/");
        // }
        // [Test]
        // public async Task clickMeButton_ShouldBeVisible()
        // {
        //     // Open the practice page
        //     await Page.GotoAsync(
        //         "https://ultimateqa.com/simple-html-elements-for-automation/"
        //     );

        //     // Locate the button by its accessible name
        //     var button = Page.GetByRole(
        //         AriaRole.Button,
        //         new() { Name = "Click Me!", Exact = true }
        //     );

        //     // Verify that the button is visible
        //     await Expect(button).ToBeVisibleAsync();
        // }
        // [Test]
        // public async Task raiseButton_ShouldBeVisible()
        // {
        //     // Open the practice page
        //     await Page.GotoAsync(
        //         "https://ultimateqa.com/simple-html-elements-for-automation/"
        //     );

        //     // Locate the button by its accessible name
        //     var button = Page.GetByRole(
        //         AriaRole.Button,
        //         new() { Name = "Raise", Exact = true }
        //     );

        //     // Verify that the button is visible
        //     await Expect(button).ToBeVisibleAsync();
        // }
        // [Test]
        // public async Task Button1_ShouldBeClickable()
        // {
        //     await Page.GotoAsync(
        //         "https://ultimateqa.com/simple-html-elements-for-automation/"
        //     );

        //     var firstButton = Page.Locator("button.buttonClass");

        //     await Expect(firstButton).ToBeVisibleAsync();
        //     await Expect(firstButton).ToBeEnabledAsync();

        //     await firstButton.ClickAsync();
        // }
        // [Test]
        // public async Task Button2_ShouldBeClickable()
        // {
        //     await Page.GotoAsync(
        //         "https://ultimateqa.com/simple-html-elements-for-automation/"
        //     );

        //     var secondButton = Page.Locator("button[name='button1']");

        //     await Expect(secondButton).ToBeVisibleAsync();
        //     await Expect(secondButton).ToBeEnabledAsync();

        //     await secondButton.ClickAsync();
        // }
        // [Test]
        // public async Task clickUsingIdLink_ShouldBeVisible()
        // {
        //     // Open the practice page
        //     await Page.GotoAsync(
        //         "https://ultimateqa.com/simple-html-elements-for-automation/"
        //     );

        //     // Locate the link using its accessible name
        //     var link = Page.GetByRole(
        //         AriaRole.Link,
        //         new() { Name = "Click this button using \"ID\"", Exact = true }
        //     );

        //     // Verify that the link is visible
        //     await Expect(link).ToBeVisibleAsync();
        // }
        // [Test]
        // public async Task ServicesLink_ShouldBeVisible()
        // {
        //     await Page.GotoAsync("https://ultimateqa.com/simple-html-elements-for-automation/");
        //     var link = Page.GetByRole(AriaRole.Link, new() { Name = "Services", Exact = true });
        //     await link.ClickAsync();
        //     await Expect(Page).ToHaveURLAsync("https://ultimateqa.com/consulting/");
        //     // await Expect(link).ToBeVisibleAsync();
        // }
        
        // [Test]
        // public async Task consulting_Schedule_Link_ShouldOpenForm()
        // {
        //     await Page.GotoAsync("https://ultimateqa.com/consulting/");

        //     var link = Page.GetByRole(
        //         AriaRole.Link,
        //         new()
        //         {
        //             Name = "SCHEDULE A FREE DISCOVERY SESSION",
        //             Exact = true
        //         }).Nth(0);

        //     var newPage = await Page.RunAndWaitForPopupAsync(
        //         async () => await link.ClickAsync());

        //     await Expect(newPage).ToHaveURLAsync(
        //         "https://40m40a.share-na2.hsforms.com/23I1BOSbZSkmmb1UP2OzAjw");
        // }
        
        // // Radio Button Tests
        // [Test]
        // public async Task MaleRadioButton_ShouldBeVisible()
        // {
        //     await Page.GotoAsync(
        //         "https://ultimateqa.com/simple-html-elements-for-automation/");

        //     var maleRadio = Page.Locator("input[type='radio']").Nth(0);

        //     await Expect(maleRadio).ToBeVisibleAsync();
        // }
        // [Test]
        // public async Task FemaleRadioButton_ShouldBeVisible()
        // {
        //     await Page.GotoAsync(
        //         "https://ultimateqa.com/simple-html-elements-for-automation/");

        //     var femaleRadio = Page.Locator("input[type='radio']").Nth(1);

        //     await Expect(femaleRadio).ToBeVisibleAsync();
        // }

        //Checkbox Tests
        
        // [Test]
        // public async Task BikeCheckbox_ShouldBeVisible()
        // {
        //     await Page.GotoAsync(
        //         "https://ultimateqa.com/simple-html-elements-for-automation/");

        //     var bikeCheckbox = Page.Locator(
        //         "input[type='checkbox']").Nth(0);

        //     await Expect(bikeCheckbox).ToBeVisibleAsync();
        // }
        
        // [Test]
        // public async Task BikeCheckbox_ShouldBeChecked()
        // {
        //     await Page.GotoAsync(
        //         "https://ultimateqa.com/simple-html-elements-for-automation/");

        //     var bikeCheckbox = Page.Locator(
        //         "input[type='checkbox'][value='Bike']");

        //     Console.WriteLine(
        //         $"Before click: {await bikeCheckbox.IsCheckedAsync()}");

        //     await bikeCheckbox.ClickAsync();

        //     Console.WriteLine(
        //         $"After click: {await bikeCheckbox.IsCheckedAsync()}");

        //     await Expect(bikeCheckbox).ToBeCheckedAsync();
        // }

        // Form Testing
        
        // [Test]
        // public async Task ContactForm_NameField_ShouldAcceptInput()
        // {
        //     // Open the form directly
        //     await Page.GotoAsync(
        //         "https://40m40a.share-na2.hsforms.com/23I1BOSbZSkmmb1UP2OzAjw");

        //     // Locate the Name field using its placeholder
        //     var nameField = Page.GetByPlaceholder("Enter text").Nth(0);

        //     // Enter a name
        //     await nameField.FillAsync("Hari");

        //     // Verify the entered name
        //     await Expect(nameField).ToHaveValueAsync("Hari");
        // }

        // First check whether the email field is accepting input or not.
        // [Test]
        // public async Task ContactForm_EmailField_ShouldAcceptInput()
        // {
        //     // Open the form directly
        //     await Page.GotoAsync(
        //         "https://40m40a.share-na2.hsforms.com/23I1BOSbZSkmmb1UP2OzAjw");

        //     // Locate the Email field using its placeholder
        //     var emailField = Page.GetByPlaceholder("Enter email").Nth(0);

        //     // Enter an email
        //     await emailField.FillAsync("hari09");

        //     // Verify the entered email
        //     await Expect(emailField).ToHaveValueAsync("hari09");
        // }
        
        // // The input email is valid or not
        
        // [Test]
        // public async Task ContactForm_EmailField_ShouldRejectInvalidEmail()
        // {
        //     await Page.GotoAsync(
        //         "https://40m40a.share-na2.hsforms.com/23I1BOSbZSkmmb1UP2OzAjw");

        //     var emailField = Page.GetByPlaceholder("Enter email");

        //     await emailField.FillAsync("hari08@gmail.com");

        //     var isValid = await emailField.EvaluateAsync<bool>(
        //         "element => element.validity.valid");

        //     Assert.That(isValid, Is.True);
        // }

        // Check for the dropdown test this is the inspection script
        
        [Test]
        public async Task ContactForm_InspectDropdown()
        {
            await Page.GotoAsync(
                "https://40m40a.share-na2.hsforms.com/23I1BOSbZSkmmb1UP2OzAjw");

            // Find the dropdown using its visible question
            var dropdown = Page.GetByText(
                "How can UltimateQA elevate your automated testing?",
                new() { Exact = false });

            // Print the HTML of the matched element
            Console.WriteLine(
                await dropdown.EvaluateAsync<string>(
                    "element => element.outerHTML"));
        }

    }
}