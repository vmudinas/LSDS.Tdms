using LSDS.CTM.CtmMessages;
using OmgeoDCIWeb_API;

namespace LSDS.CTM
{
    public class SendTradeCancel : ICtmProcess
    {
        private readonly CTM_Message _message;

        public SendTradeCancel()
        {
        }

        public SendTradeCancel(CTM_Message message)
        {
            _message = message;

        }


        public CTM_Message SendMsg(DCIWebSession con)
        {
            var processor = new CtmProcessor();
            return processor.ProcessMessage(processor.AddDocType("Cancel", _message), false, con, "Cancel");

        }

        public CTM_Message SendMsgString(DCIWebSession con, string message)
        {
            var processor = new CtmProcessor();
            return processor.ProcessMessage(processor.AddDocType("Cancel", message), false, con, "Cancel");

        }

    }
}