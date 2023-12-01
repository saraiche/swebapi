using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace swebapi.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "21ed80cc-8485-4723-9332-83bdd668d54c", "a81be686-aa89-42ee-ae58-af56380dd6d6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "20cd4495-202c-4427-a6eb-4f121bcc91c3", "bf1397fc-97a8-48eb-8395-3e3b4771c36f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "21ed80cc-8485-4723-9332-83bdd668d54c", "f5a818a3-e6d9-43ad-bcd6-5961468614dd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20cd4495-202c-4427-a6eb-4f121bcc91c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21ed80cc-8485-4723-9332-83bdd668d54c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a81be686-aa89-42ee-ae58-af56380dd6d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf1397fc-97a8-48eb-8395-3e3b4771c36f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5a818a3-e6d9-43ad-bcd6-5961468614dd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5fa37031-20cb-4c33-ad0e-6f060ce60936", "3b798bd7-668e-43cf-b1a8-d9d4bd091614", "Administrador", "ADMINISTRADOR" },
                    { "eb7c22a8-8de7-4369-ba5f-c5ceda76e0bc", "874f4002-47fa-4a4e-82a3-72e5812f1266", "Usuario general", "USUARIO GENERAL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3423845e-fe80-4164-8a98-163e0ae67d6c", 0, "ae90c92a-ec83-4ebf-bf64-ad919cc80c30", "gvera@uv.mx", false, false, null, "Guillermo Humberto Vera Amaro", "GVERA@UV.MX", "GVERA@UV.MX", "AQAAAAEAACcQAAAAEGwWJ8wzi43HI3d7SWv+vMfRXMcUtyXDbIpjFgpkW5VdOaS2DknBkH9Bn6KB6cPZaQ==", null, false, "a298d621-3de2-44f9-a8bc-fc12d63dbdb5", false, "gvera@uv.mx" },
                    { "c47e9259-4043-4b56-9bc4-a4399a3e634b", 0, "06f3cf17-f56b-4826-b4be-b94745d4731c", "gochoa@uv,mx", false, false, null, "Gerardo Ochoa Martínez", "GOCHOA@UV.MX", "GOCHOA@UV.MX", "AQAAAAEAACcQAAAAEDu4fJqblCQQmXUl0wEtP9QcKUUqAvgL7pWcB2MAjMqOJ/ovGfkGlZifqEu40YDylg==", null, false, "d157fdf5-6fb7-4766-accf-bcc6555a6643", false, "gochoa@uv.mx" },
                    { "f69f014b-7ecb-4fde-b3de-c78008d3742b", 0, "eebf0e0a-21d1-4dcb-9535-6bec72dadcc4", "sperez@uv.mx", false, false, null, "Saúl Pérez García", "SPEREZ@UV.MX", "SPEREZ@UV.MX", "AQAAAAEAACcQAAAAEJS2ivpn+IMgG9B2fxrNxEgAGAnEWXZBPkapvPiMbk55qNDP8R3Jo8wISvLG7roKFQ==", null, false, "1d85308f-6ff4-4a2a-80e4-401cc4456212", false, "sperez@uv.mx" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5fa37031-20cb-4c33-ad0e-6f060ce60936", "3423845e-fe80-4164-8a98-163e0ae67d6c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "eb7c22a8-8de7-4369-ba5f-c5ceda76e0bc", "c47e9259-4043-4b56-9bc4-a4399a3e634b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5fa37031-20cb-4c33-ad0e-6f060ce60936", "f69f014b-7ecb-4fde-b3de-c78008d3742b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5fa37031-20cb-4c33-ad0e-6f060ce60936", "3423845e-fe80-4164-8a98-163e0ae67d6c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eb7c22a8-8de7-4369-ba5f-c5ceda76e0bc", "c47e9259-4043-4b56-9bc4-a4399a3e634b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5fa37031-20cb-4c33-ad0e-6f060ce60936", "f69f014b-7ecb-4fde-b3de-c78008d3742b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fa37031-20cb-4c33-ad0e-6f060ce60936");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb7c22a8-8de7-4369-ba5f-c5ceda76e0bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3423845e-fe80-4164-8a98-163e0ae67d6c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c47e9259-4043-4b56-9bc4-a4399a3e634b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f69f014b-7ecb-4fde-b3de-c78008d3742b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "20cd4495-202c-4427-a6eb-4f121bcc91c3", "3c2619e0-49ba-43ad-982d-37b4b50a247c", "Usuario general", "USUARIO GENERAL" },
                    { "21ed80cc-8485-4723-9332-83bdd668d54c", "b461d0ad-c8af-4d6b-9c00-319d439583c6", "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a81be686-aa89-42ee-ae58-af56380dd6d6", 0, "87c37060-5464-4578-aeda-db06f110afeb", null, false, false, null, "Saúl Pérez García", "SPEREZ@UV.MX", "SPEREZ@UV.MX", "AQAAAAEAACcQAAAAEH2HubmriasTyrh9y2/kX15tWUML3Jj0DvFfI1OjfIuDyPDUIMZHjKPB9kHT3rRQCg==", null, false, "aedbd466-2b35-4877-9508-15d88df2423f", false, "sperez@uv.mx" },
                    { "bf1397fc-97a8-48eb-8395-3e3b4771c36f", 0, "ec2d961f-aaa5-4883-ab26-7b7b69f80300", null, false, false, null, "Gerardo Ochoa Martínez", "GOCHOA@UV.MX", "GOCHOA@UV.MX", "AQAAAAEAACcQAAAAECWkpkY+NSFSXAZkmi2cYe/yPq+K2Dz7u3rZPqzAm5rne/dTWO/eo0z0VQjxTBnCBA==", null, false, "c1015dea-fc8d-49b5-884a-f5c4d5e55cb5", false, "gochoa@uv.mx" },
                    { "f5a818a3-e6d9-43ad-bcd6-5961468614dd", 0, "7d79ec46-ee4e-4ea8-b4fa-3c33f41deb7d", null, false, false, null, "Guillermo Humberto Vera Amaro", "GVERA@UV.MX", "GVERA@UV.MX", "AQAAAAEAACcQAAAAEKfSgEvrgmPvFJ8SnjKthYa9AUN+AtPpq2GTOEawmY0g+xtK+hv3Ru0BZ28e52Rm0Q==", null, false, "9cd73346-0133-41a5-bc5e-2a38d92cacca", false, "gvera@uv.mx" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "21ed80cc-8485-4723-9332-83bdd668d54c", "a81be686-aa89-42ee-ae58-af56380dd6d6" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "20cd4495-202c-4427-a6eb-4f121bcc91c3", "bf1397fc-97a8-48eb-8395-3e3b4771c36f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "21ed80cc-8485-4723-9332-83bdd668d54c", "f5a818a3-e6d9-43ad-bcd6-5961468614dd" });
        }
    }
}
