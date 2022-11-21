using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.Localization;

namespace TerraPvP.Content.Items.Armors
{
    [AutoloadEquip(EquipType.Head)]
    internal class  TutorialHelmet : ModItem
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

            Item.defense = 5;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            bool bodyMatch = body.type == ModContent.ItemType<TutorialkChest>();
            bool legsMatch = legs.type == ModContent.ItemType<TutorialLeggings>();
            return bodyMatch && legsMatch;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = Language.GetTextValue("Mods.TerraPvP.ItemSetBonus.TutorialSet");

            player.moveSpeed += 0.10f;

        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<Content.Items.Placeable.TutorialRareBar>(), 6) //Add ingredient and value
                .AddTile(TileID.Anvils) //Add where he need to be craft
                .Register(); //Complete the recipe
        }
    }
}