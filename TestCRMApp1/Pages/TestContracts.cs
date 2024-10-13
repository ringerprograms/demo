using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMApp1.Pages;

namespace TestCRMApp1
{
	[Collection("CRMApp1")]
	public class TestContracts
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Contracts>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
