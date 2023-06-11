namespace ItemDispensers
{
    public class ItemDispenserModel
    {
        public ItemDispenserModel(ItemDispenserView view)
        {
            View = view;
        }
        public ItemDispenserView View { get; }
    }
}