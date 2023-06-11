using System.Collections.Generic;
using System.Linq;
using ItemDispensers;
using NpcWorker;
using Player.Models;

namespace Core
{
    public class GameData
    {
        public GameData(LocationInteractables locationInteractables)
        {
            var workers = locationInteractables.NpcWorkerViews.Select(npcWorkerView => new NpcWorkerModel(npcWorkerView)).ToList();
            var dispensers = locationInteractables.ItemDispenserViews.Select(x => new ItemDispenserModel(x)).ToList();

            DispenserModels = dispensers;
            NpcWorkerModels = workers;
        }

        public IReadOnlyList<NpcWorkerModel> NpcWorkerModels { get; }
        public IReadOnlyList<ItemDispenserModel> DispenserModels { get; }

        public readonly PlayerMovementInput PlayerMovementInput = new();
    }
}