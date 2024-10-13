using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMApp1.Pages;
using CRMApp1.ECommerce;
using CRMApp1.Northwind;
using CRMApp1.CRMApp;

namespace TestCRMApp1
{
	[Collection("CRMApp1")]
	public class TestHome
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCategoryChartModule),
				typeof(IgbGridModule),
				typeof(IgbListModule),
				typeof(IgbAvatarModule),
				typeof(IgbChipModule));
			ctx.Services.AddScoped<IECommerceService>(sp => new MockECommerceService());
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			ctx.Services.AddScoped<ICRMAppService>(sp => new MockCRMAppService());
			var componentUnderTest = ctx.RenderComponent<Home>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
