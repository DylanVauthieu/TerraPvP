using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace TerraPvP.Content.Items.Weapons
{
    internal class TestSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("My first sword");
            Tooltip.SetDefault("I create my sword !\nAnd i make 2 lines !");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            //Hitbox
            Item.width = 32;
            Item.height = 32;

            //Annimation style
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.autoReuse = true;

            //Damage values
            Item.DamageType = DamageClass.Melee;
            Item.damage = 50;
            Item.knockBack = 3.5f;
            Item.crit = 5;

            //Misc
            Item.value = Item.buyPrice(gold: 5);
            Item.rare = ItemRarityID.Master;
            Item.maxStack = 1;

            //Sound
            Item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<ItemTest>(), 8) //Add ingredient and value
                .AddTile(TileID.Anvils) //Add where he need to be craft
                .Register(); //Complete the recipe
        }
    }
}