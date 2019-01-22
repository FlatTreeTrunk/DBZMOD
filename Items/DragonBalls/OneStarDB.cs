namespace DBZMOD.Items.DragonBalls
{
    public class OneStarDB : DragonBallItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("1 Star Dragon Ball");
            Tooltip.SetDefault("A mystical ball with 1 star inscribed on it.");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.createTile = mod.TileType("OneStarDBTile");
        }

        public override int GetWhichDragonBall()
        {
            return 1;
        }
    }
}