using System;

public static class PlayerInventory
{
	private static int money = 1000;

	public static void AddMoney(int amount) {
		money += amount;
	}

	public static void DecreaseMoney(int amount) {
		money -= amount;
	}

	public static bool HasEnoughMoney(int amount) {
		return money >= amount;
	}

	public static int GetMoney() {
		return money;
	}
}
