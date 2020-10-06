
using System;

namespace eventos
{
    class deporte

{
//propiedades
 public string categoria { get; set;}




  public string nequipo { get; set;}
//concatenar propiedades marca -serie

short cjugadores;
        public short Cjugadores { 
            get
            {
                return Cjugadores;
            }
            set
            {
                if (value > 1 && value < 30)
                {
                    cjugadores = value;
                }
                else
                {
                    Console.WriteLine("numero de jugadores no valido");
                }                
            }
        }


string placa;  //variable local
 public string Placa { 
     
     get{

         return placa;
     }
     
      set
      {
            if(value.Length == 6)
            {
                placa = value;
            }else
            {
                Console.WriteLine("la placa debe de ser 6 digitos");
            }

      }
     
     
     }

//metodos

protected string Ruta {get; set;}
public void prender()
{
Console.WriteLine("El vehiculo esta prendiendo");

}

        public override bool Equals(object obj)
        {
            return obj is deporte deporte &&
                   cjugadores == deporte.cjugadores;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}