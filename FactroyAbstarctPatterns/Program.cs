namespace FactroyAbstarctPatterns
{
    

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


    public interface IFurniture
    {

        public IChair Chair { get; }
        public ISofa Sofa { get; }
        public ICofeeTable Coffeetable { get; }
    }




    public class VictorianFurniture : IFurniture
    {
        public IChair Chair => new ChairVictorina();

        public ISofa Sofa => new SofaVictorina();

        public ICofeeTable Coffeetable =>new CoffeeTableVictorina();
    }


    public class ModernFurniture : IFurniture
    {
        public IChair Chair => new ChairModern();

        public ISofa Sofa => new SofaModern();

        public ICofeeTable Coffeetable => new CoffeeTableModern();
    }



 
}