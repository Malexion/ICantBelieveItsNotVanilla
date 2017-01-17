using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace ICantBelieveItsNotVanilla
{
    public class RecipeBuilder
    {
        private ModRecipe _recipe;
        private Mod mod;

        public ModRecipe Recipe
        {
            get { if (_recipe == null) _recipe = new ModRecipe(mod); return _recipe; }
            set { _recipe = value; }
        }

        public RecipeBuilder(Mod mymod)
        {
            mod = mymod;
        }

        public static void Transmute(Mod mod, int itemID1, int itemID2, int tileID = TileID.AlchemyTable)
        {
            CreateFor(mod)
                .AddIngredient(itemID1)
                .AddTile(tileID)
                .SetResult(itemID2)

                .AddIngredient(itemID2)
                .AddTile(tileID)
                .SetResult(itemID1);
        }

        public static void Exchange(Mod mod, List<int> items, int tileID = TileID.AlchemyTable)
        {
            List<int> remaining = items;
            int target = -1;
            while(remaining.Count > 1)
            {
                target = remaining[0];
                remaining.RemoveAt(0);
                foreach (int next in remaining)
                    Transmute(mod, target, next, tileID);
            }
        }

        public static RecipeBuilder CreateFor(Mod mod)
        {
            return new RecipeBuilder(mod);
        }

        public RecipeBuilder AddIngredients(params int[] components)
        {
            foreach (int component in components)
                AddIngredient(component);
            return this;
        }

        public RecipeBuilder AddIngredient(int itemID, int stack = 1)
        {
            Recipe.AddIngredient(itemID, stack);
            return this;
        }

        public RecipeBuilder AddIngredient(string itemName, int stack = 1)
        {
            Recipe.AddIngredient(itemName, stack);
            return this;
        }

        public RecipeBuilder AddIngredient(ModItem item, int stack = 1)
        {
            Recipe.AddIngredient(item, stack);
            return this;
        }

        public RecipeBuilder AddIngredient(Mod mod, string itemName, int stack = 1)
        {
            Recipe.AddIngredient(mod, itemName, stack);
            return this;
        }

        public RecipeBuilder AddRecipeGroups(params string[] groups)
        {
            foreach (string name in groups)
                AddRecipeGroup(name);
            return this;
        }

        public RecipeBuilder AddRecipeGroup(string name, int stack = 1)
        {
            Recipe.AddRecipeGroup(name, stack);
            return this;
        }

        public RecipeBuilder AddTiles(params int[] tileIDs)
        {
            foreach (int tileID in tileIDs)
                AddTile(tileID);
            return this;
        }

        public RecipeBuilder AddTile(int tileID)
        {
            Recipe.AddTile(tileID);
            return this;
        }

        public RecipeBuilder AddTile(ModTile tile)
        {
            Recipe.AddTile(tile);
            return this;
        }

        public RecipeBuilder AddTile(Mod mod, string tileName)
        {
            Recipe.AddTile(mod, tileName);
            return this;
        }

        public RecipeBuilder SetResult(string itemName, int stack = 1)
        {
            Recipe.SetResult(itemName, stack);
            Recipe.AddRecipe();
            Recipe = null;
            return this;
        }

        public RecipeBuilder SetResult(ModItem item, int stack = 1)
        {
            Recipe.SetResult(item, stack);
            Recipe.AddRecipe();
            Recipe = null;
            return this;
        }

        public RecipeBuilder SetResult(int itemID, int stack = 1)
        {
            Recipe.SetResult(itemID, stack);
            Recipe.AddRecipe();
            Recipe = null;
            return this;
        }

        public RecipeBuilder SetResult(Mod mod, string itemName, int stack = 1)
        {
            Recipe.SetResult(mod, itemName, stack);
            Recipe.AddRecipe();
            Recipe = null;
            return this;
        }
    }
}
