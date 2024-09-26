namespace TreMandsGruppe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;  
            int b = 2;
            int c = a * b;
           
            
            Console.WriteLine("Hello, World! " + a + " * " + b + " = " + c);

            Peters_Class peters = new Peters_Class();
            peters.see_mee();

            Doggo doggo = new Doggo();
            doggo.name = "Fido";
            doggo.race = "chihuahua";
            doggo.PetDogg();

        }
    }
}
