using System;
using System.Collections.Generic;
using System.Text;
using Symbol.RFID3;
using System.IO;   
using System.Timers;
using System.Threading;
namespace ModelRFiD
{
    public  class cls_rfid
    {

        public RFIDReader rfid3;
        public delegate void ConnectionStatusEventHandler(bool status);
        public delegate void NewTagEventHandler(string tag);
        public event ConnectionStatusEventHandler ConnectionStatusEvent;
        public event NewTagEventHandler NewTagEvent;

        public bool connecting = false;
        public cls_rfid(string ip)
        {
            scd(ip);
        }
        private void scd(string ip)
        {
            if (ip != "")
            {
                if (rfid3 == null)
                {
                    try
                    {
                        rfid3 = new RFIDReader(ip, 0, 0);
                        connect();
                    }
                    catch (Exception)
                    {
                        scd(ip);
                    }
                }
                else
                {
                    rfid3 = null;
                    GC.Collect();
                    scd(ip);
                }
            }
        }
        public  void connect()
        {
            if (!connecting)
	        {
                connecting = true;
                if (cls_main.rdrip != "")
                {
                    
                    try
                    {
                        rfid3.Connect();
                        try
                        {
                            rfid3.Events.AttachTagDataWithReadEvent = true;
                            rfid3.TimeoutMilliseconds = 1000;
                            rfid3.Events.ReadNotify += new Events.ReadNotifyHandler(Events_ReadNotify);
                            rfid3.Events.NotifyReaderDisconnectEvent = true;
                            rfid3.Events.NotifyReaderExceptionEvent = true;
                            rfid3.Events.StatusNotify += new Events.StatusNotifyHandler(Events_StatusNotify);                        
                            TagData reportedTag = new TagData();
                            try
                            {
                                rfid3.Actions.Inventory.Perform();
                                ConnectionStatusEvent(true);
                            
                            }
                            catch (Exception ex)
                            {
                                logging(ex.Message, "Inventory");
                            }
                        }
                        catch (Exception ex)
                        {
                            logging(ex.Message, "Attach");
                        }
                    }
                    catch (Exception ex)
                    {
                        logging(ex.Message, "Connect");
                    }
                }
            }
            connecting = false;
        }
        public void Events_ReadNotify(object sender, Events.ReadEventArgs e)
        {
            string lv_tag = e.ReadEventData.TagData.TagID.ToString();
            NewTagEvent(lv_tag);
        }
        private void Events_StatusNotify(object sender, Symbol.RFID3.Events.StatusEventArgs e)
        {
            if (e.StatusEventData.StatusEventType == Symbol.RFID3.Events.STATUS_EVENT_TYPE.DISCONNECTION_EVENT)
            {
                ConnectionStatusEvent(false);
            }
            else if (e.StatusEventData.StatusEventType == Symbol.RFID3.Events.STATUS_EVENT_TYPE.READER_EXCEPTION_EVENT)
            {
               logging(e.StatusEventData.ReaderExceptionEventData.ReaderExceptionEventInfo.ToString(),"Event");                                                                                                    
            }
        }
        public void disconnect()
        {
            if (rfid3 != null)
            {
                try
                {
                    rfid3.Disconnect();
                    //connected = false;
                }
                catch (Exception)
                {
                    disconnect();
                }
                
            }
        }
        private void logging(string msg, string area)
        {
            System.IO.File.AppendAllText("rfid." + DateTime.Now.ToString("yyyMMdd") + ".error.log", DateTime.Now + "\t" + area + "\t" + msg + Environment.NewLine);
        }
    }
}
