using System;

namespace InventoryLibrary
{
    public class Inventory : BaseClass
    {
        public string UserId { get; set; }
        public string ItemId { get; set; }
        public int Quantity { get; set; } = 1;

        public Inventory(string userId, string itemId, int quantity)
        {
            if (string.IsNullOrWhiteSpace(userId))
            {
                throw new ArgumentException("User ID is required.");
            }
            if (string.IsNullOrWhiteSpace(itemId))
            {
                throw new ArgumentException("Item ID is required.");
            }
            if (quantity < 0)
            {
                throw new ArgumentException("Quantity cannot be less than 0.");
            }

            UserId = userId;
            ItemId = itemId;
            Quantity = quantity;
        }
    }
}
