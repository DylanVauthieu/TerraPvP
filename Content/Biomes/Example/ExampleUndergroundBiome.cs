using TerraPvP.Common.Systems;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;

namespace TerraPvP.Content.Biomes.Example
{
	public class ExampleUndergroundBiome : ModBiome
	{
		// Select all the scenery
		public override ModUndergroundBackgroundStyle UndergroundBackgroundStyle => ModContent.Find<ModUndergroundBackgroundStyle>("TerraPvP/ExampleUndergroundBackgroundStyle");

		// Select Music
		public override int Music => MusicLoader.GetMusicSlot(Mod, "Assets/Music/MiiShop");

		// Sets how the Scene Effect associated with this biome will be displayed with respect to vanilla Scene Effects. For more information see SceneEffectPriority & its values.
		public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;

		// Populate the Bestiary Filter
		public override string BestiaryIcon => base.BestiaryIcon;
		public override string BackgroundPath => base.BackgroundPath;
		public override Color? BackgroundColor => base.BackgroundColor;

		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Example Underground");
		}

		// Calculate when the biome is active.
		public override bool IsBiomeActive(Player player) {
			return (player.ZoneRockLayerHeight || player.ZoneDirtLayerHeight) &&
				ModContent.GetInstance<ExampleBiomeTileCount>().exampleBlockCount >= 40 &&
				Math.Abs(player.position.ToTileCoordinates().X - Main.maxTilesX / 2) < Main.maxTilesX / 6;
		}
	}
}
