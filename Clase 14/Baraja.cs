using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseBaraja{
    

public class Baraja { 

    
    List<int, string> mazo = new List<int, string>();
    List<int, string> mazoBarajado = new List<int, string>();
    private List<string> _palos = new List<String> {"Basto", "Copa", "Espada", "Oro"}; 
    

    public Baraja(){
        for (int i = 1; i <= 12; i++){
            if ((i != 8) || (i != 9))
                foreach(String palo in _palos){
                    mazo.Add(i,palo);
            }
        }
    }

    public void Barajar(){
        foreach (Baraja carta in mazo){
            var carta = new Random();
            var num = carta.Next(mazo.Count);
            mazoBarajado.Add(mazo[num]);
            mazo.RemoveAt(num);
        }                               
    }

    public void siguienteCarta(){ 
        if (mazo.Count = 0)
           Console.WriteLine ("No hay mas cartas");
        else
            Console.WriteLine(mazo.First());    
    }

    public void cartasDisponibles (){
    }

    public void darCartas(){

    } 

    public void cartasMonton(){

    }

    public void mostrarBaraja(){

    }

}
}