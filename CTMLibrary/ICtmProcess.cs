using CTMLibrary.CtmMessages;
using OmgeoDCIWeb_API;

namespace CTMLibrary
{
    public interface ICtmProcess
    {
        CTM_Message SendMsg(DCIWebSession conn);

    }
}
