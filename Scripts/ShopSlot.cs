using Godot;
using System;

public partial class ShopSlot : Button
{
	[Export] private Label nameLabel;
	[Export] private Label costLabel;
	[Export] private Label descriptionLabel;
	[Export] private Sprite2D labelDisplay;
	private int itemId;
	private int itemCost;

	public override void _Ready() {
		ClearShopSlot();
	}

	public int GetItemId() {
		return itemId;
	}

	public void SetShopSlot(int itemId, string itemName, string itemDescription, Texture2D itemIcon, int itemCost) {
		this.itemId = itemId;
		this.itemCost = itemCost;
		nameLabel.Text = itemName;
		costLabel.Text = "Cost: " + itemCost.ToString();
		descriptionLabel.Text = itemDescription;
		Visible = true;
		Icon = itemIcon;
		Disabled = false;
	}

	private void ClearShopSlot() {
		itemId = -1;
		itemCost = 0;
		Icon = null;
		Disabled = true;
		Visible = false;
		labelDisplay.Visible = false;
	}

	private void _on_mouse_entered() {
		if (itemId == -1) {
			return;
		}
		labelDisplay.Visible = true;
	}

	private void _on_mouse_exited() {
		labelDisplay.Visible = false;
	}

	private void _on_pressed() {
		if (!PlayerInventory.HasEnoughMoney(itemCost)) {
			return;
		}
		PlayerInventory.DecreaseMoney(itemCost);
		ClearShopSlot();
		labelDisplay.Visible = false;		
	}
}
