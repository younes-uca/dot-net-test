using DotnetGenerator.Bean.Core;
using DotnetGenerator.Zynarator.Audit;
using Microsoft.EntityFrameworkCore;

namespace DotnetGenerator.Data;

public class AppDbContext : IdentityDbContext<User, Role, long, IdentityUserClaim<long>, RoleUser, IdentityUserLogin<long>, IdentityRoleClaim<long>, IdentityUserToken<long>>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public required DbSet<Tag> Tags { get; init; }
    public required DbSet<PurchaseState> PurchaseStates { get; init; }
    public required DbSet<PurchaseItem> PurchaseItems { get; init; }
    public required DbSet<PurchaseTag> PurchaseTags { get; init; }
    public required DbSet<Purchase> Purchases { get; init; }
    public required DbSet<Product> Products { get; init; }
    public required DbSet<Client> Clients { get; init; }
    public required DbSet<ClientCategory> ClientCategorys { get; init; }
	public override required DbSet<User> Users { get; set; }
	public override required DbSet<Role> Roles { get; set; }
	public override required DbSet<RoleUser> UserRoles { get; set; }
	public required DbSet<ModelPermissionUser> ModelPermissionUsers { get; init; }
	public required DbSet<ActionPermission> ActionPermissions { get; init; }
	public required DbSet<ModelPermission> ModelPermissions { get; init; }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<decimal>().HaveColumnType("decimal(18,2)");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
     
        modelBuilder.Entity<User>().ToTable("Users");
        modelBuilder.Entity<Role>().ToTable("Roles");

        modelBuilder.Entity<RoleUser>().HasKey(ru => ru.Id);
        modelBuilder.Entity<RoleUser>().ToTable("RoleUsers");
        modelBuilder.Entity<RoleUser>()
            .HasOne(ru => ru.User)
            .WithMany(u => u!.RoleUsers)
            .HasForeignKey(ru => ru.UserId)
            .IsRequired();
        modelBuilder.Entity<RoleUser>()
            .HasOne(ru => ru.Role)
            .WithMany(r => r!.RoleUsers)
            .HasForeignKey(ru => ru.RoleId)
            .IsRequired();
        
        modelBuilder.Entity<IdentityUserClaim<long>>().ToTable("UserClaims");
        modelBuilder.Entity<IdentityUserLogin<long>>().ToTable("UserLogins");
        modelBuilder.Entity<IdentityRoleClaim<long>>().ToTable("RoleClaims");
        modelBuilder.Entity<IdentityUserToken<long>>().ToTable("UserTokens");
        
        modelBuilder.RegisterEntities();
    }
    
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        ApplyEntityChanges();
        return await base.SaveChangesAsync(cancellationToken);
    }

    private void ApplyEntityChanges()
    {
        var entries = ChangeTracker.Entries()
            .Where(e => e.State is EntityState.Added or EntityState.Modified);
        foreach (var entry in entries) 
            entry.HandleAuditableEntities();
    }
}
