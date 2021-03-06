﻿using Terraria.ModLoader;
using Terraria;

namespace MasomodeDLC.Thorium.Buffs
{
	public class DontGoIntoTheFuckingAquaticDepthsBeforeQueen : ModBuff //byeah
	{
		public override bool Autoload(ref string name, ref string texture)
		{
			texture = "FargowiltasSouls/Buffs/PlaceholderDebuff";
			return ModLoader.GetMod("ThoriumMod") != null;
		}

		public override void SetDefaults()
		{
			DisplayName.SetDefault("Abyssal Drag");
			Description.SetDefault("You cannot swim\nYou cannot breathe\nYou cannot take a chance and leave");
			Main.debuff[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.GetModPlayer<MasoDLCPlayer>().abyssalDrag = true;
		}
	}
}
