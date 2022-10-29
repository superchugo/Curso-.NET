using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseBilletera{
    

public class Billetera { 

    Billetera billeteraAux = null;
    int billetesDe10;
    int billetesDe20;
    int billetesDe50;
    int billetesDe100;
    int billetesDe200;
    int billetesDe500;
    int billetesDe1000;

    public Billetera(int billete10, int billete20, int billete50, int billete100, int billete200, int billete500, int billete1000){
        billetesDe10 = billete10;
        billetesDe20 = billete20;
        billetesDe50 = billete50;
        billetesDe100 = billete100;
        billetesDe200 = billete200;
        billetesDe500 = billete500;
        billetesDe1000 = billete1000;
    }

    public decimal total(){
         return billetesDe10* 10 + billetesDe20 * 20 + billetesDe50 * 50 
                + billetesDe100 * 100 + billetesDe200 * 200 + billetesDe500 * 500 + billetesDe1000 * 1000;
    
    }

    public Billetera combinar(Billetera billetera){ 
        
        billeteraAux = new Billetera(this.billetesDe10 + billetera.billetesDe10,
                                    this.billetesDe20 + billetera.billetesDe20,
                                    this.billetesDe50 + billetera.billetesDe50,
                                    this.billetesDe100 + billetera.billetesDe100,
                                    this.billetesDe200 + billetera.billetesDe200,
                                    this.billetesDe500 + billetera.billetesDe500,
                                    this.billetesDe1000 + billetera.billetesDe1000);
        return billeteraAux;
    }

    public void vaciarBilletera (){
        billetesDe10 = 0;
        billetesDe20 = 0;
        billetesDe50 = 0;
        billetesDe100 = 0;
        billetesDe200 = 0;
        billetesDe500 = 0;
        billetesDe1000 = 0;
    }
 } 
}