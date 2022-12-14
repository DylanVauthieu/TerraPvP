using TerraPvP.Content.Dusts;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TerraPvP.Content.Tiles
{
	public class ExampleBlock : ModTile
	{
		public override void SetStaticDefaults() {
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;

			DustType = ModContent.DustType<Sparkle>();
			ItemDrop = ModContent.ItemType<Items.Placeable.ExampleBlock>();

			AddMapEntry(new Color(200, 200, 200), CreateMapEntryName());
		}

		public override void NumDust(int i, int j, bool fail, ref int num) {
			num = fail ? 1 : 3;
		}
	}
}