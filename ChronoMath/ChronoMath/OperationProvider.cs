using System;

namespace ChronoMath
{
    public class OperationProvider
    {

        public IOperation Provide(Random rand)
        {
            
            int opType = rand.Next(0,9);
            switch(opType)
            {
                case 0:
                    return new PlusNeuf(rand);
                    break;
                case 1:
                    return new MoinsNeuf(rand);
                    break;
                case 2:
                    return new PlusOnze(rand);
                    break;
                case 3:
                    return new MoinsOnze(rand);
                    break;
                case 4:
                    return new DoubleOp(rand);
                    break;
                case 5:
                    return new Moitie(rand);
                    break;
                case 6:
                    return new FoixDix(rand);
                    break;
                case 7:
                    return new FoixCent(rand);
                    break;
                case 8:
                    return new Multiplication(rand);
                    break;
                default:
                    return null;

            }
        }
    }
}
