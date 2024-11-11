using System.ComponentModel.DataAnnotations;
using DotNet.godis;

namespace DotNet.produkt;

public class Produkt
{   
    public Bilar bil  { get; set;}

    public Godis godis{ get; set;}

    public Rör rör{ get; set;}

    public Havremjölk havremjölk1{ get; set;}

public Produkt( Bilar bil){
   
   this.bil = bil;
}

public Produkt(Godis godis){
   
   this.godis = godis;
}
public Produkt(Rör rör){
   
   this.rör = rör;
}
public Produkt(Havremjölk havremjölk){
   
   this.havremjölk1 = havremjölk;
}
public string produktInfo(){
if(bil != null){
return this.bil.bilInfo();
}
if(godis != null){
return this.godis.godisInfo();
}
if(rör != null){
return this.rör.rörInfo();
}
if(havremjölk1 != null){
return this.havremjölk1.havremjölkInfo();
}
else{
    return "inga produkter finns..";
}
}



}
