namespace LP1Exercises
{
    public abstract class Character
    {
        // Property readonly
        public string Name { get; }

        // Method that chooses a direction
        public abstract char Move();
    }
}
