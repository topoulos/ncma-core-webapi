using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ncma.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CertificateTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    ValidationDurationInDays = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dojos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Style = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dojos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstructorTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstructorTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StateName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    StateAbbrev = table.Column<string>(unicode: false, maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastName = table.Column<string>(unicode: false, maxLength: 90, nullable: true),
                    FirstName = table.Column<string>(unicode: false, maxLength: 90, nullable: true),
                    MiddleName = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    Suffix = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Address1 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Address2 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Address3 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    City = table.Column<string>(unicode: false, maxLength: 90, nullable: true),
                    StateId = table.Column<int>(nullable: true),
                    CountryId = table.Column<int>(nullable: true),
                    PostalCode = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    HomePhone = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CellPhone = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 125, nullable: true),
                    Dob = table.Column<DateTime>(type: "date", nullable: true),
                    DojoId = table.Column<int>(nullable: true),
                    MemberTypeId = table.Column<int>(nullable: true),
                    DateJoined = table.Column<DateTime>(type: "date", nullable: true),
                    DateOfRank = table.Column<DateTime>(type: "date", nullable: true),
                    RankText = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    DateInactive = table.Column<DateTime>(type: "date", nullable: true),
                    DateLastPaid = table.Column<DateTime>(type: "date", nullable: true),
                    Comments = table.Column<string>(type: "text", nullable: true),
                    InstructorTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Members_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Members_Dojos_DojoId",
                        column: x => x.DojoId,
                        principalTable: "Dojos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Members_InstructorTypes_InstructorTypeId",
                        column: x => x.InstructorTypeId,
                        principalTable: "InstructorTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Members_MemberType_MemberTypeId",
                        column: x => x.MemberTypeId,
                        principalTable: "MemberType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Members_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    MemberId = table.Column<int>(nullable: true),
                    DojoId = table.Column<int>(nullable: true),
                    CertificateTypeId = table.Column<int>(nullable: true),
                    RankText = table.Column<string>(nullable: true),
                    InstructorId = table.Column<int>(nullable: true),
                    InstructorTypeId = table.Column<int>(nullable: true),
                    FromDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ThruDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Completed = table.Column<bool>(nullable: false),
                    BatchId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Certificates_CertificateTypes_CertificateTypeId",
                        column: x => x.CertificateTypeId,
                        principalTable: "CertificateTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Certificates_Dojos_DojoId",
                        column: x => x.DojoId,
                        principalTable: "Dojos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Certificates_Members_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Certificates_InstructorTypes_InstructorTypeId",
                        column: x => x.InstructorTypeId,
                        principalTable: "InstructorTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Certificates_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DojoInstructors",
                columns: table => new
                {
                    DojoId = table.Column<int>(nullable: false),
                    InstructorId = table.Column<int>(nullable: true),
                    InstructorTypeId = table.Column<int>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DojoInstructors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DojoInstructors_Dojos_DojoId",
                        column: x => x.DojoId,
                        principalTable: "Dojos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DojoInstructors_Members_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DojoInstructors_InstructorTypes_InstructorTypeId",
                        column: x => x.InstructorTypeId,
                        principalTable: "InstructorTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "CertificateTypes",
                columns: new[] { "Id", "Description", "Name", "ValidationDurationInDays" },
                values: new object[,]
                {
                    { 1, "Rank Certificate", "Rank", 365 },
                    { 9, "Tenshi Instructor Certificate", "Tenshi Instructor", 365 },
                    { 8, "Tenshi School Charter Certificate", "Tenshi School Charter", 365 },
                    { 7, "Tenshi Membership Certificate", "Tenshi Membership", 365 },
                    { 6, "Chief Instructor Certificate", "Chief Instructor", 365 },
                    { 10, "Hanshi Seminar Certificate", "Hanshi Seminar", 365 },
                    { 4, "Member Certificate", "Membership", 365 },
                    { 3, "Instructor Certificate", "Instructor", 365 },
                    { 2, "School Charter Certificate", "School Charter", 365 },
                    { 5, "Tenshi Rank Certificate", "Tenshi Rank", 365 }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 134, "Papua New Guinea" },
                    { 125, "New Zealand" },
                    { 126, "Nicaragua" },
                    { 128, "Nigeria" },
                    { 129, "Norway" },
                    { 130, "Oman" },
                    { 131, "Pakistan" },
                    { 132, "Palau" },
                    { 133, "Panama" },
                    { 135, "Paraguay" },
                    { 140, "Puerto Rico" },
                    { 137, "Philippines" },
                    { 138, "Poland" },
                    { 139, "Portugal" },
                    { 124, "Netherlands" },
                    { 141, "Qatar" },
                    { 142, "Romania" },
                    { 143, "Russia" },
                    { 144, "Rwanda" },
                    { 145, "Saint Kitts and Nevis" },
                    { 136, "Peru" },
                    { 123, "Nepal" },
                    { 118, "Morocco" },
                    { 121, "Namibia" },
                    { 100, "Lithuania" },
                    { 101, "Luxembourg" },
                    { 102, "Macedonia" },
                    { 103, "Madagascar" },
                    { 104, "Malawi" },
                    { 105, "Malaysia" },
                    { 106, "Maldives" },
                    { 107, "Mali" },
                    { 108, "Malta" },
                    { 109, "Marshall Islands" },
                    { 110, "Mauritania" },
                    { 111, "Mauritius" },
                    { 112, "Mexico" },
                    { 113, "Micronesia" },
                    { 114, "Moldova" },
                    { 115, "Monaco" },
                    { 116, "Mongolia" },
                    { 117, "Montenegro" },
                    { 146, "Saint Lucia" },
                    { 119, "Mozambique" },
                    { 120, "Myanmar" },
                    { 122, "Nauru" },
                    { 147, "Saint Vincent and the Grenadines" },
                    { 152, "Senegal" },
                    { 149, "San Marino" },
                    { 175, "Tonga" },
                    { 176, "Trinidad and Tobago" },
                    { 177, "Tunisia" },
                    { 178, "Turkey" },
                    { 179, "Turkmenistan" },
                    { 180, "Tuvalu" },
                    { 181, "Uganda" },
                    { 182, "Ukraine" },
                    { 183, "United Arab Emirates" },
                    { 174, "Togo" },
                    { 184, "United Kingdom" },
                    { 186, "Uruguay" },
                    { 187, "Uzbekistan" },
                    { 188, "Vanuatu" },
                    { 189, "Vatican City" },
                    { 190, "Venezuela" },
                    { 191, "Vietnam" },
                    { 192, "Yemen" },
                    { 193, "Zambia" },
                    { 194, "Zimbabwe" },
                    { 185, "United States" },
                    { 173, "Thailand" },
                    { 172, "Tanzania" },
                    { 171, "Tajikistan" },
                    { 150, "Sao Tome and Principe" },
                    { 151, "Saudi Arabia" },
                    { 99, "Liechtenstein" },
                    { 153, "Serbia and Montenegro" },
                    { 154, "Seychelles" },
                    { 155, "Sierra Leone" },
                    { 156, "Singapore" },
                    { 157, "Slovakia" },
                    { 158, "Slovenia" },
                    { 159, "Solomon Islands" },
                    { 160, "Somalia" },
                    { 161, "South Africa" },
                    { 162, "Spain" },
                    { 163, "Sri Lanka" },
                    { 164, "Sudan" },
                    { 165, "Suriname" },
                    { 166, "Swaziland" },
                    { 167, "Sweden" },
                    { 168, "Switzerland" },
                    { 169, "Syria" },
                    { 170, "Taiwan" },
                    { 148, "Samoa" },
                    { 98, "Libya" },
                    { 127, "Niger" },
                    { 96, "Lesotho" },
                    { 26, "Burkina Faso" },
                    { 27, "Burundi" },
                    { 28, "Cambodia" },
                    { 29, "Cameroon" },
                    { 30, "Canada" },
                    { 31, "Cape Verde" },
                    { 32, "Central African Republic" },
                    { 33, "Chad" },
                    { 34, "Chile" },
                    { 35, "China" },
                    { 36, "Colombia" },
                    { 37, "Comoros" },
                    { 38, "Congo" },
                    { 39, "Costa Rica" },
                    { 40, "Cote dIvoire" },
                    { 41, "Croatia" },
                    { 42, "Cuba" },
                    { 43, "Cyprus" },
                    { 44, "Czech Republic" },
                    { 45, "Denmark" },
                    { 46, "Djibouti" },
                    { 25, "Bulgaria" },
                    { 47, "Dominica" },
                    { 24, "Brunei" },
                    { 22, "Botswana" },
                    { 1, "Afghanistan" },
                    { 2, "Albania" },
                    { 3, "Algeria" },
                    { 4, "Andorra" },
                    { 5, "Antigua and Barbuda" },
                    { 6, "Argentina" },
                    { 7, "Armenia" },
                    { 8, "Australia" },
                    { 9, "Austria" },
                    { 10, "Azerbaijan" },
                    { 11, "Bahamas" },
                    { 12, "Bahrain" },
                    { 13, "Bangladesh" },
                    { 97, "Liberia" },
                    { 15, "Belarus" },
                    { 16, "Belgium" },
                    { 17, "Belize" },
                    { 18, "Benin" },
                    { 19, "Bhutan" },
                    { 20, "Bolivia" },
                    { 21, "Bosnia and Herzegovina" },
                    { 23, "Brazil" },
                    { 48, "Dominican Republic" },
                    { 14, "Barbados" },
                    { 50, "Ecuador" },
                    { 75, "Iceland" },
                    { 76, "India" },
                    { 77, "Indonesia" },
                    { 78, "Iran" },
                    { 79, "Iraq" },
                    { 80, "Ireland" },
                    { 81, "Israel" },
                    { 82, "Italy" },
                    { 83, "Jamaica" },
                    { 84, "Japan" },
                    { 85, "Jordan" },
                    { 86, "Kazakhstan" },
                    { 87, "Kenya" },
                    { 88, "Kiribati" },
                    { 89, "North Korea" },
                    { 91, "Kuwait" },
                    { 92, "Kyrgyzstan" },
                    { 93, "Laos" },
                    { 94, "Latvia" },
                    { 95, "Lebanon" },
                    { 49, "East Timor" },
                    { 74, "Hungary" },
                    { 73, "Hong Kong" },
                    { 90, "South Korea" },
                    { 71, "Haiti" },
                    { 51, "Egypt" },
                    { 72, "Honduras" },
                    { 52, "El Salvador" },
                    { 54, "Eritrea" },
                    { 55, "Estonia" },
                    { 56, "Ethiopia" },
                    { 57, "Fiji" },
                    { 58, "Finland" },
                    { 59, "France" },
                    { 60, "Gabon" },
                    { 53, "Equatorial Guinea" },
                    { 62, "Georgia" },
                    { 63, "Germany" },
                    { 64, "Ghana" },
                    { 65, "Greece" },
                    { 70, "Guyana" },
                    { 66, "Grenada" },
                    { 67, "Guatemala" },
                    { 69, "Guinea-Bissau" },
                    { 68, "Guinea" },
                    { 61, "Gambia" }
                });

            migrationBuilder.InsertData(
                table: "InstructorTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Instructor" },
                    { 2, "Chief Instructor" }
                });

            migrationBuilder.InsertData(
                table: "MemberType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "SCHOOL CHARTER HOLDER" },
                    { 3, "INSTRUCTOR" },
                    { 1, "SCHOOL CHARTER MEMBER" },
                    { 2, "INDIVIDUAL" }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "StateAbbrev", "StateName" },
                values: new object[,]
                {
                    { 46, "VT", "Vermont" },
                    { 36, "OH", "Ohio" },
                    { 34, "NC", "North Carolina" },
                    { 37, "OK", "Oklahoma" },
                    { 38, "OR", "Oregon" },
                    { 39, "PA", "Pennsylvania" },
                    { 35, "ND", "North Dakota" },
                    { 40, "RI", "Rhode Island" },
                    { 41, "SC", "South Carolina" },
                    { 42, "SD", "South Dakota" },
                    { 43, "TN", "Tennessee" },
                    { 44, "TX", "Texas" },
                    { 45, "UT", "Utah" },
                    { 47, "VA", "Virginia" },
                    { 60, "ON", "Ontario" },
                    { 49, "WV", "West Virginia" },
                    { 50, "WI", "Wisconsin" },
                    { 51, "WY", "Wyoming" },
                    { 52, "AB", "Alberta" },
                    { 53, "BC", "British Columbia" },
                    { 54, "MB", "Manitoba" },
                    { 55, "NL", "Newfoundland" },
                    { 56, "NB", "New Brunswick" },
                    { 57, "NS", "Nova Scotia" },
                    { 58, "NT", "Northwest Territories" },
                    { 59, "NU", "Nunavut" },
                    { 61, "PE", "Prince Edward Island" },
                    { 33, "NY", "New York" },
                    { 62, "QC", "Quebec" },
                    { 48, "WA", "Washington" },
                    { 32, "NM", "New Mexico" },
                    { 6, "CO", "Colorado" },
                    { 30, "NH", "New Hampshire" },
                    { 63, "SK", "Saskatchewan" },
                    { 1, "AL", "Alabama" },
                    { 2, "AK", "Alaska" },
                    { 3, "AZ", "Arizona" },
                    { 4, "AR", "Arkansas" },
                    { 5, "CA", "California" },
                    { 7, "CT", "Connecticut" },
                    { 8, "DE", "Delaware" },
                    { 9, "DC", "District of Columbia" },
                    { 10, "FL", "Florida" },
                    { 11, "GA", "Georgia" },
                    { 12, "HI", "Hawaii" },
                    { 13, "ID", "Idaho" },
                    { 14, "IL", "Illinois" },
                    { 15, "IN", "Indiana" },
                    { 16, "IA", "Iowa" },
                    { 17, "KS", "Kansas" },
                    { 18, "KY", "Kentucky" },
                    { 19, "LA", "Louisiana" },
                    { 20, "ME", "Maine" },
                    { 21, "MD", "Maryland" },
                    { 22, "MA", "Massachusetts" },
                    { 23, "MI", "Michigan" },
                    { 24, "MN", "Minnesota" },
                    { 25, "MS", "Mississippi" },
                    { 26, "MO", "Missouri" },
                    { 27, "MT", "Montana" },
                    { 28, "NE", "Nebraska" },
                    { 29, "NV", "Nevada" },
                    { 31, "NJ", "New Jersey" },
                    { 64, "YT", "Yukon Territory" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_CertificateTypeId",
                table: "Certificates",
                column: "CertificateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_DojoId",
                table: "Certificates",
                column: "DojoId");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_InstructorId",
                table: "Certificates",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_InstructorTypeId",
                table: "Certificates",
                column: "InstructorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_MemberId",
                table: "Certificates",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_DojoInstructors_DojoId",
                table: "DojoInstructors",
                column: "DojoId");

            migrationBuilder.CreateIndex(
                name: "IX_DojoInstructors_InstructorId",
                table: "DojoInstructors",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_DojoInstructors_InstructorTypeId",
                table: "DojoInstructors",
                column: "InstructorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_CountryId",
                table: "Members",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_DojoId",
                table: "Members",
                column: "DojoId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_InstructorTypeId",
                table: "Members",
                column: "InstructorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_MemberTypeId",
                table: "Members",
                column: "MemberTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_StateId",
                table: "Members",
                column: "StateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "DojoInstructors");

            migrationBuilder.DropTable(
                name: "CertificateTypes");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Dojos");

            migrationBuilder.DropTable(
                name: "InstructorTypes");

            migrationBuilder.DropTable(
                name: "MemberType");

            migrationBuilder.DropTable(
                name: "States");
        }
    }
}
