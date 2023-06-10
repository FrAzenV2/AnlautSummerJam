using System.Collections.Generic;
using Items;

namespace Player.Models
{
    public class PlayerInventoryModel
    {
        public readonly List<ItemType> CurrentItems = new ();
    }
}