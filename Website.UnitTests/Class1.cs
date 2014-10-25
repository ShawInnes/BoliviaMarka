using System.Linq;
using NUnit.Framework;
using Shouldly;
using Website.Infrastructure;

namespace Website.UnitTests
{
	[TestFixture]
	public class RandomPermutationShould
	{
		[Test]
		public void ReturnUnShuffledListWhenNotShuffled()
		{
			var list1 = Models.DanceInfoRepository.Sliders.ToList();
			var list2 = Models.DanceInfoRepository.Sliders.ToList();

			list1.ShouldBe(list2);
		}

		[Test]
		public void ReturnShuffledListWhenNotShuffled()
		{
			var list1 = Models.DanceInfoRepository.Sliders.ToList();
			var list2 = Models.DanceInfoRepository.Sliders.ToList();

			list1.RandomPermutation().ShouldNotBe(list2);
		}
	}
}
