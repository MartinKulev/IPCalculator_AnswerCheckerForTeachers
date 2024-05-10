using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace IPTestFormASPTeacherApp.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IPInfos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Number = table.Column<string>(type: "longtext", nullable: false),
                    SchoolClass = table.Column<string>(type: "longtext", nullable: false),
                    TurnedInDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IPDec = table.Column<string>(type: "longtext", nullable: false),
                    IPBin = table.Column<string>(type: "longtext", nullable: false),
                    NetworkClass = table.Column<string>(type: "varchar(1)", nullable: false),
                    SMBin = table.Column<string>(type: "longtext", nullable: false),
                    SMDec = table.Column<string>(type: "longtext", nullable: false),
                    NABin = table.Column<string>(type: "longtext", nullable: false),
                    NADec = table.Column<string>(type: "longtext", nullable: false),
                    BRABin = table.Column<string>(type: "longtext", nullable: false),
                    BRADec = table.Column<string>(type: "longtext", nullable: false),
                    Range = table.Column<string>(type: "longtext", nullable: false),
                    SubnetCount = table.Column<int>(type: "int", nullable: false),
                    SubnetSMBin = table.Column<string>(type: "longtext", nullable: false),
                    SubnetSMDec = table.Column<string>(type: "longtext", nullable: false),
                    SubnetNABin1 = table.Column<string>(type: "longtext", nullable: false),
                    SubnetNADec1 = table.Column<string>(type: "longtext", nullable: false),
                    SubnetBRABin1 = table.Column<string>(type: "longtext", nullable: false),
                    SubnetBRADec1 = table.Column<string>(type: "longtext", nullable: false),
                    SubnetRange1 = table.Column<string>(type: "longtext", nullable: false),
                    SubnetNABin2 = table.Column<string>(type: "longtext", nullable: false),
                    SubnetNADec2 = table.Column<string>(type: "longtext", nullable: false),
                    SubnetBRABin2 = table.Column<string>(type: "longtext", nullable: false),
                    SubnetBRADec2 = table.Column<string>(type: "longtext", nullable: false),
                    SubnetRange2 = table.Column<string>(type: "longtext", nullable: false),
                    SubnetNABin3 = table.Column<string>(type: "longtext", nullable: false),
                    SubnetNADec3 = table.Column<string>(type: "longtext", nullable: false),
                    SubnetBRABin3 = table.Column<string>(type: "longtext", nullable: false),
                    SubnetBRADec3 = table.Column<string>(type: "longtext", nullable: false),
                    SubnetRange3 = table.Column<string>(type: "longtext", nullable: false),
                    InputIPBin = table.Column<string>(type: "longtext", nullable: false),
                    InputNetworkClass = table.Column<string>(type: "varchar(1)", nullable: false),
                    InputSMBin = table.Column<string>(type: "longtext", nullable: false),
                    InputSMDec = table.Column<string>(type: "longtext", nullable: false),
                    InputNABin = table.Column<string>(type: "longtext", nullable: false),
                    InputNADec = table.Column<string>(type: "longtext", nullable: false),
                    InputBRABin = table.Column<string>(type: "longtext", nullable: false),
                    InputBRADec = table.Column<string>(type: "longtext", nullable: false),
                    InputRange = table.Column<string>(type: "longtext", nullable: false),
                    InputSubnetSMBin = table.Column<string>(type: "longtext", nullable: false),
                    InputSubnetSMDec = table.Column<string>(type: "longtext", nullable: false),
                    InputSubnetNABin1 = table.Column<string>(type: "longtext", nullable: false),
                    InputSubnetNADec1 = table.Column<string>(type: "longtext", nullable: false),
                    InputSubnetBRABin1 = table.Column<string>(type: "longtext", nullable: false),
                    InputSubnetBRADec1 = table.Column<string>(type: "longtext", nullable: false),
                    InputSubnetRange1 = table.Column<string>(type: "longtext", nullable: false),
                    InputSubnetNABin2 = table.Column<string>(type: "longtext", nullable: false),
                    InputSubnetNADec2 = table.Column<string>(type: "longtext", nullable: false),
                    InputSubnetBRABin2 = table.Column<string>(type: "longtext", nullable: false),
                    InputSubnetBRADec2 = table.Column<string>(type: "longtext", nullable: false),
                    InputSubnetRange2 = table.Column<string>(type: "longtext", nullable: false),
                    InputSubnetNABin3 = table.Column<string>(type: "longtext", nullable: false),
                    InputSubnetNADec3 = table.Column<string>(type: "longtext", nullable: false),
                    InputSubnetBRABin3 = table.Column<string>(type: "longtext", nullable: false),
                    InputSubnetBRADec3 = table.Column<string>(type: "longtext", nullable: false),
                    InputSubnetRange3 = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPInfos", x => x.ID);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IPInfos");
        }
    }
}
