using System;
using System.Collections.Generic;
using UnityEngine;

namespace Items
{
    [CreateAssetMenu(fileName = "ItemDescriptions", menuName = "Configs/ItemDescriptions", order = 0)]
    public class ItemViewDescriptions : ScriptableObject, ISerializationCallbackReceiver
    {
        [field: SerializeField] private List<ItemDescription> _itemDescriptions = new();
        
        public Dictionary<ItemType, ItemDescription> ItemDescriptions { get; private set; }

        public void OnBeforeSerialize()
        {
        }
        
        public void OnAfterDeserialize()
        {
            ItemDescriptions = new Dictionary<ItemType, ItemDescription>();
            foreach (var itemDescription in _itemDescriptions)
            {
                ItemDescriptions.Add(itemDescription.ItemType, itemDescription);
            }
        }
    }

    [Serializable]
    public class ItemDescription
    {
        [field: SerializeField] public Sprite Icon { get; private set; }
        [field: SerializeField] public ItemType ItemType { get; private set;}
        
    }
}