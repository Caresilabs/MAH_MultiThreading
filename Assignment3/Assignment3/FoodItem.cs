
namespace Assignment3
{
    /// <summary>
    /// A database model for our products.
    /// </summary>
    public class FoodItem
    {
        public string Name { get; private set; }

        public float Weight { get; private set; }

        public float Volume { get; private set; }

        public FoodItem(string name, float weight, float volume)
        {
            this.Name = name;
            this.Weight = weight;
            this.Volume = volume;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
