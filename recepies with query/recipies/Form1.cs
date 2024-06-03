using Dapper;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recipies
{
    public partial class Form1 : Form
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load_1(object sender, EventArgs e)
        {
            await LoadRecipes();
        }

        private async Task LoadRecipes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    var recipes = await connection.QueryAsync<dynamic>("GetAllRecipes", commandType: CommandType.StoredProcedure);
                    dgvRecipes.DataSource = recipes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var recipe = new
            {
                title = txtTitle.Text,
                description = txtDescription.Text,
                instructions = txtInstructions.Text,
                servings = (int)numServings.Value,
                prep_time = (int)numPrepTime.Value,
                cook_time = (int)numCookTime.Value,
                total_time = (int)numTotalTime.Value
            };

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    DynamicParameters dynParameters = new DynamicParameters();
                    dynParameters.Add("@title", recipe.title);
                    dynParameters.Add("@description", recipe.description);
                    dynParameters.Add("@instructions", recipe.instructions);
                    dynParameters.Add("@servings", recipe.servings, DbType.Int32);
                    dynParameters.Add("@prep_time", recipe.prep_time, DbType.Int32);
                    dynParameters.Add("@cook_time", recipe.cook_time, DbType.Int32);
                    dynParameters.Add("@total_time", recipe.total_time, DbType.Int32);

                    connection.Open();
                    await connection.ExecuteAsync("InsertRecipe", dynParameters, commandType: CommandType.StoredProcedure);
                    MessageBox.Show("Recipe saved successfully.");
                    await LoadRecipes(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            int recipeId = (int)numRecipeId.Value;
            if (recipeId > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
            {
    
                    try
                    {
                        DynamicParameters dynParameters = new DynamicParameters();
                        dynParameters.Add("@recipe_id", (int)numRecipeId.Value, DbType.Int32);
                        dynParameters.Add("@title", txtTitle.Text);
                        dynParameters.Add("@description", txtDescription.Text);
                        dynParameters.Add("@instructions", txtInstructions.Text);
                        dynParameters.Add("@servings", (int)numServings.Value, DbType.Int32);
                        dynParameters.Add("@prep_time", (int)numPrepTime.Value, DbType.Int32);
                        dynParameters.Add("@cook_time", (int)numCookTime.Value, DbType.Int32);
                        dynParameters.Add("@total_time", (int)numTotalTime.Value, DbType.Int32);

                        connection.Open();
                        await connection.ExecuteAsync("UpdateRecipe", dynParameters, commandType: CommandType.StoredProcedure);
                        MessageBox.Show("Recipe updated successfully.");
                        await LoadRecipes(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
 
            }
            else
            {
                MessageBox.Show("Please enter a valid recipe ID.");
            }
        }


        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int recipeId = (int)numRecipeId.Value;
            if (recipeId > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            await connection.ExecuteAsync("DELETE FROM RecipeIngredient WHERE recipe_id = @RecipeId", new { RecipeId = recipeId }, transaction);

                            await connection.ExecuteAsync("DELETE FROM Recipe WHERE recipe_id = @RecipeId", new { RecipeId = recipeId }, transaction);

                            transaction.Commit();
                            MessageBox.Show("Recipe deleted successfully.");
                            await LoadRecipes();                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid recipe ID.");
            }
        }

        private async void txtRecipeId_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int recipeId = (int)numRecipeId.Value;
                if (recipeId > 0)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            DynamicParameters dynParameters = new DynamicParameters();
                            dynParameters.Add("@recipe_id", recipeId, DbType.Int32);

                            connection.Open();
                            var recipe = await connection.QueryFirstOrDefaultAsync<Recipe>("GetRecipeById", dynParameters, commandType: CommandType.StoredProcedure);

                            if (recipe != null)
                            {
                                txtTitle.Text = recipe.title;
                                txtDescription.Text = recipe.description;
                                txtInstructions.Text = recipe.instructions;
                                numServings.Value = recipe.servings;
                                numPrepTime.Value = recipe.prep_time;
                                numCookTime.Value = recipe.cook_time;
                                numTotalTime.Value = recipe.total_time;
                            }
                            else
                            {
                                MessageBox.Show("Recipe not found.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid recipe ID.");
                }
            }
        }


        private class Recipe
        {
            public int recipe_id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string instructions { get; set; }
            public int servings { get; set; }
            public int prep_time { get; set; }
            public int cook_time { get; set; }
            public int total_time { get; set; }
        }


    }
}
