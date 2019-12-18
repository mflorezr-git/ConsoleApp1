/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace ConsoleApp1
{
	[XmlRoot(ElementName = "Properties")]
	public class Properties
	{
		[XmlElement(ElementName = "Revision")]
		public string Revision { get; set; }
		[XmlElement(ElementName = "ChangeDate")]
		public string ChangeDate { get; set; }
		[XmlElement(ElementName = "Author")]
		public string Author { get; set; }
	}

	[XmlRoot(ElementName = "RioConverter")]
	public class RioConverter
	{
		[XmlElement(ElementName = "Properties")]
		public Properties Properties { get; set; }
		[XmlElement(ElementName = "ScriptReferences")]
		public string ScriptReferences { get; set; }
		[XmlElement(ElementName = "Script")]
		public string Script { get; set; }
	}

	[XmlRoot(ElementName = "Unit")]
	public class Unit
	{
		[XmlAttribute(AttributeName = "DecimalPlaces")]
		public string DecimalPlaces { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "Parameter")]
	public class Parameter
	{
		[XmlElement(ElementName = "Name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "Description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "ForeignId")]
		public string ForeignId { get; set; }
		[XmlElement(ElementName = "DataType")]
		public string DataType { get; set; }
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlElement(ElementName = "MinValue")]
		public string MinValue { get; set; }
		[XmlElement(ElementName = "MaxValue")]
		public string MaxValue { get; set; }
		[XmlElement(ElementName = "Unit")]
		public Unit Unit { get; set; }
		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }
		[XmlElement(ElementName = "EnumList")]
		public EnumList EnumList { get; set; }
	}

	[XmlRoot(ElementName = "Block")]
	public class Block
	{
		[XmlElement(ElementName = "Name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "Description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "ForeignId")]
		public string ForeignId { get; set; }
		[XmlElement(ElementName = "Parameter")]
		public List<Parameter> Parameter { get; set; }
		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }
		[XmlElement(ElementName = "Block")]
		public List<Block> Blocks { get; set; }
	}

	[XmlRoot(ElementName = "EnumValue")]
	public class EnumValue
	{
		[XmlAttribute(AttributeName = "EnumId")]
		public string EnumId { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "EnumList")]
	public class EnumList
	{
		[XmlElement(ElementName = "EnumValue")]
		public List<EnumValue> EnumValue { get; set; }
	}

	[XmlRoot(ElementName = "CUSTOM")]
	public class CUSTOM
	{
		[XmlElement(ElementName = "Name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "Description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "Block")]
		public Block Block { get; set; }
	}

	[XmlRoot(ElementName = "DEVICE_MODEL")]
	public class DEVICE_MODEL
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "MANUFACTURER")]
	public class MANUFACTURER
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "DEVICE_TYPE")]
	public class DEVICE_TYPE
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "SERIALNR")]
	public class SERIALNR
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "ADDITIONAL_INFO2")]
	public class ADDITIONAL_INFO2
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "NAMEPLATE")]
	public class NAMEPLATE
	{
		[XmlElement(ElementName = "DEVICE_MODEL")]
		public DEVICE_MODEL DEVICE_MODEL { get; set; }
		[XmlElement(ElementName = "MANUFACTURER")]
		public MANUFACTURER MANUFACTURER { get; set; }
		[XmlElement(ElementName = "DEVICE_TYPE")]
		public DEVICE_TYPE DEVICE_TYPE { get; set; }
		[XmlElement(ElementName = "SERIALNR")]
		public SERIALNR SERIALNR { get; set; }
		[XmlElement(ElementName = "ADDITIONAL_INFO2")]
		public ADDITIONAL_INFO2 ADDITIONAL_INFO2 { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "BlockType")]
		public string BlockType { get; set; }
	}

	[XmlRoot(ElementName = "DEVICE_ADDRESS")]
	public class DEVICE_ADDRESS
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "SUBSTATION")]
	public class SUBSTATION
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "SUBSTATION_ADDRESS")]
	public class SUBSTATION_ADDRESS
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "BAY")]
	public class BAY
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "BAY_ADDRESS")]
	public class BAY_ADDRESS
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "PROTECTED_OBJECT_NAME")]
	public class PROTECTED_OBJECT_NAME
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "LOCATION")]
	public class LOCATION
	{
		[XmlElement(ElementName = "DEVICE_ADDRESS")]
		public DEVICE_ADDRESS DEVICE_ADDRESS { get; set; }
		[XmlElement(ElementName = "SUBSTATION")]
		public SUBSTATION SUBSTATION { get; set; }
		[XmlElement(ElementName = "SUBSTATION_ADDRESS")]
		public SUBSTATION_ADDRESS SUBSTATION_ADDRESS { get; set; }
		[XmlElement(ElementName = "BAY")]
		public BAY BAY { get; set; }
		[XmlElement(ElementName = "BAY_ADDRESS")]
		public BAY_ADDRESS BAY_ADDRESS { get; set; }
		[XmlElement(ElementName = "PROTECTED_OBJECT_NAME")]
		public PROTECTED_OBJECT_NAME PROTECTED_OBJECT_NAME { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "BlockType")]
		public string BlockType { get; set; }
	}

	[XmlRoot(ElementName = "PHASES")]
	public class PHASES
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "FNOM")]
	public class FNOM
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "VNOM")]
	public class VNOM
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "VPRIM_LL")]
	public class VPRIM_LL
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "INOM")]
	public class INOM
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "IPRIM")]
	public class IPRIM
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "NOMINALVALUES")]
	public class NOMINALVALUES
	{
		[XmlElement(ElementName = "PHASES")]
		public PHASES PHASES { get; set; }
		[XmlElement(ElementName = "FNOM")]
		public FNOM FNOM { get; set; }
		[XmlElement(ElementName = "VNOM")]
		public VNOM VNOM { get; set; }
		[XmlElement(ElementName = "VPRIM_LL")]
		public VPRIM_LL VPRIM_LL { get; set; }
		[XmlElement(ElementName = "INOM")]
		public INOM INOM { get; set; }
		[XmlElement(ElementName = "IPRIM")]
		public IPRIM IPRIM { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "BlockType")]
		public string BlockType { get; set; }
	}

	[XmlRoot(ElementName = "VLNVN")]
	public class VLNVN
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "ININOM")]
	public class ININOM
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "RESIDUALFACTORS")]
	public class RESIDUALFACTORS
	{
		[XmlElement(ElementName = "VLNVN")]
		public VLNVN VLNVN { get; set; }
		[XmlElement(ElementName = "ININOM")]
		public ININOM ININOM { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "BlockType")]
		public string BlockType { get; set; }
	}

	[XmlRoot(ElementName = "VMAX_LL")]
	public class VMAX_LL
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "IMAX")]
	public class IMAX
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "LIMITS")]
	public class LIMITS
	{
		[XmlElement(ElementName = "VMAX_LL")]
		public VMAX_LL VMAX_LL { get; set; }
		[XmlElement(ElementName = "IMAX")]
		public IMAX IMAX { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "BlockType")]
		public string BlockType { get; set; }
	}

	[XmlRoot(ElementName = "DEBOUNCETIME")]
	public class DEBOUNCETIME
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "DEGLITCHTIME")]
	public class DEGLITCHTIME
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "OVERLOADSUPTIME")]
	public class OVERLOADSUPTIME
	{
		[XmlElement(ElementName = "Value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "MISC")]
	public class MISC
	{
		[XmlElement(ElementName = "DEBOUNCETIME")]
		public DEBOUNCETIME DEBOUNCETIME { get; set; }
		[XmlElement(ElementName = "DEGLITCHTIME")]
		public DEGLITCHTIME DEGLITCHTIME { get; set; }
		[XmlElement(ElementName = "OVERLOADSUPTIME")]
		public OVERLOADSUPTIME OVERLOADSUPTIME { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "BlockType")]
		public string BlockType { get; set; }
	}

	[XmlRoot(ElementName = "DEVICE")]
	public class DEVICE
	{
		[XmlElement(ElementName = "NAMEPLATE")]
		public NAMEPLATE NAMEPLATE { get; set; }
		[XmlElement(ElementName = "LOCATION")]
		public LOCATION LOCATION { get; set; }
		[XmlElement(ElementName = "NOMINALVALUES")]
		public NOMINALVALUES NOMINALVALUES { get; set; }
		[XmlElement(ElementName = "RESIDUALFACTORS")]
		public RESIDUALFACTORS RESIDUALFACTORS { get; set; }
		[XmlElement(ElementName = "LIMITS")]
		public LIMITS LIMITS { get; set; }
		[XmlElement(ElementName = "MISC")]
		public MISC MISC { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "BlockType")]
		public string BlockType { get; set; }
	}

	[XmlRoot(ElementName = "RIO")]
	public class RIO
	{
		[XmlElement(ElementName = "Name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "Description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "DEVICE")]
		public DEVICE DEVICE { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "BlockType")]
		public string BlockType { get; set; }
	}

	[XmlRoot(ElementName = "XRio")]
	public class XRio
	{
		[XmlElement(ElementName = "Version")]
		public string Version { get; set; }
		[XmlElement(ElementName = "Language")]
		public string Language { get; set; }
		[XmlElement(ElementName = "RioConverter")]
		public RioConverter RioConverter { get; set; }
		[XmlElement(ElementName = "CUSTOM")]
		public CUSTOM CUSTOM { get; set; }
		[XmlElement(ElementName = "RIO")]
		public RIO RIO { get; set; }
		[XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsi { get; set; }
	}

}
