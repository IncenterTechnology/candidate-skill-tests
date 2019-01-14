namespace Test.Models
{
	public class Meat : Food
	{
		public Meat() : base(FoodType.Meat) { }
		public override int Calories => 960;
	}
}
