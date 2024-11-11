using System;

namespace DotNet.godis;

public class Godis
{
     public int antal;
    public string smak;
    

public Godis(int antal, string smak){
this.antal = antal;
this.smak = smak;

}

public string godisInfo(){

    return "Godis med smak "+ this.smak+" och antal "+ this.antal+"...";
}

}
