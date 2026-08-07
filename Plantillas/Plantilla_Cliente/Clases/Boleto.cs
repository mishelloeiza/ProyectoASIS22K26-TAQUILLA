using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Inicio de código realizado por Carlos Andres Arriaza Lara 0901-23-13862 31/07/2026*/
namespace Plantilla_Cliente.Clases
{
    public class Boleto
    {
        int idBoleto;
        int idFuncion;
        int numero_boleto;
        int id_venta;
        string estado_boleto;
        public Boleto(int idBoleto, int idFuncion, int numero_boleto, int id_venta, string estado_boleto)
        {
            this.idBoleto = idBoleto;
            this.idFuncion = idFuncion;
            this.numero_boleto = numero_boleto;
            this.id_venta = id_venta;
            this.estado_boleto = estado_boleto;
        }
    }
    
    /*Fin del código de Carlos Andres Arriaza Lara 0901-23-13862 31/07/2026*/
}
