using LSDS.CTM;
using LSDS.CTM.CtmMessages;
using OmgeoDCIWeb_API;

namespace LSDS.CTM
{
    public class SendTradeDetail : ICtmProcess
    {
        private readonly CTM_Message _message;

        public SendTradeDetail()
        {
        }

        public SendTradeDetail(CTM_Message message)
        {
            _message = message;
       
        }


        public CTM_Message SendMsg(DCIWebSession con)
        {
            var processor = new CtmProcessor();
            return processor.ProcessMessage(processor.AddDocType("TradeDetail", _message), false, con, "TradeDetail");

        }

        public CTM_Message SendMsgString(DCIWebSession con, string message)
        {
            var processor = new CtmProcessor();
            return processor.ProcessMessage(processor.AddDocType("TradeDetail", message), false, con, "TradeDetail");

        }

    }
}