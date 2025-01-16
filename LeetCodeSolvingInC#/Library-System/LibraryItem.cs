using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolvingInC_.Library_System
{
    internal class LibraryItem
    {
        // • A unique identifier for the item
        public int ItemId { get; set; }

        // • A property to track the availability of the item.
        public bool IsAvailable { get; set; }

        // • A method void CheckOut() to mark the item as unavailable.
        public void CheckOut()
        {
            this.IsAvailable = false;
        }

        // • A method void ReturnItem() to mark the item as available.
        public void ReturnItem()
        {
            this.IsAvailable = true;
        }

        public LibraryItem() {
            Random random = new Random();
            this.ItemId = random.Next(1000, 10000);
            this.IsAvailable = true;
        }
    }
}
