﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMain
{
    public class Calculadora
    {
        private List<string> listahistorico;

        public Calculadora()
        {
            listahistorico = new List<string>();
        }


        public int somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            listahistorico.Insert(0, $"Result: {resultado}");
            return resultado;
        }
        public int subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            listahistorico.Insert(0, $"Result: {resultado}");
            return resultado;
        }
        public int multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            listahistorico.Insert(0, $"Result: {resultado}");
            return resultado;
        }
        public int dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            listahistorico.Insert(0, $"Result: {resultado}");
            return resultado;
        }

        public List<string> historico()
        {
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }
    }
}
