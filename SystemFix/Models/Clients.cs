using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemFix
{
    //Clase global para el almacenamiento de clientes 
    public class Clients
    {
        //Se definen las propiedades de la clase 
        public string Name { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string TempPay { get; set; }
        public string Mark { get; set; }
        public string Reference { get; set; }
        public string Details { get; set; }
        public string Type_Device { get; set; }


        public Clients(string name, string lastname, string id, string phone, string address, string tempay, string mark, string reference, string details, string type_device)
        {
            Name = name;
            LastName = lastname;
            ID = id;
            Phone = phone;
            Address = address;
            TempPay = tempay;
            Mark = mark;
            Reference = reference;
            Details = details;
            Type_Device = type_device;


        }
           
    }
}
