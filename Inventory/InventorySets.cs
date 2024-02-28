namespace WeekSix
{
    public class InventorySets
    {
        public static void Inventory(List<Item> itemList, List<Sales> salesList)
        {
            itemList = new List<Item>
            {
                new Item { ItemId = 1, ItemDes = "Bag" },
                new Item { ItemId = 2, ItemDes = "Pen" },
                new Item { ItemId = 3, ItemDes = "Book" },
                new Item { ItemId = 4, ItemDes = "Shoe" },
                new Item { ItemId = 5, ItemDes = "Pin" }
            };

            salesList = new List<Sales>
            {
                new Sales { InvNo = 1, ItemId = 3, Qty = 10 },
                new Sales { InvNo = 2, ItemId = 2, Qty = 20 },
                new Sales { InvNo = 3, ItemId = 3, Qty = 500 },
                new Sales { InvNo = 4, ItemId = 4, Qty = 20 },
                new Sales { InvNo = 5, ItemId = 3, Qty = 100 },
                new Sales { InvNo = 6, ItemId = 1, Qty = 50 }
            };

            var query = from item in itemList
                        join sale in salesList on item.ItemId equals sale.ItemId
                        select new
                        {
                            ItemId = item.ItemId,
                            ItemName = item.ItemDes,
                            Quantity = sale.Qty
                        };

            Console.WriteLine("Item ID\tItem Name\tQuantity");
            Console.WriteLine("----------------------------------");
            foreach (var item in query.Distinct())
            {
                Console.WriteLine($"{item.ItemId}\t{item.ItemName}\t{item.Quantity}");
            }
        }
    }
}


