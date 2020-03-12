using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Cooperativa
{
    public class DepositosBL
    {
        Contexto _contexto;
        public BindingList<Deposito> ListaDepositos { get; set; }

        public DepositosBL()
        {
            _contexto = new Contexto(); 
            ListaDepositos = new BindingList<Deposito>();
        }
        
        public BindingList<Deposito> ObtenerDepositos()
        {
            _contexto.Depositos.Load();
            ListaDepositos = _contexto.Depositos.Local.ToBindingList();      
            return ListaDepositos; 

        }
        public Resultado GuardarDeposito(Deposito deposito)
        {
            var resultado = Validar(deposito);
            if (resultado.Existoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();  

            resultado.Existoso = true;
            return resultado;
        }

        public void AgregarDeposito()
        {
            var nuevoDeposito = new Deposito();
            ListaDepositos.Add(nuevoDeposito);
        }

        public bool EliminarDeposito(int id)
        {
            foreach (var deposito in ListaDepositos)
            {
                if (deposito.Id == id)

                {
                    ListaDepositos.Remove(deposito);
                    _contexto.SaveChanges();  
                    return true;
                }
            }

            return false;
        }

        private Resultado Validar(Deposito deposito)
        {
            var resultado = new Resultado();
            resultado.Existoso = true;

            if (string.IsNullOrEmpty(deposito.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese su nombre";
                resultado.Existoso = false;
            }

            if (deposito.Ncuenta < 0) 
            {
                resultado.Mensaje = "Ingrese el numero de cuenta";
                resultado.Existoso = false;
            }

            if (deposito.Cantidad < 0)
            {
                resultado.Mensaje = "La cantidad debe de ser mayor que CERO";
                resultado.Existoso = false;
            }

            return resultado;
        }
    }

    public class Deposito
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Cantidad { get; set; }
        public int Ncuenta { get; set; }
        public bool Tcuenta { get; set; }
    }


    public class Resultado
    {
        public bool Existoso { get; set; }
        public string Mensaje { get; set; }
    }
}
