public class DicDemo{
    private Dictionary<string,Persona> person = new Dictionary<string,Persona>();

    public void Additem(string id, Persona person){
        this.person.Add(id, person);
    }
    public void Viewdata(){

    }
     public void Viewdata(int opcion){
        switch(opcion){

            case 0:
                Dictionary<string,Persona>.KeyCollection keys = this.person.Keys;
                foreach(string key in keys){
                    Console.WriteLine("{0}",key);
                }
                break;
            case 1:
                 Dictionary<string,Persona>.ValueCollection Valor = this.person.Values;

                 foreach(Persona p in Valor){
                    Persona p2 = p;
                    Console.WriteLine("{0}",p2.Id);
                    Console.WriteLine("{0}",p2.Name);
                    Console.WriteLine("{0}",p2.Email);
                    
                 }
                break;
            case 2:
                foreach(KeyValuePair<string,Persona> par in person){
                    Console.WriteLine("{0} - {1}",par.Key , par.Value.Name);
                }
                break;    
            case 3:
            break;
        }
    }
}