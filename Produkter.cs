
using DotNet.produkt;

namespace DotNet.produkter;

public class Produkter
{
public List<Produkt> produkterList {get; set;}

public Produkter(){
    produkterList = new List<Produkt>();
}
public void addTask(Produkt produkt){ 
    
    produkterList.Add(produkt);}

    
}

