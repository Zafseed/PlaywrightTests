using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

public class Tests : PageTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        await Page.GotoAsync("https://playwright.dev");

        await Page.GetByRole(AriaRole.Link, new() { Name = "Get started" }).ClickAsync();

        await Expect(Page.GetByRole(AriaRole.Heading, new() { Name = "Installation" })).ToBeVisibleAsync();
    }
}
