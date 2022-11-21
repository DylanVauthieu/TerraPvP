using TerraPvP.Content.Items.Placeable.Furniture;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace TerraPvP.Content.Items.Placeable
{
	public class ExampleBlock : ModItem
	{
		public override void SetStaticDefaults() {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
			ItemID.Sets.ExtractinatorMode[Item.type] = Item.type;
		}
		public override void SetDefaults() {
			Item.width = 12;
			Item.height = 12;
			Item.maxStack = 999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<Tiles.ExampleBlock>();
		}

		public override void AddRecipes() {
			CreateRecipe(10)
				.AddIngredient<TutorialItem>()
				.AddTile<Tiles.Furniture.ExampleWorkbench>()
				.Register();

            // TODO : Create the first wall
			// CreateRecipe()
			// 	.AddIngredient<ExampleWall>(4)
			// 	.AddTile<Tiles.Furniture.ExampleWorkbench>()
			// 	.Register();

            // TODO : Create first Plateform
			// CreateRecipe()
			// 	.AddIngredient<ExamplePlatform>(2)
			// 	.AddTile<Tiles.Furniture.ExampleWorkbench>()
			// 	.Register();
		}

        //* Can do it for the extratinator
		// public override void ExtractinatorUse(ref int resultType, ref int resultStack) { // Calls upon use of an extractinator. Below is the chance you will get ExampleOre from the extractinator.
		// 	if (Main.rand.NextBool(3)) {
		// 		resultType = ModContent.ItemType<ExampleOre>();  // Get this from the extractinator with a 1 in 3 chance.
		// 		if (Main.rand.NextBool(5)) {
		// 			resultStack += Main.rand.Next(2); // Add a chance to get more than one of ExampleOre from the extractinator.
		// 		}
		// 	}
		// }
	}
}