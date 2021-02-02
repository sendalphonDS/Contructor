using System;
using System.Collections.Generic;

namespace Tatarea02
{
    class program
    {
        static void Main(string[] args)
        {
            //var cliente = new Cliente();
            DateTime FechaConHora = new DateTime(1995, 4, 29, 9, 30, 45);
            DateTime FechaConHora1 = new DateTime(1994, 4, 29, 9, 30, 45);
            DateTime FechaConHora2 = new DateTime(1996, 4, 29, 9, 30, 45);
            DateTime FechaConHora3 = new DateTime(1997, 4, 29, 9, 30, 45);
            DateTime FechaConHora4 = new DateTime(1998, 4, 29, 9, 30, 45);
            List<string> Telefonos = new List<string>();
            string n = "0";
            string r = "0";

            Telefonos.Add("22");
            Telefonos.Add("22");
            Telefonos.Add("22");
            Telefonos.Add("22");
            Telefonos.Add("22");

            for (n = "0"; n < Telefonos.length; n++)
            {
                r = Telefonos[n];
                Console.WriteLine(r);
            }
            Console.WriteLine("-------");


            //cliente.Dni = "924623";
            // cliente.Nombre = "arturo";
            // cliente.ApellidoPaterno = "maqui";
            //cliente.ApellidoMaterno = "victoriano";
            //cliente.Edad = 26;
            //cliente.Telefono = "26425";

            //Console.WriteLine(
            // $"nombre de la persona: \n" +
            // $" {cliente.Nombre} \n" +
            //$" {cliente.ApellidoPaterno} \n" +
            // $" {cliente.ApellidoMaterno} \n");

            //  Console.WriteLine($"Fecha de nacimiento: { FechaConHora.ToString()} y su DNI es: {cliente.Dni}");
            // Console.Read();
            var cliente = new Cliente("265842", "marco", "Moreno", "val", 25, "253646");
            var cliente1 = new Cliente("251252", "jose", "marko", "valdi", 26, "252456");
            var cliente2 = new Cliente("255251", "siel", "kotoko", "mikaha", 23, "256478");
            var cliente3 = new Cliente("2512551", "asmo", "shin", "kagome", 24, "586146");
            var cliente4 = new Cliente("52222", "sendalphon", "megumin", "ardi", 27, "264786");
            

            Console.WriteLine(
            $"nombre de la persona: \n" +
            $" {cliente.Nombre} \n" +
            $" {cliente.ApellidoPaterno} \n" +
            $" {cliente.ApellidoMaterno} \n");


            Console.WriteLine($"Fecha de nacimiento: { FechaConHora.ToString()} y su DNI es: {cliente.Dni}");

            Console.WriteLine(
        $"nombre de la persona: \n" +
        $" {cliente1.Nombre} \n" +
        $" {cliente1.ApellidoPaterno} \n" +
        $" {cliente1.ApellidoMaterno} \n");

            Console.WriteLine($"Fecha de nacimiento: { FechaConHora1.ToString()} y su DNI es: {cliente.Dni}");


            Console.WriteLine(
    $"nombre de la persona: \n" +
    $" {cliente2.Nombre} \n" +
    $" {cliente2.ApellidoPaterno} \n" +
    $" {cliente2.ApellidoMaterno} \n");


            Console.WriteLine($"Fecha de nacimiento: { FechaConHora2.ToString()} y su DNI es: {cliente2.Dni}");


            Console.WriteLine(
    $"nombre de la persona: \n" +
    $" {cliente3.Nombre} \n" +
    $" {cliente3.ApellidoPaterno} \n" +
    $" {cliente3.ApellidoMaterno} \n");

            Console.WriteLine($"Fecha de nacimiento: { FechaConHora3.ToString()} y su DNI es: {cliente3.Dni}");

            Console.WriteLine(
  $"nombre de la persona: \n" +
  $" {cliente4.Nombre} \n" +
  $" {cliente4.ApellidoPaterno} \n" +
  $" {cliente4.ApellidoMaterno} \n");

            Console.WriteLine($"Fecha de nacimiento: { FechaConHora4.ToString()} y su DNI es: {cliente4.Dni}");
            Console.Read();

        }

    }
    }


