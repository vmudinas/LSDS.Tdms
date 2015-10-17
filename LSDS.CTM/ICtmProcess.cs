using LSDS.CTM;
using LSDS.CTM.CtmMessages;
using OmgeoDCIWeb_API;

namespace LSDS.CTM
{
    public interface ICtmProcess
    {
        CTM_Message SendMsg(DCIWebSession conn);

    }
}
