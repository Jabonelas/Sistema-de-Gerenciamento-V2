﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaDeGerenciamento2_0
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SistemaDeGerenciamento2_0Entities : DbContext
    {
        public SistemaDeGerenciamento2_0Entities()
            : base("name=SistemaDeGerenciamento2_0Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_cadastro_despesa> tb_cadastro_despesa { get; set; }
        public virtual DbSet<tb_configuracao_financeira> tb_configuracao_financeira { get; set; }
        public virtual DbSet<tb_despesa> tb_despesa { get; set; }
        public virtual DbSet<tb_enderecos> tb_enderecos { get; set; }
        public virtual DbSet<tb_estoque> tb_estoque { get; set; }
        public virtual DbSet<tb_grupo> tb_grupo { get; set; }
        public virtual DbSet<tb_informacoes_comerciais> tb_informacoes_comerciais { get; set; }
        public virtual DbSet<tb_nota_fiscal_entrada> tb_nota_fiscal_entrada { get; set; }
        public virtual DbSet<tb_nota_fiscal_saida> tb_nota_fiscal_saida { get; set; }
        public virtual DbSet<tb_permissoes> tb_permissoes { get; set; }
        public virtual DbSet<tb_produto> tb_produto { get; set; }
        public virtual DbSet<tb_registro> tb_registro { get; set; }
        public virtual DbSet<tb_repeticao_despesa> tb_repeticao_despesa { get; set; }
    }
}