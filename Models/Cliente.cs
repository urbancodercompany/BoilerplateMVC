using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

/*
    The main Client class
    Contains all property for the client structure
*/

/// <summary>
/// Model of Client.
/// </summary>
/// <returns>
/// Model of client.
/// </returns>

namespace BoilerplateMVC.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [DisplayName("Nombre")]
        public string Firstname { get; set; }

        [DisplayName("Apelido")]
        public string Lastname { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Fecha de nacimiento")]
        public DateTime Birthdate { get; set; }

        [DisplayName("Teléfono")]
        public string phone { get; set; }

        [DisplayName("Nº Exterior")]
        public string numeroExterior { get; set; }

        [DisplayName("Nº Interior")]
        public string numeroInterior { get; set; }

        [DisplayName("Calle")]
        public string Street { get; set; }

        [DisplayName("Colonia")]
        public string Neighborhood { get; set; }

        [DisplayName("Delegación o Municipio")]
        public string District { get; set; }

        [DisplayName("Código Postal")]
        public string CP { get; set; }

        [DisplayName("País")]
        public string Country { get; set; }
    }
}