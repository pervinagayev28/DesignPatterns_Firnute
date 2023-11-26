namespace FactroyAbstarctPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var chair = new ChairModern();
            var sofa = new SofaModern();
            var coffeetable = new CoffeeTableModern();
            Furniture furniture = new(chair, sofa, coffeetable);

        }
    }


    // ***** furnute interfaces ********
    public interface IChair
    {
        IChair creatChair();
    }
    public interface ISofa
    {
        ISofa creatSofa();
    }
    public interface ICofeeTable
    {
        ICofeeTable creatCofeeTable();
    }

    // ***** Chair Concret classes ********

    public class ChairModern : IChair
    {
        public IChair creatChair() =>
            new ChairModern();
    }


    public class ChairVictorina : IChair
    {
        public IChair creatChair() =>
            new ChairVictorina();
    }

    // ***** Sofa Concret classes ********

    public class SofaModern : ISofa
    {
        public ISofa creatSofa() =>
            new SofaModern();
    }


    public class SofaVictorina : ISofa
    {
        public ISofa creatSofa() =>
            new SofaVictorina();
    }

    // ***** CofeeTable Concret classes ********


    public class CoffeeTableModern : ICofeeTable
    {
        public ICofeeTable creatCofeeTable() =>
            new CoffeeTableModern();
    }
    public class CoffeeTableVictorina : ICofeeTable
    {
        public ICofeeTable creatCofeeTable() =>
            new CoffeeTableVictorina();
    }


    public class Furniture
    {
        public Furniture(IChair chair, ISofa sofa, ICofeeTable coffeetable)
        {
            Chair = chair;
            Sofa = sofa;
            Coffeetable = coffeetable;
            //some......

        }

        public IChair Chair { get; }
        public ISofa Sofa { get; }
        public ICofeeTable Coffeetable { get; }
    }




}