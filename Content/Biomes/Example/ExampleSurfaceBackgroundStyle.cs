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
    }
}