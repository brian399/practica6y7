/*
 * Created by SharpDevelop.
 * User: REDE
 * Date: 03/12/2013
 * Time: 07:51 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica7
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Alumnos alumnos = new Alumnos();
			string opc;
			do{
				Console.Clear();
				Console.WriteLine (
				                   "1.- Mostrar todo\n" +
				                   "2.- Agregar Nuevo Registro\n" +
				                   "3.- Editar Registro\n" +
				                   "4.- Eliminar Registro\n" +
				                   "5.- Salir");
				opc = Console.ReadLine();
				switch(opc){
					case "1":
						Console.Clear();
						alumnos.mostrarTodos();
						Console.ReadKey(true);
						break;
					case "2":
						Console.Clear();
						alumnos.insertarRegistroNuevo();
						Console.ReadKey(true);
						break;
					case "3":
						Console.Clear();
						alumnos.editarRegistro();
						break;
					case "4":
						Console.Clear();
						alumnos.eliminarRegistroPorId();
						break;
					case "5":
						Console.Clear();
						Console.Write("Press any key to continue . . . ");
						Console.ReadKey(true);
						break;
					default:
						Console.Clear();
						Console.WriteLine("Opcion incorrecta");
						Console.ReadKey(true);
						break;
				}
			}while(opc != "5");
		}
	}
}