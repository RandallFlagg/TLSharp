using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeleSharp.TL;

namespace TeleSharp.TL
{
    [TLObject(681706865)]
    public class TLMessageEntityCode : TLAbsMessageEntity
    {
        public override int Constructor
        {
            get
            {
                return 681706865;
            }
        }

        public int Offset { get; set; }
        public int Length { get; set; }

        public void ComputeFlags()
        {
            // do nothing
        }

        public override void DeserializeBody(BinaryReader br)
        {
            Offset = br.ReadInt32();
            Length = br.ReadInt32();
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(Offset);
            bw.Write(Length);
        }
    }
}
