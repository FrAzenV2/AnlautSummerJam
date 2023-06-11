using System.Collections.Generic;
using ItemDispensers;
using NpcWorker;
using UnityEngine;

namespace Core
{
    public class LocationInteractables : MonoBehaviour
    {
        [field: SerializeField] public List<NpcWorkerView> NpcWorkerViews { get; private set; }
        [field: SerializeField] public List<ItemDispenserView> ItemDispenserViews { get; private set; }
    }
}