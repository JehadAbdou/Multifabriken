using System;

namespace DotNet;

public class Rör
{

     public double längd;
    public double diameter;
    

public Rör(double längd, double diameter){
this.längd = längd;
this.diameter = diameter;

}

public string rörInfo(){

    return "Rör med längd "+ this.längd+" m och diameter "+ this.diameter+" m";
}
}
