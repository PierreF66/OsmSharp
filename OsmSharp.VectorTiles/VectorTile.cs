//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: vector_tile.proto
namespace mapnik.vector
{
  [global::ProtoBuf.ProtoContract(Name=@"tile")]
  public partial class tile : global::ProtoBuf.IExtensible
  {
    public tile() {}
    
    private readonly global::System.Collections.Generic.List<mapnik.vector.tile.layer> _layers = new global::System.Collections.Generic.List<mapnik.vector.tile.layer>();
    [global::ProtoBuf.ProtoMember(3, Name=@"layers", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<mapnik.vector.tile.layer> layers
    {
      get { return _layers; }
    }
  
  [global::ProtoBuf.ProtoContract(Name=@"value")]
  public partial class value : global::ProtoBuf.IExtensible
  {
    public value() {}
    
    private string _string_value = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"string_value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string string_value
    {
      get { return _string_value; }
      set { _string_value = value; }
    }
    private float _float_value = default(float);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"float_value", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float float_value
    {
      get { return _float_value; }
      set { _float_value = value; }
    }
    private double _double_value = default(double);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"double_value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(double))]
    public double double_value
    {
      get { return _double_value; }
      set { _double_value = value; }
    }
    private long _int_value = default(long);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"int_value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long int_value
    {
      get { return _int_value; }
      set { _int_value = value; }
    }
    private ulong _uint_value = default(ulong);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"uint_value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong uint_value
    {
      get { return _uint_value; }
      set { _uint_value = value; }
    }
    private long _sint_value = default(long);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"sint_value", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long sint_value
    {
      get { return _sint_value; }
      set { _sint_value = value; }
    }
    private bool _bool_value = default(bool);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"bool_value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool bool_value
    {
      get { return _bool_value; }
      set { _bool_value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"feature")]
  public partial class feature : global::ProtoBuf.IExtensible
  {
    public feature() {}
    
    private ulong _id = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong id
    {
      get { return _id; }
      set { _id = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _tags = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(2, Name=@"tags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<uint> tags
    {
      get { return _tags; }
    }
  
    private mapnik.vector.tile.GeomType _type = mapnik.vector.tile.GeomType.Unknown;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(mapnik.vector.tile.GeomType.Unknown)]
    public mapnik.vector.tile.GeomType type
    {
      get { return _type; }
      set { _type = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _geometry = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(4, Name=@"geometry", DataFormat = global::ProtoBuf.DataFormat.TwosComplement, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<uint> geometry
    {
      get { return _geometry; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"layer")]
  public partial class layer : global::ProtoBuf.IExtensible
  {
    public layer() {}
    
    private uint _version;
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint version
    {
      get { return _version; }
      set { _version = value; }
    }
    private string _name;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private readonly global::System.Collections.Generic.List<mapnik.vector.tile.feature> _features = new global::System.Collections.Generic.List<mapnik.vector.tile.feature>();
    [global::ProtoBuf.ProtoMember(2, Name=@"features", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<mapnik.vector.tile.feature> features
    {
      get { return _features; }
    }
  
    private readonly global::System.Collections.Generic.List<string> _keys = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(3, Name=@"keys", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> keys
    {
      get { return _keys; }
    }
  
    private readonly global::System.Collections.Generic.List<mapnik.vector.tile.value> _values = new global::System.Collections.Generic.List<mapnik.vector.tile.value>();
    [global::ProtoBuf.ProtoMember(4, Name=@"values", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<mapnik.vector.tile.value> values
    {
      get { return _values; }
    }
  
    private uint _extent = (uint)4096;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"extent", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((uint)4096)]
    public uint extent
    {
      get { return _extent; }
      set { _extent = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"GeomType")]
    public enum GeomType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"Unknown", Value=0)]
      Unknown = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Point", Value=1)]
      Point = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LineString", Value=2)]
      LineString = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Polygon", Value=3)]
      Polygon = 3
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}