using Microsoft.EntityFrameworkCore.Migrations;

namespace MeisterIdentityAPI.Migrations
{
    public partial class SQLTableCorrections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApiUserClaims_ApiUsers_UserId",
                table: "ApiUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_ApiUserLogins_ApiUsers_UserId",
                table: "ApiUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_ApiUserRoles_ApiUsers_UserId",
                table: "ApiUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_ApiUserRoles_Roles_RoleId",
                table: "ApiUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_ApiUserTokens_ApiUsers_UserId",
                table: "ApiUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                table: "RoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaims",
                table: "RoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApiUserTokens",
                table: "ApiUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApiUsers",
                table: "ApiUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApiUserRoles",
                table: "ApiUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApiUserLogins",
                table: "ApiUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApiUserClaims",
                table: "ApiUserClaims");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                newName: "RoleClaims");

            migrationBuilder.RenameTable(
                name: "ApiUserTokens",
                newName: "ApiUserTokens");

            migrationBuilder.RenameTable(
                name: "ApiUsers",
                newName: "ApiUsers");

            migrationBuilder.RenameTable(
                name: "ApiUserRoles",
                newName: "ApiUserRoles");

            migrationBuilder.RenameTable(
                name: "ApiUserLogins",
                newName: "ApiUserLogins");

            migrationBuilder.RenameTable(
                name: "ApiUserClaims",
                newName: "ApiUserClaims");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                newName: "IX_RoleClaims_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_ApiUserRoles_RoleId",
                table: "ApiUserRoles",
                newName: "IX_ApiUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_ApiUserLogins_UserId",
                table: "ApiUserLogins",
                newName: "IX_ApiUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ApiUserClaims_UserId",
                table: "ApiUserClaims",
                newName: "IX_ApiUserClaims_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaims",
                table: "RoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApiUserTokens",
                table: "ApiUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApiUsers",
                table: "ApiUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApiUserRoles",
                table: "ApiUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApiUserLogins",
                table: "ApiUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApiUserClaims",
                table: "ApiUserClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                table: "RoleClaims",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApiUserClaims_ApiUsers_UserId",
                table: "ApiUserClaims",
                column: "UserId",
                principalTable: "ApiUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApiUserLogins_ApiUsers_UserId",
                table: "ApiUserLogins",
                column: "UserId",
                principalTable: "ApiUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApiUserRoles_Roles_RoleId",
                table: "ApiUserRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApiUserRoles_ApiUsers_UserId",
                table: "ApiUserRoles",
                column: "UserId",
                principalTable: "ApiUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApiUserTokens_ApiUsers_UserId",
                table: "ApiUserTokens",
                column: "UserId",
                principalTable: "ApiUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                table: "RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_ApiUserClaims_ApiUsers_UserId",
                table: "ApiUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_ApiUserLogins_ApiUsers_UserId",
                table: "ApiUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_ApiUserRoles_Roles_RoleId",
                table: "ApiUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_ApiUserRoles_ApiUsers_UserId",
                table: "ApiUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_ApiUserTokens_ApiUsers_UserId",
                table: "ApiUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApiUserTokens",
                table: "ApiUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApiUsers",
                table: "ApiUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApiUserRoles",
                table: "ApiUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApiUserLogins",
                table: "ApiUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApiUserClaims",
                table: "ApiUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaims",
                table: "RoleClaims");

            migrationBuilder.RenameTable(
                name: "ApiUserTokens",
                newName: "ApiUserTokens");

            migrationBuilder.RenameTable(
                name: "ApiUsers",
                newName: "ApiUsers");

            migrationBuilder.RenameTable(
                name: "ApiUserRoles",
                newName: "ApiUserRoles");

            migrationBuilder.RenameTable(
                name: "ApiUserLogins",
                newName: "ApiUserLogins");

            migrationBuilder.RenameTable(
                name: "ApiUserClaims",
                newName: "ApiUserClaims");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                newName: "RoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_ApiUserRoles_RoleId",
                table: "ApiUserRoles",
                newName: "IX_ApiUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_ApiUserLogins_UserId",
                table: "ApiUserLogins",
                newName: "IX_ApiUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ApiUserClaims_UserId",
                table: "ApiUserClaims",
                newName: "IX_ApiUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                newName: "IX_RoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApiUserTokens",
                table: "ApiUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApiUsers",
                table: "ApiUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApiUserRoles",
                table: "ApiUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApiUserLogins",
                table: "ApiUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApiUserClaims",
                table: "ApiUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaims",
                table: "RoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApiUserClaims_ApiUsers_UserId",
                table: "ApiUserClaims",
                column: "UserId",
                principalTable: "ApiUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApiUserLogins_ApiUsers_UserId",
                table: "ApiUserLogins",
                column: "UserId",
                principalTable: "ApiUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApiUserRoles_ApiUsers_UserId",
                table: "ApiUserRoles",
                column: "UserId",
                principalTable: "ApiUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApiUserRoles_Roles_RoleId",
                table: "ApiUserRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApiUserTokens_ApiUsers_UserId",
                table: "ApiUserTokens",
                column: "UserId",
                principalTable: "ApiUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                table: "RoleClaims",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
