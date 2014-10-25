using System.Linq;
using NUnit.Framework;
using Shouldly;

namespace Website.UnitTests
{
	[TestFixture]
	public class DanceInfoRepositoryShould
	{
		[Test]
		public void ReturnOrderedList()
		{
			var list = Models.DanceInfoRepository.Sliders.ToList();

			list.ShouldNotBe(null);
			list.Count.ShouldNotBe(0);
			list.ShouldContain(list.FirstOrDefault());
		}
	}
}