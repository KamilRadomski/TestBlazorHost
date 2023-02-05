﻿using SatisfactoryProductionator.DataModels.Enums;

namespace SatisfactoryProductionator.DataConverter
{
	public static class Constants
	{
		public static readonly string JSON_FILEPATH = @"data/docs.json";
		public static readonly string RAW_RESOURCES =  "Resources/RawResources";
		public static readonly string PARTS = "Resource/Parts";
		public static readonly string XMAS = "Christmas";
		public static readonly string BUILDING_ONE_INDEX = "Factory/";
		public static readonly string BUILDING_TWO_INDEX = "/";
		public static readonly string ITEM_SPLIT = "),(";
		public static readonly string ITEM_SPLIT_COMMA = ",";
		public static readonly string ITEM_QUANTITY_SPLIT = @"""',Amount=";
		public static readonly string ITEM_INDEX_ONE = ".";
		public static readonly string ITEM_INDEX_TWO = "_C";

		public static readonly List<string> ITEM_CLASSES = new()
		{
			"Class'/Script/FactoryGame.FGItemDescriptor'",
			"Class'/Script/FactoryGame.FGItemDescriptorBiomass'",
			"Class'/Script/FactoryGame.FGResourceDescriptor'",
			"Class'/Script/FactoryGame.FGItemDescriptorNuclearFuel'",
			"Class'/Script/FactoryGame.FGAmmoTypeProjectile'",
			"Class'/Script/FactoryGame.FGAmmoTypeSpreadshot'",
			"Class'/Script/FactoryGame.FGAmmoTypeInstantHit'",
			"Class'/Script/FactoryGame.FGConsumableDescriptor'",
			"Class'/Script/FactoryGame.FGEquipmentDescriptor'",
		};

		public static readonly List<(string className, BuildingType buildingType)> BUILDING_CLASSES = new()
		{
			("Class'/Script/FactoryGame.FGBuildableResourceExtractor'", BuildingType.Extractor),
			("Class'/Script/FactoryGame.FGBuildableFrackingActivator'", BuildingType.Extractor),
			("Class'/Script/FactoryGame.FGBuildableFrackingExtractor'", BuildingType.Extractor),
			("Class'/Script/FactoryGame.FGBuildableWaterPump'", BuildingType.Extractor),
			("Class'/Script/FactoryGame.FGBuildableManufacturer'", BuildingType.Manufacturer),
			("Class'/Script/FactoryGame.FGBuildableManufacturerVariablePower'", BuildingType.VariableManufacturer),
			("Class'/Script/FactoryGame.FGBuildableGeneratorGeoThermal'", BuildingType.Generator),
			("Class'/Script/FactoryGame.FGBuildableGeneratorFuel'", BuildingType.Generator),
			("Class'/Script/FactoryGame.FGBuildableGeneratorNuclear'", BuildingType.Generator),

		};

		public static readonly List<string> ITEM_FILTER = new()
		{
			"FICSMAS Gift",
			"Candy Cane",
			"FICSMAS Tree Branch",
			"FICSMAS Bow",
			"Actual Snow",
			"FICSMAS Decoration",
			"FICSMAS Ornament Bundle",
			"Iron FICSMAS Ornament",
			"Copper FICSMAS Ornament",
			"Blue FICSMAS Ornament",
			"Red FICSMAS Ornament",
			"FICSMAS Wonder Star",
			"HUB Parts",
			"Sweet Fireworks",
			"Fancy Fireworks",
			"Sparkly Fireworks",
			"Snowball",
			"Chainsaw",
			"Factory Cart\u2122",
			"Hazmat Suit",
			"Jetpack",
			"Blade Runners",
			"Rebar Gun",
			"Rifle",
			"Xeno-Zapper",
			"Xeno-Basher",
			"Nobelisk Detonator",
			"Object Scanner",
			"Gas Mask",
			"Hover Pack",
			"Zipline",
			"Candy Cane Basher",
			"Golden Factory Cart\u2122",
		};

		public static readonly Dictionary<string, ItemType> CATEGORY_MAP = new()
		{
			{ "Portable Miner", ItemType.Special},
			{ "Blue Power Slug", ItemType.Special },
			{ "Yellow Power Slug", ItemType.Special},
			{ "Purple Power Slug", ItemType.Special },
			{ "Power Shard", ItemType.Special },
			{ "Adaptive Control Unit", ItemType.SpaceParts },
			{ "AI Limiter", ItemType.Electronics },
			{ "Alclad Aluminum Sheet", ItemType.StandardParts },
			{ "Alien DNA Capsule", ItemType.Alien },
			{ "Alien Protein", ItemType.Alien },
			{ "Alumina Solution", ItemType.Liquids },
			{ "Aluminum Casing", ItemType.StandardParts },
			{ "Aluminum Ingot", ItemType.Ingots },
			{ "Aluminum Scrap", ItemType.Minerals },
			{ "Assembly Director System", ItemType.SpaceParts },
			{ "Automated Wiring", ItemType.SpaceParts },
			{ "Bacon Agaric", ItemType.Consumables },
			{ "Battery", ItemType.Electronics },
			{ "Bauxite", ItemType.Ores },
			{ "Beacon", ItemType.Consumables },
			{ "Beryl Nut", ItemType.Consumables },
			{ "Biomass", ItemType.Fuels },
			{ "Black Powder", ItemType.Minerals },
			{ "Cable", ItemType.Electronics },
			{ "Caterium Ingot", ItemType.Ingots },
			{ "Caterium Ore", ItemType.Ores },
			{ "Circuit Board", ItemType.Electronics },
			{ "Cluster Nobelisk", ItemType.Ammos },
			{ "Coal", ItemType.Ores },
			{ "Color Cartridge", ItemType.Consumables },
			{ "Compacted Coal", ItemType.Minerals },
			{ "Computer", ItemType.Communications },
			{ "Concrete", ItemType.Minerals },
			{ "Cooling System", ItemType.IndustrialParts },
			{ "Copper Ingot", ItemType.Ingots },
			{ "Copper Ore", ItemType.Ores },
			{ "Copper Powder", ItemType.Minerals },
			{ "Copper Sheet", ItemType.StandardParts },
			{ "Crude Oil", ItemType.Liquids },
			{ "Crystal Oscillator", ItemType.Communications },
			{ "Electromagnetic Control Rod", ItemType.Electronics },
			{ "Empty Canister", ItemType.Containers },
			{ "Empty Fluid Tank", ItemType.Containers },
			{ "Encased Industrial Beam", ItemType.StandardParts },
			{ "Encased Plutonium Cell", ItemType.Nuclear },
			{ "Encased Uranium Cell", ItemType.Nuclear },
			{ "Explosive Rebar", ItemType.Ammos },
			{ "Fabric", ItemType.StandardParts },
			{ "Flower Petals", ItemType.Fuels },
			{ "Fuel", ItemType.Liquids },
			{ "Fused Modular Frame", ItemType.StandardParts },
			{ "Gas Filter", ItemType.Consumables },
			{ "Gas Nobelisk", ItemType.Ammos },
			{ "Hatcher Remains", ItemType.Alien },
			{ "Heat Sink", ItemType.IndustrialParts },
			{ "Heavy Modular Frame", ItemType.StandardParts },
			{ "Heavy Oil Residue", ItemType.Liquids },
			{ "High-Speed Connector", ItemType.Electronics },
			{ "Hog Remains", ItemType.Alien },
			{ "Homing Rifle Ammo", ItemType.Ammos },
			{ "Iodine Infused Filter", ItemType.Consumables },
			{ "Iron Ingot", ItemType.Ingots },
			{ "Iron Ore", ItemType.Ores },
			{ "Iron Plate", ItemType.StandardParts },
			{ "Iron Rebar", ItemType.Ammos },
			{ "Iron Rod", ItemType.StandardParts },
			{ "Leaves", ItemType.Fuels },
			{ "Limestone", ItemType.Ores },
			{ "Liquid Biofuel", ItemType.Liquids },
			{ "Magnetic Field Generator", ItemType.SpaceParts },
			{ "Medicinal Inhaler", ItemType.Consumables },
			{ "Modular Engine", ItemType.SpaceParts },
			{ "Modular Frame", ItemType.StandardParts },
			{ "Motor", ItemType.IndustrialParts },
			{ "Mycelia", ItemType.Fuels },
			{ "Nitric Acid", ItemType.Liquids },
			{ "Nitrogen Gas", ItemType.Gas},
			{ "Nobelisk", ItemType.Ammos },
			{ "Non-fissile Uranium", ItemType.Nuclear },
			{ "Nuclear Pasta", ItemType.Nuclear },
			{ "Nuke Nobelisk", ItemType.Ammos },
			{ "Packaged Alumina Solution", ItemType.Containers },
			{ "Packaged Fuel", ItemType.Fuels },
			{ "Packaged Heavy Oil Residue", ItemType.Fuels },
			{ "Packaged Liquid Biofuel", ItemType.Fuels },
			{ "Packaged Nitric Acid", ItemType.Containers },
			{ "Packaged Nitrogen Gas", ItemType.Containers },
			{ "Packaged Oil", ItemType.Fuels },
			{ "Packaged Sulfuric Acid", ItemType.Containers },
			{ "Packaged Turbofuel", ItemType.Fuels },
			{ "Packaged Water", ItemType.Containers },
			{ "Paleberry", ItemType.Consumables },
			{ "Parachute", ItemType.Consumables },
			{ "Petroleum Coke", ItemType.OilProducts },
			{ "Plasma Spitter Remains", ItemType.Alien },
			{ "Plastic", ItemType.OilProducts },
			{ "Plutonium Fuel Rod", ItemType.Fuels },
			{ "Plutonium Pellet", ItemType.Nuclear },
			{ "Plutonium Waste", ItemType.Nuclear },
			{ "Polymer Resin", ItemType.OilProducts },
			{ "Pressure Conversion Cube", ItemType.Containers },
			{ "Pulse Nobelisk", ItemType.Ammos },
			{ "Quartz Crystal", ItemType.Minerals },
			{ "Quickwire", ItemType.Electronics },
			{ "Radio Control Unit", ItemType.Communications },
			{ "Raw Quartz", ItemType.Ores },
			{ "Reinforced Iron Plate", ItemType.StandardParts },
			{ "Rifle Ammo", ItemType.Ammos },
			{ "Rotor", ItemType.IndustrialParts },
			{ "Rubber", ItemType.OilProducts },
			{ "Screw", ItemType.StandardParts },
			{ "Shatter Rebar", ItemType.Ammos },
			{ "Silica", ItemType.Minerals },
			{ "Smart Plating", ItemType.SpaceParts },
			{ "Smokeless Powder", ItemType.Minerals },
			{ "Solid Biofuel", ItemType.Fuels },
			{ "Stator", ItemType.IndustrialParts },
			{ "Steel Beam", ItemType.StandardParts },
			{ "Steel Ingot", ItemType.Ingots },
			{ "Steel Pipe", ItemType.StandardParts },
			{ "Stinger Remains", ItemType.Alien },
			{ "Stun Rebar", ItemType.Ammos },
			{ "Sulfur", ItemType.Ores },
			{ "Sulfuric Acid", ItemType.Liquids },
			{ "Supercomputer", ItemType.Communications },
			{ "Thermal Propulsion Rocket", ItemType.SpaceParts },
			{ "Turbo Motor", ItemType.IndustrialParts },
			{ "Turbo Rifle Ammo", ItemType.Ammos },
			{ "Turbofuel", ItemType.Liquids },
			{ "Uranium Fuel Rod", ItemType.Fuels },
			{ "Uranium Waste", ItemType.Nuclear },
			{ "Uranium", ItemType.Ores },
			{ "Versatile Framework", ItemType.SpaceParts },
			{ "Water", ItemType.Liquids },
			{ "Wire", ItemType.Electronics },
			{ "Wood", ItemType.Fuels },

		};

		public static readonly Dictionary<string, string> BUILDING_MAP = new()
		{
			{ "AssemblerMk1", "Assembler" },
			{ "Blender", "Blender" },
			{ "ConstructorMk1", "Constructor" },
			{ "Constructor", "Constructor" },
			{ "FoundryMk1", "Foundry" },
			{ "Foundry", "Foundry" },
			{ "HadronCollider", "Particle Accelerator" },
			{ "ManufacturerMk1", "Manufacturer" },
			{ "OilRefinery", "Refinery" },
			{ "Refinery", "Refinery" },
			{ "Packager", "Packager" },
			{ "SmelterMk1", "Smelter" },
			{ "Smelter", "Smelter" },
			{ "Miner Mk.1", "Miner Mk1" },
			{ "Miner Mk.2", "Miner Mk2" },
			{ "Miner Mk.3", "Miner Mk3" },
			{ "Oil Extractor", "Oil Extractor" },
			{ "Resource Well Pressurizer", "Resource Well Pressurizer" },
			{ "Water Extractor", "Water Extractor" },

		};

		public static readonly List<string> EXTRACTABLE_RESOURCES = new()
		{
			"Bauxite",
			"Caterium Ore",
			"Coal",
			"Copper Ore",
			"Crude Oil",
			"Iron Ore",
			"LimeStone",
			"Raw Quartz",
			"Sulfur",
			"Uranium",

		};

		public static readonly List<string> BIOMASS_FUELS = new()
		{
			"Hog Remains",
			"Plasma Spitter Remains",
			"Flower Petals",
			"Leaves",
			"Mycelia",
			"Wood",
			"Hatcher Remains",
			"Stinger Remains",
			"Solid Biofuel",
			"Packaged Liquid Biofuel",
			"Biomass",
			"Liquid Biofuel",
			"Packaged Alumina Solution",
			"Packaged Sulfuric Acid",
			"Packaged Nitrogen Gas",
			"Packaged Nitric Acid",
			"Fabric",
		};

		public static readonly Dictionary<string, string> SIZE_MAP = new()
		{
			{ "SS_FLUID", "Fluid" },
			{ "SS_ONE", "1" },
			{ "SS_SMALL", "50" },
			{ "SS_MEDIUM", "100" },
			{ "SS_BIG", "200" },
			{ "SS_HUGE", "500" },
		};
	}
}