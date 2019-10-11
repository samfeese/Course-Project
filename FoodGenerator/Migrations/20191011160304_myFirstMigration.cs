using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodGenerator.Migrations
{
    public partial class myFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allerigies",
                columns: table => new
                {
                    AllergiesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllergyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allerigies", x => x.AllergiesId);
                });

            migrationBuilder.CreateTable(
                name: "Calender",
                columns: table => new
                {
                    CalanderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calender", x => x.CalanderId);
                });

            migrationBuilder.CreateTable(
                name: "Family",
                columns: table => new
                {
                    FamilyDataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FamilyName = table.Column<string>(nullable: true),
                    FamilyMeals = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Family", x => x.FamilyDataId);
                });

            migrationBuilder.CreateTable(
                name: "Utilities",
                columns: table => new
                {
                    UtilityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilities", x => x.UtilityId);
                });

            migrationBuilder.CreateTable(
                name: "FoodDetails",
                columns: table => new
                {
                    FoodDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FoodName = table.Column<string>(nullable: true),
                    DryStorage = table.Column<bool>(nullable: false),
                    AllergyID = table.Column<int>(nullable: false),
                    AllergiesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodDetails", x => x.FoodDetailsId);
                    table.ForeignKey(
                        name: "FK_FoodDetails_Allerigies_AllergiesId",
                        column: x => x.AllergiesId,
                        principalTable: "Allerigies",
                        principalColumn: "AllergiesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecipeDetails",
                columns: table => new
                {
                    RecipeDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RecipeName = table.Column<string>(nullable: true),
                    RecipeURL = table.Column<string>(nullable: true),
                    FoodId = table.Column<int>(nullable: false),
                    FoodDetailsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeDetails", x => x.RecipeDetailsId);
                    table.ForeignKey(
                        name: "FK_RecipeDetails_FoodDetails_FoodDetailsId",
                        column: x => x.FoodDetailsId,
                        principalTable: "FoodDetails",
                        principalColumn: "FoodDetailsId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MealCategories",
                columns: table => new
                {
                    MealCategoriesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MealName = table.Column<string>(nullable: true),
                    MealCategory = table.Column<string>(nullable: true),
                    RecipeId = table.Column<int>(nullable: false),
                    RecipeDetailsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealCategories", x => x.MealCategoriesId);
                    table.ForeignKey(
                        name: "FK_MealCategories_RecipeDetails_RecipeDetailsId",
                        column: x => x.RecipeDetailsId,
                        principalTable: "RecipeDetails",
                        principalColumn: "RecipeDetailsId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BreakfastMeals",
                columns: table => new
                {
                    BreakfastMealsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BreakfastMealName = table.Column<string>(nullable: true),
                    MealDesciption = table.Column<string>(nullable: true),
                    UtilityId = table.Column<int>(nullable: false),
                    MealCategoriesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreakfastMeals", x => x.BreakfastMealsId);
                    table.ForeignKey(
                        name: "FK_BreakfastMeals_MealCategories_MealCategoriesId",
                        column: x => x.MealCategoriesId,
                        principalTable: "MealCategories",
                        principalColumn: "MealCategoriesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BreakfastMeals_Utilities_UtilityId",
                        column: x => x.UtilityId,
                        principalTable: "Utilities",
                        principalColumn: "UtilityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DinnerMeals",
                columns: table => new
                {
                    DinnerMealsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DinnerMealName = table.Column<string>(nullable: true),
                    UtilityId = table.Column<int>(nullable: false),
                    MealCategoriesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DinnerMeals", x => x.DinnerMealsId);
                    table.ForeignKey(
                        name: "FK_DinnerMeals_MealCategories_MealCategoriesId",
                        column: x => x.MealCategoriesId,
                        principalTable: "MealCategories",
                        principalColumn: "MealCategoriesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DinnerMeals_Utilities_UtilityId",
                        column: x => x.UtilityId,
                        principalTable: "Utilities",
                        principalColumn: "UtilityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LunchMeals",
                columns: table => new
                {
                    LunchMealsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LunchMealName = table.Column<string>(nullable: true),
                    UtilityId = table.Column<int>(nullable: false),
                    MealCategoriesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LunchMeals", x => x.LunchMealsId);
                    table.ForeignKey(
                        name: "FK_LunchMeals_MealCategories_MealCategoriesId",
                        column: x => x.MealCategoriesId,
                        principalTable: "MealCategories",
                        principalColumn: "MealCategoriesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LunchMeals_Utilities_UtilityId",
                        column: x => x.UtilityId,
                        principalTable: "Utilities",
                        principalColumn: "UtilityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BreakfastMeals_MealCategoriesId",
                table: "BreakfastMeals",
                column: "MealCategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_BreakfastMeals_UtilityId",
                table: "BreakfastMeals",
                column: "UtilityId");

            migrationBuilder.CreateIndex(
                name: "IX_DinnerMeals_MealCategoriesId",
                table: "DinnerMeals",
                column: "MealCategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_DinnerMeals_UtilityId",
                table: "DinnerMeals",
                column: "UtilityId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodDetails_AllergiesId",
                table: "FoodDetails",
                column: "AllergiesId");

            migrationBuilder.CreateIndex(
                name: "IX_LunchMeals_MealCategoriesId",
                table: "LunchMeals",
                column: "MealCategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_LunchMeals_UtilityId",
                table: "LunchMeals",
                column: "UtilityId");

            migrationBuilder.CreateIndex(
                name: "IX_MealCategories_RecipeDetailsId",
                table: "MealCategories",
                column: "RecipeDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeDetails_FoodDetailsId",
                table: "RecipeDetails",
                column: "FoodDetailsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BreakfastMeals");

            migrationBuilder.DropTable(
                name: "Calender");

            migrationBuilder.DropTable(
                name: "DinnerMeals");

            migrationBuilder.DropTable(
                name: "Family");

            migrationBuilder.DropTable(
                name: "LunchMeals");

            migrationBuilder.DropTable(
                name: "MealCategories");

            migrationBuilder.DropTable(
                name: "Utilities");

            migrationBuilder.DropTable(
                name: "RecipeDetails");

            migrationBuilder.DropTable(
                name: "FoodDetails");

            migrationBuilder.DropTable(
                name: "Allerigies");
        }
    }
}
