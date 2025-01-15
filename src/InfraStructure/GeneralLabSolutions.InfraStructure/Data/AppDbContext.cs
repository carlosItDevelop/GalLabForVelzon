using FluentValidation.Results;
using GeneralLabSolutions.Domain.Entities;
using GeneralLabSolutions.Domain.Mensageria;
using GeneralLabSolutions.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using GeneralLabSolutions.Domain.Entities.Base;
using System.Reflection.Metadata.Ecma335;

namespace GeneralLabSolutions.InfraStructure.Data
{
    public class AppDbContext : DbContext, IUnitOfWork
	{

		private readonly IMediatorHandler? _mediatorHandler;

        public AppDbContext(DbContextOptions<AppDbContext> options, IMediatorHandler? mediatorHandler = null)
			: base(options) 
		{
            _mediatorHandler = mediatorHandler;
        }

        public DbSet<Produto> Produto { get; set; }
		public DbSet<CategoriaProduto> CategoriaProduto { get; set; }
		public DbSet<Cliente> Cliente { get; set; }
		public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
		public DbSet<ItemPedido> ItemPedido { get; set; }
		public DbSet<Telefone> Telefone { get; set; }
		public DbSet<Pessoa> Pessoa { get; set; }
		public DbSet<Contato> Contato { get; set; }
		public DbSet<GerenciadorDeFluxoKanban> GerenciadorDeFluxoKanban { get; set; }
        public DbSet<MembroEquipe> MembroEquipe { get; set; }
		public DbSet<Voucher> Voucher { get; set; }

        public EstadoDoItem EstadoDoItem { get; set; }

        public DbSet<PessoaTelefone> PessoaTelefone { get; set; }
        public DbSet<PessoaContato> PessoaContato { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Ignore<ValidationResult>();
			modelBuilder.Ignore<Event>();

            modelBuilder.Entity<EstadoDoItem>().HasKey(p => p.Id);
            modelBuilder.Entity<EstadoDoItem>().Property(p => p.Estado)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);



            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
				e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
				property.SetColumnType("varchar(100)");

			foreach (var relationship in modelBuilder.Model.GetEntityTypes()
				.SelectMany(e => e.GetForeignKeys()))
				relationship.DeleteBehavior = DeleteBehavior.Restrict;

			modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
		}


		public async Task<bool> CommitAsync()
		{
			var sucesso = await base.SaveChangesAsync() > 0;
			if (sucesso)
				await _mediatorHandler!.PublicarEventos(this);
			return sucesso;
		}

    }

    #region: Todo: Guardar para quando for persistir Events
    //public static class MediatorExtension
    //{
    //	public static async Task PublicarEventos<T>(this IMediatorHandler mediator, T ctx) where T : DbContext
    //	{
    //		var domainEntities = ctx.ChangeTracker
    //			.Entries<EntityBase>()
    //			.Where(x => x.Entity.Notificacoes != null && x.Entity.Notificacoes.Any())
    //			.ToList();

    //		var domainEvents = domainEntities
    //			.SelectMany(x => x.Entity.Notificacoes!)
    //			.ToList();

    //		domainEntities.ToList()
    //			.ForEach(entity => entity.Entity.LimparEventos());
    //		var tasks = domainEvents
    //			.Select(async (domainEvent) =>
    //			{
    //				await mediator.PublicarEvento(domainEvent);
    //			});

    //		await Task.WhenAll(tasks);
    //	}
    //}

    public static class MediatorExtension
    {
        public static async Task PublicarEventos<T>(this IMediatorHandler mediator, T ctx) where T : DbContext
        {
            // Exemplo de código padrão para publicar Domain Events
            var domainEntities = ctx.ChangeTracker
                .Entries<EntityBase>()
                .Where(x => x.Entity.Notificacoes != null && x.Entity.Notificacoes.Any())
                .ToList();

            // Para cada entidade com eventos de domínio, publicar
            foreach (var entityEntry in domainEntities)
            {
                var events = entityEntry.Entity?.Notificacoes?.ToArray();
                entityEntry.Entity?.LimparEventos(); // se quiser limpar depois
                foreach (var domainEvent in events!)
                {
                    await mediator.PublicarEvento(domainEvent);
                }
            }
        }
    }



    #endregion
}
