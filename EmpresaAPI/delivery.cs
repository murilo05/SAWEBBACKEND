//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmpresaAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class delivery
    {
        public int id { get; set; }
        public string Telefone { get; set; }
        public string Nome { get; set; }
        public string Logradouro { get; set; }
        public string Número { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string entregador { get; set; }
        public Nullable<bool> finalizada { get; set; }
    }
}
