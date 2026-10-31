namespace Module10.HW
{
    public class Food // Public class defining a Food object
    {
        // Fields store the data belonging to each Food object
        int foodId; // integer field
        string foodName, foodDescription; // string fields
        double foodCost; // double field

        // // Public properties allow reading (getters) and changing (setters) private field values
        public int FoodId
        {
            get { return foodId; }
            set { foodId = value; }
        }

        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; }
        }
        public string FoodDescription
        {
            get { return foodDescription; }
            set { foodDescription = value; }
        }
        public double FoodCost
        {
            get { return foodCost; }
            set { foodCost = value; }
        }

        // could make a method to display class from here

        // notes for MAC - constructor initializes a new object/instance
    }
}
