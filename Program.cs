namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q5 Part1
            //BaseClass B1 = new DerivedCalass();
            //BaseClass B2 = new DerivedCalass2();
            //B1.DisplayMessage();
            //B2.DisplayMessage();
            #endregion
            #region Q5 Part2
            Duration d = new Duration(1, 10, 15);
            //Console.WriteLine( d.ToString());
            //Duration d =new Duration(3600);
            // Console.WriteLine($"{d.ToString()}" );
            Duration D1 = new Duration(1, 10, 15);
            D1.ToString();
            Duration D4 = new Duration(3600);
            D4.ToString();
            Duration D2 = new Duration(7800);
            D2.ToString();
            Duration D3 = new Duration(666);
            D3.ToString();

            D3 = D1 + D2;
            D3 = D1 + 7800;
            D3 = 666 + D3;
        	D3 = ++D1;
        	D3 = --D2;
        	D1 = D1 - D2;
            Console.WriteLine( D1 > D2);
            Console.WriteLine( D1 <= D2);
        	
        	DateTime Obj = (DateTime)D1;


            #endregion
        }
    }
}
