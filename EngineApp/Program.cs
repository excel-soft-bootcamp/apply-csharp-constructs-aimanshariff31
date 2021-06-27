using System;

namespace EngineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DiCorEngine _harrier = new DiCorEngine();
            TataCarEngine Harrier = new TataCarEngine(_harrier);
            Harrier.Drive();
            Harrier.Halt();
            VeriCorEngine _nexon = new VeriCorEngine();
            TataCarEngine Nexon = new TataCarEngine(_nexon);
            Nexon.Drive();
            Nexon.Halt();
            MultiJetEngine _hexa = new MultiJetEngine();
            TataCarEngine Hexa = new TataCarEngine(_hexa);
            Hexa.Drive();
            Hexa.Halt();
            DiCorEngine _safari = new DiCorEngine();
            TataCarEngine Safari = new TataCarEngine(_safari);
            Safari.Drive();
            Safari.Halt();



        }
    }
}
