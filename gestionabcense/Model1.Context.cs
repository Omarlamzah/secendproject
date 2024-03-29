﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gestionabcense
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class gestionabsenceEntities : DbContext
    {
        public gestionabsenceEntities()
            : base("name=gestionabsenceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<fonction> fonctions { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<usere> useres { get; set; }
        public virtual DbSet<Decision> Decisions { get; set; }
        public virtual DbSet<detaille_abs> detaille_abs { get; set; }
        public virtual DbSet<absence> absences { get; set; }
    
        public virtual int virifiePROC(string ppr, Nullable<System.DateTime> dateabse, ObjectParameter nab)
        {
            var pprParameter = ppr != null ?
                new ObjectParameter("ppr", ppr) :
                new ObjectParameter("ppr", typeof(string));
    
            var dateabseParameter = dateabse.HasValue ?
                new ObjectParameter("dateabse", dateabse) :
                new ObjectParameter("dateabse", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("virifiePROC", pprParameter, dateabseParameter, nab);
        }
    
        public virtual int virifieppr(string ppr, ObjectParameter nab)
        {
            var pprParameter = ppr != null ?
                new ObjectParameter("ppr", ppr) :
                new ObjectParameter("ppr", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("virifieppr", pprParameter, nab);
        }
    
        public virtual int testuser(string u, Nullable<int> p, ObjectParameter existc)
        {
            var uParameter = u != null ?
                new ObjectParameter("u", u) :
                new ObjectParameter("u", typeof(string));
    
            var pParameter = p.HasValue ?
                new ObjectParameter("p", p) :
                new ObjectParameter("p", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("testuser", uParameter, pParameter, existc);
        }
    
        public virtual int ifuserisADMIN(string u, Nullable<int> p, ObjectParameter existc)
        {
            var uParameter = u != null ?
                new ObjectParameter("u", u) :
                new ObjectParameter("u", typeof(string));
    
            var pParameter = p.HasValue ?
                new ObjectParameter("p", p) :
                new ObjectParameter("p", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ifuserisADMIN", uParameter, pParameter, existc);
        }
    }
}
