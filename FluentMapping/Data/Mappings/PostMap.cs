using System;
using FluentMapping.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentMapping.Data.Mappings
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            /*
            CREATE TABLE [Post] (
            [Id] INT NOT NULL IDENTITY(1, 1),
            */
            // definindo a tabela
            builder.ToTable("Post");

            //definindo quem é a chave primária
            builder.HasKey(x => x.Id);

            ///DEFININDO AS PROPIEDADES DOS CAMPOS
            //Definir o identity e como o será o incremento da chave primária
            builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

            //Constrainsts
            //[Title] VARCHAR(160) NOT NULL
            builder.Property(x => x.Title)
            .HasColumnName("Title")
            .HasColumnType("VARCHAR")
            .HasMaxLength(160)
            .IsRequired();

            //[Body] TEXT NOT NULL
            builder.Property(x => x.Title)
            .HasColumnName("Body")
            .HasColumnType("TEXT")
            .IsRequired();

            //[Summary] VARCHAR(255) NOT NULL,
            builder.Property(x => x.Summary)
            .HasColumnName("Summary")
            .HasColumnType("VARCHAR")
            .HasMaxLength(255)
            .IsRequired();

            //[Slug] VARCHAR(80) NOT NULL,
            builder.Property(x => x.Slug)
            .HasColumnName("Slug")
            .HasColumnType("VARCHAR")
            .HasMaxLength(80)
            .IsRequired();

            //[CreateDate] DATETIME NOT NULL DEFAULT(GETDATE()),
            builder.Property(x => x.CreateDate)
            .HasColumnName("CreateDate")
            .HasColumnType("DATETIME")
            .IsRequired()
            .HasDefaultValue(DateTime.Now.ToUniversalTime());

            //[LastUpdateDate] DATETIME NOT NULL DEFAULT(GETDATE())
            builder.Property(x => x.CreateDate)
            .HasColumnName("LastUpdateDate")
            .HasColumnType("DATETIME")
            .IsRequired()
            .HasDefaultValue(DateTime.Now.ToUniversalTime());

            //CREATE NONCLUSTERED INDEX [IX_Post_Slug] ON [Post]([Slug])*/
            //DEFININDO OS INDICES
            builder.HasIndex(x => x.Slug, "IX_Post_Slug")
            .IsUnique();
        }
    }
}