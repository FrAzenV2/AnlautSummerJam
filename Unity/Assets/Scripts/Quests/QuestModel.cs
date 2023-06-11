using Items;

namespace Quests
{
    public record QuestModel(float StartTs, float Duration, ItemType RequiredItem)
    {
        public float StartTs { get; } = StartTs;
        public float Duration { get;} = Duration;
        public ItemType RequiredItem { get; } = RequiredItem;
    }
}