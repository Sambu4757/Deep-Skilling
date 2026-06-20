using System;

class Program
{
    static void Main()
    {
        Computer gamingPC = new Computer.Builder()
                                .SetCPU("Intel i9")
                                .SetRAM(32)
                                .SetStorage(1024)
                                .SetGraphicsCard("RTX 4090")
                                .Build();

        Computer officePC = new Computer.Builder()
                                .SetCPU("Intel i5")
                                .SetRAM(8)
                                .SetStorage(256)
                                .SetGraphicsCard("Integrated")
                                .Build();

        gamingPC.Display();
        officePC.Display();
    }
}