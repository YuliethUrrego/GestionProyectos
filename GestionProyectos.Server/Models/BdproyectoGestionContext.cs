using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GestionProyectos.Server.Models;

public partial class BdproyectoGestionContext : DbContext
{
    public BdproyectoGestionContext()
    {
    }

    public BdproyectoGestionContext(DbContextOptions<BdproyectoGestionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Administrador> Administradors { get; set; }

    public virtual DbSet<Informe> Informes { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Proyecto> Proyectos { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Tarea> Tareas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuariosEnProyecto> UsuariosEnProyectos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-RLJ4SB7\\SQLEXPRESS;Database=BDProyectoGestion;Encrypt=False;User Id=sa;Password=320dev;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrador>(entity =>
        {
            entity.HasKey(e => e.AdministradorId).HasName("PK__Administ__2C780D56A5BA3A97");

            entity.ToTable("Administrador");

            entity.Property(e => e.AdministradorId).HasColumnName("AdministradorID");
            entity.Property(e => e.EmailEmpresa).HasMaxLength(255);
            entity.Property(e => e.PersonaId).HasColumnName("PersonaID");
            entity.Property(e => e.RazonSocial).HasMaxLength(255);
            entity.Property(e => e.Telefono).HasMaxLength(255);

            entity.HasOne(d => d.Persona).WithMany(p => p.Administradors)
                .HasForeignKey(d => d.PersonaId)
                .HasConstraintName("FK__Administr__Perso__3F466844");
        });

        modelBuilder.Entity<Informe>(entity =>
        {
            entity.HasKey(e => e.InformeId).HasName("PK__Informes__5B458746747C2936");

            entity.Property(e => e.InformeId).HasColumnName("InformeID");
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.TareaId).HasColumnName("TareaID");
            entity.Property(e => e.TipoDoc).HasMaxLength(255);

            entity.HasOne(d => d.Tarea).WithMany(p => p.Informes)
                .HasForeignKey(d => d.TareaId)
                .HasConstraintName("FK__Informes__TareaI__4BAC3F29");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.PersonaId).HasName("PK__Persona__7C34D32341426B9E");

            entity.ToTable("Persona");

            entity.Property(e => e.PersonaId).HasColumnName("PersonaID");
            entity.Property(e => e.Contrasenia).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(255);
        });

        modelBuilder.Entity<Proyecto>(entity =>
        {
            entity.HasKey(e => e.ProyectoId).HasName("PK__Proyecto__CF241D45246489B7");

            entity.ToTable("Proyecto");

            entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");
            entity.Property(e => e.AdministradorId).HasColumnName("AdministradorID");
            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.Tipo).HasMaxLength(255);

            entity.HasOne(d => d.Administrador).WithMany(p => p.Proyectos)
                .HasForeignKey(d => d.AdministradorId)
                .HasConstraintName("FK__Proyecto__Admini__4222D4EF");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.RolId).HasName("PK__Rol__F92302D1A803BE29");

            entity.ToTable("Rol");

            entity.Property(e => e.RolId).HasColumnName("RolID");
            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(255);
        });

        modelBuilder.Entity<Tarea>(entity =>
        {
            entity.HasKey(e => e.TareaId).HasName("PK__Tarea__5CD83671AE253228");

            entity.ToTable("Tarea");

            entity.Property(e => e.TareaId).HasColumnName("TareaID");
            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");

            entity.HasOne(d => d.Proyecto).WithMany(p => p.Tareas)
                .HasForeignKey(d => d.ProyectoId)
                .HasConstraintName("FK__Tarea__ProyectoI__48CFD27E");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PK__Usuario__2B3DE7987611D789");

            entity.ToTable("Usuario");

            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            entity.Property(e => e.PersonaId).HasColumnName("PersonaID");
            entity.Property(e => e.RolId).HasColumnName("RolID");

            entity.HasOne(d => d.Persona).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.PersonaId)
                .HasConstraintName("FK__Usuario__Persona__3B75D760");

            entity.HasOne(d => d.Rol).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.RolId)
                .HasConstraintName("FK__Usuario__RolID__3C69FB99");
        });

        modelBuilder.Entity<UsuariosEnProyecto>(entity =>
        {
            entity.HasKey(e => e.UsuarioEnProyectoId).HasName("PK__Usuarios__AE560C85AD5502ED");

            entity.Property(e => e.UsuarioEnProyectoId).HasColumnName("UsuarioEnProyectoID");
            entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");
            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

            entity.HasOne(d => d.Proyecto).WithMany(p => p.UsuariosEnProyectos)
                .HasForeignKey(d => d.ProyectoId)
                .HasConstraintName("FK__UsuariosE__Proye__45F365D3");

            entity.HasOne(d => d.Usuario).WithMany(p => p.UsuariosEnProyectos)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK__UsuariosE__Usuar__44FF419A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
