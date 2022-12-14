using Terraria;
using Terraria.IO;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.WorldBuilding;
using TerraPvP.Content.Tiles;

namespace TerraPvP.Common.Systems.GenPasses
{
    internal class TutorialOreGenPass : GenPass
    {
        public TutorialOreGenPass(string name, float weight) : base(name, weight) { }

        protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
        {
            progress.Message = "Spawning tutorial ores";

            //Tutorial ore
            int maxToSpawn = (int)(Main.maxTilesX * Main.maxTilesY * 6E-05); //Small world -> 4200 * 1200 * 0.00006 = 302.4 (302)
            for (int i = 0; i < maxToSpawn; i++)
            {
                int x = WorldGen.genRand.Next(100, Main.maxTilesX - 100);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurface, Main.maxTilesY - 300);

                WorldGen.TileRunner(x, y, WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 5), ModContent.TileType<TutorialOre>());
            }

            //Tutorial Rare Ore
            maxToSpawn = WorldGen.genRand.Next(100, 250);
            int numSpawned = 0;
            int attemps = 0;
            while (numSpawned < maxToSpawn)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next(0, Main.maxTilesY);

                Tile tile = Framing.GetTileSafely(x, y);
                if (tile.TileType == TileID.SnowBlock || tile.TileType == TileID.IceBlock || tile.TileType == TileID.Slush)
                {
                    WorldGen.TileRunner(x, y, WorldGen.genRand.Next(2, 5), WorldGen.genRand.Next(1, 4), ModContent.TileType<TutorialRareOre>());
                    numSpawned++;
                }

                attemps++;
                if (attemps >= 100000)
                {
                    break;
                }
            }
        }
    }
}