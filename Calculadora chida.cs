/*
 * Created by SharpDevelop.
 * User: Jesus Bon
 * Date: 25/02/2015
 * Time: 08:23 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora {



class Program
	{
		static int Suma (  int a,   int b)
		{
			  int suma = a + b;
			return suma;
		}
		static  int Resta (  int a,   int b)
		{
			  int resta = a - b;
			return resta;
		}
		static   int Multiplicacion ( int a,   int b)
		{
			  int multiplicacion = a * b;
			return multiplicacion;
		}
		static   int Division (  int a,   int b)
		{
			 int division = a / b;
			return division;
				
		}
		
		static  double areacuadrado ( double c,  double d)
		{
			 double areacuadrado = c * d;
			return areacuadrado;
			
		}
		
		static  double areatriangulo ( double c,  double d)
		{
		double areatriangulo = c * d /2;			
		 return areatriangulo;
		}
		
		static  double  areacirculo ( double c, double d)
		{
			 double areacirculo = c * c * 3.1416;
			return areacirculo;
		}
		
		 static void Main(string[] args)
		{
		 	int a,b;
			double c,d;
			
     		Console.Write("Dame el primer valor: ");
            a =  int.Parse(Console.ReadLine());
            Console.Write("Dame el segundo valor: ");
            b =  int.Parse(Console.ReadLine());
            
            Console.Write("Ingresa el valor: ");
            c =  double.Parse(Console.ReadLine());
            Console.Write("Ingresa el siguiente valor: ");
            d =  double.Parse(Console.ReadLine());
            
            
            
            
        
            Console.Write("\n1º) Suma" + "\n2º) Resta" + "\n3º) Multiplicación" + "\n4º) División" +
                          "\n5º)Area cuadrada" + "\n6º)Area Triangulo" + "\n7º)Area Circulo");
            
            Console.Write("\n\nSelecciona una de las opción: 	");

                switch (Console.Read()) { 
                    case '1': Console.Write("\nSuma = " + Suma(a,b));
                    break; 
                    
                    case '2': Console.Write("Resta = " + Resta(a,b));
                    break; 
                    
                    case '3': Console.Write("Multiplicación = " + Multiplicacion(a,b));
                    break; 
                    
                    case '4': Console.Write("División = " + Division(a,b));
                    break;  
             		
            		case '5': Console.Write("Area Cuadrado = " + areacuadrado(c,d));
                    break; 
                    
                     case '6': Console.Write("Area Triangulo = " + areatriangulo(c,d));
                     break; 
                    
                     case '7': Console.Write("Area Circulo = " + areacirculo(c,d));
                     break; }
              		
            		
            
            Console.ReadKey();
          
		}
	}
}
