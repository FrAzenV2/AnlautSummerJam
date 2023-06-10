using System.Collections.Generic;

namespace Common
{
    public class CompositeFrameUpdater : IFrameUpdater
    {
        private readonly List<IFrameUpdater> _updaters;

        public CompositeFrameUpdater(List<IFrameUpdater> updaters)
        {
            _updaters = updaters;

        }

        public void Update()
        {
            foreach (var updater in _updaters) updater.Update();
        }
    }
}