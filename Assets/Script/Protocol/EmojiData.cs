// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: xls2proto/emoji_data.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from xls2proto/emoji_data.proto</summary>
public static partial class EmojiDataReflection {

  #region Descriptor
  /// <summary>File descriptor for xls2proto/emoji_data.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static EmojiDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Chp4bHMycHJvdG8vZW1vamlfZGF0YS5wcm90byImCgplbW9qaV9kYXRhEgoK",
          "AmlkGAEgASgNEgwKBGljb24YAiABKAkiLgoQZW1vamlfZGF0YV9BUlJBWRIa",
          "CgVpdGVtcxgBIAMoCzILLmVtb2ppX2RhdGFiBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::emoji_data), global::emoji_data.Parser, new[]{ "Id", "Icon" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::emoji_data_ARRAY), global::emoji_data_ARRAY.Parser, new[]{ "Items" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class emoji_data : pb::IMessage<emoji_data> {
  private static readonly pb::MessageParser<emoji_data> _parser = new pb::MessageParser<emoji_data>(() => new emoji_data());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<emoji_data> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::EmojiDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public emoji_data() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public emoji_data(emoji_data other) : this() {
    id_ = other.id_;
    icon_ = other.icon_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public emoji_data Clone() {
    return new emoji_data(this);
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 1;
  private uint id_;
  /// <summary>
  ///* ID 
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public uint Id {
    get { return id_; }
    set {
      id_ = value;
    }
  }

  /// <summary>Field number for the "icon" field.</summary>
  public const int IconFieldNumber = 2;
  private string icon_ = "";
  /// <summary>
  ///*  
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Icon {
    get { return icon_; }
    set {
      icon_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as emoji_data);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(emoji_data other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Id != other.Id) return false;
    if (Icon != other.Icon) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Id != 0) hash ^= Id.GetHashCode();
    if (Icon.Length != 0) hash ^= Icon.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Id != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(Id);
    }
    if (Icon.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Icon);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Id != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
    }
    if (Icon.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Icon);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(emoji_data other) {
    if (other == null) {
      return;
    }
    if (other.Id != 0) {
      Id = other.Id;
    }
    if (other.Icon.Length != 0) {
      Icon = other.Icon;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          Id = input.ReadUInt32();
          break;
        }
        case 18: {
          Icon = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class emoji_data_ARRAY : pb::IMessage<emoji_data_ARRAY> {
  private static readonly pb::MessageParser<emoji_data_ARRAY> _parser = new pb::MessageParser<emoji_data_ARRAY>(() => new emoji_data_ARRAY());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<emoji_data_ARRAY> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::EmojiDataReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public emoji_data_ARRAY() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public emoji_data_ARRAY(emoji_data_ARRAY other) : this() {
    items_ = other.items_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public emoji_data_ARRAY Clone() {
    return new emoji_data_ARRAY(this);
  }

  /// <summary>Field number for the "items" field.</summary>
  public const int ItemsFieldNumber = 1;
  private static readonly pb::FieldCodec<global::emoji_data> _repeated_items_codec
      = pb::FieldCodec.ForMessage(10, global::emoji_data.Parser);
  private readonly pbc::RepeatedField<global::emoji_data> items_ = new pbc::RepeatedField<global::emoji_data>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::emoji_data> Items {
    get { return items_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as emoji_data_ARRAY);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(emoji_data_ARRAY other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!items_.Equals(other.items_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= items_.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    items_.WriteTo(output, _repeated_items_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    size += items_.CalculateSize(_repeated_items_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(emoji_data_ARRAY other) {
    if (other == null) {
      return;
    }
    items_.Add(other.items_);
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          items_.AddEntriesFrom(input, _repeated_items_codec);
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code