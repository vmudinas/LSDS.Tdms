using LSDS.CTM;
using OmgeoDCIWeb_API;

namespace LSDS.CTM
{
    public interface ICtmProcess
    {
        CTM_Message SendMsg(DCIWebSession conn);

    }
}
