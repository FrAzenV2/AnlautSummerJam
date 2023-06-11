using Quests;

namespace NpcWorker
{
    public class NpcWorkerModel
    {
        public NpcWorkerModel(NpcWorkerView view)
        {
            View = view;
        }
        public float CurrentStamina = 100;
        public NpcWorkerView View { get; }
        
        public QuestModel CurrentQuest { get; set; }

    }
}