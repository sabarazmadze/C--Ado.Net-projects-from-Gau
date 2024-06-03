CREATE DATABASE recipe;
GO

-- Use the 'recipe' database
USE recipe;
GO

-- Create the 'Recipe' table
CREATE TABLE Recipe (
    recipe_id INT PRIMARY KEY IDENTITY,
    title NVARCHAR(255) NOT NULL,
    description NVARCHAR(MAX),
    instructions NVARCHAR(MAX),
    servings INT,
    prep_time INT, -- in minutes
    cook_time INT, -- in minutes
    total_time INT -- in minutes
);

-- Create the 'Ingredient' table
CREATE TABLE Ingredient (
    ingredient_id INT PRIMARY KEY IDENTITY,
    name NVARCHAR(255) NOT NULL
);

-- Create the 'RecipeIngredient' table
CREATE TABLE RecipeIngredient (
    recipe_id INT,
    ingredient_id INT,
    amount NVARCHAR(50),
    unit NVARCHAR(50),
    FOREIGN KEY (recipe_id) REFERENCES Recipe(recipe_id),
    FOREIGN KEY (ingredient_id) REFERENCES Ingredient(ingredient_id),
    PRIMARY KEY (recipe_id, ingredient_id)
);


-- Insert recipes
INSERT INTO Recipe (title, description, instructions, servings, prep_time, cook_time, total_time)
VALUES
    ('Spaghetti Carbonara', 'Classic Italian pasta dish with creamy sauce', '1. Cook pasta according to package instructions. 2. Meanwhile, fry pancetta until crisp. 3. Mix eggs, cheese, and pepper in a bowl. 4. Drain pasta, mix with egg mixture and pancetta. Serve immediately.', 4, 10, 15, 25),
    ('Chicken Parmesan', 'Breaded chicken topped with marinara sauce and cheese', '1. Bread chicken with flour, egg, and breadcrumbs. 2. Fry chicken until golden brown. 3. Top with marinara sauce and cheese. 4. Bake until cheese is melted and bubbly.', 4, 15, 20, 35),
    ('Vegetable Stir Fry', 'Quick and healthy stir-fried vegetables', '1. Heat oil in a pan. 2. Add vegetables and stir-fry until tender. 3. Add sauce and cook for a few more minutes. 4. Serve hot.', 4, 10, 10, 20),
    ('Chocolate Chip Cookies', 'Classic homemade cookies with chocolate chips', '1. Preheat oven. 2. Cream butter and sugars. 3. Mix in eggs and vanilla. 4. Stir in dry ingredients and chocolate chips. 5. Drop dough onto baking sheets. 6. Bake until golden brown.', 24, 15, 10, 25),
    ('Greek Salad', 'Fresh salad with tomatoes, cucumbers, olives, and feta cheese', '1. Chop vegetables and toss together in a bowl. 2. Add olives and feta cheese. 3. Dress with olive oil and vinegar. 4. Serve chilled.', 4, 15, 0, 15);

-- Insert ingredients
INSERT INTO Ingredient (name)
VALUES
    ('pasta'),
    ('pancetta'),
    ('eggs'),
    ('cheese'),
    ('black pepper'),
    ('chicken breast'),
    ('flour'),
    ('breadcrumbs'),
    ('marinara sauce'),
    ('oil'),
    ('vegetables'),
    ('sauce'),
    ('butter'),
    ('sugars'),
    ('vanilla'),
    ('chocolate chips'),
    ('tomatoes'),
    ('cucumbers'),
    ('olives'),
    ('feta cheese'),
    ('olive oil'),
    ('vinegar');

-- Insert RecipeIngredient associations
-- Spaghetti Carbonara
INSERT INTO RecipeIngredient (recipe_id, ingredient_id, amount, unit)
VALUES
    (1, 1, '250', 'grams'),  -- pasta
    (1, 2, '100', 'grams'),  -- pancetta
    (1, 3, '4', 'large'),    -- eggs
    (1, 4, '100', 'grams'),  -- cheese
    (1, 5, 'to taste', NULL); -- black pepper

