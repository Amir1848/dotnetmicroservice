// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/students.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Calculation.Grpc.Protos {

  /// <summary>Holder for reflection information generated from Protos/students.proto</summary>
  public static partial class StudentsReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/students.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StudentsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQcm90b3Mvc3R1ZGVudHMucHJvdG8iLgobR2V0QWxsVGVhY2hpbmdBc3Np",
            "c3RhbnRzUmVxEg8KB3Rlcm1faWQYASABKAMiRwoVQWxsVGVhY2hpbmdBc3Np",
            "c3RhbnRzEi4KEnRlYWNoaW5nQXNzaXN0YW50cxgBIAMoCzISLlRlYWNoaW5n",
            "QXNzaXN0YW50IqQBChFUZWFjaGluZ0Fzc2lzdGFudBIKCgJpZBgBIAEoAxIU",
            "CgxzdHVkZW50X2NvZGUYAiABKAkSFAoMc3R1ZGVudF9uYW1lGAMgASgJEhkK",
            "EXN0dWRlbnRfbGFzdF9uYW1lGAQgASgJEhQKDGNvdXJzZV90aXRsZRgFIAEo",
            "CRISCgp0ZXJtX3RpdGxlGAYgASgJEhIKCmxlc3Nvbl9yZWYYByABKAMyXQoH",
            "U3R1ZGVudBJSChhHZXRBbGxUZWFjaGluZ0Fzc2lzdGFudHMSHC5HZXRBbGxU",
            "ZWFjaGluZ0Fzc2lzdGFudHNSZXEaFi5BbGxUZWFjaGluZ0Fzc2lzdGFudHMi",
            "AEIaqgIXQ2FsY3VsYXRpb24uR3JwYy5Qcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Calculation.Grpc.Protos.GetAllTeachingAssistantsReq), global::Calculation.Grpc.Protos.GetAllTeachingAssistantsReq.Parser, new[]{ "TermId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Calculation.Grpc.Protos.AllTeachingAssistants), global::Calculation.Grpc.Protos.AllTeachingAssistants.Parser, new[]{ "TeachingAssistants" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Calculation.Grpc.Protos.TeachingAssistant), global::Calculation.Grpc.Protos.TeachingAssistant.Parser, new[]{ "Id", "StudentCode", "StudentName", "StudentLastName", "CourseTitle", "TermTitle", "LessonRef" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetAllTeachingAssistantsReq : pb::IMessage<GetAllTeachingAssistantsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetAllTeachingAssistantsReq> _parser = new pb::MessageParser<GetAllTeachingAssistantsReq>(() => new GetAllTeachingAssistantsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetAllTeachingAssistantsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Calculation.Grpc.Protos.StudentsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAllTeachingAssistantsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAllTeachingAssistantsReq(GetAllTeachingAssistantsReq other) : this() {
      termId_ = other.termId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAllTeachingAssistantsReq Clone() {
      return new GetAllTeachingAssistantsReq(this);
    }

    /// <summary>Field number for the "term_id" field.</summary>
    public const int TermIdFieldNumber = 1;
    private long termId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long TermId {
      get { return termId_; }
      set {
        termId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetAllTeachingAssistantsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetAllTeachingAssistantsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TermId != other.TermId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TermId != 0L) hash ^= TermId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (TermId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(TermId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (TermId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(TermId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (TermId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TermId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetAllTeachingAssistantsReq other) {
      if (other == null) {
        return;
      }
      if (other.TermId != 0L) {
        TermId = other.TermId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            TermId = input.ReadInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            TermId = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class AllTeachingAssistants : pb::IMessage<AllTeachingAssistants>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AllTeachingAssistants> _parser = new pb::MessageParser<AllTeachingAssistants>(() => new AllTeachingAssistants());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AllTeachingAssistants> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Calculation.Grpc.Protos.StudentsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AllTeachingAssistants() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AllTeachingAssistants(AllTeachingAssistants other) : this() {
      teachingAssistants_ = other.teachingAssistants_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AllTeachingAssistants Clone() {
      return new AllTeachingAssistants(this);
    }

    /// <summary>Field number for the "teachingAssistants" field.</summary>
    public const int TeachingAssistantsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Calculation.Grpc.Protos.TeachingAssistant> _repeated_teachingAssistants_codec
        = pb::FieldCodec.ForMessage(10, global::Calculation.Grpc.Protos.TeachingAssistant.Parser);
    private readonly pbc::RepeatedField<global::Calculation.Grpc.Protos.TeachingAssistant> teachingAssistants_ = new pbc::RepeatedField<global::Calculation.Grpc.Protos.TeachingAssistant>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Calculation.Grpc.Protos.TeachingAssistant> TeachingAssistants {
      get { return teachingAssistants_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AllTeachingAssistants);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AllTeachingAssistants other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!teachingAssistants_.Equals(other.teachingAssistants_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= teachingAssistants_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      teachingAssistants_.WriteTo(output, _repeated_teachingAssistants_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      teachingAssistants_.WriteTo(ref output, _repeated_teachingAssistants_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += teachingAssistants_.CalculateSize(_repeated_teachingAssistants_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AllTeachingAssistants other) {
      if (other == null) {
        return;
      }
      teachingAssistants_.Add(other.teachingAssistants_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            teachingAssistants_.AddEntriesFrom(input, _repeated_teachingAssistants_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            teachingAssistants_.AddEntriesFrom(ref input, _repeated_teachingAssistants_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class TeachingAssistant : pb::IMessage<TeachingAssistant>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TeachingAssistant> _parser = new pb::MessageParser<TeachingAssistant>(() => new TeachingAssistant());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TeachingAssistant> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Calculation.Grpc.Protos.StudentsReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TeachingAssistant() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TeachingAssistant(TeachingAssistant other) : this() {
      id_ = other.id_;
      studentCode_ = other.studentCode_;
      studentName_ = other.studentName_;
      studentLastName_ = other.studentLastName_;
      courseTitle_ = other.courseTitle_;
      termTitle_ = other.termTitle_;
      lessonRef_ = other.lessonRef_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TeachingAssistant Clone() {
      return new TeachingAssistant(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private long id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "student_code" field.</summary>
    public const int StudentCodeFieldNumber = 2;
    private string studentCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StudentCode {
      get { return studentCode_; }
      set {
        studentCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "student_name" field.</summary>
    public const int StudentNameFieldNumber = 3;
    private string studentName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StudentName {
      get { return studentName_; }
      set {
        studentName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "student_last_name" field.</summary>
    public const int StudentLastNameFieldNumber = 4;
    private string studentLastName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StudentLastName {
      get { return studentLastName_; }
      set {
        studentLastName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "course_title" field.</summary>
    public const int CourseTitleFieldNumber = 5;
    private string courseTitle_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CourseTitle {
      get { return courseTitle_; }
      set {
        courseTitle_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "term_title" field.</summary>
    public const int TermTitleFieldNumber = 6;
    private string termTitle_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TermTitle {
      get { return termTitle_; }
      set {
        termTitle_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "lesson_ref" field.</summary>
    public const int LessonRefFieldNumber = 7;
    private long lessonRef_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long LessonRef {
      get { return lessonRef_; }
      set {
        lessonRef_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TeachingAssistant);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TeachingAssistant other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (StudentCode != other.StudentCode) return false;
      if (StudentName != other.StudentName) return false;
      if (StudentLastName != other.StudentLastName) return false;
      if (CourseTitle != other.CourseTitle) return false;
      if (TermTitle != other.TermTitle) return false;
      if (LessonRef != other.LessonRef) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0L) hash ^= Id.GetHashCode();
      if (StudentCode.Length != 0) hash ^= StudentCode.GetHashCode();
      if (StudentName.Length != 0) hash ^= StudentName.GetHashCode();
      if (StudentLastName.Length != 0) hash ^= StudentLastName.GetHashCode();
      if (CourseTitle.Length != 0) hash ^= CourseTitle.GetHashCode();
      if (TermTitle.Length != 0) hash ^= TermTitle.GetHashCode();
      if (LessonRef != 0L) hash ^= LessonRef.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Id);
      }
      if (StudentCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(StudentCode);
      }
      if (StudentName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(StudentName);
      }
      if (StudentLastName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(StudentLastName);
      }
      if (CourseTitle.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(CourseTitle);
      }
      if (TermTitle.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(TermTitle);
      }
      if (LessonRef != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(LessonRef);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Id);
      }
      if (StudentCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(StudentCode);
      }
      if (StudentName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(StudentName);
      }
      if (StudentLastName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(StudentLastName);
      }
      if (CourseTitle.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(CourseTitle);
      }
      if (TermTitle.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(TermTitle);
      }
      if (LessonRef != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(LessonRef);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (StudentCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StudentCode);
      }
      if (StudentName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StudentName);
      }
      if (StudentLastName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StudentLastName);
      }
      if (CourseTitle.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CourseTitle);
      }
      if (TermTitle.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TermTitle);
      }
      if (LessonRef != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(LessonRef);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TeachingAssistant other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0L) {
        Id = other.Id;
      }
      if (other.StudentCode.Length != 0) {
        StudentCode = other.StudentCode;
      }
      if (other.StudentName.Length != 0) {
        StudentName = other.StudentName;
      }
      if (other.StudentLastName.Length != 0) {
        StudentLastName = other.StudentLastName;
      }
      if (other.CourseTitle.Length != 0) {
        CourseTitle = other.CourseTitle;
      }
      if (other.TermTitle.Length != 0) {
        TermTitle = other.TermTitle;
      }
      if (other.LessonRef != 0L) {
        LessonRef = other.LessonRef;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id = input.ReadInt64();
            break;
          }
          case 18: {
            StudentCode = input.ReadString();
            break;
          }
          case 26: {
            StudentName = input.ReadString();
            break;
          }
          case 34: {
            StudentLastName = input.ReadString();
            break;
          }
          case 42: {
            CourseTitle = input.ReadString();
            break;
          }
          case 50: {
            TermTitle = input.ReadString();
            break;
          }
          case 56: {
            LessonRef = input.ReadInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Id = input.ReadInt64();
            break;
          }
          case 18: {
            StudentCode = input.ReadString();
            break;
          }
          case 26: {
            StudentName = input.ReadString();
            break;
          }
          case 34: {
            StudentLastName = input.ReadString();
            break;
          }
          case 42: {
            CourseTitle = input.ReadString();
            break;
          }
          case 50: {
            TermTitle = input.ReadString();
            break;
          }
          case 56: {
            LessonRef = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
