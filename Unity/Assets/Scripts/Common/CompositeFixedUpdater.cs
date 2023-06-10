using System.Collections.Generic;

namespace Common
{
    public class CompositeFixedUpdater : IFixedUpdater
    {
        private readonly List<IFixedUpdater> _fixedUpdaters;

        public CompositeFixedUpdater(List<IFixedUpdater> fixedUpdaters)
        {
            _fixedUpdaters = fixedUpdaters;

        }
        public void FixedUpdate()
        {
            foreach (var fixedUpdater in _fixedUpdaters) fixedUpdater.FixedUpdate();
        }
    }
}