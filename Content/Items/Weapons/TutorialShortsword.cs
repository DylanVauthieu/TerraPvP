using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using TerraPvP.Content.Projectiles.Weapons;

namespace TerraPvP.Content.Items.Weapons
{
    internal class TutorialShortsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("My first short sword !");
            Tooltip.SetDefault("I create my short sword !");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            //Hitbox
            Item.width = 32;
            Item.height = 32;

            //Annimation style
            Item.useStyle = ItemUseStyleID.Rapier;
            Item.useTime = 12;
            Item.useAnimation = 12;
            Item.autoReuse = true;
            Item.useTurn = true;
            Item.UseSound = SoundID.Item1;

            //Damage values
            Item.DamageType = DamageClass.Melee;
            Item.damage = 17;
            Item.knockBack = 4f;

            //Misc
            Item.value = Item.buyPrice(silver: 20);
            Item.value = Item.sellPrice(copper: 70);
            Item.rare = ItemRarityID.Blue;
            Item.maxStack = 1;

            Item.noUseGraphic = true;
            Item.noMelee = true;

            Item.shootSpeed = 2.1f;
            Item.shoot = ModContent.ProjectileType<TutorialShortswordProjectile>();
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