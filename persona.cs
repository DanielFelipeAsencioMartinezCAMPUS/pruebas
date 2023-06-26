public class Persona{
    private string ? id;
    private string ? name;

    private string ? email;

    private DateTime dateregistered;
    
    public string? Id { get => id; set =>id =value; }

    public string? Name { get => name; set => name =value;}
    
    public string? Email { get => email; set => email = value; }
    public DateTime Dateregistered { get => dateregistered; set => dateregistered = value; }
    
    public Persona(){
        
    }

    public Persona(string name, string email, DateTime date){
        this.name = name;
        this.email = email;
    }

}