﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Guilherme.Hotel.Project.Models
{
    // É possível adicionar dados do perfil do usuário adicionando mais propriedades na sua classe ApplicationUser, visite https://go.microsoft.com/fwlink/?LinkID=317594 para obter mais informações.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Observe que o authenticationType deve corresponder àquele definido em CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Adicionar declarações de usuário personalizado aqui
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: true)
        {
        }

        public DbSet<Pessoas> Pessoas { get; set; }
        public DbSet<Relatorios>  Relatorios  { get; set; }
        public DbSet<Telefones>  Telefones { get; set; }
        public DbSet<ManutencaoServicos>  ManutencaoServicos { get; set; }
        public DbSet<Quartos>  Quartos   { get; set; }
        public DbSet<Hospedes>  Hospedes { get; set; }
        public DbSet<Servicos>  Servicos { get; set; }
        public DbSet<Funcionarios> Funcionarios  { get; set; }
        public DbSet<Terceirizados>  Terceirizados  { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}  