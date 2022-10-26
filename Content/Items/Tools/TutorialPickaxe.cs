using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace TerraPvP.Content.Items.Tools
{
    internal class TutorialPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("My first Pickaxe !");
            Tooltip.SetDefault("I create my Pickaxe !");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            //Hitbox
            Item.width = 32;
            Item.height = 32;

            //Annimation style
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 13;
            Item.useAnimation = 15;
            Item.autoReuse = true;
            Item.useTurn = true;

            //Damage values
            Item.DamageType = DamageClass.Melee;
            Item.damage = 12;
            Item.knockBack = 3f;

            //Misc
            Item.value = Item.buyPrice(silver: 3);
            Item.value = Item.sellPrice(copper: 12);
            Item.rare = ItemRarityID.Blue;
            Item.maxStack = 1;
            Item.pick = 60; //Strength of the pickaxe
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddRecipeGroup(RecipeGroupID.Wood, 10)
                .AddIngredient(ModContent.ItemType<ItemTest>(), 4)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}