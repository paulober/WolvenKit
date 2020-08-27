using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSbDescCamera : CVariable
	{
		[RED("uId")] 		public CString UId { get; set;}

		[RED("repoCamId")] 		public CString RepoCamId { get; set;}

		[RED("pos")] 		public Vector Pos { get; set;}

		[RED("rot")] 		public EulerAngles Rot { get; set;}

		[RED("fov")] 		public CFloat Fov { get; set;}

		[RED("dof")] 		public SStoryBoardCameraDofSettings Dof { get; set;}

		public SSbDescCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSbDescCamera(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}