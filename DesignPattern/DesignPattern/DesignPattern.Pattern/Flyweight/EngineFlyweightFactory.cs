using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern.Flyweight
{
    public class EngineFlyweightFactory
    {
        private Dictionary<int, IEngine> standardEnginePool;
        private Dictionary<int, IEngine> turboEnginePool;

        public EngineFlyweightFactory()
        {
            standardEnginePool = new Dictionary<int, IEngine>();
            turboEnginePool = new Dictionary<int, IEngine>();
        }

        public IEngine GetStandardEngine(int size)
        {
            IEngine e;

            if (!standardEnginePool.TryGetValue(size, out e))
            {
                e = new StandardEngine(size);
                standardEnginePool.Add(size, e);
            }
            return e;
        }
        public IEngine GetTurboEngine(int size)
        {
            IEngine e;

            if (!turboEnginePool.TryGetValue(size, out e))
            {
                e = new TurboEngine(size);
                turboEnginePool.Add(size, e);
            }
            return e;
        }
    }
}
