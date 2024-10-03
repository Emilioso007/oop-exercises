using System;

namespace Lagersystem;

public class NonFoodItem : Item
{

	private string[] _materials;

	public NonFoodItem(string name, double price, string[] materials) : base(name, price) {
		_materials = materials;
	}

	public string[] GetMaterials() {
		return _materials;
	}

	public override string ToString() {

		return $"Name: {_name}, Price: {_price}, Materials: {string.Join(", ", _materials)}";

	}

}