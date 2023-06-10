using System.Collections.Generic;

namespace Common
{
    public class CompositeUpdater : IFrameUpdater, IFixedUpdater
    {
        private readonly List<IFrameUpdater> _frameUpdaters;
        private readonly List<IFixedUpdater> _fixedUpdaters;

        public CompositeUpdater(List<IFrameUpdater> frameUpdaters, List<IFixedUpdater> fixedUpdaters)
        {
            _frameUpdaters = frameUpdaters;
            _fixedUpdaters = fixedUpdaters;
        }
        
        public void Update()
        {
            foreach (var frameUpdater in _frameUpdaters)
            {
                frameUpdater.Update();
            }
        }
        public void FixedUpdate()
        {
            foreach (var fixedUpdater in _fixedUpdaters)
            {
                fixedUpdater.FixedUpdate();
            }
        }
    }
}