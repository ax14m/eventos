using System;


namespace eventos
{
    class Dpelota : deporte
    {


 string ndeporte;
    public string nombreDepor {
        get{return ndeporte;} 
        
        set{
            string nomdeporte = value;
            switch(nomdeporte)
            {
                case "Futbol":
                    ndeporte = nomdeporte;
                    break;
                case "Beisbol":
                    ndeporte = nomdeporte;
                    break;    
                case "Baloncesto":
                    ndeporte = nomdeporte;
                    break;    
                case "Bolos":
                    ndeporte =nomdeporte;
                    break;  
                case "Ping Pong":
                    ndeporte = nomdeporte;
                    break;
                case "Voleibol":
                    ndeporte = nomdeporte;
                    break; 
                    default:
                    Console.WriteLine($"Deporte no existe, por favor verificar") ; 
                    break;       
            }

        }
        
     }
   
 
   
    }
 }

