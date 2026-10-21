namespace BlazingPizza.Data;

public static class SeedData
{
    public static void Initialize(PizzaStoreContext db)
    {
        var specials = new PizzaSpecial[]
        {
            new PizzaSpecial
            {
                Name = "Basic Cheese Pizza",
                Description = "Delicious pizza loaded with cheese",
                BasePrice = 9.99m,
                ImageUrl = "img/pizzas/cheese.jpg"
            },
            new PizzaSpecial
            {
                Name = "The Baconatorizor",
                Description = "A pizza packed with bacon",
                BasePrice = 11.99m,
                ImageUrl = "img/pizzas/bacon.jpg"
            },
            new PizzaSpecial
            {
                Name = "Classic pepperoni",
                Description = "The classic pepperoni pizza",
                BasePrice = 10.50m,
                ImageUrl = "img/pizzas/pepperoni.jpg"
            },
            new PizzaSpecial
            {
                Name = "Buffalo chicken",
                Description = "Spicy chicken with hot sauce",
                BasePrice = 12.75m,
                ImageUrl = "img/pizzas/meaty.jpg"
            },
            new PizzaSpecial
            {
                Name = "Mushroom Lovers",
                Description = "Loaded with mushrooms",
                BasePrice = 11.00m,
                ImageUrl = "img/pizzas/mushroom.jpg"
            },
            new PizzaSpecial
            {
                Name = "Veggie Delight",
                Description = "Fresh vegetables on pizza",
                BasePrice = 11.50m,
                ImageUrl = "img/pizzas/salad.jpg"
            },
            new PizzaSpecial
            {
                Name = "Margherita",
                Description = "Tomatoes, mozzarella and basil",
                BasePrice = 9.99m,
                ImageUrl = "img/pizzas/margherita.jpg"
            }
        };

        db.Specials.AddRange(specials);
        db.SaveChanges();
    }
}
