using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeleSharp.TL;

namespace TeleSharp.TL
{
    [TLObject(2054952868)]
    public class TLInputMessagesFilterRoundVoice : TLAbsMessagesFilter
    {
        public override int Constructor
        {
            get
            {
                return 2054952868;
            }
        }

        // no fields

        public void ComputeFlags()
        {
            // do nothing
        }

        public override void DeserializeBody(BinaryReader br)
        {
            // do nothing
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            // do nothing
        }
    }
}
