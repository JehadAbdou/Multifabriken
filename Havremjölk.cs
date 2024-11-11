using System;

namespace DotNet;

public class Havremjölk
{

    public double fetthalt;
    public double litermängd;
    

public Havremjölk(double fetthalt, double litermängd){
this.fetthalt = fetthalt;
this.litermängd = litermängd;

}

public string havremjölkInfo(){

    return "Havremjölk med fettahlt "+ this.fetthalt+" och litermängd "+ this.litermängd+" L";
}
}
