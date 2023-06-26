internal class Program
{
    private static void Main(string[] args)
    {
        Persona person = new Persona();
       DicDemo dicc = new DicDemo();
       Console.Clear();
       Console.WriteLine("ingrese el nombre :");
       person.Name = Console.ReadLine();
       Console.WriteLine("ingrese el email :");
        person.Email = Console.ReadLine();
        person.Dateregistered  = DateTime.UtcNow;

        dicc.Additem(person.Id ?? "0", person);
        dicc.Viewdata(0);
        dicc.Viewdata(1);
    }

}
