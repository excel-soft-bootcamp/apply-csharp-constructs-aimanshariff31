using System;
using System.Collections.Generic;
using System.Text;

namespace EngineApp
{
    public class TataCarEngine
    {
        Iengine _engine;

        public TataCarEngine(Iengine engine)
        {

            this._engine = engine;
        }

        public void Drive()
        {

            _engine.Start();
        }
        public void Halt()
        {

            _engine.Stop();
        }


    }
    public interface Iengine
    {
        void Start();
        void Stop();
    }

    public class DiCorEngine : Iengine
    {

        public void Start() { }
        public void Stop() { }
    }

    public class VeriCorEngine : Iengine
    {

        public void Start() { }
        public void Stop() { }
    }

    public class MultiJetEngine : Iengine
    {

        public void Start() { }
        public void Stop() { }

    }
    public class RevorTron : Iengine
    {

        public void Start() { }
        public void Stop() { }
    }

}
