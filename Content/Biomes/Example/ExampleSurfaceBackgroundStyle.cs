using Terraria;
using Terraria.ModLoader;

namespace TerraPvP.Content.Biomes.Example
{
    internal class ExampleSurfaceBackgroundStyle : ModSurfaceBackgroundStyle
    {
        public override void ModifyFarFades(float[] fades, float transitionSpeed) {
            for (int i = 0; i < fades.Length; i++) {
                if (i == Slot) {
                    fades[i] += transitionSpeed;
                    if (fades[i] > 1f) {
                        fades[i] = 1f;
                    }
                }

                else {
                    fades[1] -= transitionSpeed;
                    if (fades[i] < 0f) {
                        fades[i] = 0f;
                    }
                }
            }
        }

    public override int ChooseFarTexture() {
		return BackgroundTextureLoader.GetBackgroundSlot(Mod, "Assets/Textures/Backgrounds/ExampleBiomeSurfaceFar");
	}

    private static int SurfaceFrameCountter;
    private static int SurfaceFrame;
        public override int ChooseMiddleTexture() {
            if (++SurfaceFrameCountter > 12) {
                SurfaceFrame = (SurfaceFrame + 1) % 4;
                SurfaceFrameCountter = 0;
            }

            switch (SurfaceFrame) {
				case 0:
					return BackgroundTextureLoader.GetBackgroundSlot(Mod, "Assets/Textures/Backgrounds/ExampleBiomeSurfaceMid0");
				case 1:
					return BackgroundTextureLoader.GetBackgroundSlot(Mod, "Assets/Textures/Backgrounds/ExampleBiomeSurfaceMid1");
				case 2:
					return BackgroundTextureLoader.GetBackgroundSlot(Mod, "Assets/Textures/Backgrounds/ExampleBiomeSurfaceMid2");
				case 3:
					return BackgroundTextureLoader.GetBackgroundSlot(Mod, "Assets/Textures/Backgrounds/ExampleBiomeSurfaceMid3");
				default:
					return -1;
			}
        }

        public override int ChooseCloseTexture(ref float scale, ref double parallax, ref float a, ref float b)
        {
            return BackgroundTextureLoader.GetBackgroundSlot(Mod, "Assets/Textures/Backgrounds/ExampleBiomeSurfaceClose");
        }
    }
}