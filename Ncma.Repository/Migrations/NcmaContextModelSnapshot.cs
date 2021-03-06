﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ncma.Repository.Models;

namespace Ncma.Repository.Migrations
{
    [DbContext(typeof(NcmaContext))]
    partial class NcmaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Ncma.Repository.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Ncma.Repository.Models.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BatchId");

                    b.Property<int?>("CertificateTypeId");

                    b.Property<bool>("Completed");

                    b.Property<int?>("DojoId");

                    b.Property<DateTime?>("FromDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("InstructorId");

                    b.Property<int?>("InstructorTypeId");

                    b.Property<bool>("IsActive");

                    b.Property<int?>("MemberId");

                    b.Property<string>("RankText");

                    b.Property<DateTime?>("ThruDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("CertificateTypeId");

                    b.HasIndex("DojoId");

                    b.HasIndex("InstructorId");

                    b.HasIndex("InstructorTypeId");

                    b.HasIndex("MemberId");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("Ncma.Repository.Models.CertificateType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int?>("ValidationDurationInDays");

                    b.HasKey("Id");

                    b.ToTable("CertificateTypes");

                    b.HasData(
                        new { Id = 1, Description = "Rank Certificate", Name = "Rank", ValidationDurationInDays = 365 },
                        new { Id = 2, Description = "School Charter Certificate", Name = "School Charter", ValidationDurationInDays = 365 },
                        new { Id = 3, Description = "Instructor Certificate", Name = "Instructor", ValidationDurationInDays = 365 },
                        new { Id = 4, Description = "Member Certificate", Name = "Membership", ValidationDurationInDays = 365 },
                        new { Id = 5, Description = "Tenshi Rank Certificate", Name = "Tenshi Rank", ValidationDurationInDays = 365 },
                        new { Id = 6, Description = "Chief Instructor Certificate", Name = "Chief Instructor", ValidationDurationInDays = 365 },
                        new { Id = 7, Description = "Tenshi Membership Certificate", Name = "Tenshi Membership", ValidationDurationInDays = 365 },
                        new { Id = 8, Description = "Tenshi School Charter Certificate", Name = "Tenshi School Charter", ValidationDurationInDays = 365 },
                        new { Id = 9, Description = "Tenshi Instructor Certificate", Name = "Tenshi Instructor", ValidationDurationInDays = 365 },
                        new { Id = 10, Description = "Hanshi Seminar Certificate", Name = "Hanshi Seminar", ValidationDurationInDays = 365 }
                    );
                });

            modelBuilder.Entity("Ncma.Repository.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new { Id = 1, Name = "Afghanistan" },
                        new { Id = 2, Name = "Albania" },
                        new { Id = 3, Name = "Algeria" },
                        new { Id = 4, Name = "Andorra" },
                        new { Id = 5, Name = "Antigua and Barbuda" },
                        new { Id = 6, Name = "Argentina" },
                        new { Id = 7, Name = "Armenia" },
                        new { Id = 8, Name = "Australia" },
                        new { Id = 9, Name = "Austria" },
                        new { Id = 10, Name = "Azerbaijan" },
                        new { Id = 11, Name = "Bahamas" },
                        new { Id = 12, Name = "Bahrain" },
                        new { Id = 13, Name = "Bangladesh" },
                        new { Id = 14, Name = "Barbados" },
                        new { Id = 15, Name = "Belarus" },
                        new { Id = 16, Name = "Belgium" },
                        new { Id = 17, Name = "Belize" },
                        new { Id = 18, Name = "Benin" },
                        new { Id = 19, Name = "Bhutan" },
                        new { Id = 20, Name = "Bolivia" },
                        new { Id = 21, Name = "Bosnia and Herzegovina" },
                        new { Id = 22, Name = "Botswana" },
                        new { Id = 23, Name = "Brazil" },
                        new { Id = 24, Name = "Brunei" },
                        new { Id = 25, Name = "Bulgaria" },
                        new { Id = 26, Name = "Burkina Faso" },
                        new { Id = 27, Name = "Burundi" },
                        new { Id = 28, Name = "Cambodia" },
                        new { Id = 29, Name = "Cameroon" },
                        new { Id = 30, Name = "Canada" },
                        new { Id = 31, Name = "Cape Verde" },
                        new { Id = 32, Name = "Central African Republic" },
                        new { Id = 33, Name = "Chad" },
                        new { Id = 34, Name = "Chile" },
                        new { Id = 35, Name = "China" },
                        new { Id = 36, Name = "Colombia" },
                        new { Id = 37, Name = "Comoros" },
                        new { Id = 38, Name = "Congo" },
                        new { Id = 39, Name = "Costa Rica" },
                        new { Id = 40, Name = "Cote dIvoire" },
                        new { Id = 41, Name = "Croatia" },
                        new { Id = 42, Name = "Cuba" },
                        new { Id = 43, Name = "Cyprus" },
                        new { Id = 44, Name = "Czech Republic" },
                        new { Id = 45, Name = "Denmark" },
                        new { Id = 46, Name = "Djibouti" },
                        new { Id = 47, Name = "Dominica" },
                        new { Id = 48, Name = "Dominican Republic" },
                        new { Id = 49, Name = "East Timor" },
                        new { Id = 50, Name = "Ecuador" },
                        new { Id = 51, Name = "Egypt" },
                        new { Id = 52, Name = "El Salvador" },
                        new { Id = 53, Name = "Equatorial Guinea" },
                        new { Id = 54, Name = "Eritrea" },
                        new { Id = 55, Name = "Estonia" },
                        new { Id = 56, Name = "Ethiopia" },
                        new { Id = 57, Name = "Fiji" },
                        new { Id = 58, Name = "Finland" },
                        new { Id = 59, Name = "France" },
                        new { Id = 60, Name = "Gabon" },
                        new { Id = 61, Name = "Gambia" },
                        new { Id = 62, Name = "Georgia" },
                        new { Id = 63, Name = "Germany" },
                        new { Id = 64, Name = "Ghana" },
                        new { Id = 65, Name = "Greece" },
                        new { Id = 66, Name = "Grenada" },
                        new { Id = 67, Name = "Guatemala" },
                        new { Id = 68, Name = "Guinea" },
                        new { Id = 69, Name = "Guinea-Bissau" },
                        new { Id = 70, Name = "Guyana" },
                        new { Id = 71, Name = "Haiti" },
                        new { Id = 72, Name = "Honduras" },
                        new { Id = 73, Name = "Hong Kong" },
                        new { Id = 74, Name = "Hungary" },
                        new { Id = 75, Name = "Iceland" },
                        new { Id = 76, Name = "India" },
                        new { Id = 77, Name = "Indonesia" },
                        new { Id = 78, Name = "Iran" },
                        new { Id = 79, Name = "Iraq" },
                        new { Id = 80, Name = "Ireland" },
                        new { Id = 81, Name = "Israel" },
                        new { Id = 82, Name = "Italy" },
                        new { Id = 83, Name = "Jamaica" },
                        new { Id = 84, Name = "Japan" },
                        new { Id = 85, Name = "Jordan" },
                        new { Id = 86, Name = "Kazakhstan" },
                        new { Id = 87, Name = "Kenya" },
                        new { Id = 88, Name = "Kiribati" },
                        new { Id = 89, Name = "North Korea" },
                        new { Id = 90, Name = "South Korea" },
                        new { Id = 91, Name = "Kuwait" },
                        new { Id = 92, Name = "Kyrgyzstan" },
                        new { Id = 93, Name = "Laos" },
                        new { Id = 94, Name = "Latvia" },
                        new { Id = 95, Name = "Lebanon" },
                        new { Id = 96, Name = "Lesotho" },
                        new { Id = 97, Name = "Liberia" },
                        new { Id = 98, Name = "Libya" },
                        new { Id = 99, Name = "Liechtenstein" },
                        new { Id = 100, Name = "Lithuania" },
                        new { Id = 101, Name = "Luxembourg" },
                        new { Id = 102, Name = "Macedonia" },
                        new { Id = 103, Name = "Madagascar" },
                        new { Id = 104, Name = "Malawi" },
                        new { Id = 105, Name = "Malaysia" },
                        new { Id = 106, Name = "Maldives" },
                        new { Id = 107, Name = "Mali" },
                        new { Id = 108, Name = "Malta" },
                        new { Id = 109, Name = "Marshall Islands" },
                        new { Id = 110, Name = "Mauritania" },
                        new { Id = 111, Name = "Mauritius" },
                        new { Id = 112, Name = "Mexico" },
                        new { Id = 113, Name = "Micronesia" },
                        new { Id = 114, Name = "Moldova" },
                        new { Id = 115, Name = "Monaco" },
                        new { Id = 116, Name = "Mongolia" },
                        new { Id = 117, Name = "Montenegro" },
                        new { Id = 118, Name = "Morocco" },
                        new { Id = 119, Name = "Mozambique" },
                        new { Id = 120, Name = "Myanmar" },
                        new { Id = 121, Name = "Namibia" },
                        new { Id = 122, Name = "Nauru" },
                        new { Id = 123, Name = "Nepal" },
                        new { Id = 124, Name = "Netherlands" },
                        new { Id = 125, Name = "New Zealand" },
                        new { Id = 126, Name = "Nicaragua" },
                        new { Id = 127, Name = "Niger" },
                        new { Id = 128, Name = "Nigeria" },
                        new { Id = 129, Name = "Norway" },
                        new { Id = 130, Name = "Oman" },
                        new { Id = 131, Name = "Pakistan" },
                        new { Id = 132, Name = "Palau" },
                        new { Id = 133, Name = "Panama" },
                        new { Id = 134, Name = "Papua New Guinea" },
                        new { Id = 135, Name = "Paraguay" },
                        new { Id = 136, Name = "Peru" },
                        new { Id = 137, Name = "Philippines" },
                        new { Id = 138, Name = "Poland" },
                        new { Id = 139, Name = "Portugal" },
                        new { Id = 140, Name = "Puerto Rico" },
                        new { Id = 141, Name = "Qatar" },
                        new { Id = 142, Name = "Romania" },
                        new { Id = 143, Name = "Russia" },
                        new { Id = 144, Name = "Rwanda" },
                        new { Id = 145, Name = "Saint Kitts and Nevis" },
                        new { Id = 146, Name = "Saint Lucia" },
                        new { Id = 147, Name = "Saint Vincent and the Grenadines" },
                        new { Id = 148, Name = "Samoa" },
                        new { Id = 149, Name = "San Marino" },
                        new { Id = 150, Name = "Sao Tome and Principe" },
                        new { Id = 151, Name = "Saudi Arabia" },
                        new { Id = 152, Name = "Senegal" },
                        new { Id = 153, Name = "Serbia and Montenegro" },
                        new { Id = 154, Name = "Seychelles" },
                        new { Id = 155, Name = "Sierra Leone" },
                        new { Id = 156, Name = "Singapore" },
                        new { Id = 157, Name = "Slovakia" },
                        new { Id = 158, Name = "Slovenia" },
                        new { Id = 159, Name = "Solomon Islands" },
                        new { Id = 160, Name = "Somalia" },
                        new { Id = 161, Name = "South Africa" },
                        new { Id = 162, Name = "Spain" },
                        new { Id = 163, Name = "Sri Lanka" },
                        new { Id = 164, Name = "Sudan" },
                        new { Id = 165, Name = "Suriname" },
                        new { Id = 166, Name = "Swaziland" },
                        new { Id = 167, Name = "Sweden" },
                        new { Id = 168, Name = "Switzerland" },
                        new { Id = 169, Name = "Syria" },
                        new { Id = 170, Name = "Taiwan" },
                        new { Id = 171, Name = "Tajikistan" },
                        new { Id = 172, Name = "Tanzania" },
                        new { Id = 173, Name = "Thailand" },
                        new { Id = 174, Name = "Togo" },
                        new { Id = 175, Name = "Tonga" },
                        new { Id = 176, Name = "Trinidad and Tobago" },
                        new { Id = 177, Name = "Tunisia" },
                        new { Id = 178, Name = "Turkey" },
                        new { Id = 179, Name = "Turkmenistan" },
                        new { Id = 180, Name = "Tuvalu" },
                        new { Id = 181, Name = "Uganda" },
                        new { Id = 182, Name = "Ukraine" },
                        new { Id = 183, Name = "United Arab Emirates" },
                        new { Id = 184, Name = "United Kingdom" },
                        new { Id = 185, Name = "United States" },
                        new { Id = 186, Name = "Uruguay" },
                        new { Id = 187, Name = "Uzbekistan" },
                        new { Id = 188, Name = "Vanuatu" },
                        new { Id = 189, Name = "Vatican City" },
                        new { Id = 190, Name = "Venezuela" },
                        new { Id = 191, Name = "Vietnam" },
                        new { Id = 192, Name = "Yemen" },
                        new { Id = 193, Name = "Zambia" },
                        new { Id = 194, Name = "Zimbabwe" }
                    );
                });

            modelBuilder.Entity("Ncma.Repository.Models.Dojo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Style")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Dojos");
                });

            modelBuilder.Entity("Ncma.Repository.Models.DojoInstructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DojoId");

                    b.Property<int?>("InstructorId");

                    b.Property<int?>("InstructorTypeId");

                    b.Property<bool>("IsActive");

                    b.HasKey("Id");

                    b.HasIndex("DojoId");

                    b.HasIndex("InstructorId");

                    b.HasIndex("InstructorTypeId");

                    b.ToTable("DojoInstructors");
                });

            modelBuilder.Entity("Ncma.Repository.Models.InstructorType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("InstructorTypes");

                    b.HasData(
                        new { Id = 1, Name = "Instructor" },
                        new { Id = 2, Name = "Chief Instructor" }
                    );
                });

            modelBuilder.Entity("Ncma.Repository.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Address2")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Address3")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("CellPhone")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("City")
                        .HasMaxLength(90)
                        .IsUnicode(false);

                    b.Property<string>("Comments")
                        .HasColumnType("text");

                    b.Property<int?>("CountryId");

                    b.Property<DateTime?>("DateInactive")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateJoined")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateLastPaid")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateOfRank")
                        .HasColumnType("date");

                    b.Property<DateTime?>("Dob")
                        .HasColumnType("date");

                    b.Property<int?>("DojoId");

                    b.Property<string>("Email")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .HasMaxLength(90)
                        .IsUnicode(false);

                    b.Property<string>("HomePhone")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<int?>("InstructorTypeId");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName")
                        .HasMaxLength(90)
                        .IsUnicode(false);

                    b.Property<int?>("MemberTypeId");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(12)
                        .IsUnicode(false);

                    b.Property<string>("RankText")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int?>("StateId");

                    b.Property<string>("Suffix")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("DojoId");

                    b.HasIndex("InstructorTypeId");

                    b.HasIndex("MemberTypeId");

                    b.HasIndex("StateId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("Ncma.Repository.Models.MemberType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("MemberType");

                    b.HasData(
                        new { Id = 1, Name = "SCHOOL CHARTER MEMBER" },
                        new { Id = 2, Name = "INDIVIDUAL" },
                        new { Id = 3, Name = "INSTRUCTOR" },
                        new { Id = 4, Name = "SCHOOL CHARTER HOLDER" }
                    );
                });

            modelBuilder.Entity("Ncma.Repository.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StateAbbrev")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    b.Property<string>("StateName")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("States");

                    b.HasData(
                        new { Id = 1, StateAbbrev = "AL", StateName = "Alabama" },
                        new { Id = 2, StateAbbrev = "AK", StateName = "Alaska" },
                        new { Id = 3, StateAbbrev = "AZ", StateName = "Arizona" },
                        new { Id = 4, StateAbbrev = "AR", StateName = "Arkansas" },
                        new { Id = 5, StateAbbrev = "CA", StateName = "California" },
                        new { Id = 6, StateAbbrev = "CO", StateName = "Colorado" },
                        new { Id = 7, StateAbbrev = "CT", StateName = "Connecticut" },
                        new { Id = 8, StateAbbrev = "DE", StateName = "Delaware" },
                        new { Id = 9, StateAbbrev = "DC", StateName = "District of Columbia" },
                        new { Id = 10, StateAbbrev = "FL", StateName = "Florida" },
                        new { Id = 11, StateAbbrev = "GA", StateName = "Georgia" },
                        new { Id = 12, StateAbbrev = "HI", StateName = "Hawaii" },
                        new { Id = 13, StateAbbrev = "ID", StateName = "Idaho" },
                        new { Id = 14, StateAbbrev = "IL", StateName = "Illinois" },
                        new { Id = 15, StateAbbrev = "IN", StateName = "Indiana" },
                        new { Id = 16, StateAbbrev = "IA", StateName = "Iowa" },
                        new { Id = 17, StateAbbrev = "KS", StateName = "Kansas" },
                        new { Id = 18, StateAbbrev = "KY", StateName = "Kentucky" },
                        new { Id = 19, StateAbbrev = "LA", StateName = "Louisiana" },
                        new { Id = 20, StateAbbrev = "ME", StateName = "Maine" },
                        new { Id = 21, StateAbbrev = "MD", StateName = "Maryland" },
                        new { Id = 22, StateAbbrev = "MA", StateName = "Massachusetts" },
                        new { Id = 23, StateAbbrev = "MI", StateName = "Michigan" },
                        new { Id = 24, StateAbbrev = "MN", StateName = "Minnesota" },
                        new { Id = 25, StateAbbrev = "MS", StateName = "Mississippi" },
                        new { Id = 26, StateAbbrev = "MO", StateName = "Missouri" },
                        new { Id = 27, StateAbbrev = "MT", StateName = "Montana" },
                        new { Id = 28, StateAbbrev = "NE", StateName = "Nebraska" },
                        new { Id = 29, StateAbbrev = "NV", StateName = "Nevada" },
                        new { Id = 30, StateAbbrev = "NH", StateName = "New Hampshire" },
                        new { Id = 31, StateAbbrev = "NJ", StateName = "New Jersey" },
                        new { Id = 32, StateAbbrev = "NM", StateName = "New Mexico" },
                        new { Id = 33, StateAbbrev = "NY", StateName = "New York" },
                        new { Id = 34, StateAbbrev = "NC", StateName = "North Carolina" },
                        new { Id = 35, StateAbbrev = "ND", StateName = "North Dakota" },
                        new { Id = 36, StateAbbrev = "OH", StateName = "Ohio" },
                        new { Id = 37, StateAbbrev = "OK", StateName = "Oklahoma" },
                        new { Id = 38, StateAbbrev = "OR", StateName = "Oregon" },
                        new { Id = 39, StateAbbrev = "PA", StateName = "Pennsylvania" },
                        new { Id = 40, StateAbbrev = "RI", StateName = "Rhode Island" },
                        new { Id = 41, StateAbbrev = "SC", StateName = "South Carolina" },
                        new { Id = 42, StateAbbrev = "SD", StateName = "South Dakota" },
                        new { Id = 43, StateAbbrev = "TN", StateName = "Tennessee" },
                        new { Id = 44, StateAbbrev = "TX", StateName = "Texas" },
                        new { Id = 45, StateAbbrev = "UT", StateName = "Utah" },
                        new { Id = 46, StateAbbrev = "VT", StateName = "Vermont" },
                        new { Id = 47, StateAbbrev = "VA", StateName = "Virginia" },
                        new { Id = 48, StateAbbrev = "WA", StateName = "Washington" },
                        new { Id = 49, StateAbbrev = "WV", StateName = "West Virginia" },
                        new { Id = 50, StateAbbrev = "WI", StateName = "Wisconsin" },
                        new { Id = 51, StateAbbrev = "WY", StateName = "Wyoming" },
                        new { Id = 52, StateAbbrev = "AB", StateName = "Alberta" },
                        new { Id = 53, StateAbbrev = "BC", StateName = "British Columbia" },
                        new { Id = 54, StateAbbrev = "MB", StateName = "Manitoba" },
                        new { Id = 55, StateAbbrev = "NL", StateName = "Newfoundland" },
                        new { Id = 56, StateAbbrev = "NB", StateName = "New Brunswick" },
                        new { Id = 57, StateAbbrev = "NS", StateName = "Nova Scotia" },
                        new { Id = 58, StateAbbrev = "NT", StateName = "Northwest Territories" },
                        new { Id = 59, StateAbbrev = "NU", StateName = "Nunavut" },
                        new { Id = 60, StateAbbrev = "ON", StateName = "Ontario" },
                        new { Id = 61, StateAbbrev = "PE", StateName = "Prince Edward Island" },
                        new { Id = 62, StateAbbrev = "QC", StateName = "Quebec" },
                        new { Id = 63, StateAbbrev = "SK", StateName = "Saskatchewan" },
                        new { Id = 64, StateAbbrev = "YT", StateName = "Yukon Territory" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Ncma.Repository.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Ncma.Repository.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ncma.Repository.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Ncma.Repository.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ncma.Repository.Models.Certificate", b =>
                {
                    b.HasOne("Ncma.Repository.Models.CertificateType", "CertificateType")
                        .WithMany("Certificates")
                        .HasForeignKey("CertificateTypeId");

                    b.HasOne("Ncma.Repository.Models.Dojo", "Dojo")
                        .WithMany("Certificates")
                        .HasForeignKey("DojoId");

                    b.HasOne("Ncma.Repository.Models.Member", "Instructor")
                        .WithMany()
                        .HasForeignKey("InstructorId");

                    b.HasOne("Ncma.Repository.Models.InstructorType", "InstructorType")
                        .WithMany()
                        .HasForeignKey("InstructorTypeId");

                    b.HasOne("Ncma.Repository.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId");
                });

            modelBuilder.Entity("Ncma.Repository.Models.DojoInstructor", b =>
                {
                    b.HasOne("Ncma.Repository.Models.Dojo", "Dojo")
                        .WithMany("DojoInstructors")
                        .HasForeignKey("DojoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ncma.Repository.Models.Member", "Instructor")
                        .WithMany()
                        .HasForeignKey("InstructorId");

                    b.HasOne("Ncma.Repository.Models.InstructorType", "InstructorType")
                        .WithMany()
                        .HasForeignKey("InstructorTypeId");
                });

            modelBuilder.Entity("Ncma.Repository.Models.Member", b =>
                {
                    b.HasOne("Ncma.Repository.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("Ncma.Repository.Models.Dojo", "Dojo")
                        .WithMany()
                        .HasForeignKey("DojoId");

                    b.HasOne("Ncma.Repository.Models.InstructorType")
                        .WithMany("Instructors")
                        .HasForeignKey("InstructorTypeId");

                    b.HasOne("Ncma.Repository.Models.MemberType", "MemberType")
                        .WithMany("Members")
                        .HasForeignKey("MemberTypeId");

                    b.HasOne("Ncma.Repository.Models.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId");
                });
#pragma warning restore 612, 618
        }
    }
}
