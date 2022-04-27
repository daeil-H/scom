using System;
using System.Collections.Generic;
using System.Text;
using kr.co.aim.scomdriver.global;
using kr.co.aim.scomdriver.plugin;
using kr.co.aim.scomdriver.structure;
using kr.co.aim.scomdriver.callback;
using kr.co.aim.scomdriver.timeout;


namespace sampleUI
{
    class SECSWrapper : ISECSListener
    {

        SinglePlugIn plugIn = new SinglePlugIn();
        SECSConfig config = new SECSConfig();
        Form1 rootHandle;

        public CODEGEN m_smdFactory;
        
        //use SECS Config
        public void initialize(Form1 rootHandle)
        {
            this.rootHandle = rootHandle;
            initializeConfig();

            plugIn.AddSECSListener(this);
            chekcReturnObject(plugIn.Initialize(config), "Initialize");
            initializeSMDFactory();
        }

        //use driverid and local driverid.xml
        public void initialize2(Form1 rootHandle)
        {
            this.rootHandle = rootHandle;

            plugIn.AddSECSListener(this);
            chekcReturnObject(plugIn.Initialize("EQPP22", "SEComINI.xml"), "Initialize");
            initializeSMDFactory();
        }

        private void initializeSMDFactory()
        {
            m_smdFactory = new CODEGEN(plugIn);
        }

        public void terminate()
        {
            chekcReturnObject(plugIn.Terminate(), "Terminate");
            
        }

        private void initializeConfig()
        {
            config.Active = true;
            config.AnalyzerOption = 7;
            config.DeviceId = 0;
            config.DispatchOn = true;
            config.DriverId = "host01";
            config.DriverLogLevel = 0;
            config.Host = true;
            //config.Host = false;
            config.IpAddress = "127.0.0.1";
            config.LinktestDuration = 120;
            config.LogModeDaily = true;
            config.LogModeDeleteDuration = 3;
            config.LogRootPath = ".";
            //config.MaxLength =
            config.ModelingInfoFromFile = "default.smd";
            config.OverRawBinaryLength = 10;
            config.Port = 9000;
            config.SecsLogMode = 1;
            config.UseRawBinary = false;
            config.Timeout6 = 30;

        }

        public void onConnected(string driverid)
        {
            rootHandle.txtConnectionUpdate(1);
            rootHandle.txtLogUpdate("Connected");

        }

        public void onDisconnected(string driverid)
        {
            rootHandle.txtConnectionUpdate(2);
            rootHandle.txtLogUpdate("Disconnectd");
        }

        public void onReceived(string driverid, SECSTransaction trx)
        {
            if (trx.ControlMessage)
                rootHandle.txtLogUpdate("RECV Control Message");
            else
            {
                loggingTransactionMsg(trx, false);

                if (trx.Stream == 7 && trx.Function == 25)
                    replyS7F26(trx.Systembyte);
            }
        }
        public void onIllegal(string driverid, SECSTransaction trx, string illegalMessage)
        {
            rootHandle.txtLogUpdate("RECV Illiegal Message");
        }

        public void onTimeout(string driverid, SECSTimeout timeout)
        {
        }

        public void onSendComplete(string driverid, SECSTransaction trx)
        {
            loggingTransactionMsg(trx, true);
        }

        public void onLog(string driverid, string log)
        {

        }

        public void onUnknownReceived(string driverID, SECSTransaction trx)
        {
            rootHandle.txtLogUpdate("RECV Unknonwn Message");
        }

        private void loggingTransactionMsg(SECSTransaction trx, Boolean isSendmsg)
        {
            String msg;
            if(isSendmsg)
                msg = "[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] SEND: S" + trx.Stream + "F" + trx.Function + " ";
            else
                msg = "[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] RECV: S" + trx.Stream + "F" + trx.Function + " ";

            if (trx.Wbit)
                msg += "W ";
            msg += "SystemBytes=" + trx.Systembyte;
            rootHandle.txtLogUpdate(msg);

            
            if (trx.HeaderString.Trim() != "")
            {
                msg = trx.HeaderString.Trim() + "\n";
                msg += trx.SECS1BodyString.Trim();
                rootHandle.txtLogUpdate(msg);
            }
            if(trx.SECS2BodyString != "")
                rootHandle.txtLogUpdate(trx.SECS2BodyString);
        }

        public void SendMessage(SECSTransaction trx)
        {
            chekcReturnObject(plugIn.request(trx), "Send");
        }

        public void hotSend(int stream, int function,  string messageName)
        {
            ReturnObject returnObject = plugIn.GetDefinedMessage(stream,function,messageName) as ReturnObject;
            if (returnObject.isSuccess())
                chekcReturnObject(plugIn.request(returnObject.getReturnData() as SECSTransaction), "Send");
            else
                chekcReturnObject(returnObject, "GetDefinedMessage");

        }

        private bool chekcReturnObject(IReturnObject returnObject, string action)
        {
            if (!returnObject.isSuccess())
                return false;

            return returnObject.isSuccess();
        }

        public SECSTransaction hotSendMessage(int stream, int function, string msgName)
        {
            return null;
        }

        public ReturnObject SendS2F41()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 41;

            trx.add(new ListFormat());
            trx.add(AsciiFormat.TYPE, -1, "RCMD", "RCMDVALUE");

            int nCPCOUNT = 3;
            IFormat nodeCPCount = trx.add(ListFormat.TYPE, nCPCOUNT, "CPCOUNT", "");
            for (int i = 0; i < nCPCOUNT; i++)
            {
                IFormat temp = nodeCPCount.add(ListFormat.TYPE, 2, "", "");
                temp.add(AsciiFormat.TYPE, -1, "CPNAME", "CPNAMEVALUE" + i);// fixed 경우 length는 fixed, fixed가 아닌 경우 variable이라고 명시해 주고, -1로 하자.
                temp.add(AsciiFormat.TYPE, 12, "CPVALUE", "CPVALUEVALUE" + i);
            }

            //return plugIn.request(trx);


            SECSTransaction trx1 = new SECSTransaction();

            trx1.setStreamNWbit(2, false);
            trx1.Function = 41;


            IFormat list1;


            list1 = trx1.add(new ListFormat());


            list1.add(AsciiFormat.TYPE, -1, "RCMD", "RCMDVALUE");

            int nCPCOUNT1 = 3;
            IFormat nodeCPCount1 = list1.add(ListFormat.TYPE, nCPCOUNT1, "CPCOUNT", "");
            for (int i = 0; i < nCPCOUNT1; i++)
            {
                IFormat temp = nodeCPCount1.add(ListFormat.TYPE, 2, "", "");
                temp.add(AsciiFormat.TYPE, -1, "CPNAME", "CPNAMEVALUE" + i);// fixed 경우 length는 fixed, fixed가 아닌 경우 variable이라고 명시해 주고, -1로 하자.
                temp.add(AsciiFormat.TYPE, 10, "CPVALUE", "CPVALUEVALUE" + i);
            }

            return plugIn.request(trx1) as ReturnObject;
        }

        public void replyS7F26(long systembyte)
        {
            ReturnObject returnObject = (ReturnObject)plugIn.GetDefinedMessage(7, 26, "S7F26");
            SECSTransaction sxtrx = returnObject.getReturnData() as SECSTransaction;
            sxtrx.Systembyte = systembyte;

            IFormat target = sxtrx.getByName("PPARM");
            target.Value = "THIS IS TEST DATA";

            plugIn.reply(sxtrx);
        }
    }
}
