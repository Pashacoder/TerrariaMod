using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Mod02.Items
{
	public class Your_dream : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Your dream");
			Tooltip.SetDefault("What you enjoy in your eyes is a burden to others");
		}

		public override void SetDefaults()
		{
			Item.damage = 79;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
			Item.height = 40;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = 1;
			Item.knockBack = 10;
			Item.value = 250000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 5);
            recipe.AddIngredient(ItemID.DirtBlock, 5);
            recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}