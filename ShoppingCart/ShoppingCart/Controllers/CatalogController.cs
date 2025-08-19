using Microsoft.AspNetCore.Mvc;
namespace ShoppingCart.Models;

[ApiController]
[Route("[controller]")]
public class CatalogController : ControllerBase
{
    // In-memory item
    private static readonly List<Item> Items = new()
    {
        new Item { Id = 1, Name = "Classic Mug", Category = "Mug", Description = "Ceramic mug with logo", Price = 199, ImageUrl = "/images/mug1.png", Colors = ["White", "Black"], IsAvailable = true },
        new Item { Id = 2, Name = "Travel Mug", Category = "Mug", Description = "Insulated travel mug", Price = 349, ImageUrl = "/images/mug2.png", Colors = ["Silver"], IsAvailable = true },

        new Item { Id = 3, Name = "Logo T-Shirt", Category = "TShirt", Description = "Cotton T-shirt with logo", Price = 499, ImageUrl = "/images/tshirt1.png", Sizes = ["S", "M", "L"], Colors = ["Blue", "White"], IsAvailable = true },
        new Item { Id = 4, Name = "Graphic Tee", Category = "TShirt", Description = "T-shirt with graphic print", Price = 599, ImageUrl = "/images/tshirt2.png", Sizes = ["M", "L", "XL"], Colors = ["Black"], IsAvailable = true },

        new Item { Id = 5, Name = "Snapback Cap", Category = "Cap", Description = "Adjustable snapback cap", Price = 299, ImageUrl = "/images/cap1.png", Sizes = ["One Size"], Colors = ["Red", "Black"], IsAvailable = true },
        new Item { Id = 6, Name = "Dad Hat", Category = "Cap", Description = "Classic dad hat", Price = 349, ImageUrl = "/images/cap2.png", Sizes = ["One Size"], Colors = ["Green"], IsAvailable = true }
    };

    [HttpGet("GetItems")]
    public IActionResult GetItems()
    {
        var availableItems = Items.Where(i => i.IsAvailable).ToList();
        return Ok(availableItems);
    }

    [HttpGet("GetItemDetails/{itemId}")]
    public IActionResult GetItemDetails(int itemId)
    {
        var item = Items.FirstOrDefault(i => i.Id == itemId);
        if (item == null) return NotFound();
        return Ok(item);
    }

  
}
