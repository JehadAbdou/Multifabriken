namespace DotNet;

public class Bilar
{
    public int regnummer;
    public string färg;
    public string bilmärke;

public Bilar(int regnummer, string färg, string bilmärke){
this.regnummer = regnummer;
this.färg = färg;
this.bilmärke = bilmärke;
}

public string bilInfo(){

    return "bil med reg nummer "+ this.regnummer+" och "+ this.färg+" färg, och "+ this.bilmärke+" märke";
}

}
