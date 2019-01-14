namespace Test.Models
{
	public class Vegetable : Food
	{
		public Vegetable() : base(FoodType.Vegetable) { }
		public override int Calories => 280;
	}
}
