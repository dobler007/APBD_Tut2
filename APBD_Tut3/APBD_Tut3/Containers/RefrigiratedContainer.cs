using System;
using System.Collections;

namespace APBD_Tut3.Containers
{
    public class RefrigeratedContainer : Container
    {
        private ArrayList Fridge { get; } = new ArrayList();

        public RefrigeratedContainer(int cargoMass, int height, int tareWeight, int depth, int capacity)
            : base(cargoMass, height, tareWeight, depth, capacity)
        {
            FillContainerWithRandomProducts();
        }

        private void FillContainerWithRandomProducts()
        {
            string[] PredefinedProducts = {
                "Apples", "Bananas", "Oranges", "Grapes", "Strawberries",
                "Lettuce", "Tomatoes", "Cucumbers", "Carrots", "Broccoli"
            };

            Random rnd = new Random();
            for (int i = 0; i < Capacity; i++)
            {
                string randomProduct = PredefinedProducts[rnd.Next(PredefinedProducts.Length)];
                Fridge.Add(randomProduct);
            }
        }
    }
}