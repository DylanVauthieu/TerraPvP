using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace TerraPvP.Content.Items.Armors
{
    //Nom des fichiers dans l'ordre alphabétiques (pour les craft)
    [AutoloadEquip(EquipType.Body)]
    internal class  TutorialkChest : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;

            Item.value = Item.buyPrice(gold: 1);
            Item.rare = ItemRarityID.Blue;

            Item.defense = 6;
        }

        public override void UpdateEquip(Player player)
        {
            //Buff Immunity
            player.buffImmune[BuffID.Frozen] = true;

            //Increase Health and Mana
            player.statLifeMax2 += 20;
            player.statManaMax2 += 20;

            //Increase Max Minions
            player.maxMinions += 2;

            //Increase MS
            player.moveSpeed += 0.7f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<Content.Items.Placeables.TutorialRareBar>(), 10) //Add ingredient and value
                .AddTile(TileID.Anvils) //Add where he need to be craft
                .Register(); //Complete the recipe
        }
    }
}