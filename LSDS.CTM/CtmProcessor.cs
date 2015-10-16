using System;
using System.Text.RegularExpressions;
using OmgeoDCIWeb_API;

namespace LSDS.CTM
{
    public class CtmProcessor 
    {

        public CTM_Message ReturnCtmMessage(byte[] response, string name)
        {
            if (response == null)
            {
                return null;
            }
            var newMessage = new CTM_Message();
            var enc = System.Text.Encoding.ASCII;
            var responseString = "";
            responseString = enc?.GetString(response);
            try
            {
          
            if (responseString.Contains("Invalid.dtd"))
            {
                var invalidMsg = Regex.Split(responseString, "Invalid.dtd'>");
               
                if (1 < invalidMsg.Length)
                {
                    responseString = invalidMsg[1].Replace("\r", "").Replace("\n", "");
                }
                else
                {
                    invalidMsg = Regex.Split(responseString, "Invalid.dtd\">");
                    responseString = invalidMsg[1].Replace("\r", "").Replace("\n", "");
                }
            }
            else
            {
                var values = Regex.Split(responseString, ".dtd'>");
                if (1 < values.Length)
                {
                    responseString = values[1].Replace("\r", "").Replace("\n", "");
                }
                else
                {
                    values = Regex.Split(responseString, ".dtd\">");
                    responseString = values[1].Replace("\r", "").Replace("\n", "");
                }
            }
            }
            catch (Exception ex)
            {

                //Log an Error
                var msg = ex.Message;
            }
            try
            {
                return Seralizer.Deserialize<CTM_Message>(responseString);
            }
            catch (Exception)
            {
               // newMessage.Invalid.Text[0] = "Serialization failed for : " + responseString;
            }
            return null;
        }

        public CTM_Message ProcessMessage(byte[] message, bool duplicate,DCIWebSession webSession, string msgName)
        {

            byte[] response = null;

            response = webSession?.Submit("/home/WS/DCISubmit", // URL
         message, 0, message.Length, // message bytes, offset,
                                     // length
         "xml", // message class
       Guid.NewGuid().ToString(), // transport message id *See Note Above
         duplicate); // duplicate msgId causes exception

            return response != null ? ReturnCtmMessage(response, msgName) : null;
        }

      
        public byte[] AddDocType(string name, CTM_Message message)
        {
            var strMsg = Seralizer.SerializeObject<CTM_Message>(message)?.Replace("<CTM_Message>", "<!DOCTYPE CTM_Message PUBLIC \"-//TFN//DTD " + name + " 1.3//EN\" \"" + name + ".dtd\"><CTM_Message>").Replace("\r\n", "");
            var iso8859Encoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            return iso8859Encoding?.GetBytes(strMsg);
        }

     
    }
}
