using Items;
using UnityEngine;

namespace ItemDispensers
{
    public class ItemDispenserView : MonoBehaviour
    {
        [field: SerializeField] public ItemType Item { get; private set; }
        
        [SerializeField] private SpriteRenderer _dispenserItemIcon;
        [SerializeField] private GameObject _dispenserIconHolder;
        
        
        public void SetItemIcon(Sprite sprite)
        {
            _dispenserItemIcon.sprite = sprite;
        }

        public void SetActive(bool isActive)
        {
            _dispenserIconHolder.SetActive(isActive);
        }
    }
}