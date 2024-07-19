﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Data.Models.Adventure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.ToTable("Adventures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Players must find out about the Baron Stern Brow's daughter, Patience. They must travel to Nacre in hopes of finding her.",
                            ModuleId = 1,
                            Title = "Road to Nacre"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Players must help Mayor Sea Foam with recent disappearances of his younger citizens.",
                            ModuleId = 1,
                            Title = "The Missing Children"
                        });
                });

            modelBuilder.Entity("Data.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 0,
                            Description = "Xazhadir is the arch-mage who occupies the blue tower. He is the primary quest giver of the second module.",
                            Name = "Xazhadir"
                        },
                        new
                        {
                            Id = 2,
                            Age = 0,
                            Description = "Azlan is a leonin from Desolation. He has embarked on a quest seeking to improve the living conditions in his tribe. ",
                            Name = "Azlan"
                        },
                        new
                        {
                            Id = 3,
                            Age = 0,
                            Description = "Sea Foam is the hot-tempered, but caring and honourable mayor of Nacre.",
                            Name = "Mayor Sea Foam"
                        },
                        new
                        {
                            Id = 4,
                            Age = 0,
                            Description = "Blank Canvas is a half-elf paladin, who has sworn an oath to protect nature, its beauty and its bounty.",
                            Name = "Blank Canvas"
                        });
                });

            modelBuilder.Entity("Data.Models.CompletedAdventure", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("AdventureId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "AdventureId");

                    b.HasIndex("AdventureId");

                    b.ToTable("CompletedAdventures");

                    b.HasData(
                        new
                        {
                            UserId = 2,
                            AdventureId = 1
                        },
                        new
                        {
                            UserId = 3,
                            AdventureId = 1
                        });
                });

            modelBuilder.Entity("Data.Models.Dungeon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AdventureId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Map")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdventureId");

                    b.ToTable("Dungeons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdventureId = 1,
                            Description = "Players must travel to nacre, either between two forests, or by sea. In either case, they are ambushed by fey creatures on the way there.",
                            Map = "N/A",
                            Title = "Fey Ambush"
                        },
                        new
                        {
                            Id = 2,
                            AdventureId = 2,
                            Description = "Players must find the missing people in Lover's cave.",
                            Map = "N/A",
                            Title = "Lover's Cave"
                        });
                });

            modelBuilder.Entity("Data.Models.Faction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Factions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "This is Xazhadir the Diviner's seat of power.",
                            Name = "Blue Tower"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Nacre is a small fishing town where the first module takes place.",
                            Name = "Nacre"
                        });
                });

            modelBuilder.Entity("Data.Models.LoreEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("LoreEntries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Content = "Rhyme of Creation\r\nFirst comes always Everglow\r\nHidden pulse from deep and low\r\nSecond comes Foundation Stone\r\nThis one to be left alone!\r\nWolfrose lively, Wolfrose calm\r\nShifts and turns in pouch or palm\r\nMany covet Summercrown\r\nWisdom’s gift of high renown \r\nLiving Rainbow – fancy’s roam,\r\nFickle as the ocean’s foam\r\nSin of the Eternal Book\r\nSeek it if you dare to look\r\nLast of Ages sees the Bow\r\nMay it ever Truepath show\r\n",
                            Title = "Rhyme of Creation"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Content = "This is the story of three sisters who all desired eternal life.",
                            Title = "Salt, Moss and Anise"
                        });
                });

            modelBuilder.Entity("Data.Models.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Modules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatorId = 1,
                            Description = "This is the starting module in the series. It spans levels 1-5.",
                            Title = "Salt, Moss and Anise"
                        },
                        new
                        {
                            Id = 2,
                            CreatorId = 1,
                            Description = "This is the second module in the series. It spans levels 5-9.",
                            Title = "A Wizard's Playthings"
                        });
                });

            modelBuilder.Entity("Data.Models.NonPlayerCharacter", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("AdventureId")
                        .HasColumnType("int");

                    b.Property<int>("CreatorId")
                        .HasColumnType("int");

                    b.Property<int>("FactionId")
                        .HasColumnType("int");

                    b.Property<string>("StatBlock")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdventureId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("FactionId");

                    b.ToTable("NonPlayerCharacters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatorId = 1,
                            FactionId = 1,
                            StatBlock = "N/A"
                        },
                        new
                        {
                            Id = 3,
                            CreatorId = 1,
                            FactionId = 2,
                            StatBlock = "N/A"
                        });
                });

            modelBuilder.Entity("Data.Models.PlayerCharacter", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("CharacterSheet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("PlayerCharacters");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            CharacterSheet = "N/A",
                            OwnerId = 2
                        },
                        new
                        {
                            Id = 4,
                            CharacterSheet = "N/A",
                            OwnerId = 3
                        });
                });

            modelBuilder.Entity("Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "alexkalionski@gmail.com",
                            FirstName = "Alexei",
                            LastName = "Kalionski",
                            Password = "kaminski",
                            UserType = 0,
                            Username = "Shoni"
                        },
                        new
                        {
                            Id = 2,
                            Email = "k.al.sotirov@gmail.com",
                            FirstName = "Kiril",
                            LastName = "Sotirov",
                            Password = "azlanrustmane",
                            UserType = 1,
                            Username = "Azlan"
                        },
                        new
                        {
                            Id = 3,
                            Email = "stefan.neschev@gmai.com",
                            FirstName = "Stefan",
                            LastName = "Neshev",
                            Password = "donnelkoza",
                            UserType = 2,
                            Username = "Donnel"
                        });
                });

            modelBuilder.Entity("FactionFaction", b =>
                {
                    b.Property<int>("AlliesId")
                        .HasColumnType("int");

                    b.Property<int>("OpponentsId")
                        .HasColumnType("int");

                    b.HasKey("AlliesId", "OpponentsId");

                    b.HasIndex("OpponentsId");

                    b.ToTable("FactionFaction");
                });

            modelBuilder.Entity("Data.Models.Adventure", b =>
                {
                    b.HasOne("Data.Models.Module", "Module")
                        .WithMany("Adventures")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Module");
                });

            modelBuilder.Entity("Data.Models.CompletedAdventure", b =>
                {
                    b.HasOne("Data.Models.Adventure", "Adventure")
                        .WithMany("CompletedBy")
                        .HasForeignKey("AdventureId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Data.Models.User", "User")
                        .WithMany("CompletedAdventures")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Adventure");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data.Models.Dungeon", b =>
                {
                    b.HasOne("Data.Models.Adventure", "Adventure")
                        .WithMany("Dungeons")
                        .HasForeignKey("AdventureId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Adventure");
                });

            modelBuilder.Entity("Data.Models.LoreEntry", b =>
                {
                    b.HasOne("Data.Models.User", "Author")
                        .WithMany("LoreEntries")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Data.Models.Module", b =>
                {
                    b.HasOne("Data.Models.User", "Creator")
                        .WithMany("CreatedModules")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("Data.Models.NonPlayerCharacter", b =>
                {
                    b.HasOne("Data.Models.Adventure", null)
                        .WithMany("Characters")
                        .HasForeignKey("AdventureId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Data.Models.User", "Creator")
                        .WithMany("CreatedNonPlayerCharacters")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Data.Models.Faction", "Faction")
                        .WithMany("Members")
                        .HasForeignKey("FactionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Data.Models.Character", "Character")
                        .WithOne("NonPlayerCharacter")
                        .HasForeignKey("Data.Models.NonPlayerCharacter", "Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Creator");

                    b.Navigation("Faction");
                });

            modelBuilder.Entity("Data.Models.PlayerCharacter", b =>
                {
                    b.HasOne("Data.Models.Character", "Character")
                        .WithOne("PlayerCharacter")
                        .HasForeignKey("Data.Models.PlayerCharacter", "Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Data.Models.User", "Owner")
                        .WithMany("Characters")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("FactionFaction", b =>
                {
                    b.HasOne("Data.Models.Faction", null)
                        .WithMany()
                        .HasForeignKey("AlliesId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Data.Models.Faction", null)
                        .WithMany()
                        .HasForeignKey("OpponentsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Models.Adventure", b =>
                {
                    b.Navigation("Characters");

                    b.Navigation("CompletedBy");

                    b.Navigation("Dungeons");
                });

            modelBuilder.Entity("Data.Models.Character", b =>
                {
                    b.Navigation("NonPlayerCharacter");

                    b.Navigation("PlayerCharacter");
                });

            modelBuilder.Entity("Data.Models.Faction", b =>
                {
                    b.Navigation("Members");
                });

            modelBuilder.Entity("Data.Models.Module", b =>
                {
                    b.Navigation("Adventures");
                });

            modelBuilder.Entity("Data.Models.User", b =>
                {
                    b.Navigation("Characters");

                    b.Navigation("CompletedAdventures");

                    b.Navigation("CreatedModules");

                    b.Navigation("CreatedNonPlayerCharacters");

                    b.Navigation("LoreEntries");
                });
#pragma warning restore 612, 618
        }
    }
}
