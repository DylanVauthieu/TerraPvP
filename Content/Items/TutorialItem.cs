using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace TerraPvP.Content.Items
{
    internal class TutorialItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }
        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;

            Item.value = Item.buyPrice(copper: 5, silver: 3, gold: 1);
            Item.maxStack = 10;
        }
    }
}
