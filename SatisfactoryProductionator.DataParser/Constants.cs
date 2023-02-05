﻿using SatisfactoryProductionator.DataModels.Enums;

namespace SatisfactoryProductionator.DataParser
{
	public static class Constants
	{
		public static readonly string JSON_FILEPATH = @"data/docs.json";
		public static readonly string RAW_RESOURCES = "Resources/RawResources";
		public static readonly string RAW_RESOURCES2 = "Resource/RawResources";
		public static readonly string PARTS = "Resource/Parts";
		public static readonly string AMMO = "Ammo";
		public static readonly string XMAS = "Christmas";
		public static readonly string BUILDING_ONE_INDEX = "Factory/";
		public static readonly string BUILDING_TWO_INDEX = "/";
		public static readonly string ITEM_SPLIT = "),(";
		public static readonly string ITEM_SPLIT_COMMA = ",";
		public static readonly string ITEM_QUANTITY_SPLIT = @"""',Amount=";
		public static readonly string ITEM_INDEX_ONE = ".";
		public static readonly string ITEM_INDEX_TWO = "_C";
		public static readonly string ALTERNATE_PREFIX = "Alternate: ";
		public static readonly int MAX_PAGE_SIZE = 4;

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

		public static readonly List<string> RECIPE_CLASSES = new()
		{
			"Class'/Script/FactoryGame.FGRecipe'",
			//"Class'/Script/FactoryGame.FGCustomizationRecipe'",
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
			{ "Portable Miner", ItemType.Special },
			{ "Blue Power Slug", ItemType.Special },
			{ "Yellow Power Slug", ItemType.Special },
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
			{ "Nitrogen Gas", ItemType.Gas },
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
			{ "Particle Accelerator", "Particle Accelerator" },
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
			{ "Converter", "Converter" },
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

		public static readonly Dictionary<string, string> ITEM_NAMES = new()
		{
			{ "Desc_NuclearWaste_C", "Uranium Waste" },
			{ "Desc_PlutoniumWaste_C", "Plutonium Waste" },
			{ "Desc_Battery_C", "Battery" },
			{ "Desc_AluminumIngot_C", "Aluminum Ingot" },
			{ "Desc_NonFissibleUranium_C", "Non-fissile Uranium" },
			{ "Desc_PlutoniumPellet_C", "Plutonium Pellet" },
			{ "Desc_PlutoniumCell_C", "Encased Plutonium Cell" },
			{ "Desc_Crystal_C", "Blue Power Slug" },
			{ "Desc_IronRod_C", "Iron Rod" },
			{ "Desc_IronScrew_C", "Screw" },
			{ "Desc_Wire_C", "Wire" },
			{ "Desc_Crystal_mk2_C", "Yellow Power Slug" },
			{ "Desc_Crystal_mk3_C", "Purple Power Slug" },
			{ "Desc_Cement_C", "Concrete" },
			{ "Desc_Silica_C", "Silica" },
			{ "Desc_IronPlate_C", "Iron Plate" },
			{ "Desc_SteelPlate_C", "Steel Beam" },
			{ "Desc_ColorCartridge_C", "Color Cartridge" },
			{ "Desc_CrystalShard_C", "Power Shard" },
			{ "Desc_Cable_C", "Cable" },
			{ "Desc_ModularFrame_C", "Modular Frame" },
			{ "Desc_Fuel_C", "Packaged Fuel" },
			{ "Desc_TurboFuel_C", "Packaged Turbofuel" },
			{ "Desc_HazmatFilter_C", "Iodine Infused Filter" },
			{ "Desc_Filter_C", "Gas Filter" },
			{ "Desc_IronPlateReinforced_C", "Reinforced Iron Plate" },
			{ "Desc_CopperIngot_C", "Copper Ingot" },
			{ "Desc_ModularFrameFused_C", "Fused Modular Frame" },
			{ "Desc_CircuitBoard_C", "Circuit Board" },
			{ "Desc_CopperSheet_C", "Copper Sheet" },
			{ "Desc_CrystalOscillator_C", "Crystal Oscillator" },
			{ "Desc_SpaceElevatorPart_1_C", "Smart Plating" },
			{ "Desc_SpaceElevatorPart_2_C", "Versatile Framework" },
			{ "Desc_SpaceElevatorPart_3_C", "Automated Wiring" },
			{ "Desc_SpaceElevatorPart_4_C", "Modular Engine" },
			{ "Desc_PackagedWater_C", "Packaged Water" },
			{ "Desc_AlienDNACapsule_C", "Alien DNA Capsule" },
			{ "Desc_HighSpeedConnector_C", "High-Speed Connector" },
			{ "Desc_Motor_C", "Motor" },
			{ "Desc_SpaceElevatorPart_5_C", "Adaptive Control Unit" },
			{ "Desc_SpaceElevatorPart_6_C", "Magnetic Field Generator" },
			{ "Desc_SpaceElevatorPart_7_C", "Assembly Director System" },
			{ "Desc_SpaceElevatorPart_8_C", "Thermal Propulsion Rocket" },
			{ "Desc_SpaceElevatorPart_9_C", "Nuclear Pasta" },
			{ "Desc_IronIngot_C", "Iron Ingot" },
			{ "Desc_AluminumPlate_C", "Alclad Aluminum Sheet" },
			{ "Desc_Rotor_C", "Rotor" },
			{ "Desc_Rubber_C", "Rubber" },
			{ "Desc_Plastic_C", "Plastic" },
			{ "Desc_SteelPlateReinforced_C", "Encased Industrial Beam" },
			{ "Desc_SteelPipe_C", "Steel Pipe" },
			{ "Desc_LiquidFuel_C", "Fuel" },
			{ "Desc_PolymerResin_C", "Polymer Resin" },
			{ "Desc_HeavyOilResidue_C", "Heavy Oil Residue" },
			{ "Desc_PetroleumCoke_C", "Petroleum Coke" },
			{ "Desc_FluidCanister_C", "Empty Canister" },
			{ "Desc_ModularFrameHeavy_C", "Heavy Modular Frame" },
			{ "Desc_PackagedOil_C", "Packaged Oil" },
			{ "Desc_PackagedOilResidue_C", "Packaged Heavy Oil Residue" },
			{ "Desc_SteelIngot_C", "Steel Ingot" },
			{ "Desc_AluminaSolution_C", "Alumina Solution" },
			{ "Desc_AluminumScrap_C", "Aluminum Scrap" },
			{ "Desc_SulfuricAcid_C", "Sulfuric Acid" },
			{ "Desc_UraniumCell_C", "Encased Uranium Cell" },
			{ "Desc_AluminumPlateReinforced_C", "Heat Sink" },
			{ "Desc_CoolingSystem_C", "Cooling System" },
			{ "Desc_NitricAcid_C", "Nitric Acid" },
			{ "Desc_AluminumCasing_C", "Aluminum Casing" },
			{ "Desc_ModularFrameLightweight_C", "Radio Control Unit" },
			{ "Desc_Computer_C", "Computer" },
			{ "Desc_QuartzCrystal_C", "Quartz Crystal" },
			{ "Desc_GoldIngot_C", "Caterium Ingot" },
			{ "Desc_Stator_C", "Stator" },
			{ "Desc_CircuitBoardHighSpeed_C", "AI Limiter" },
			{ "Desc_HighSpeedWire_C", "Quickwire" },
			{ "Desc_CompactedCoal_C", "Compacted Coal" },
			{ "Desc_LiquidTurboFuel_C", "Turbofuel" },
			{ "Desc_ComputerSuper_C", "Supercomputer" },
			{ "Desc_GasTank_C", "Empty Fluid Tank" },
			{ "Desc_ElectromagneticControlRod_C", "Electromagnetic Control Rod" },
			{ "Desc_PressureConversionCube_C", "Pressure Conversion Cube" },
			{ "Desc_MotorLightweight_C", "Turbo Motor" },
			{ "Desc_CopperDust_C", "Copper Powder" },
			{ "Desc_Gunpowder_C", "Black Powder" },
			{ "Desc_AlienProtein_C", "Alien Protein" },
			{ "Desc_GunpowderMK2_C", "Smokeless Powder" },
			{ "Desc_Berry_C", "Paleberry" },
			{ "Desc_Shroom_C", "Bacon Agaric" },
			{ "Desc_Nut_C", "Beryl Nut" },
			{ "Desc_Medkit_C", "Medicinal Inhaler" },
			{ "BP_EquipmentDescriptorBeacon_C", "Beacon" },
			{ "Desc_Parachute_C", "Parachute" },
			{ "Desc_HogParts_C", "Hog Remains" },
			{ "Desc_SpitterParts_C", "Plasma Spitter Remains" },
			{ "Desc_FlowerPetals_C", "Flower Petals" },
			{ "Desc_Leaves_C", "Leaves" },
			{ "Desc_Mycelia_C", "Mycelia" },
			{ "Desc_Wood_C", "Wood" },
			{ "Desc_HatcherParts_C", "Hatcher Remains" },
			{ "Desc_StingerParts_C", "Stinger Remains" },
			{ "Desc_Biofuel_C", "Solid Biofuel" },
			{ "Desc_PackagedBiofuel_C", "Packaged Liquid Biofuel" },
			{ "Desc_GenericBiomass_C", "Biomass" },
			{ "Desc_LiquidBiofuel_C", "Liquid Biofuel" },
			{ "Desc_PackagedAlumina_C", "Packaged Alumina Solution" },
			{ "Desc_PackagedSulfuricAcid_C", "Packaged Sulfuric Acid" },
			{ "Desc_PackagedNitrogenGas_C", "Packaged Nitrogen Gas" },
			{ "Desc_PackagedNitricAcid_C", "Packaged Nitric Acid" },
			{ "Desc_Fabric_C", "Fabric" },
			{ "Desc_Coal_C", "Coal" },
			{ "Desc_OreCopper_C", "Copper Ore" },
			{ "Desc_OreGold_C", "Caterium Ore" },
			{ "Desc_OreIron_C", "Iron Ore" },
			{ "Desc_RawQuartz_C", "Raw Quartz" },
			{ "Desc_Stone_C", "Limestone" },
			{ "Desc_Sulfur_C", "Sulfur" },
			{ "Desc_LiquidOil_C", "Crude Oil" },
			{ "Desc_NitrogenGas_C", "Nitrogen Gas" },
			{ "Desc_Water_C", "Water" },
			{ "Desc_OreBauxite_C", "Bauxite" },
			{ "Desc_OreUranium_C", "Uranium" },
			{ "BP_ItemDescriptorPortableMiner_C", "Portable Miner" },
			{ "Desc_NuclearFuelRod_C", "Uranium Fuel Rod" },
			{ "Desc_PlutoniumFuelRod_C", "Plutonium Fuel Rod" },
			{ "Desc_Rebar_Explosive_C", "Explosive Rebar" },
			{ "Desc_Rebar_Stunshot_C", "Stun Rebar" },
			{ "Desc_SpikedRebar_C", "Iron Rebar" },
			{ "Desc_CartridgeSmartProjectile_C", "Homing Rifle Ammo" },
			{ "Desc_NobeliskCluster_C", "Cluster Nobelisk" },
			{ "Desc_NobeliskExplosive_C", "Nobelisk" },
			{ "Desc_NobeliskGas_C", "Gas Nobelisk" },
			{ "Desc_NobeliskNuke_C", "Nuke Nobelisk" },
			{ "Desc_NobeliskShockwave_C", "Pulse Nobelisk" },
			{ "Desc_Rebar_Spreadshot_C", "Shatter Rebar" },
			{ "Desc_CartridgeChaos_C", "Turbo Rifle Ammo" },
			{ "Desc_CartridgeStandard_C", "Rifle Ammo" },
		};
	}
}