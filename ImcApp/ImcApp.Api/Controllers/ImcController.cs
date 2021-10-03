using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ImcApp.Api.Entities;
using ImcApp.Api.Controllers;

 /*Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a Objetos
    Nombre del Maestro: Chuc Uc Joel Ivan
    Nombre de la actividad: Actividad 1: IMC Masa Muscular
    Nombre del alumno: Jose Alejandro Vazquez Suaste
    Cuatrimestre: 4
    Grupo: A
    Parcial: 1
    */
namespace ImcApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImcController : ControllerBase
    {
         [HttpPost]
        public string MF(DATOS MASA)
        {    
            double Resultado;
            String Mensaje="";
            Resultado = (MASA.Peso / Math.Pow((MASA.Altura/100), 2));

      if(Resultado < 18.5)
            {
                Mensaje= "Usted tiene un peso menos de lo Normal";
            }
            else
            {
                if(Resultado>= 18.5  && Resultado <=24.9)
                {
                    Mensaje="Usted tiene un peso Normal";
                }
                else
                {
                    if(Resultado>=25.00 && Resultado <= 29.9)
                    {
                         Mensaje="Usted tiene un peso Alto";
                    }
                    else
                    {
                         Mensaje="Usted tiene Obesidad";
                    }
                }
            }
          return "Tu Masa: "+ Convert.ToString(Resultado)+"Tu peso es:"+ Mensaje;
        }
    } 
}