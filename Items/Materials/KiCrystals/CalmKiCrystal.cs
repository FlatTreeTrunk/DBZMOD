namespace DBZMOD.Items.Materials.KiCrystals
{
    public class CalmKiCrystal : KiCrystal
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Calm Ki Crystal");
            Tooltip.SetDefault("'The calm force of nature lives within.'");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 9999;
            item.value = 300;
            item.rare = 2;
        }
    }
}