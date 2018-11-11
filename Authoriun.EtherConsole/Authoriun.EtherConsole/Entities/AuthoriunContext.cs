namespace Authoriun.EtherConsole.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AuthoriunContext : DbContext
    {
        public AuthoriunContext()
            : base("name=AuthoriunContext")
        {
        }

        public virtual DbSet<LogAcao> LogAcao { get; set; }
        public virtual DbSet<LogAuditoria> LogAuditoria { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioToken> UsuarioToken { get; set; }
        public virtual DbSet<GeneroObra> GeneroObra { get; set; }
        public virtual DbSet<GeneroObraDescricao> GeneroObraDescricao { get; set; }
        public virtual DbSet<Idioma> Idioma { get; set; }
        public virtual DbSet<OrgaoExpedidor> OrgaoExpedidor { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<PaisDescricao> PaisDescricao { get; set; }
        public virtual DbSet<TipoContato> TipoContato { get; set; }
        public virtual DbSet<TipoContatoDescricao> TipoContatoDescricao { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }
        public virtual DbSet<TipoDocumentoDescricao> TipoDocumentoDescricao { get; set; }
        public virtual DbSet<TipoEndereco> TipoEndereco { get; set; }
        public virtual DbSet<TipoEnderecoDescricao> TipoEnderecoDescricao { get; set; }
        public virtual DbSet<TipoPessoa> TipoPessoa { get; set; }
        public virtual DbSet<TipoPessoaDescricao> TipoPessoaDescricao { get; set; }
        public virtual DbSet<Arquivo> Arquivo { get; set; }
        public virtual DbSet<Obra> Obra { get; set; }
        public virtual DbSet<ObraVinculo> ObraVinculo { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<Registro> Registro { get; set; }
        public virtual DbSet<RegistroTransmissao> RegistroTransmissao { get; set; }
        public virtual DbSet<Representante> Representante { get; set; }
        public virtual DbSet<Requerente> Requerente { get; set; }
        public virtual DbSet<RequerenteCliente> RequerenteCliente { get; set; }
        public virtual DbSet<RequerenteObra> RequerenteObra { get; set; }
        public virtual DbSet<RequerenteRepresentante> RequerenteRepresentante { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Contato> Contato { get; set; }
        public virtual DbSet<Documento> Documento { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Pagamento> Pagamento { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<PedidoProduto> PedidoProduto { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .Property(e => e.NomeApresentacao)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Senha)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Arquivo)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Cliente)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Contato)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Documento)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Endereco)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.GeneroObra)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.GeneroObraDescricao)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Idioma)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Obra)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.ObraVinculo)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.OrgaoExpedidor)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Pais)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.PaisDescricao)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Pessoa)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Registro)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.RegistroTransmissao)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Representante)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Requerente)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.RequerenteCliente)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.RequerenteObra)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.RequerenteRepresentante)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.TipoContato)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.TipoContatoDescricao)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.TipoDocumento)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.TipoDocumentoDescricao)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.TipoEndereco)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.TipoEnderecoDescricao)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.TipoPessoa)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.TipoPessoaDescricao)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.UsuarioToken)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdTenant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.UsuarioToken1)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.IdUsuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UsuarioToken>()
                .Property(e => e.Token)
                .IsUnicode(false);

            modelBuilder.Entity<GeneroObra>()
                .HasMany(e => e.GeneroObraDescricao)
                .WithRequired(e => e.GeneroObra)
                .HasForeignKey(e => e.IdGeneroObra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GeneroObra>()
                .HasMany(e => e.Obra)
                .WithRequired(e => e.GeneroObra)
                .HasForeignKey(e => e.IdGeneroObra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GeneroObraDescricao>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Idioma>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Idioma>()
                .Property(e => e.ISO639Alfa2)
                .IsUnicode(false);

            modelBuilder.Entity<Idioma>()
                .Property(e => e.ISO639Alfa3)
                .IsUnicode(false);

            modelBuilder.Entity<Idioma>()
                .Property(e => e.HtmlCode)
                .IsUnicode(false);

            modelBuilder.Entity<Idioma>()
                .HasMany(e => e.GeneroObraDescricao)
                .WithRequired(e => e.Idioma)
                .HasForeignKey(e => e.IdIdioma)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Idioma>()
                .HasMany(e => e.PaisDescricao)
                .WithRequired(e => e.Idioma)
                .HasForeignKey(e => e.IdIdioma)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Idioma>()
                .HasMany(e => e.TipoContatoDescricao)
                .WithRequired(e => e.Idioma)
                .HasForeignKey(e => e.IdIdioma)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Idioma>()
                .HasMany(e => e.TipoDocumentoDescricao)
                .WithRequired(e => e.Idioma)
                .HasForeignKey(e => e.IdIdioma)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Idioma>()
                .HasMany(e => e.TipoEnderecoDescricao)
                .WithRequired(e => e.Idioma)
                .HasForeignKey(e => e.IdIdioma)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Idioma>()
                .HasMany(e => e.TipoPessoaDescricao)
                .WithRequired(e => e.Idioma)
                .HasForeignKey(e => e.IdIdioma)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrgaoExpedidor>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<OrgaoExpedidor>()
                .Property(e => e.Sigla)
                .IsUnicode(false);

            modelBuilder.Entity<OrgaoExpedidor>()
                .HasMany(e => e.Documento)
                .WithOptional(e => e.OrgaoExpedidor)
                .HasForeignKey(e => e.IdOrgaoExpedidor);

            modelBuilder.Entity<Pais>()
                .Property(e => e.ISO3166Alfa2)
                .IsUnicode(false);

            modelBuilder.Entity<Pais>()
                .Property(e => e.ISO3166Alfa3)
                .IsUnicode(false);

            modelBuilder.Entity<Pais>()
                .HasMany(e => e.Documento)
                .WithOptional(e => e.Pais)
                .HasForeignKey(e => e.IdPais);

            modelBuilder.Entity<Pais>()
                .HasMany(e => e.Endereco)
                .WithOptional(e => e.Pais)
                .HasForeignKey(e => e.IdPais);

            modelBuilder.Entity<Pais>()
                .HasMany(e => e.PaisDescricao)
                .WithRequired(e => e.Pais)
                .HasForeignKey(e => e.IdPais)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pais>()
                .HasMany(e => e.Pessoa)
                .WithOptional(e => e.Pais)
                .HasForeignKey(e => e.IdPaisNacionalidade);

            modelBuilder.Entity<PaisDescricao>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<TipoContato>()
                .HasMany(e => e.Contato)
                .WithRequired(e => e.TipoContato)
                .HasForeignKey(e => e.IdTipoContato)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoContato>()
                .HasMany(e => e.TipoContatoDescricao)
                .WithRequired(e => e.TipoContato)
                .HasForeignKey(e => e.IdTipoContato)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoContatoDescricao>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<TipoDocumento>()
                .HasMany(e => e.Documento)
                .WithRequired(e => e.TipoDocumento)
                .HasForeignKey(e => e.IdTipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoDocumento>()
                .HasMany(e => e.TipoDocumentoDescricao)
                .WithRequired(e => e.TipoDocumento)
                .HasForeignKey(e => e.IdTipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoDocumentoDescricao>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<TipoEndereco>()
                .HasMany(e => e.Endereco)
                .WithRequired(e => e.TipoEndereco)
                .HasForeignKey(e => e.IdTipoEndereco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoEndereco>()
                .HasMany(e => e.TipoEnderecoDescricao)
                .WithRequired(e => e.TipoEndereco)
                .HasForeignKey(e => e.IdTipoEndereco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoEnderecoDescricao>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<TipoPessoa>()
                .HasMany(e => e.Pessoa)
                .WithRequired(e => e.TipoPessoa)
                .HasForeignKey(e => e.IdTipoPessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoPessoa>()
                .HasMany(e => e.TipoPessoaDescricao)
                .WithRequired(e => e.TipoPessoa)
                .HasForeignKey(e => e.IdTipoPessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoPessoaDescricao>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Arquivo>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Arquivo>()
                .Property(e => e.Extensao)
                .IsUnicode(false);

            modelBuilder.Entity<Arquivo>()
                .Property(e => e.Mime)
                .IsUnicode(false);

            modelBuilder.Entity<Arquivo>()
                .Property(e => e.Tamanho)
                .IsUnicode(false);

            modelBuilder.Entity<Arquivo>()
                .Property(e => e.MD5)
                .IsUnicode(false);

            modelBuilder.Entity<Arquivo>()
                .Property(e => e.SHA256)
                .IsUnicode(false);

            modelBuilder.Entity<Arquivo>()
                .Property(e => e.SHA512)
                .IsUnicode(false);

            modelBuilder.Entity<Arquivo>()
                .Property(e => e.JWTCertificado)
                .IsUnicode(false);

            modelBuilder.Entity<Arquivo>()
                .Property(e => e.JWTChavePublica)
                .IsUnicode(false);

            modelBuilder.Entity<Arquivo>()
                .HasMany(e => e.Registro)
                .WithRequired(e => e.Arquivo)
                .HasForeignKey(e => e.IdArquivo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Obra>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<Obra>()
                .Property(e => e.Grafica)
                .IsUnicode(false);

            modelBuilder.Entity<Obra>()
                .Property(e => e.Editora)
                .IsUnicode(false);

            modelBuilder.Entity<Obra>()
                .Property(e => e.Ano)
                .IsUnicode(false);

            modelBuilder.Entity<Obra>()
                .Property(e => e.Volume)
                .IsUnicode(false);

            modelBuilder.Entity<Obra>()
                .Property(e => e.Edicao)
                .IsUnicode(false);

            modelBuilder.Entity<Obra>()
                .Property(e => e.LocalPublicacao)
                .IsUnicode(false);

            modelBuilder.Entity<Obra>()
                .Property(e => e.AdaptacaoTituloOriginal)
                .IsUnicode(false);

            modelBuilder.Entity<Obra>()
                .Property(e => e.AdaptacaoAutorOriginal)
                .IsUnicode(false);

            modelBuilder.Entity<Obra>()
                .Property(e => e.TraducaoTituloOriginal)
                .IsUnicode(false);

            modelBuilder.Entity<Obra>()
                .Property(e => e.TraducaoAutorOriginal)
                .IsUnicode(false);

            modelBuilder.Entity<Obra>()
                .Property(e => e.Observacoes)
                .IsUnicode(false);

            modelBuilder.Entity<Obra>()
                .HasMany(e => e.Arquivo)
                .WithRequired(e => e.Obra)
                .HasForeignKey(e => e.IdObra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Obra>()
                .HasMany(e => e.ObraVinculo)
                .WithRequired(e => e.Obra)
                .HasForeignKey(e => e.IdObra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Obra>()
                .HasMany(e => e.Registro)
                .WithRequired(e => e.Obra)
                .HasForeignKey(e => e.IdObra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Obra>()
                .HasMany(e => e.RequerenteObra)
                .WithRequired(e => e.Obra)
                .HasForeignKey(e => e.IdObra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ObraVinculo>()
                .Property(e => e.Outros)
                .IsUnicode(false);

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.NomeFantasia)
                .IsUnicode(false);

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.Pseudonimo)
                .IsUnicode(false);

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.NomeMae)
                .IsUnicode(false);

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.Naturalidade)
                .IsUnicode(false);

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.Ocupacao)
                .IsUnicode(false);

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.Escolaridade)
                .IsUnicode(false);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.Cliente)
                .WithRequired(e => e.Pessoa)
                .HasForeignKey(e => e.IdPessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.Contato)
                .WithRequired(e => e.Pessoa)
                .HasForeignKey(e => e.IdPessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.Documento)
                .WithRequired(e => e.Pessoa)
                .HasForeignKey(e => e.IdPessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.Endereco)
                .WithRequired(e => e.Pessoa)
                .HasForeignKey(e => e.IdPessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.Representante)
                .WithRequired(e => e.Pessoa)
                .HasForeignKey(e => e.IdPessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.Requerente)
                .WithRequired(e => e.Pessoa)
                .HasForeignKey(e => e.IdPessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Registro>()
                .Property(e => e.HashTransacao)
                .IsUnicode(false);

            modelBuilder.Entity<Registro>()
                .HasMany(e => e.RegistroTransmissao)
                .WithRequired(e => e.Registro)
                .HasForeignKey(e => e.IdRegistro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RegistroTransmissao>()
                .Property(e => e.HashTransacao)
                .IsUnicode(false);

            modelBuilder.Entity<RegistroTransmissao>()
                .Property(e => e.De)
                .IsUnicode(false);

            modelBuilder.Entity<RegistroTransmissao>()
                .Property(e => e.Para)
                .IsUnicode(false);

            modelBuilder.Entity<RegistroTransmissao>()
                .Property(e => e.Bloco)
                .IsUnicode(false);

            modelBuilder.Entity<RegistroTransmissao>()
                .Property(e => e.Valor)
                .HasPrecision(18, 9);

            modelBuilder.Entity<RegistroTransmissao>()
                .Property(e => e.GasPreco)
                .HasPrecision(18, 9);

            modelBuilder.Entity<RegistroTransmissao>()
                .Property(e => e.CustoFinal)
                .HasPrecision(18, 9);

            modelBuilder.Entity<RegistroTransmissao>()
                .Property(e => e.DadoEnviado)
                .IsUnicode(false);

            modelBuilder.Entity<RegistroTransmissao>()
                .Property(e => e.NotaPrivada)
                .IsUnicode(false);

            modelBuilder.Entity<RegistroTransmissao>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<RegistroTransmissao>()
                .Property(e => e.Mensagem)
                .IsUnicode(false);

            modelBuilder.Entity<Representante>()
                .Property(e => e.Parentesco)
                .IsUnicode(false);

            modelBuilder.Entity<Representante>()
                .HasMany(e => e.RequerenteRepresentante)
                .WithRequired(e => e.Representante)
                .HasForeignKey(e => e.IdRepresentante)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Requerente>()
                .HasMany(e => e.RequerenteCliente)
                .WithRequired(e => e.Requerente)
                .HasForeignKey(e => e.IdRequerente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Requerente>()
                .HasMany(e => e.RequerenteObra)
                .WithRequired(e => e.Requerente)
                .HasForeignKey(e => e.IdRequerente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Requerente>()
                .HasMany(e => e.RequerenteRepresentante)
                .WithRequired(e => e.Requerente)
                .HasForeignKey(e => e.IdRequerente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.RequerenteCliente)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => e.IdCliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contato>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Identificador)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.UF)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Municipio)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Logradouro)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.CEP)
                .IsUnicode(false);
        }
    }
}
