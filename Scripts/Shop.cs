using Godot;
using System;

public partial class Shop : Node
{
	[Export] private ShopSlot[] shopSlots;
	[Export] private Texture2D godotIcon;
	[Export] private Label moneyLabel;

	public override void _Ready()
	{
		shopSlots[0].SetShopSlot(0, "Godot Icon 1", "This is the Godot icon 1.", godotIcon, 100);
		shopSlots[1].SetShopSlot(0, "Godot Icon 2", "This is the Godot icon 2.", godotIcon, 1000);
	}

	public override void _Process(double delta)
	{
		moneyLabel.Text = "Money: " + PlayerInventory.GetMoney().ToString();
	}
}