-- Chicken Parmesan
INSERT INTO RecipeIngredient (recipe_id, ingredient_id, amount, unit)
VALUES
    (2, 6, '4', 'pieces'),       -- chicken breast
    (2, 7, '1/2', 'cup'),        -- flour
    (2, 8, '1/2', 'cup'),        -- breadcrumbs
    (2, 9, '1', 'cup'),          -- marinara sauce
    (2, 4, '1/2', 'cup'),        -- cheese
    (2, 10, 'to taste', NULL);   -- oil

-- Vegetable Stir Fry
INSERT INTO RecipeIngredient (recipe_id, ingredient_id, amount, unit)
VALUES
    (3, 11, '500', 'grams'),     -- vegetables
    (3, 12, '1/4', 'cup'),       -- sauce
    (3, 10, '2', 'tablespoons'); -- oil

-- Chocolate Chip Cookies
INSERT INTO RecipeIngredient (recipe_id, ingredient_id, amount, unit)
VALUES
    (4, 13, '1/2', 'cup'),         -- butter
    (4, 14, '1', 'cup'),           -- sugars
    (4, 15, '1', 'teaspoon'),      -- vanilla
    (4, 16, '2', 'cups'),          -- chocolate chips
    (4, 7, '2 1/4', 'cups'),       -- flour
    (4, 5, '1/2', 'teaspoon');     -- black pepper

-- Greek Salad
INSERT INTO RecipeIngredient (recipe_id, ingredient_id, amount, unit)
VALUES
    (5, 17, '2', 'pieces'),     -- tomatoes
    (5, 18, '1', 'piece'),      -- cucumbers
    (5, 19, '1/2', 'cup'),      -- olives
    (5, 20, '100', 'grams'),    -- feta cheese
    (5, 21, '2', 'tablespoons'),-- olive oil
    (5, 22, '1', 'tablespoon'); -- vinegar)

go
CREATE or alter PROCEDURE InsertRecipe
    @title NVARCHAR(255),
    @description NVARCHAR(MAX),
    @instructions NVARCHAR(MAX),
    @servings INT,
    @prep_time INT,
    @cook_time INT,
    @total_time INT
AS
BEGIN
    INSERT INTO Recipe (title, description, instructions, servings, prep_time, cook_time, total_time)
    VALUES (@title, @description, @instructions, @servings, @prep_time, @cook_time, @total_time);
END;
go
EXEC InsertRecipe 'New Recipe', 'Description of the new recipe', 'Instructions for the new recipe', 4, 20, 30, 50;
 go 

CREATE or alter PROCEDURE GetAllRecipes
AS
BEGIN
    SELECT * FROM Recipe;
END;
--go
--EXEC GetAllRecipes;
go

CREATE or alter PROCEDURE GetRecipeById
    @recipe_id INT
AS
BEGIN
    SELECT * FROM Recipe WHERE recipe_id = @recipe_id;
END;
--go
--EXEC GetRecipeById 1;

go

CREATE or alter PROCEDURE UpdateRecipe
    @recipe_id INT,
    @title NVARCHAR(255),
    @description NVARCHAR(MAX),
    @instructions NVARCHAR(MAX),
    @servings INT,
    @prep_time INT,
    @cook_time INT,
    @total_time INT
AS
BEGIN
    UPDATE Recipe
    SET title = @title,
        description = @description,
        instructions = @instructions,
        servings = @servings,
        prep_time = @prep_time,
        cook_time = @cook_time,
        total_time = @total_time
    WHERE recipe_id = @recipe_id;
END;
--go
--EXEC UpdateRecipe 1, 'Updated Recipe Title', 'Updated Description', 'Updated Instructions', 6, 25, 40, 65;

go 
CREATE or alter PROCEDURE DeleteRecipe
    @recipe_id INT
AS
BEGIN
    DELETE FROM Recipe WHERE recipe_id = @recipe_id;
END;
--go
--EXEC DeleteRecipe 1;

go

CREATE OR ALTER PROCEDURE GetAllRecipes
AS
BEGIN
    SELECT * FROM Recipe;
END;
