using System;
using System.Collections;

namespace APBD_Tut3.Containers
{
    public class RefrigeratedContainer : Container
    {
        // ArrayList to store cargo inside the container
        private ArrayList Fridge { get; } = new ArrayList();

        public RefrigeratedContainer(int cargoMass, int height, int tareWeight, int depth, int capacity)
            : base(cargoMass, height, tareWeight, depth, capacity)
        {
            // Fill the container with randomly selected predefined products
            FillContainerWithRandomProducts();
        }

        // Method to fill the container with random products
        private void FillContainerWithRandomProducts()
        {
            // Array to store predefined products
            string[] PredefinedProducts = {
                "Apples", "Bananas", "Oranges", "Grapes", "Strawberries",
                "Lettuce", "Tomatoes", "Cucumbers", "Carrots", "Broccoli"
            };

            Random rnd = new Random();
            for (int i = 0; i < Capacity; i++)
            {
                // Randomly select a product from the predefined products array
                string randomProduct = PredefinedProducts[rnd.Next(PredefinedProducts.Length)];
                // Add the random product to the fridge list
                Fridge.Add(randomProduct);
            }
        }
    }
}