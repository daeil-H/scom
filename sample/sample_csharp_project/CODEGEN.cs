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
    class CODEGEN
    {
        private SinglePlugIn m_plugIn;

        public CODEGEN(SinglePlugIn plugin)
        {
            m_plugIn = plugin;
        }
        
        public ReturnObject sendRequestMessage(SECSTransaction trx)
        {
            return m_plugIn.request(trx) as ReturnObject;
        }

        public ReturnObject sendReplyMessage(SECSTransaction trx)
        {
            return m_plugIn.request(trx) as ReturnObject;
        }

        public SECSTransaction getDefinedMessage(int stream, int function, string definedMessageName)
        {
            ReturnObject returnObject = m_plugIn.GetDefinedMessage(stream, function, definedMessageName) as ReturnObject;
            if (returnObject.isSuccess())
                return returnObject.getReturnData() as SECSTransaction;
            else
            {
                //System.Diagnostics.Trace.WriteLine("Faile to getDefinedMessage Error:" + returnObject.getErrorObject().getErrorDiscription());
                return null;
            }

        }

        
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeAreYouThere()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, true);
            trx.Function = 1;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeOnLineData()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, false);
            trx.Function = 2;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"MDLN","AIMFAb");
                node_0.add(AsciiFormat.TYPE,6,"SOFTREV","V01R01");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeIAmHere()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, false);
            trx.Function = 2;

            ListFormat node_0=trx.add(ListFormat.TYPE,0,"","")  as ListFormat;

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS1F3()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, true);
            trx.Function = 3;

            int nSVIDCOUNT = 20; //varibale count, if need, change! 
            ListFormat node_SVIDCOUNT=trx.add(ListFormat.TYPE,nSVIDCOUNT,"SVIDCOUNT","") as ListFormat; 
            for(int n0=0; n0< nSVIDCOUNT; n0++) 
            { 
                node_SVIDCOUNT.add(Int2Format.TYPE,1,"SVID","0");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS1F4()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, false);
            trx.Function = 4;

            int nSVCOUNT = 20; //varibale count, if need, change! 
            ListFormat node_SVCOUNT=trx.add(ListFormat.TYPE,nSVCOUNT,"SVCOUNT","") as ListFormat; 
            for(int n0=0; n0< nSVCOUNT; n0++) 
            { 
                node_SVCOUNT.add(XFormat.TYPE,-1,"SV","");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS1F5()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, true);
            trx.Function = 5;

            trx.add(BinaryFormat.TYPE,1,"SFCD","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS1F6()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, false);
            trx.Function = 6;

            trx.add(BinaryFormat.TYPE,1,"ACKC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS1F7()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, true);
            trx.Function = 7;

            trx.add(BinaryFormat.TYPE,1,"SFCD","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS1F8()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, false);
            trx.Function = 8;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS1F9()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, true);
            trx.Function = 9;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS1F10()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, false);
            trx.Function = 10;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,-1,"TSIP","");
                node_0.add(BinaryFormat.TYPE,-1,"TSOP","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS1F11()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, true);
            trx.Function = 11;

            int nSVIDCOUNT = 20; //varibale count, if need, change! 
            ListFormat node_SVIDCOUNT=trx.add(ListFormat.TYPE,nSVIDCOUNT,"SVIDCOUNT","") as ListFormat; 
            for(int n0=0; n0< nSVIDCOUNT; n0++) 
            { 
                node_SVIDCOUNT.add(Int2Format.TYPE,1,"SVID","0");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS1F12()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, false);
            trx.Function = 12;

            int nSVIDCOUNT = 20; //varibale count, if need, change! 
            ListFormat node_SVIDCOUNT=trx.add(ListFormat.TYPE,nSVIDCOUNT,"SVIDCOUNT","") as ListFormat; 
            for(int n0=0; n0< nSVIDCOUNT; n0++) 
            { 
                ListFormat node_1=node_SVIDCOUNT.add(ListFormat.TYPE,3,"","")  as ListFormat;
                    node_1.add(Int2Format.TYPE,1,"SVID","0");
                    node_1.add(AsciiFormat.TYPE,-1,"SVNAME","");
                    node_1.add(AsciiFormat.TYPE,-1,"UNITS","");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeConnectHost()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, true);
            trx.Function = 13;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"MDLN","AIMFAB");
                node_0.add(AsciiFormat.TYPE,6,"SOFTREV","V01R01");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeConnectEquip()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, true);
            trx.Function = 13;

            ListFormat node_0=trx.add(ListFormat.TYPE,0,"","")  as ListFormat;

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeHostConnected()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, false);
            trx.Function = 14;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"COMMACK","0");
                ListFormat node_1=node_0.add(ListFormat.TYPE,0,"","")  as ListFormat;

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeEquipConnected()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, false);
            trx.Function = 14;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"COMMACK","0");
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(AsciiFormat.TYPE,6,"MDLN","AIMFAB");
                    node_1.add(AsciiFormat.TYPE,6,"SOFTREV","V01R01");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS1F15()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, true);
            trx.Function = 15;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS1F16()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, false);
            trx.Function = 16;

            trx.add(BinaryFormat.TYPE,1,"OFLACK","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS1F17()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, true);
            trx.Function = 17;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS1F18()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, false);
            trx.Function = 18;

            trx.add(BinaryFormat.TYPE,1,"ONLACK","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS1F19()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, true);
            trx.Function = 19;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"OBJTYPE","");
                int nOBJECTCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_OBJECTCOUNT=node_0.add(ListFormat.TYPE,nOBJECTCOUNT,"OBJECTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nOBJECTCOUNT; n1++) 
                { 
                    node_OBJECTCOUNT.add(AsciiFormat.TYPE,6,"OBJECTID","");
                } 
                int nATTRCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ATTRCOUNT=node_0.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                for(int n1=0; n1< nATTRCOUNT; n1++) 
                { 
                    node_ATTRCOUNT.add(AsciiFormat.TYPE,6,"ATTRID","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS1F20()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(1, false);
            trx.Function = 20;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                int nOBJECTCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_OBJECTCOUNT=node_0.add(ListFormat.TYPE,nOBJECTCOUNT,"OBJECTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nOBJECTCOUNT; n1++) 
                { 
                    int nATTRCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ATTRCOUNT=node_OBJECTCOUNT.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nATTRCOUNT; n2++) 
                    { 
                        node_ATTRCOUNT.add(AsciiFormat.TYPE,-1,"ATTRDATA","");
                    } 
                } 
                int nERRORCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ERRORCOUNT=node_0.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                for(int n1=0; n1< nERRORCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_2.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS2F1()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 1;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"SPID","");
                node_0.add(Int2Format.TYPE,1,"LENGTH","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F2()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 2;

            trx.add(BinaryFormat.TYPE,1,"ACKC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS2F3()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 3;

            trx.add(BinaryFormat.TYPE,-1,"EPD","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F4()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 4;

            trx.add(BinaryFormat.TYPE,1,"ACKC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS2F5()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 5;

            trx.add(AsciiFormat.TYPE,-1,"SPID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F6()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 6;

            trx.add(BinaryFormat.TYPE,1,"ACKC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS2F7()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 7;

            trx.add(AsciiFormat.TYPE,-1,"SPID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F8()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 8;

            trx.add(BinaryFormat.TYPE,1,"ACKC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS2F9()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 9;

            trx.add(AsciiFormat.TYPE,-1,"SPID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F10()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 10;

            trx.add(XFormat.TYPE,-1,"ACKC","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F11()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 11;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F12()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 12;

            int nPROGRAMCOUNT = 10; //varibale count, if need, change! 
            ListFormat node_PROGRAMCOUNT=trx.add(ListFormat.TYPE,nPROGRAMCOUNT,"PROGRAMCOUNT","") as ListFormat; 
            for(int n0=0; n0< nPROGRAMCOUNT; n0++) 
            { 
                node_PROGRAMCOUNT.add(AsciiFormat.TYPE,-1,"SPID","");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F13()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 13;

            int nECIDCOUNT = 10; //varibale count, if need, change! 
            ListFormat node_ECIDCOUNT=trx.add(ListFormat.TYPE,nECIDCOUNT,"ECIDCOUNT","") as ListFormat; 
            for(int n0=0; n0< nECIDCOUNT; n0++) 
            { 
                node_ECIDCOUNT.add(Uint2Format.TYPE,1,"ECID","0");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F14()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 14;

            int nECVCOUNT = 10; //varibale count, if need, change! 
            ListFormat node_ECVCOUNT=trx.add(ListFormat.TYPE,nECVCOUNT,"ECVCOUNT","") as ListFormat; 
            for(int n0=0; n0< nECVCOUNT; n0++) 
            { 
                node_ECVCOUNT.add(Uint2Format.TYPE,1,"ECV","0");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS2F15()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 15;

            int nECIDCOUNT = 10; //varibale count, if need, change! 
            ListFormat node_ECIDCOUNT=trx.add(ListFormat.TYPE,nECIDCOUNT,"ECIDCOUNT","") as ListFormat; 
            for(int n0=0; n0< nECIDCOUNT; n0++) 
            { 
                ListFormat node_1=node_ECIDCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint2Format.TYPE,1,"ECID","0");
                    node_1.add(AsciiFormat.TYPE,-1,"ECV","");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F16()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 16;

            trx.add(BinaryFormat.TYPE,1,"EAC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeDateTimeRequest()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 17;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeDateTimeData()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 18;

            trx.add(AsciiFormat.TYPE,16,"TIMEDATE","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS2F19()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 19;

            trx.add(BinaryFormat.TYPE,1,"CCODE","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F20()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 20;

            trx.add(BinaryFormat.TYPE,1,"ACKC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS2F21()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 21;

            trx.add(AsciiFormat.TYPE,-1,"RCMD","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F22()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 22;

            trx.add(BinaryFormat.TYPE,1,"CMDA","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS2F23()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 23;

            ListFormat node_0=trx.add(ListFormat.TYPE,5,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"TRID","0");
                node_0.add(AsciiFormat.TYPE,6,"DSPER","");
                node_0.add(Uint2Format.TYPE,1,"TOTSMP","0");
                node_0.add(Uint2Format.TYPE,1,"REPGSZ","0");
                int nSVIDCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_SVIDCOUNT=node_0.add(ListFormat.TYPE,nSVIDCOUNT,"SVIDCOUNT","") as ListFormat; 
                for(int n1=0; n1< nSVIDCOUNT; n1++) 
                { 
                    node_SVIDCOUNT.add(Uint2Format.TYPE,1,"SVID","0");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F24()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 24;

            trx.add(BinaryFormat.TYPE,1,"ACKC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS2F25()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 25;

            trx.add(BinaryFormat.TYPE,-1,"DATA","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F26()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 26;

            trx.add(BinaryFormat.TYPE,-1,"DATA","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS2F27()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 27;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"LOC","");
                node_0.add(AsciiFormat.TYPE,-1,"PPID","");
                int nMTIDCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_MTIDCOUNT=node_0.add(ListFormat.TYPE,nMTIDCOUNT,"MTIDCOUNT","") as ListFormat; 
                for(int n1=0; n1< nMTIDCOUNT; n1++) 
                { 
                    node_MTIDCOUNT.add(AsciiFormat.TYPE,-1,"MTID","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F28()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 28;

            trx.add(Uint1Format.TYPE,1,"CMDA","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F29()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 29;

            int nECIDCOUNT = 10; //varibale count, if need, change! 
            ListFormat node_ECIDCOUNT=trx.add(ListFormat.TYPE,nECIDCOUNT,"ECIDCOUNT","") as ListFormat; 
            for(int n0=0; n0< nECIDCOUNT; n0++) 
            { 
                node_ECIDCOUNT.add(Uint2Format.TYPE,1,"ECID","0");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F30()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 30;

            int nECIDCOUNT = 10; //varibale count, if need, change! 
            ListFormat node_ECIDCOUNT=trx.add(ListFormat.TYPE,nECIDCOUNT,"ECIDCOUNT","") as ListFormat; 
            for(int n0=0; n0< nECIDCOUNT; n0++) 
            { 
                ListFormat node_1=node_ECIDCOUNT.add(ListFormat.TYPE,6,"","")  as ListFormat;
                    node_1.add(Uint2Format.TYPE,1,"ECID","0");
                    node_1.add(AsciiFormat.TYPE,-1,"ECNAME","");
                    node_1.add(AsciiFormat.TYPE,-1,"ECMIN","");
                    node_1.add(AsciiFormat.TYPE,-1,"ECMAX","");
                    node_1.add(AsciiFormat.TYPE,-1,"ECDEF","");
                    node_1.add(AsciiFormat.TYPE,-1,"ECUNIT","");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS2F31()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 31;

            trx.add(AsciiFormat.TYPE,16,"TIMEDATE","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F32()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 32;

            trx.add(BinaryFormat.TYPE,1,"ACKC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS2F33()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 33;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                int nRPTIDCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_RPTIDCOUNT=node_0.add(ListFormat.TYPE,nRPTIDCOUNT,"RPTIDCOUNT","") as ListFormat; 
                for(int n1=0; n1< nRPTIDCOUNT; n1++) 
                { 
                    ListFormat node_2=node_RPTIDCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"RPTID","0");
                        int nVIDCOUNT = 10; //varibale count, if need, change! 
                        ListFormat node_VIDCOUNT=node_2.add(ListFormat.TYPE,nVIDCOUNT,"VIDCOUNT","") as ListFormat; 
                        for(int n3=0; n3< nVIDCOUNT; n3++) 
                        { 
                            node_VIDCOUNT.add(Uint2Format.TYPE,1,"VID","0");
                        } 
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F34()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 34;

            trx.add(BinaryFormat.TYPE,1,"DRACK","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS2F35()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 35;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                int nCEIDCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_CEIDCOUNT=node_0.add(ListFormat.TYPE,nCEIDCOUNT,"CEIDCOUNT","") as ListFormat; 
                for(int n1=0; n1< nCEIDCOUNT; n1++) 
                { 
                    ListFormat node_2=node_CEIDCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"CEID","0");
                        int nRPTIDCOUNT = 10; //varibale count, if need, change! 
                        ListFormat node_RPTIDCOUNT=node_2.add(ListFormat.TYPE,nRPTIDCOUNT,"RPTIDCOUNT","") as ListFormat; 
                        for(int n3=0; n3< nRPTIDCOUNT; n3++) 
                        { 
                            node_RPTIDCOUNT.add(Uint2Format.TYPE,1,"RPTID","0");
                        } 
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F36()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 36;

            trx.add(BinaryFormat.TYPE,1,"LRACK","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS2F37()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 37;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BooleanFormat.TYPE,1,"CEED","False");
                int nCEIDCOUNT = 40; //varibale count, if need, change! 
                ListFormat node_CEIDCOUNT=node_0.add(ListFormat.TYPE,nCEIDCOUNT,"CEIDCOUNT","") as ListFormat; 
                for(int n1=0; n1< nCEIDCOUNT; n1++) 
                { 
                    node_CEIDCOUNT.add(Uint2Format.TYPE,1,"CEID","0");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F38()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 38;

            trx.add(BinaryFormat.TYPE,1,"ERACK","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS2F39()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 39;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(Uint2Format.TYPE,1,"DATALENGTH","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F40()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 40;

            trx.add(BinaryFormat.TYPE,1,"ACKC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F41()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 41;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"RCMD","");
                int nCPCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_CPCOUNT=node_0.add(ListFormat.TYPE,nCPCOUNT,"CPCOUNT","") as ListFormat; 
                for(int n1=0; n1< nCPCOUNT; n1++) 
                { 
                    ListFormat node_2=node_CPCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"CPNAME","");
                        node_2.add(AsciiFormat.TYPE,-1,"CPVAL","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F42()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 42;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"HCACK","0");
                int nCPCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_CPCOUNT=node_0.add(ListFormat.TYPE,nCPCOUNT,"CPCOUNT","") as ListFormat; 
                for(int n1=0; n1< nCPCOUNT; n1++) 
                { 
                    ListFormat node_2=node_CPCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"CPNAME","");
                        node_2.add(BinaryFormat.TYPE,1,"CPACK","0");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F43()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 43;

            int nSTRIDCOUNT = 10; //varibale count, if need, change! 
            ListFormat node_STRIDCOUNT=trx.add(ListFormat.TYPE,nSTRIDCOUNT,"STRIDCOUNT","") as ListFormat; 
            for(int n0=0; n0< nSTRIDCOUNT; n0++) 
            { 
                ListFormat node_1=node_STRIDCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(BinaryFormat.TYPE,1,"STRID","0");
                    int nFCNIDCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_FCNIDCOUNT=node_1.add(ListFormat.TYPE,nFCNIDCOUNT,"FCNIDCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nFCNIDCOUNT; n2++) 
                    { 
                        node_FCNIDCOUNT.add(BinaryFormat.TYPE,1,"FCNID","0");
                    } 
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F44()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 44;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"RSACK","0");
                int nSTRIDCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_STRIDCOUNT=node_0.add(ListFormat.TYPE,nSTRIDCOUNT,"STRIDCOUNT","") as ListFormat; 
                for(int n1=0; n1< nSTRIDCOUNT; n1++) 
                { 
                    ListFormat node_2=node_STRIDCOUNT.add(ListFormat.TYPE,3,"","")  as ListFormat;
                        node_2.add(BinaryFormat.TYPE,1,"STRID","0");
                        node_2.add(BinaryFormat.TYPE,1,"STRACK","0");
                        int nFCNIDCOUNT = 10; //varibale count, if need, change! 
                        ListFormat node_FCNIDCOUNT=node_2.add(ListFormat.TYPE,nFCNIDCOUNT,"FCNIDCOUNT","") as ListFormat; 
                        for(int n3=0; n3< nFCNIDCOUNT; n3++) 
                        { 
                            node_FCNIDCOUNT.add(BinaryFormat.TYPE,1,"FCNID","0");
                        } 
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F45()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 45;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                int nVARCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_VARCOUNT=node_0.add(ListFormat.TYPE,nVARCOUNT,"VARCOUNT","") as ListFormat; 
                for(int n1=0; n1< nVARCOUNT; n1++) 
                { 
                    ListFormat node_2=node_VARCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"VID","0");
                        int nLIMITCOUNT = 10; //varibale count, if need, change! 
                        ListFormat node_LIMITCOUNT=node_2.add(ListFormat.TYPE,nLIMITCOUNT,"LIMITCOUNT","") as ListFormat; 
                        for(int n3=0; n3< nLIMITCOUNT; n3++) 
                        { 
                            ListFormat node_4=node_LIMITCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                                node_4.add(BinaryFormat.TYPE,1,"LIMITID","0");
                                ListFormat node_Limits=node_4.add(ListFormat.TYPE,2,"","Limits")  as ListFormat;
                                    node_Limits.add(AsciiFormat.TYPE,-1,"UPPERDB","");
                                    node_Limits.add(AsciiFormat.TYPE,-1,"LOWERDB","");
                        } 
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F46()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 46;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"ACKC","0");
                int nVARCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_VARCOUNT=node_0.add(ListFormat.TYPE,nVARCOUNT,"VARCOUNT","") as ListFormat; 
                for(int n1=0; n1< nVARCOUNT; n1++) 
                { 
                    ListFormat node_2=node_VARCOUNT.add(ListFormat.TYPE,3,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"VID","0");
                        node_2.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        ListFormat node_Limits=node_2.add(ListFormat.TYPE,2,"","Limits")  as ListFormat;
                            node_Limits.add(BinaryFormat.TYPE,1,"LIMITID","0");
                            node_Limits.add(BinaryFormat.TYPE,1,"LIMITERROR","0");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F47()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 47;

            int nVARCOUNT = 10; //varibale count, if need, change! 
            ListFormat node_VARCOUNT=trx.add(ListFormat.TYPE,nVARCOUNT,"VARCOUNT","") as ListFormat; 
            for(int n0=0; n0< nVARCOUNT; n0++) 
            { 
                node_VARCOUNT.add(Uint2Format.TYPE,1,"VID","0");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F48()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 48;

            int nVARCOUNT = 10; //varibale count, if need, change! 
            ListFormat node_VARCOUNT=trx.add(ListFormat.TYPE,nVARCOUNT,"VARCOUNT","") as ListFormat; 
            for(int n0=0; n0< nVARCOUNT; n0++) 
            { 
                ListFormat node_1=node_VARCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint2Format.TYPE,1,"VID","0");
                    ListFormat node_2=node_1.add(ListFormat.TYPE,4,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"UNITS","");
                        node_2.add(AsciiFormat.TYPE,-1,"LIMITMIN","");
                        node_2.add(AsciiFormat.TYPE,-1,"LIMITMAX","");
                        int nLIMITCOUNT = 10; //varibale count, if need, change! 
                        ListFormat node_LIMITCOUNT=node_2.add(ListFormat.TYPE,nLIMITCOUNT,"LIMITCOUNT","") as ListFormat; 
                        for(int n3=0; n3< nLIMITCOUNT; n3++) 
                        { 
                            ListFormat node_4=node_LIMITCOUNT.add(ListFormat.TYPE,3,"","")  as ListFormat;
                                node_4.add(BinaryFormat.TYPE,1,"LIMITID","0");
                                node_4.add(AsciiFormat.TYPE,-1,"UPPERDB","");
                                node_4.add(AsciiFormat.TYPE,-1,"LOWERDB","");
                        } 
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F49()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 49;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(Uint2Format.TYPE,1,"RPTID","0");
                node_0.add(AsciiFormat.TYPE,-1,"DATASRC","");
                int nVARCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_VARCOUNT=node_0.add(ListFormat.TYPE,nVARCOUNT,"VARCOUNT","") as ListFormat; 
                for(int n1=0; n1< nVARCOUNT; n1++) 
                { 
                    node_VARCOUNT.add(Uint2Format.TYPE,1,"VID","0");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F50()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 50;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"RPTID","0");
                node_0.add(Uint2Format.TYPE,1,"ERRCODE","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F51()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 51;

            int nREPORTCOUNT = 10; //varibale count, if need, change! 
            ListFormat node_REPORTCOUNT=trx.add(ListFormat.TYPE,nREPORTCOUNT,"REPORTCOUNT","") as ListFormat; 
            for(int n0=0; n0< nREPORTCOUNT; n0++) 
            { 
                node_REPORTCOUNT.add(Uint2Format.TYPE,1,"RPTID","0");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F52()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 52;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"ACKC","0");
                int nREPORTCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_REPORTCOUNT=node_0.add(ListFormat.TYPE,nREPORTCOUNT,"REPORTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nREPORTCOUNT; n1++) 
                { 
                    ListFormat node_2=node_REPORTCOUNT.add(ListFormat.TYPE,3,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"RPTID","0");
                        node_2.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_2.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS2F53()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 53;

            ListFormat node_0=trx.add(ListFormat.TYPE,6,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(Uint2Format.TYPE,1,"TRID","0");
                node_0.add(BooleanFormat.TYPE,1,"CEED","False");
                int nREPORTCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_REPORTCOUNT=node_0.add(ListFormat.TYPE,nREPORTCOUNT,"REPORTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nREPORTCOUNT; n1++) 
                { 
                    node_REPORTCOUNT.add(Uint2Format.TYPE,1,"RPTID","0");
                } 
                node_0.add(Float4Format.TYPE,1,"TRSPER","0");
                ListFormat node_TRACECOUNT=node_0.add(ListFormat.TYPE,8,"","TRACECOUNT")  as ListFormat;
                    node_TRACECOUNT.add(Uint2Format.TYPE,1,"TOTSMP","0");
                    node_TRACECOUNT.add(Uint2Format.TYPE,1,"REPGSZ","0");
                    node_TRACECOUNT.add(AsciiFormat.TYPE,-1,"STARTEVNTSRC","");
                    node_TRACECOUNT.add(Uint2Format.TYPE,1,"STARTCEID","0");
                    node_TRACECOUNT.add(AsciiFormat.TYPE,-1,"STOPEVNTSRC","");
                    node_TRACECOUNT.add(Uint2Format.TYPE,1,"STOPCEID","0");
                    node_TRACECOUNT.add(BooleanFormat.TYPE,1,"TRAUTOD","False");
                    node_TRACECOUNT.add(BooleanFormat.TYPE,1,"RPTOC","False");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F54()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 54;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"TRID","0");
                node_0.add(Uint2Format.TYPE,1,"ERRCODE","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F55()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 55;

            int nTRACECOUNT = 10; //varibale count, if need, change! 
            ListFormat node_TRACECOUNT=trx.add(ListFormat.TYPE,nTRACECOUNT,"TRACECOUNT","") as ListFormat; 
            for(int n0=0; n0< nTRACECOUNT; n0++) 
            { 
                node_TRACECOUNT.add(Uint2Format.TYPE,1,"TRID","0");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F56()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 56;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BooleanFormat.TYPE,1,"ACKC","False");
                int nTRACECOUNT = 10; //varibale count, if need, change! 
                ListFormat node_TRACECOUNT=node_0.add(ListFormat.TYPE,nTRACECOUNT,"TRACECOUNT","") as ListFormat; 
                for(int n1=0; n1< nTRACECOUNT; n1++) 
                { 
                    ListFormat node_2=node_TRACECOUNT.add(ListFormat.TYPE,3,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"TRID","0");
                        node_2.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_2.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F57()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 57;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(AsciiFormat.TYPE,-1,"EVNTSRC","");
                node_0.add(Uint2Format.TYPE,1,"CEID","0");
                int nREPORTCOUNT = 16; //varibale count, if need, change! 
                ListFormat node_REPORTCOUNT=node_0.add(ListFormat.TYPE,nREPORTCOUNT,"REPORTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nREPORTCOUNT; n1++) 
                { 
                    node_REPORTCOUNT.add(Uint2Format.TYPE,1,"RPTID","0");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F58()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 58;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"EVNTSRC","");
                node_0.add(Uint2Format.TYPE,1,"CEID","0");
                node_0.add(Uint2Format.TYPE,1,"ERRCODE","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F59()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 59;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"EVNTSRC","");
                node_0.add(Uint2Format.TYPE,1,"CEID","0");
                node_0.add(Uint2Format.TYPE,1,"RPTID","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F60()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 60;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"EVNTSRC","");
                node_0.add(Uint2Format.TYPE,1,"CEID","0");
                node_0.add(Uint2Format.TYPE,1,"RPTID","0");
                node_0.add(Uint2Format.TYPE,1,"ERRCODE","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F61()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 61;

            int nTRACECOUNT = 16; //varibale count, if need, change! 
            ListFormat node_TRACECOUNT=trx.add(ListFormat.TYPE,nTRACECOUNT,"TRACECOUNT","") as ListFormat; 
            for(int n0=0; n0< nTRACECOUNT; n0++) 
            { 
                node_TRACECOUNT.add(Uint2Format.TYPE,1,"TRID","0");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F62()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 62;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BooleanFormat.TYPE,1,"ACKC","False");
                int nTRACECOUNT = 16; //varibale count, if need, change! 
                ListFormat node_TRACECOUNT=node_0.add(ListFormat.TYPE,nTRACECOUNT,"TRACECOUNT","") as ListFormat; 
                for(int n1=0; n1< nTRACECOUNT; n1++) 
                { 
                    ListFormat node_2=node_TRACECOUNT.add(ListFormat.TYPE,3,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"TRID","0");
                        node_2.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_2.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F63()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, true);
            trx.Function = 63;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(AsciiFormat.TYPE,-1,"OBJSPEC","");
                node_0.add(AsciiFormat.TYPE,-1,"RCMD","");
                int nPARMCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_PARMCOUNT=node_0.add(ListFormat.TYPE,nPARMCOUNT,"PARMCOUNT","") as ListFormat; 
                for(int n1=0; n1< nPARMCOUNT; n1++) 
                { 
                    ListFormat node_2=node_PARMCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"CPNAME","0");
                        node_2.add(Uint2Format.TYPE,1,"CPVAL","0");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS2F64()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(2, false);
            trx.Function = 64;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BooleanFormat.TYPE,1,"HCACK","False");
                int nPARMCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_PARMCOUNT=node_0.add(ListFormat.TYPE,nPARMCOUNT,"PARMCOUNT","") as ListFormat; 
                for(int n1=0; n1< nPARMCOUNT; n1++) 
                { 
                    ListFormat node_2=node_PARMCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"CPNAME","0");
                        node_2.add(Uint2Format.TYPE,1,"CEPACK","0");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS3F1()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(3, true);
            trx.Function = 1;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS3F2()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(3, false);
            trx.Function = 2;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"MF","0");
                int nMTCOUNT = 5; //varibale count, if need, change! 
                ListFormat node_MTCOUNT=node_0.add(ListFormat.TYPE,nMTCOUNT,"MTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nMTCOUNT; n1++) 
                { 
                    ListFormat node_2=node_MTCOUNT.add(ListFormat.TYPE,3,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"LOC","");
                        node_2.add(Uint2Format.TYPE,1,"QUA","0");
                        node_2.add(AsciiFormat.TYPE,-1,"MTID","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS3F3()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(3, true);
            trx.Function = 3;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS3F4()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(3, false);
            trx.Function = 4;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"CCODE","0");
                int nMTCOUNT = 5; //varibale count, if need, change! 
                ListFormat node_MTCOUNT=node_0.add(ListFormat.TYPE,nMTCOUNT,"MTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nMTCOUNT; n1++) 
                { 
                    ListFormat node_2=node_MTCOUNT.add(ListFormat.TYPE,3,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"TTC","0");
                        node_2.add(Uint2Format.TYPE,1,"QUA","0");
                        node_2.add(AsciiFormat.TYPE,-1,"MTID","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS3F5()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(3, true);
            trx.Function = 5;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"CCODE","0");
                node_0.add(Uint2Format.TYPE,1,"QUA","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS3F6()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(3, false);
            trx.Function = 6;

            trx.add(BinaryFormat.TYPE,1,"ACKC3","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS3F7()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(3, true);
            trx.Function = 7;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS3F8()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(3, false);
            trx.Function = 8;

            trx.add(BinaryFormat.TYPE,1,"ACKC3","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS3F9()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(3, true);
            trx.Function = 9;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");
                node_0.add(AsciiFormat.TYPE,-1,"EMID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS3F10()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(3, false);
            trx.Function = 10;

            trx.add(BinaryFormat.TYPE,1,"ACKC3","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS3F11()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(3, true);
            trx.Function = 11;

            trx.add(BinaryFormat.TYPE,1,"PTN","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS3F12()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(3, false);
            trx.Function = 12;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"PTN","0");
                node_0.add(BinaryFormat.TYPE,1,"MIDRA","0");
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS3F13()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(3, true);
            trx.Function = 13;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"PTN","0");
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS3F14()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(3, false);
            trx.Function = 14;

            trx.add(BinaryFormat.TYPE,1,"MIDAC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS4F1()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, true);
            trx.Function = 1;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"PTN","0");
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F2()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, false);
            trx.Function = 2;

            trx.add(BinaryFormat.TYPE,1,"RSACK","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F3()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, false);
            trx.Function = 3;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"PTN","0");
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F5()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, false);
            trx.Function = 5;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"PTN","0");
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F7()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, false);
            trx.Function = 7;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"PTN","0");
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F9()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, false);
            trx.Function = 9;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"PTN","0");
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F11()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, false);
            trx.Function = 11;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"PTN","0");
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F13()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, false);
            trx.Function = 13;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"PTN","0");
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F15()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, false);
            trx.Function = 15;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"PTN","0");
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS4F17()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, true);
            trx.Function = 17;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"PTN","0");
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F18()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, false);
            trx.Function = 18;

            trx.add(BinaryFormat.TYPE,1,"ACKC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F19()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, true);
            trx.Function = 19;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(AsciiFormat.TYPE,-1,"TRJOBNAME","");
                    int nTRANSFERCOUNT = 5; //varibale count, if need, change! 
                    ListFormat node_TRANSFERCOUNT=node_1.add(ListFormat.TYPE,nTRANSFERCOUNT,"TRANSFERCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nTRANSFERCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_TRANSFERCOUNT.add(ListFormat.TYPE,12,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"TRLINK","0");
                            node_3.add(Uint2Format.TYPE,1,"TRPORT","0");
                            node_3.add(AsciiFormat.TYPE,-1,"TROBJNAME","");
                            node_3.add(Uint2Format.TYPE,1,"TROBJTYPE","0");
                            node_3.add(Uint1Format.TYPE,1,"TRROLE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"TRRCP","");
                            node_3.add(AsciiFormat.TYPE,-1,"TRPTNR","");
                            node_3.add(Uint2Format.TYPE,1,"TRPTPORT","0");
                            node_3.add(Uint1Format.TYPE,1,"TRDIR","0");
                            node_3.add(Uint1Format.TYPE,1,"TRTYPE","0");
                            node_3.add(Uint2Format.TYPE,-1,"TRLOCATION","");
                            node_3.add(BooleanFormat.TYPE,1,"TRAUTOSTART","False");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F20()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, false);
            trx.Function = 20;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"TRJOBID","0");
                int nTRANSFERCOUNT = 5; //varibale count, if need, change! 
                ListFormat node_TRANSFERCOUNT=node_0.add(ListFormat.TYPE,nTRANSFERCOUNT,"TRANSFERCOUNT","") as ListFormat; 
                for(int n1=0; n1< nTRANSFERCOUNT; n1++) 
                { 
                    node_TRANSFERCOUNT.add(Uint2Format.TYPE,1,"TRLINK","0");
                } 
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint2Format.TYPE,1,"ACKC","0");
                    int nERRORCOUNT = 5; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F21()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, true);
            trx.Function = 21;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"TRJOBID","0");
                node_0.add(AsciiFormat.TYPE,-1,"TRCMDNAME","");
                int nPARMCOUNT = 5; //varibale count, if need, change! 
                ListFormat node_PARMCOUNT=node_0.add(ListFormat.TYPE,nPARMCOUNT,"PARMCOUNT","") as ListFormat; 
                for(int n1=0; n1< nPARMCOUNT; n1++) 
                { 
                    ListFormat node_2=node_PARMCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"CPNAME","");
                        node_2.add(AsciiFormat.TYPE,-1,"CPVAL","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F22()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, false);
            trx.Function = 22;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"ACKC","0");
                int nERRORCOUNT = 5; //varibale count, if need, change! 
                ListFormat node_ERRORCOUNT=node_0.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                for(int n1=0; n1< nERRORCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_2.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS4F23()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, true);
            trx.Function = 23;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"TRJOBID","0");
                node_0.add(AsciiFormat.TYPE,-1,"TRJOBNAME","");
                node_0.add(BinaryFormat.TYPE,1,"TRJOBMS","0");
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint2Format.TYPE,1,"ACKC","0");
                    int nERRORCOUNT = 5; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F24()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, false);
            trx.Function = 24;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS4F25()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, true);
            trx.Function = 25;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(Uint2Format.TYPE,1,"DATALENGTH","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F26()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, false);
            trx.Function = 26;

            trx.add(BinaryFormat.TYPE,1,"ACKC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F27()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, false);
            trx.Function = 27;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"EQNAME","");
                ListFormat node_1=node_0.add(ListFormat.TYPE,11,"","")  as ListFormat;
                    node_1.add(Uint2Format.TYPE,1,"TRLINK","0");
                    node_1.add(Uint2Format.TYPE,1,"TRPORT","0");
                    node_1.add(AsciiFormat.TYPE,-1,"TROBJNAME","");
                    node_1.add(Uint2Format.TYPE,1,"TROBJTYPE","0");
                    node_1.add(Uint1Format.TYPE,1,"TRROLE","0");
                    node_1.add(AsciiFormat.TYPE,-1,"TRRCP","");
                    node_1.add(AsciiFormat.TYPE,-1,"TRPTNR","");
                    node_1.add(Uint2Format.TYPE,1,"TRPTPORT","0");
                    node_1.add(Uint1Format.TYPE,1,"TRDIR","0");
                    node_1.add(Uint1Format.TYPE,1,"TRTYPE","0");
                    node_1.add(Uint2Format.TYPE,-1,"TRLOCATION","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F29()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, false);
            trx.Function = 29;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"TRLINK","0");
                node_0.add(Uint2Format.TYPE,1,"MCINDEX","0");
                node_0.add(AsciiFormat.TYPE,-1,"CNAME","");
                int nPARMCOUNT = 5; //varibale count, if need, change! 
                ListFormat node_PARMCOUNT=node_0.add(ListFormat.TYPE,nPARMCOUNT,"PARMCOUNT","") as ListFormat; 
                for(int n1=0; n1< nPARMCOUNT; n1++) 
                { 
                    ListFormat node_2=node_PARMCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"CPNAME","");
                        node_2.add(AsciiFormat.TYPE,-1,"CPVAL","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F31()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, false);
            trx.Function = 31;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"TRLINK","0");
                node_0.add(Uint2Format.TYPE,1,"MCINDEX","0");
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint2Format.TYPE,1,"ACKC","0");
                    int nERRORCOUNT = 5; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F33()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, false);
            trx.Function = 33;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"TRLINK","0");
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint2Format.TYPE,1,"ACKC","0");
                    int nERRORCOUNT = 5; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F35()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, false);
            trx.Function = 35;

            trx.add(Uint2Format.TYPE,1,"TRLINK","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F37()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, false);
            trx.Function = 37;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"TRLINK","0");
                node_0.add(Uint2Format.TYPE,1,"ACKC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F39()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, false);
            trx.Function = 39;

            trx.add(Uint2Format.TYPE,1,"TRLINK","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS4F41()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(4, false);
            trx.Function = 41;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"TRLINK","0");
                node_0.add(Uint2Format.TYPE,1,"HOHALTACK","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS5F1()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(5, true);
            trx.Function = 1;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"ALCD","0");
                node_0.add(BinaryFormat.TYPE,1,"ALID","0");
                node_0.add(AsciiFormat.TYPE,-1,"ALTX","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS5F2()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(5, false);
            trx.Function = 2;

            trx.add(BinaryFormat.TYPE,1,"ACKC5","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS5F3()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(5, true);
            trx.Function = 3;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"ALED","0");
                node_0.add(BinaryFormat.TYPE,1,"ALID","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS5F4()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(5, false);
            trx.Function = 4;

            trx.add(BinaryFormat.TYPE,1,"ACKC5","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS5F5()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(5, true);
            trx.Function = 5;

            int nALIDCOUNT = 5; //varibale count, if need, change! 
            ListFormat node_ALIDCOUNT=trx.add(ListFormat.TYPE,nALIDCOUNT,"ALIDCOUNT","") as ListFormat; 
            for(int n0=0; n0< nALIDCOUNT; n0++) 
            { 
                node_ALIDCOUNT.add(BinaryFormat.TYPE,1,"ALID","0");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS5F6()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(5, false);
            trx.Function = 6;

            int nALIDCOUNT = 20; //varibale count, if need, change! 
            ListFormat node_ALIDCOUNT=trx.add(ListFormat.TYPE,nALIDCOUNT,"ALIDCOUNT","") as ListFormat; 
            for(int n0=0; n0< nALIDCOUNT; n0++) 
            { 
                ListFormat node_1=node_ALIDCOUNT.add(ListFormat.TYPE,3,"","")  as ListFormat;
                    node_1.add(BinaryFormat.TYPE,1,"ALCD","0");
                    node_1.add(BinaryFormat.TYPE,1,"ALID","0");
                    node_1.add(AsciiFormat.TYPE,-1,"ALTX","");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS5F7()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(5, true);
            trx.Function = 7;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS5F8()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(5, false);
            trx.Function = 8;

            int nALIDCOUNT = 20; //varibale count, if need, change! 
            ListFormat node_ALIDCOUNT=trx.add(ListFormat.TYPE,nALIDCOUNT,"ALIDCOUNT","") as ListFormat; 
            for(int n0=0; n0< nALIDCOUNT; n0++) 
            { 
                ListFormat node_1=node_ALIDCOUNT.add(ListFormat.TYPE,3,"","")  as ListFormat;
                    node_1.add(BinaryFormat.TYPE,1,"ALCD","0");
                    node_1.add(BinaryFormat.TYPE,1,"ALID","0");
                    node_1.add(AsciiFormat.TYPE,-1,"ALTX","");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS5F9()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(5, true);
            trx.Function = 9;

            ListFormat node_0=trx.add(ListFormat.TYPE,5,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"TIMESTAMP","");
                node_0.add(AsciiFormat.TYPE,-1,"EXID","");
                node_0.add(AsciiFormat.TYPE,-1,"EXTYPE","");
                node_0.add(AsciiFormat.TYPE,-1,"EXMESSAGE","");
                int nEXCOUNT = 20; //varibale count, if need, change! 
                ListFormat node_EXCOUNT=node_0.add(ListFormat.TYPE,nEXCOUNT,"EXCOUNT","") as ListFormat; 
                for(int n1=0; n1< nEXCOUNT; n1++) 
                { 
                    node_EXCOUNT.add(AsciiFormat.TYPE,-1,"EXRECVRA","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS5F10()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(5, false);
            trx.Function = 10;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS5F11()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(5, true);
            trx.Function = 11;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"TIMESTAMP","");
                node_0.add(AsciiFormat.TYPE,-1,"EXID","");
                node_0.add(AsciiFormat.TYPE,-1,"EXTYPE","");
                node_0.add(AsciiFormat.TYPE,-1,"EXMESSAGE","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS5F12()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(5, false);
            trx.Function = 12;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS5F13()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(5, true);
            trx.Function = 13;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"EXID","");
                node_0.add(AsciiFormat.TYPE,-1,"EXRECVRA","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS5F14()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(5, false);
            trx.Function = 14;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"EXID","");
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(BooleanFormat.TYPE,1,"ACKA","False");
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,2,"","ERRORCOUNT")  as ListFormat;
                        node_ERRORCOUNT.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_ERRORCOUNT.add(AsciiFormat.TYPE,-1,"ERRTEXT","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS5F15()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(5, true);
            trx.Function = 15;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"TIMESTAMP","");
                node_0.add(AsciiFormat.TYPE,-1,"EXID","");
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(BooleanFormat.TYPE,1,"ACKA","False");
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,2,"","ERRORCOUNT")  as ListFormat;
                        node_ERRORCOUNT.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_ERRORCOUNT.add(AsciiFormat.TYPE,-1,"ERRTEXT","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS5F16()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(5, false);
            trx.Function = 16;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS5F17()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(5, true);
            trx.Function = 17;

            trx.add(AsciiFormat.TYPE,-1,"EXID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS5F18()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(5, false);
            trx.Function = 18;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"EXID","");
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(BooleanFormat.TYPE,1,"ACKA","False");
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,2,"","ERRORCOUNT")  as ListFormat;
                        node_ERRORCOUNT.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_ERRORCOUNT.add(AsciiFormat.TYPE,-1,"ERRTEXT","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS6F1()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, true);
            trx.Function = 1;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"TRID","0");
                node_0.add(Uint2Format.TYPE,1,"SMPLN","0");
                node_0.add(AsciiFormat.TYPE,12,"STIME","");
                int nSVCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_SVCOUNT=node_0.add(ListFormat.TYPE,nSVCOUNT,"SVCOUNT","") as ListFormat; 
                for(int n1=0; n1< nSVCOUNT; n1++) 
                { 
                    node_SVCOUNT.add(AsciiFormat.TYPE,-1,"SV","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS6F2()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, false);
            trx.Function = 2;

            trx.add(BinaryFormat.TYPE,1,"ACKC6","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS6F3()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, true);
            trx.Function = 3;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(Uint2Format.TYPE,1,"CEID","0");
                int nDSIDCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_DSIDCOUNT=node_0.add(ListFormat.TYPE,nDSIDCOUNT,"DSIDCOUNT","") as ListFormat; 
                for(int n1=0; n1< nDSIDCOUNT; n1++) 
                { 
                    ListFormat node_2=node_DSIDCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"DSID","0");
                        int nDVCOUNT = 5; //varibale count, if need, change! 
                        ListFormat node_DVCOUNT=node_2.add(ListFormat.TYPE,nDVCOUNT,"DVCOUNT","") as ListFormat; 
                        for(int n3=0; n3< nDVCOUNT; n3++) 
                        { 
                            ListFormat node_4=node_DVCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                                node_4.add(AsciiFormat.TYPE,-1,"DVNAME","");
                                node_4.add(AsciiFormat.TYPE,-1,"DVVALUE","");
                        } 
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS6F4()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, false);
            trx.Function = 4;

            trx.add(BinaryFormat.TYPE,1,"ACKC6","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS6F5()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, true);
            trx.Function = 5;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(Uint2Format.TYPE,1,"LENGTH","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS6F6()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, false);
            trx.Function = 6;

            trx.add(BinaryFormat.TYPE,1,"GRANT6","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS6F7()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, true);
            trx.Function = 7;

            trx.add(Uint2Format.TYPE,1,"DATAID","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS6F8()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, false);
            trx.Function = 8;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(Uint2Format.TYPE,1,"CEID","0");
                int nDSIDCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_DSIDCOUNT=node_0.add(ListFormat.TYPE,nDSIDCOUNT,"DSIDCOUNT","") as ListFormat; 
                for(int n1=0; n1< nDSIDCOUNT; n1++) 
                { 
                    ListFormat node_2=node_DSIDCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"DSID","0");
                        int nDVCOUNT = 15; //varibale count, if need, change! 
                        ListFormat node_DVCOUNT=node_2.add(ListFormat.TYPE,nDVCOUNT,"DVCOUNT","") as ListFormat; 
                        for(int n3=0; n3< nDVCOUNT; n3++) 
                        { 
                            ListFormat node_4=node_DVCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                                node_4.add(AsciiFormat.TYPE,-1,"DVNAME","");
                                node_4.add(AsciiFormat.TYPE,-1,"DVVALUE","");
                        } 
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS6F9()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, true);
            trx.Function = 9;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"PFCD","0");
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(Uint2Format.TYPE,1,"CEID","0");
                int nDSIDCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_DSIDCOUNT=node_0.add(ListFormat.TYPE,nDSIDCOUNT,"DSIDCOUNT","") as ListFormat; 
                for(int n1=0; n1< nDSIDCOUNT; n1++) 
                { 
                    ListFormat node_2=node_DSIDCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"DSID","0");
                        int nDVCOUNT = 5; //varibale count, if need, change! 
                        ListFormat node_DVCOUNT=node_2.add(ListFormat.TYPE,nDVCOUNT,"DVCOUNT","") as ListFormat; 
                        for(int n3=0; n3< nDVCOUNT; n3++) 
                        { 
                            node_DVCOUNT.add(AsciiFormat.TYPE,-1,"DVVALUE","");
                        } 
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS6F10()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, false);
            trx.Function = 10;

            trx.add(BinaryFormat.TYPE,1,"ACKC6","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS6F11()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, true);
            trx.Function = 11;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(Uint2Format.TYPE,1,"CEID","0");
                int nRPTIDCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_RPTIDCOUNT=node_0.add(ListFormat.TYPE,nRPTIDCOUNT,"RPTIDCOUNT","") as ListFormat; 
                for(int n1=0; n1< nRPTIDCOUNT; n1++) 
                { 
                    ListFormat node_2=node_RPTIDCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"RPTID","0");
                        int nVCOUNT = 5; //varibale count, if need, change! 
                        ListFormat node_VCOUNT=node_2.add(ListFormat.TYPE,nVCOUNT,"VCOUNT","") as ListFormat; 
                        for(int n3=0; n3< nVCOUNT; n3++) 
                        { 
                            node_VCOUNT.add(AsciiFormat.TYPE,-1,"V","");
                        } 
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS6F12()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, false);
            trx.Function = 12;

            trx.add(BinaryFormat.TYPE,1,"ACKC6","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS6F13()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, true);
            trx.Function = 13;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(Uint2Format.TYPE,1,"CEID","0");
                int nREPORTCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_REPORTCOUNT=node_0.add(ListFormat.TYPE,nREPORTCOUNT,"REPORTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nREPORTCOUNT; n1++) 
                { 
                    ListFormat node_2=node_REPORTCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"RPTID","0");
                        int nVARCOUNT = 5; //varibale count, if need, change! 
                        ListFormat node_VARCOUNT=node_2.add(ListFormat.TYPE,nVARCOUNT,"VARCOUNT","") as ListFormat; 
                        for(int n3=0; n3< nVARCOUNT; n3++) 
                        { 
                            ListFormat node_4=node_VARCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                                node_4.add(Uint2Format.TYPE,1,"VID","0");
                                node_4.add(AsciiFormat.TYPE,-1,"V","");
                        } 
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS6F14()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, false);
            trx.Function = 14;

            trx.add(BinaryFormat.TYPE,1,"ACKC6","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS6F15()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, true);
            trx.Function = 15;

            trx.add(Uint2Format.TYPE,1,"CEID","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS6F16()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, false);
            trx.Function = 16;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(Uint2Format.TYPE,1,"CEID","0");
                int nRPTIDCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_RPTIDCOUNT=node_0.add(ListFormat.TYPE,nRPTIDCOUNT,"RPTIDCOUNT","") as ListFormat; 
                for(int n1=0; n1< nRPTIDCOUNT; n1++) 
                { 
                    ListFormat node_2=node_RPTIDCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"RPTID","0");
                        int nVCOUNT = 5; //varibale count, if need, change! 
                        ListFormat node_VCOUNT=node_2.add(ListFormat.TYPE,nVCOUNT,"VCOUNT","") as ListFormat; 
                        for(int n3=0; n3< nVCOUNT; n3++) 
                        { 
                            node_VCOUNT.add(AsciiFormat.TYPE,-1,"V","");
                        } 
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS6F17()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, true);
            trx.Function = 17;

            trx.add(Uint2Format.TYPE,1,"CEID","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS6F18()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, false);
            trx.Function = 18;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(Uint2Format.TYPE,1,"CEID","0");
                int nRPTIDCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_RPTIDCOUNT=node_0.add(ListFormat.TYPE,nRPTIDCOUNT,"RPTIDCOUNT","") as ListFormat; 
                for(int n1=0; n1< nRPTIDCOUNT; n1++) 
                { 
                    ListFormat node_2=node_RPTIDCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"RPTID","0");
                        int nVIDCOUNT = 5; //varibale count, if need, change! 
                        ListFormat node_VIDCOUNT=node_2.add(ListFormat.TYPE,nVIDCOUNT,"VIDCOUNT","") as ListFormat; 
                        for(int n3=0; n3< nVIDCOUNT; n3++) 
                        { 
                            ListFormat node_4=node_VIDCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                                node_4.add(Uint2Format.TYPE,1,"VID","0");
                                node_4.add(AsciiFormat.TYPE,-1,"V","");
                        } 
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS6F19()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, true);
            trx.Function = 19;

            trx.add(Uint2Format.TYPE,1,"RPTID","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS6F20()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, false);
            trx.Function = 20;

            int nVCOUNT = 5; //varibale count, if need, change! 
            ListFormat node_VCOUNT=trx.add(ListFormat.TYPE,nVCOUNT,"VCOUNT","") as ListFormat; 
            for(int n0=0; n0< nVCOUNT; n0++) 
            { 
                node_VCOUNT.add(AsciiFormat.TYPE,-1,"V","");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS6F21()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, true);
            trx.Function = 21;

            trx.add(Uint2Format.TYPE,1,"RPTID","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS6F22()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, false);
            trx.Function = 22;

            int nVIDCOUNT = 5; //varibale count, if need, change! 
            ListFormat node_VIDCOUNT=trx.add(ListFormat.TYPE,nVIDCOUNT,"VIDCOUNT","") as ListFormat; 
            for(int n0=0; n0< nVIDCOUNT; n0++) 
            { 
                ListFormat node_1=node_VIDCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint2Format.TYPE,1,"VID","0");
                    node_1.add(AsciiFormat.TYPE,-1,"V","");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS6F23()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, true);
            trx.Function = 23;

            trx.add(BinaryFormat.TYPE,1,"CCODE","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS6F24()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, false);
            trx.Function = 24;

            trx.add(BinaryFormat.TYPE,1,"ACKC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS6F25()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, true);
            trx.Function = 25;

            ListFormat node_0=trx.add(ListFormat.TYPE,7,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(Uint2Format.TYPE,1,"OPID","0");
                node_0.add(Uint4Format.TYPE,1,"LINKID","0");
                node_0.add(AsciiFormat.TYPE,-1,"RCPSPEC","");
                node_0.add(Uint2Format.TYPE,1,"RMCHGSTAT","0");
                int nVARCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_VARCOUNT=node_0.add(ListFormat.TYPE,nVARCOUNT,"VARCOUNT","") as ListFormat; 
                for(int n1=0; n1< nVARCOUNT; n1++) 
                { 
                    ListFormat node_2=node_VARCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"RCPATTRID","");
                        node_2.add(AsciiFormat.TYPE,-1,"RCPATTRDATA","");
                } 
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint1Format.TYPE,1,"RMACK","0");
                    int nERRORCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS6F26()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, false);
            trx.Function = 26;

            trx.add(BinaryFormat.TYPE,1,"ACKC6","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS6F27()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, true);
            trx.Function = 27;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(Uint2Format.TYPE,1,"TRID","0");
                ListFormat node_GROUPCOUNT=node_0.add(ListFormat.TYPE,1,"","GROUPCOUNT")  as ListFormat;
                    int nREPORTCOUNT = 16; //varibale count, if need, change! 
                    ListFormat node_REPORTCOUNT=node_GROUPCOUNT.add(ListFormat.TYPE,nREPORTCOUNT,"REPORTCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nREPORTCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_REPORTCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"RPTID","0");
                            int nVCOUNT = 5; //varibale count, if need, change! 
                            ListFormat node_VCOUNT=node_3.add(ListFormat.TYPE,nVCOUNT,"VCOUNT","") as ListFormat; 
                            for(int n4=0; n4< nVCOUNT; n4++) 
                            { 
                                node_VCOUNT.add(AsciiFormat.TYPE,-1,"V","");
                            } 
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS6F28()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, false);
            trx.Function = 28;

            trx.add(Uint2Format.TYPE,1,"TRID","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS6F29()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, true);
            trx.Function = 29;

            trx.add(Uint2Format.TYPE,1,"TRID","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS6F30()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(6, false);
            trx.Function = 30;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"TRID","0");
                int nREPORTCOUNT = 16; //varibale count, if need, change! 
                ListFormat node_REPORTCOUNT=node_0.add(ListFormat.TYPE,nREPORTCOUNT,"REPORTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nREPORTCOUNT; n1++) 
                { 
                    ListFormat node_2=node_REPORTCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"RPTID","0");
                        int nVCOUNT = 5; //varibale count, if need, change! 
                        ListFormat node_VCOUNT=node_2.add(ListFormat.TYPE,nVCOUNT,"VCOUNT","") as ListFormat; 
                        for(int n3=0; n3< nVCOUNT; n3++) 
                        { 
                            node_VCOUNT.add(AsciiFormat.TYPE,-1,"V","");
                        } 
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS7F1()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, true);
            trx.Function = 1;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"PPID","");
                node_0.add(Uint2Format.TYPE,1,"LENGTH","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS7F2()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, false);
            trx.Function = 2;

            trx.add(BinaryFormat.TYPE,1,"PPGNT","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS7F3()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, true);
            trx.Function = 3;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"PPID","");
                node_0.add(BinaryFormat.TYPE,-1,"PPBODY","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS7F4()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, false);
            trx.Function = 4;

            trx.add(BinaryFormat.TYPE,1,"ACKC7","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS7F5()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, true);
            trx.Function = 5;

            trx.add(AsciiFormat.TYPE,-1,"PPID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS7F6()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, false);
            trx.Function = 6;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"PPID","");
                node_0.add(BinaryFormat.TYPE,-1,"PPBODY","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS7F7()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, true);
            trx.Function = 7;

            trx.add(AsciiFormat.TYPE,-1,"MTID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS7F8()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, false);
            trx.Function = 8;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"PPID","");
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS7F9()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, true);
            trx.Function = 9;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS7F10()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, false);
            trx.Function = 10;

            int nPIDCOUNT = 5; //varibale count, if need, change! 
            ListFormat node_PIDCOUNT=trx.add(ListFormat.TYPE,nPIDCOUNT,"PIDCOUNT","") as ListFormat; 
            for(int n0=0; n0< nPIDCOUNT; n0++) 
            { 
                ListFormat node_1=node_PIDCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(AsciiFormat.TYPE,-1,"PPID","");
                    int nMTIDCOUNT = 25; //varibale count, if need, change! 
                    ListFormat node_MTIDCOUNT=node_1.add(ListFormat.TYPE,nMTIDCOUNT,"MTIDCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nMTIDCOUNT; n2++) 
                    { 
                        node_MTIDCOUNT.add(AsciiFormat.TYPE,-1,"MTID","");
                    } 
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS7F11()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, true);
            trx.Function = 11;

            int nPPIDCOUNT = 5; //varibale count, if need, change! 
            ListFormat node_PPIDCOUNT=trx.add(ListFormat.TYPE,nPPIDCOUNT,"PPIDCOUNT","") as ListFormat; 
            for(int n0=0; n0< nPPIDCOUNT; n0++) 
            { 
                ListFormat node_1=node_PPIDCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(AsciiFormat.TYPE,-1,"PPID","");
                    int nMTIDCOUNT = 25; //varibale count, if need, change! 
                    ListFormat node_MTIDCOUNT=node_1.add(ListFormat.TYPE,nMTIDCOUNT,"MTIDCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nMTIDCOUNT; n2++) 
                    { 
                        node_MTIDCOUNT.add(AsciiFormat.TYPE,-1,"MTID","");
                    } 
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS7F12()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, false);
            trx.Function = 12;

            trx.add(BinaryFormat.TYPE,1,"ACKC7","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS7F13()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, true);
            trx.Function = 13;

            int nPPIDCOUNT = 5; //varibale count, if need, change! 
            ListFormat node_PPIDCOUNT=trx.add(ListFormat.TYPE,nPPIDCOUNT,"PPIDCOUNT","") as ListFormat; 
            for(int n0=0; n0< nPPIDCOUNT; n0++) 
            { 
                ListFormat node_1=node_PPIDCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(AsciiFormat.TYPE,-1,"PPID","");
                    int nMTIDCOUNT = 25; //varibale count, if need, change! 
                    ListFormat node_MTIDCOUNT=node_1.add(ListFormat.TYPE,nMTIDCOUNT,"MTIDCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nMTIDCOUNT; n2++) 
                    { 
                        node_MTIDCOUNT.add(AsciiFormat.TYPE,-1,"MTID","");
                    } 
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS7F14()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, false);
            trx.Function = 14;

            trx.add(BinaryFormat.TYPE,1,"ACKC7","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS7F15()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, true);
            trx.Function = 15;

            trx.add(BinaryFormat.TYPE,1,"MMODE","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS7F16()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, false);
            trx.Function = 16;

            trx.add(BinaryFormat.TYPE,1,"ACKC7","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS7F17()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, true);
            trx.Function = 17;

            int nPPIDCOUNT = 5; //varibale count, if need, change! 
            ListFormat node_PPIDCOUNT=trx.add(ListFormat.TYPE,nPPIDCOUNT,"PPIDCOUNT","") as ListFormat; 
            for(int n0=0; n0< nPPIDCOUNT; n0++) 
            { 
                node_PPIDCOUNT.add(AsciiFormat.TYPE,-1,"PPID","");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS7F18()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, false);
            trx.Function = 18;

            trx.add(BinaryFormat.TYPE,1,"ACKC7","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS7F19()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, true);
            trx.Function = 19;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS7F20()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, false);
            trx.Function = 20;

            int nPPIDCOUNT = 5; //varibale count, if need, change! 
            ListFormat node_PPIDCOUNT=trx.add(ListFormat.TYPE,nPPIDCOUNT,"PPIDCOUNT","") as ListFormat; 
            for(int n0=0; n0< nPPIDCOUNT; n0++) 
            { 
                node_PPIDCOUNT.add(AsciiFormat.TYPE,-1,"PPID","");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS7F21()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, true);
            trx.Function = 21;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS7F22()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, false);
            trx.Function = 22;

            ListFormat node_0=trx.add(ListFormat.TYPE,5,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"MDLN","");
                node_0.add(AsciiFormat.TYPE,-1,"SOFTREV","");
                node_0.add(Uint2Format.TYPE,1,"CMDMAX","0");
                node_0.add(Uint2Format.TYPE,1,"BYTMAX","0");
                int nCOMMANDCOUNT = 5; //varibale count, if need, change! 
                ListFormat node_COMMANDCOUNT=node_0.add(ListFormat.TYPE,nCOMMANDCOUNT,"COMMANDCOUNT","") as ListFormat; 
                for(int n1=0; n1< nCOMMANDCOUNT; n1++) 
                { 
                    ListFormat node_2=node_COMMANDCOUNT.add(ListFormat.TYPE,11,"","")  as ListFormat;
                        node_2.add(BinaryFormat.TYPE,1,"CCODE","0");
                        node_2.add(AsciiFormat.TYPE,-1,"CNAME","");
                        node_2.add(BinaryFormat.TYPE,1,"RQCMD","0");
                        node_2.add(BinaryFormat.TYPE,1,"BLKDEF","0");
                        node_2.add(Uint2Format.TYPE,1,"BCDS","0");
                        node_2.add(Uint2Format.TYPE,1,"IBCDS","0");
                        node_2.add(Uint2Format.TYPE,1,"NBCDS","0");
                        node_2.add(Uint2Format.TYPE,1,"ACDS","0");
                        node_2.add(Uint2Format.TYPE,1,"IACDS","0");
                        node_2.add(Uint2Format.TYPE,1,"NACDS","0");
                        ListFormat node_3=node_2.add(ListFormat.TYPE,4,"","")  as ListFormat;
                            node_3.add(AsciiFormat.TYPE,-1,"PNAME","");
                            node_3.add(BinaryFormat.TYPE,1,"RQPAR","0");
                            node_3.add(AsciiFormat.TYPE,-1,"PDFLT","");
                            node_3.add(AsciiFormat.TYPE,-1,"PMAX","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS7F23()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, true);
            trx.Function = 23;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"PPID","");
                node_0.add(AsciiFormat.TYPE,-1,"MDLN","");
                node_0.add(AsciiFormat.TYPE,-1,"SOFTREV","");
                int nCOMMANDCOUNT = 5; //varibale count, if need, change! 
                ListFormat node_COMMANDCOUNT=node_0.add(ListFormat.TYPE,nCOMMANDCOUNT,"COMMANDCOUNT","") as ListFormat; 
                for(int n1=0; n1< nCOMMANDCOUNT; n1++) 
                { 
                    ListFormat node_2=node_COMMANDCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(BinaryFormat.TYPE,1,"CCODE","0");
                        int nPPARMCOUNT = 5; //varibale count, if need, change! 
                        ListFormat node_PPARMCOUNT=node_2.add(ListFormat.TYPE,nPPARMCOUNT,"PPARMCOUNT","") as ListFormat; 
                        for(int n3=0; n3< nPPARMCOUNT; n3++) 
                        { 
                            node_PPARMCOUNT.add(AsciiFormat.TYPE,-1,"PPARM","");
                        } 
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS7F24()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, false);
            trx.Function = 24;

            trx.add(BinaryFormat.TYPE,1,"ACKC7","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS7F25()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, true);
            trx.Function = 25;

            trx.add(AsciiFormat.TYPE,-1,"PPID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS7F26()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, false);
            trx.Function = 26;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"PPID","");
                node_0.add(AsciiFormat.TYPE,-1,"MDLN","");
                node_0.add(AsciiFormat.TYPE,-1,"SOFTREV","");
                int nCOMMANDCOUNT = 5; //varibale count, if need, change! 
                ListFormat node_COMMANDCOUNT=node_0.add(ListFormat.TYPE,nCOMMANDCOUNT,"COMMANDCOUNT","") as ListFormat; 
                for(int n1=0; n1< nCOMMANDCOUNT; n1++) 
                { 
                    ListFormat node_2=node_COMMANDCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(BinaryFormat.TYPE,1,"CCODE","0");
                        int nPPARMCOUNT = 5; //varibale count, if need, change! 
                        ListFormat node_PPARMCOUNT=node_2.add(ListFormat.TYPE,nPPARMCOUNT,"PPARMCOUNT","") as ListFormat; 
                        for(int n3=0; n3< nPPARMCOUNT; n3++) 
                        { 
                            node_PPARMCOUNT.add(AsciiFormat.TYPE,-1,"PPARM","");
                        } 
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS7F27()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, true);
            trx.Function = 27;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"PPID","");
                int nERRORCOUNT = 5; //varibale count, if need, change! 
                ListFormat node_ERRORCOUNT=node_0.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                for(int n1=0; n1< nERRORCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ERRORCOUNT.add(ListFormat.TYPE,3,"","")  as ListFormat;
                        node_2.add(BinaryFormat.TYPE,1,"ACKC7A","0");
                        node_2.add(Uint2Format.TYPE,1,"SEQNUM","0");
                        node_2.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS7F28()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, false);
            trx.Function = 28;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS7F29()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, true);
            trx.Function = 29;

            trx.add(Uint2Format.TYPE,1,"LENGTH","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS7F30()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, false);
            trx.Function = 30;

            trx.add(BinaryFormat.TYPE,1,"ACKC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS7F31()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, true);
            trx.Function = 31;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"PPID","");
                node_0.add(AsciiFormat.TYPE,-1,"MDLN","");
                node_0.add(AsciiFormat.TYPE,-1,"SOFTREV","");
                int nCCODECOUNT = 5; //varibale count, if need, change! 
                ListFormat node_CCODECOUNT=node_0.add(ListFormat.TYPE,nCCODECOUNT,"CCODECOUNT","") as ListFormat; 
                for(int n1=0; n1< nCCODECOUNT; n1++) 
                { 
                    ListFormat node_2=node_CCODECOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(BinaryFormat.TYPE,1,"CCODE","0");
                        int nPPARMCOUNT = 5; //varibale count, if need, change! 
                        ListFormat node_PPARMCOUNT=node_2.add(ListFormat.TYPE,nPPARMCOUNT,"PPARMCOUNT","") as ListFormat; 
                        for(int n3=0; n3< nPPARMCOUNT; n3++) 
                        { 
                            node_PPARMCOUNT.add(AsciiFormat.TYPE,-1,"PPARM","");
                        } 
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS7F32()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, false);
            trx.Function = 32;

            trx.add(BinaryFormat.TYPE,1,"ACKC7","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS7F33()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, true);
            trx.Function = 33;

            trx.add(AsciiFormat.TYPE,-1,"PPID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS7F34()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, false);
            trx.Function = 34;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"PPID","");
                node_0.add(Uint2Format.TYPE,1,"UNFLEN","0");
                node_0.add(Uint2Format.TYPE,1,"FRMLEN","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS7F35()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, true);
            trx.Function = 35;

            trx.add(AsciiFormat.TYPE,-1,"MTID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS7F36()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(7, false);
            trx.Function = 36;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");
                node_0.add(AsciiFormat.TYPE,-1,"PPID","");
                node_0.add(BinaryFormat.TYPE,-1,"PPBODY","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS8F1()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(8, true);
            trx.Function = 1;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS8F2()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(8, false);
            trx.Function = 2;

            trx.add(BinaryFormat.TYPE,-1,"BPD","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS8F3()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(8, true);
            trx.Function = 3;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS8F4()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(8, false);
            trx.Function = 4;

            trx.add(BinaryFormat.TYPE,-1,"EPD","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS9F1()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(9, false);
            trx.Function = 1;

            trx.add(BinaryFormat.TYPE,10,"MHEAD","0 0 0 0 0 0 0 0 0 0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS9F3()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(9, false);
            trx.Function = 3;

            trx.add(BinaryFormat.TYPE,10,"MHEAD","0 0 0 0 0 0 0 0 0 0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS9F5()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(9, false);
            trx.Function = 5;

            trx.add(BinaryFormat.TYPE,10,"MHEAD","0 0 0 0 0 0 0 0 0 0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS9F7()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(9, false);
            trx.Function = 7;

            trx.add(BinaryFormat.TYPE,10,"MHEAD","0 0 0 0 0 0 0 0 0 0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS9F9()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(9, false);
            trx.Function = 9;

            trx.add(BinaryFormat.TYPE,10,"SHEAD","0 0 0 0 0 0 0 0 0 0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS9F11()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(9, false);
            trx.Function = 11;

            trx.add(BinaryFormat.TYPE,10,"MHEAD","0 0 0 0 0 0 0 0 0 0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS9F13()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(9, false);
            trx.Function = 13;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"MEXP","");
                node_0.add(XFormat.TYPE,-1,"EDID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS10F1()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(10, true);
            trx.Function = 1;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"TID","0");
                node_0.add(AsciiFormat.TYPE,-1,"TEXT","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS10F2()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(10, false);
            trx.Function = 2;

            trx.add(BinaryFormat.TYPE,1,"ACKC10","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS10F3()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(10, true);
            trx.Function = 3;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"TID","0");
                node_0.add(AsciiFormat.TYPE,-1,"TEXT","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS10F4()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(10, false);
            trx.Function = 4;

            trx.add(BinaryFormat.TYPE,1,"ACKC10","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS10F5()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(10, true);
            trx.Function = 5;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"TID","0");
                int nTEXTCOUNT = 6; //varibale count, if need, change! 
                ListFormat node_TEXTCOUNT=node_0.add(ListFormat.TYPE,nTEXTCOUNT,"TEXTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nTEXTCOUNT; n1++) 
                { 
                    node_TEXTCOUNT.add(AsciiFormat.TYPE,-1,"TEXT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS10F6()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(10, false);
            trx.Function = 6;

            trx.add(BinaryFormat.TYPE,1,"ACKC10","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS10F7()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(10, false);
            trx.Function = 7;

            trx.add(BinaryFormat.TYPE,1,"TID","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS10F9()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(10, true);
            trx.Function = 9;

            trx.add(AsciiFormat.TYPE,-1,"TEXT","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS10F10()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(10, false);
            trx.Function = 10;

            trx.add(BinaryFormat.TYPE,1,"ACKC10","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS12F1()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(12, true);
            trx.Function = 1;

            ListFormat node_0=trx.add(ListFormat.TYPE,15,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");
                node_0.add(BinaryFormat.TYPE,1,"IDTYP","0");
                node_0.add(Uint2Format.TYPE,1,"FNLOC","0");
                node_0.add(Uint2Format.TYPE,1,"FFROT","0");
                node_0.add(BinaryFormat.TYPE,1,"ORLOC","0");
                node_0.add(BinaryFormat.TYPE,1,"RPSEL","0");
                int nPOINTCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_POINTCOUNT=node_0.add(ListFormat.TYPE,nPOINTCOUNT,"POINTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nPOINTCOUNT; n1++) 
                { 
                    node_POINTCOUNT.add(Int2Format.TYPE,1,"REFP","0");
                } 
                node_0.add(AsciiFormat.TYPE,-1,"DUTMS","");
                node_0.add(Uint2Format.TYPE,1,"XDIES","0");
                node_0.add(Uint2Format.TYPE,1,"YDIES","0");
                node_0.add(Uint2Format.TYPE,1,"ROWCT","0");
                node_0.add(Uint2Format.TYPE,1,"COLCT","0");
                node_0.add(BinaryFormat.TYPE,1,"NULBC","0");
                node_0.add(Uint2Format.TYPE,1,"PRDCT","0");
                node_0.add(BinaryFormat.TYPE,1,"PRAXI","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS12F2()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(12, false);
            trx.Function = 2;

            trx.add(BinaryFormat.TYPE,1,"ACKC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS12F3()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(12, true);
            trx.Function = 3;

            ListFormat node_0=trx.add(ListFormat.TYPE,9,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");
                node_0.add(BinaryFormat.TYPE,1,"IDTYP","0");
                node_0.add(BinaryFormat.TYPE,1,"MAPFT","0");
                node_0.add(Uint2Format.TYPE,1,"FNLOC","0");
                node_0.add(Uint2Format.TYPE,1,"FFROT","0");
                node_0.add(BinaryFormat.TYPE,1,"ORLOC","0");
                node_0.add(BinaryFormat.TYPE,1,"PRAXI","0");
                node_0.add(BinaryFormat.TYPE,1,"BCEQU","0");
                node_0.add(BinaryFormat.TYPE,1,"NULBC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS12F4()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(12, false);
            trx.Function = 4;

            ListFormat node_0=trx.add(ListFormat.TYPE,15,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");
                node_0.add(BinaryFormat.TYPE,1,"IDTYP","0");
                node_0.add(Uint2Format.TYPE,1,"FNLOC","0");
                node_0.add(BinaryFormat.TYPE,1,"ORLOC","0");
                node_0.add(BinaryFormat.TYPE,1,"RPSEL","0");
                int nPOINTCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_POINTCOUNT=node_0.add(ListFormat.TYPE,nPOINTCOUNT,"POINTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nPOINTCOUNT; n1++) 
                { 
                    node_POINTCOUNT.add(Int2Format.TYPE,1,"REFP","0");
                } 
                node_0.add(AsciiFormat.TYPE,-1,"DUTMS","");
                node_0.add(Uint2Format.TYPE,1,"XDIES","0");
                node_0.add(Uint2Format.TYPE,1,"YDIES","0");
                node_0.add(Uint2Format.TYPE,1,"ROWCT","0");
                node_0.add(Uint2Format.TYPE,1,"COLCT","0");
                node_0.add(Uint2Format.TYPE,1,"PRDCT","0");
                node_0.add(BinaryFormat.TYPE,1,"BCEQU","0");
                node_0.add(BinaryFormat.TYPE,1,"NULBC","0");
                node_0.add(Uint2Format.TYPE,1,"MLCL","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS12F5()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(12, true);
            trx.Function = 5;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");
                node_0.add(BinaryFormat.TYPE,1,"IDTYP","0");
                node_0.add(BinaryFormat.TYPE,1,"MAPFT","0");
                node_0.add(Uint2Format.TYPE,1,"MLCL","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS12F6()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(12, false);
            trx.Function = 6;

            trx.add(BinaryFormat.TYPE,1,"ACKC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS12F7()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(12, true);
            trx.Function = 7;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");
                node_0.add(BinaryFormat.TYPE,1,"IDTYP","0");
                int nMAPDATACOUNT = 5; //varibale count, if need, change! 
                ListFormat node_MAPDATACOUNT=node_0.add(ListFormat.TYPE,nMAPDATACOUNT,"MAPDATACOUNT","") as ListFormat; 
                for(int n1=0; n1< nMAPDATACOUNT; n1++) 
                { 
                    ListFormat node_2=node_MAPDATACOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Int2Format.TYPE,1,"RSINF","0");
                        node_2.add(BinaryFormat.TYPE,1,"BINLT","0");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS12F8()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(12, false);
            trx.Function = 8;

            trx.add(BinaryFormat.TYPE,1,"ACKC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS12F9()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(12, true);
            trx.Function = 9;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");
                node_0.add(BinaryFormat.TYPE,1,"IDTYP","0");
                node_0.add(Int2Format.TYPE,1,"STRP","0");
                node_0.add(BinaryFormat.TYPE,1,"BINLT","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS12F10()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(12, false);
            trx.Function = 10;

            trx.add(BinaryFormat.TYPE,1,"ACKC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS12F11()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(12, true);
            trx.Function = 11;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");
                node_0.add(BinaryFormat.TYPE,1,"IDTYP","0");
                int nMAPDATACOUNT = 5; //varibale count, if need, change! 
                ListFormat node_MAPDATACOUNT=node_0.add(ListFormat.TYPE,nMAPDATACOUNT,"MAPDATACOUNT","") as ListFormat; 
                for(int n1=0; n1< nMAPDATACOUNT; n1++) 
                { 
                    ListFormat node_2=node_MAPDATACOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Int2Format.TYPE,1,"RSINF","0");
                        node_2.add(BinaryFormat.TYPE,1,"BINLT","0");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS12F12()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(12, false);
            trx.Function = 12;

            trx.add(BinaryFormat.TYPE,1,"ACKC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS12F13()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(12, true);
            trx.Function = 13;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");
                node_0.add(BinaryFormat.TYPE,1,"IDTYP","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS12F14()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(12, false);
            trx.Function = 14;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");
                node_0.add(BinaryFormat.TYPE,1,"IDTYP","0");
                int nMAPDATACOUNT = 5; //varibale count, if need, change! 
                ListFormat node_MAPDATACOUNT=node_0.add(ListFormat.TYPE,nMAPDATACOUNT,"MAPDATACOUNT","") as ListFormat; 
                for(int n1=0; n1< nMAPDATACOUNT; n1++) 
                { 
                    ListFormat node_2=node_MAPDATACOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Int2Format.TYPE,1,"RSINF","0");
                        node_2.add(BinaryFormat.TYPE,1,"BINLT","0");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS12F15()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(12, true);
            trx.Function = 15;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");
                node_0.add(BinaryFormat.TYPE,1,"IDTYP","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS12F16()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(12, false);
            trx.Function = 16;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");
                node_0.add(BinaryFormat.TYPE,1,"IDTYP","0");
                node_0.add(Int2Format.TYPE,1,"STRP","0");
                node_0.add(BinaryFormat.TYPE,1,"BINLT","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS12F17()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(12, true);
            trx.Function = 17;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");
                node_0.add(BinaryFormat.TYPE,1,"IDTYP","0");
                node_0.add(Int2Format.TYPE,1,"STRP","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS12F18()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(12, false);
            trx.Function = 18;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"MTID","");
                node_0.add(BinaryFormat.TYPE,1,"IDTYP","0");
                int nMAPDATACOUNT = 5; //varibale count, if need, change! 
                ListFormat node_MAPDATACOUNT=node_0.add(ListFormat.TYPE,nMAPDATACOUNT,"MAPDATACOUNT","") as ListFormat; 
                for(int n1=0; n1< nMAPDATACOUNT; n1++) 
                { 
                    ListFormat node_2=node_MAPDATACOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Int2Format.TYPE,1,"RSINF","0");
                        node_2.add(BinaryFormat.TYPE,1,"BINLT","0");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS12F19()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(12, false);
            trx.Function = 19;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"MAPER","0");
                node_0.add(BinaryFormat.TYPE,1,"DATLC","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS13F1()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(13, true);
            trx.Function = 1;

            ListFormat node_0=trx.add(ListFormat.TYPE,1,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"DSNAME","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS13F2()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(13, false);
            trx.Function = 2;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"DSNAME","");
                node_0.add(BinaryFormat.TYPE,1,"ACKC13","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS13F3()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(13, true);
            trx.Function = 3;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(Int2Format.TYPE,1,"HANDLE","0");
                node_0.add(AsciiFormat.TYPE,-1,"DSNAME","");
                node_0.add(Uint4Format.TYPE,1,"CKPNT","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS13F4()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(13, false);
            trx.Function = 4;

            ListFormat node_0=trx.add(ListFormat.TYPE,5,"","")  as ListFormat;
                node_0.add(Int2Format.TYPE,1,"HANDLE","0");
                node_0.add(AsciiFormat.TYPE,-1,"DSNAME","");
                node_0.add(BinaryFormat.TYPE,1,"ACKC13","0");
                node_0.add(Int1Format.TYPE,1,"RTYPE","0");
                node_0.add(Int2Format.TYPE,1,"RECLEN","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS13F5()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(13, true);
            trx.Function = 5;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Int2Format.TYPE,1,"HANDLE","0");
                node_0.add(Int2Format.TYPE,1,"READLN","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS13F6()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(13, false);
            trx.Function = 6;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(Int2Format.TYPE,1,"HANDLE","0");
                node_0.add(BinaryFormat.TYPE,1,"ACKC13","0");
                node_0.add(Uint4Format.TYPE,1,"CKPNT","0");
                int nDATASETCOUNT = 5; //varibale count, if need, change! 
                ListFormat node_DATASETCOUNT=node_0.add(ListFormat.TYPE,nDATASETCOUNT,"DATASETCOUNT","") as ListFormat; 
                for(int n1=0; n1< nDATASETCOUNT; n1++) 
                { 
                    node_DATASETCOUNT.add(BinaryFormat.TYPE,-1,"FILDAT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS13F7()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(13, true);
            trx.Function = 7;

            trx.add(Int2Format.TYPE,1,"HANDLE","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS13F8()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(13, false);
            trx.Function = 8;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Int2Format.TYPE,1,"HANDLE","0");
                node_0.add(BinaryFormat.TYPE,1,"ACKC13","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS13F9()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(13, true);
            trx.Function = 9;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS13F10()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(13, false);
            trx.Function = 10;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS13F11()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(13, true);
            trx.Function = 11;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(AsciiFormat.TYPE,-1,"OBJECTSPEC","");
                node_0.add(Uint2Format.TYPE,1,"DATALENGTH","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS13F12()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(13, false);
            trx.Function = 12;

            trx.add(BooleanFormat.TYPE,1,"GRANT","False");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS13F13()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(13, true);
            trx.Function = 13;

            ListFormat node_0=trx.add(ListFormat.TYPE,8,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(AsciiFormat.TYPE,-1,"OBJECTSPEC","");
                node_0.add(AsciiFormat.TYPE,-1,"TBLTYP","");
                node_0.add(AsciiFormat.TYPE,-1,"TBLID","");
                node_0.add(Uint1Format.TYPE,1,"TBLCMD","0");
                int nATTRCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ATTRCOUNT=node_0.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                for(int n1=0; n1< nATTRCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRID","");
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRDATA","");
                } 
                int nCOLUMN = 20; //varibale count, if need, change! 
                ListFormat node_COLUMN=node_0.add(ListFormat.TYPE,nCOLUMN,"COLUMN","") as ListFormat; 
                for(int n1=0; n1< nCOLUMN; n1++) 
                { 
                    node_COLUMN.add(AsciiFormat.TYPE,-1,"COLHDR","");
                } 
                int nROW = 20; //varibale count, if need, change! 
                ListFormat node_ROW=node_0.add(ListFormat.TYPE,nROW,"ROW","") as ListFormat; 
                for(int n1=0; n1< nROW; n1++) 
                { 
                    int nTABLECOUNT = 20; //varibale count, if need, change! 
                    ListFormat node_TABLECOUNT=node_ROW.add(ListFormat.TYPE,nTABLECOUNT,"TABLECOUNT","") as ListFormat; 
                    for(int n2=0; n2< nTABLECOUNT; n2++) 
                    { 
                        node_TABLECOUNT.add(AsciiFormat.TYPE,-1,"TBLELT","");
                    } 
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS13F14()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(13, false);
            trx.Function = 14;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint1Format.TYPE,-1,"TBLACK","");
                int nERRORCOUNT = 20; //varibale count, if need, change! 
                ListFormat node_ERRORCOUNT=node_0.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                for(int n1=0; n1< nERRORCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_2.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS13F15()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(13, true);
            trx.Function = 15;

            ListFormat node_0=trx.add(ListFormat.TYPE,7,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(AsciiFormat.TYPE,-1,"OBJECTSPEC","");
                node_0.add(AsciiFormat.TYPE,-1,"TBLTYP","");
                node_0.add(AsciiFormat.TYPE,-1,"TBLID","");
                node_0.add(Uint1Format.TYPE,1,"TBLCMD","0");
                int nCOLUMN = 20; //varibale count, if need, change! 
                ListFormat node_COLUMN=node_0.add(ListFormat.TYPE,nCOLUMN,"COLUMN","") as ListFormat; 
                for(int n1=0; n1< nCOLUMN; n1++) 
                { 
                    node_COLUMN.add(AsciiFormat.TYPE,-1,"COLHDR","");
                } 
                int nROW = 20; //varibale count, if need, change! 
                ListFormat node_ROW=node_0.add(ListFormat.TYPE,nROW,"ROW","") as ListFormat; 
                for(int n1=0; n1< nROW; n1++) 
                { 
                    node_ROW.add(AsciiFormat.TYPE,-1,"TBLELT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS13F16()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(13, false);
            trx.Function = 16;

            ListFormat node_0=trx.add(ListFormat.TYPE,6,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"TBLTYP","");
                node_0.add(AsciiFormat.TYPE,-1,"TBLID","");
                int nATTRCOUNT = 20; //varibale count, if need, change! 
                ListFormat node_ATTRCOUNT=node_0.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                for(int n1=0; n1< nATTRCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRID","");
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRDATA","");
                } 
                int nCOLUMN = 20; //varibale count, if need, change! 
                ListFormat node_COLUMN=node_0.add(ListFormat.TYPE,nCOLUMN,"COLUMN","") as ListFormat; 
                for(int n1=0; n1< nCOLUMN; n1++) 
                { 
                    node_COLUMN.add(AsciiFormat.TYPE,-1,"COLHDR","");
                } 
                int nROW = 20; //varibale count, if need, change! 
                ListFormat node_ROW=node_0.add(ListFormat.TYPE,nROW,"ROW","") as ListFormat; 
                for(int n1=0; n1< nROW; n1++) 
                { 
                    int nTABLECOUNT = 20; //varibale count, if need, change! 
                    ListFormat node_TABLECOUNT=node_ROW.add(ListFormat.TYPE,nTABLECOUNT,"TABLECOUNT","") as ListFormat; 
                    for(int n2=0; n2< nTABLECOUNT; n2++) 
                    { 
                        node_TABLECOUNT.add(AsciiFormat.TYPE,-1,"TBLELT","");
                    } 
                } 
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(AsciiFormat.TYPE,-1,"TBLACK","");
                    int nERRCOUNT = 20; //varibale count, if need, change! 
                    ListFormat node_ERRCOUNT=node_1.add(ListFormat.TYPE,nERRCOUNT,"ERRCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS14F1()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(14, true);
            trx.Function = 1;

            ListFormat node_0=trx.add(ListFormat.TYPE,5,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"OBJECTSPEC","");
                node_0.add(AsciiFormat.TYPE,-1,"OBJTYPE","");
                int nOBJECTCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_OBJECTCOUNT=node_0.add(ListFormat.TYPE,nOBJECTCOUNT,"OBJECTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nOBJECTCOUNT; n1++) 
                { 
                    node_OBJECTCOUNT.add(AsciiFormat.TYPE,-1,"OBJECTID","");
                } 
                int nATTRCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ATTRCOUNT=node_0.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                for(int n1=0; n1< nATTRCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ATTRCOUNT.add(ListFormat.TYPE,3,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRID","");
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRDATA","");
                        node_2.add(Uint1Format.TYPE,-1,"ATTRRELN","");
                } 
                int nATTRIBUTECOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ATTRIBUTECOUNT=node_0.add(ListFormat.TYPE,nATTRIBUTECOUNT,"ATTRIBUTECOUNT","") as ListFormat; 
                for(int n1=0; n1< nATTRIBUTECOUNT; n1++) 
                { 
                    node_ATTRIBUTECOUNT.add(AsciiFormat.TYPE,-1,"ATTRIBUTEID","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS14F2()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(14, false);
            trx.Function = 2;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                int nOBJECTCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_OBJECTCOUNT=node_0.add(ListFormat.TYPE,nOBJECTCOUNT,"OBJECTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nOBJECTCOUNT; n1++) 
                { 
                    ListFormat node_2=node_OBJECTCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"OBJECTID","");
                        int nATTRCOUNT = 10; //varibale count, if need, change! 
                        ListFormat node_ATTRCOUNT=node_2.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                        for(int n3=0; n3< nATTRCOUNT; n3++) 
                        { 
                            ListFormat node_4=node_ATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                                node_4.add(AsciiFormat.TYPE,-1,"ATTRID","");
                                node_4.add(AsciiFormat.TYPE,-1,"ATTRDATA","");
                        } 
                } 
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint2Format.TYPE,1,"OBJACK","0");
                    int nERRORCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS14F3()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(14, true);
            trx.Function = 3;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"OBJECTSPEC","");
                node_0.add(AsciiFormat.TYPE,-1,"OBJTYPE","");
                int nOBJECTCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_OBJECTCOUNT=node_0.add(ListFormat.TYPE,nOBJECTCOUNT,"OBJECTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nOBJECTCOUNT; n1++) 
                { 
                    node_OBJECTCOUNT.add(AsciiFormat.TYPE,-1,"OBJECTID","");
                } 
                int nATTRCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ATTRCOUNT=node_0.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                for(int n1=0; n1< nATTRCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRID","");
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRDATA","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS14F4()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(14, false);
            trx.Function = 4;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                int nOBJECTCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_OBJECTCOUNT=node_0.add(ListFormat.TYPE,nOBJECTCOUNT,"OBJECTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nOBJECTCOUNT; n1++) 
                { 
                    ListFormat node_2=node_OBJECTCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"OBJECTID","");
                        int nATTRCOUNT = 10; //varibale count, if need, change! 
                        ListFormat node_ATTRCOUNT=node_2.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                        for(int n3=0; n3< nATTRCOUNT; n3++) 
                        { 
                            ListFormat node_4=node_ATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                                node_4.add(AsciiFormat.TYPE,-1,"ATTRID","");
                                node_4.add(AsciiFormat.TYPE,-1,"ATTRDATA","");
                        } 
                } 
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint2Format.TYPE,1,"OBJACK","0");
                    int nERRORCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS14F5()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(14, true);
            trx.Function = 5;

            trx.add(AsciiFormat.TYPE,-1,"OBJECTSPEC","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS14F6()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(14, false);
            trx.Function = 6;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                int nOBJECTCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_OBJECTCOUNT=node_0.add(ListFormat.TYPE,nOBJECTCOUNT,"OBJECTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nOBJECTCOUNT; n1++) 
                { 
                    node_OBJECTCOUNT.add(AsciiFormat.TYPE,-1,"OBJTYPE","");
                } 
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint2Format.TYPE,1,"OBJACK","0");
                    int nERRORCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS14F7()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(14, true);
            trx.Function = 7;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"OBJECTSPEC","");
                int nOBJECTCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_OBJECTCOUNT=node_0.add(ListFormat.TYPE,nOBJECTCOUNT,"OBJECTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nOBJECTCOUNT; n1++) 
                { 
                    node_OBJECTCOUNT.add(AsciiFormat.TYPE,-1,"OBJTYPE","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS14F8()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(14, false);
            trx.Function = 8;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                int nOBJECTCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_OBJECTCOUNT=node_0.add(ListFormat.TYPE,nOBJECTCOUNT,"OBJECTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nOBJECTCOUNT; n1++) 
                { 
                    ListFormat node_2=node_OBJECTCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"OBJTYPE","");
                        int nATTRCOUNT = 10; //varibale count, if need, change! 
                        ListFormat node_ATTRCOUNT=node_2.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                        for(int n3=0; n3< nATTRCOUNT; n3++) 
                        { 
                            node_ATTRCOUNT.add(AsciiFormat.TYPE,-1,"ATTRID","");
                        } 
                } 
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint2Format.TYPE,1,"OBJACK","0");
                    int nERRORCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS14F9()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(14, true);
            trx.Function = 9;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"OBJECTSPEC","");
                node_0.add(AsciiFormat.TYPE,-1,"OBJTYPE","");
                int nATTRCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ATTRCOUNT=node_0.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                for(int n1=0; n1< nATTRCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRID","");
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRDATA","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS14F10()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(14, false);
            trx.Function = 10;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"OBJECTSPEC","");
                int nATTRCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ATTRCOUNT=node_0.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                for(int n1=0; n1< nATTRCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRID","");
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRDATA","");
                } 
                node_0.add(Uint2Format.TYPE,1,"OBJACK","0");
                int nERRORCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ERRORCOUNT=node_0.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                for(int n1=0; n1< nERRORCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_2.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS14F11()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(14, true);
            trx.Function = 11;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"OBJECTSPEC","");
                int nATTRCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ATTRCOUNT=node_0.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                for(int n1=0; n1< nATTRCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRID","");
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRDATA","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS14F12()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(14, false);
            trx.Function = 12;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                int nATTRCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ATTRCOUNT=node_0.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                for(int n1=0; n1< nATTRCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRID","");
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRDATA","");
                } 
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint2Format.TYPE,1,"OBJACK","0");
                    int nERRORCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS14F13()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(14, true);
            trx.Function = 13;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"OBJECTSPEC","");
                int nATTRCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ATTRCOUNT=node_0.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                for(int n1=0; n1< nATTRCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRID","");
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRDATA","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS14F14()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(14, false);
            trx.Function = 14;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(Uint4Format.TYPE,1,"OBJTOKEN","0");
                int nATTRCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ATTRCOUNT=node_0.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                for(int n1=0; n1< nATTRCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRID","");
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRDATA","");
                } 
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint2Format.TYPE,1,"OBJACK","0");
                    int nERRORCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS14F15()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(14, true);
            trx.Function = 15;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"OBJECTSPEC","");
                node_0.add(Uint1Format.TYPE,1,"OBJCMD","0");
                node_0.add(Uint4Format.TYPE,1,"OBJTOKEN","0");
                int nATTRCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ATTRCOUNT=node_0.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                for(int n1=0; n1< nATTRCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRID","");
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRDATA","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS14F16()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(14, false);
            trx.Function = 16;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                int nATTRCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ATTRCOUNT=node_0.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                for(int n1=0; n1< nATTRCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRID","");
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRDATA","");
                } 
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint2Format.TYPE,1,"OBJACK","0");
                    int nERRORCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS14F17()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(14, true);
            trx.Function = 17;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"OBJECTSPEC","");
                node_0.add(Uint1Format.TYPE,1,"OBJCMD","0");
                node_0.add(AsciiFormat.TYPE,-1,"TARGETSPEC","");
                int nATTRCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ATTRCOUNT=node_0.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                for(int n1=0; n1< nATTRCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRID","");
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRDATA","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS14F18()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(14, false);
            trx.Function = 18;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                int nATTRCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ATTRCOUNT=node_0.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                for(int n1=0; n1< nATTRCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRID","");
                        node_2.add(AsciiFormat.TYPE,-1,"ATTRDATA","");
                } 
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint2Format.TYPE,1,"OBJACK","0");
                    int nERRORCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS15F1()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 1;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(AsciiFormat.TYPE,-1,"RCPSPEC","");
                node_0.add(Uint2Format.TYPE,1,"RMDATASIZE","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F2()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 2;

            trx.add(BooleanFormat.TYPE,1,"RMGRANT","False");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F3()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 3;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"RMNSSPEC","");
                node_0.add(Uint1Format.TYPE,1,"RMNSCMD","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F4()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 4;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint1Format.TYPE,1,"RMACK","0");
                int nERRORCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ERRORCOUNT=node_0.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                for(int n1=0; n1< nERRORCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_2.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F5()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 5;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"RMNSSPEC","");
                node_0.add(AsciiFormat.TYPE,-1,"RMNEWNS","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F6()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 6;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint1Format.TYPE,1,"RMACK","0");
                int nERRORCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ERRORCOUNT=node_0.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                for(int n1=0; n1< nERRORCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_2.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F7()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 7;

            trx.add(AsciiFormat.TYPE,-1,"OBJECTSPEC","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F8()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 8;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"RMSPACE","0");
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint1Format.TYPE,1,"RMACK","0");
                    int nERRORCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F9()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 9;

            trx.add(AsciiFormat.TYPE,-1,"RCPSPEC","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F10()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 10;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"RCPSTAT","0");
                node_0.add(AsciiFormat.TYPE,-1,"RCPVERS","");
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint1Format.TYPE,1,"RMACK","0");
                    int nERRORCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F11()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 11;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"RMNSSPEC","");
                node_0.add(AsciiFormat.TYPE,-1,"RCPCLASS","");
                node_0.add(AsciiFormat.TYPE,-1,"RCPNAME","");
                node_0.add(AsciiFormat.TYPE,-1,"AGENT","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F12()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 12;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"AGENT","");
                node_0.add(AsciiFormat.TYPE,-1,"RCPVERS","");
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint1Format.TYPE,1,"RMACK","0");
                    int nERRORCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F13()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 13;

            ListFormat node_0=trx.add(ListFormat.TYPE,5,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(BooleanFormat.TYPE,1,"RCPUPDT","False");
                node_0.add(AsciiFormat.TYPE,-1,"RCPSPEC","");
                int nRECIPEATTRCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_RECIPEATTRCOUNT=node_0.add(ListFormat.TYPE,nRECIPEATTRCOUNT,"RECIPEATTRCOUNT","") as ListFormat; 
                for(int n1=0; n1< nRECIPEATTRCOUNT; n1++) 
                { 
                    ListFormat node_2=node_RECIPEATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"RCPATTRID","");
                        node_2.add(AsciiFormat.TYPE,-1,"RCPATTRDATA","");
                } 
                node_0.add(AsciiFormat.TYPE,-1,"RCPBODY","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F14()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 14;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint1Format.TYPE,1,"RMACK","0");
                int nERRORCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ERRORCOUNT=node_0.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                for(int n1=0; n1< nERRORCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_2.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F15()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 15;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(AsciiFormat.TYPE,-1,"RCPSPEC","");
                node_0.add(BooleanFormat.TYPE,1,"RCPSECCODE","False");
                ListFormat node_COUNT=node_0.add(ListFormat.TYPE,3,"","COUNT")  as ListFormat;
                    ListFormat node_RCPCOUNT=node_COUNT.add(ListFormat.TYPE,2,"","RCPCOUNT")  as ListFormat;
                        node_RCPCOUNT.add(AsciiFormat.TYPE,-1,"GENRCPSECNM","");
                        int nGENRCPATTRCOUNT = 20; //varibale count, if need, change! 
                        ListFormat node_GENRCPATTRCOUNT=node_RCPCOUNT.add(ListFormat.TYPE,nGENRCPATTRCOUNT,"GENRCPATTRCOUNT","") as ListFormat; 
                        for(int n3=0; n3< nGENRCPATTRCOUNT; n3++) 
                        { 
                            ListFormat node_4=node_GENRCPATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                                node_4.add(AsciiFormat.TYPE,-1,"GENRCPATTRID","");
                                node_4.add(AsciiFormat.TYPE,-1,"GENRCPATTRDATA","");
                        } 
                    node_COUNT.add(AsciiFormat.TYPE,-1,"RCPBODY","");
                    int nRCPSECCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_RCPSECCOUNT=node_COUNT.add(ListFormat.TYPE,nRCPSECCOUNT,"RCPSECCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nRCPSECCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_RCPSECCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(AsciiFormat.TYPE,-1,"RCPSECNM","");
                            int nRCPATTRCOUNT = 10; //varibale count, if need, change! 
                            ListFormat node_RCPATTRCOUNT=node_3.add(ListFormat.TYPE,nRCPATTRCOUNT,"RCPATTRCOUNT","") as ListFormat; 
                            for(int n4=0; n4< nRCPATTRCOUNT; n4++) 
                            { 
                                ListFormat node_5=node_RCPATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                                    node_5.add(AsciiFormat.TYPE,-1,"RCPATTRID","");
                                    node_5.add(AsciiFormat.TYPE,-1,"RCPATTRDATA","");
                            } 
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F16()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 16;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BinaryFormat.TYPE,1,"RCPSECCODE","0");
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint1Format.TYPE,1,"RMACK","0");
                    int nRECIPEATTRCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_RECIPEATTRCOUNT=node_1.add(ListFormat.TYPE,nRECIPEATTRCOUNT,"RECIPEATTRCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nRECIPEATTRCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_RECIPEATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(AsciiFormat.TYPE,-1,"RCPATTRID","");
                            node_3.add(AsciiFormat.TYPE,-1,"RCPATTRDATA","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F17()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 17;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"RCPSPEC","");
                node_0.add(BinaryFormat.TYPE,1,"RCPSECCODE","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F18()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 18;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                ListFormat node_COUNT=node_0.add(ListFormat.TYPE,3,"","COUNT")  as ListFormat;
                    ListFormat node_VARCOUNT=node_COUNT.add(ListFormat.TYPE,2,"","VARCOUNT")  as ListFormat;
                        node_VARCOUNT.add(AsciiFormat.TYPE,-1,"RCPSECNM","");
                        int nRECIPEATTRCOUNT = 10; //varibale count, if need, change! 
                        ListFormat node_RECIPEATTRCOUNT=node_VARCOUNT.add(ListFormat.TYPE,nRECIPEATTRCOUNT,"RECIPEATTRCOUNT","") as ListFormat; 
                        for(int n3=0; n3< nRECIPEATTRCOUNT; n3++) 
                        { 
                            ListFormat node_4=node_RECIPEATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                                node_4.add(AsciiFormat.TYPE,-1,"RCPATTRID","");
                                node_4.add(AsciiFormat.TYPE,-1,"RCPATTRDATA","");
                        } 
                    node_COUNT.add(AsciiFormat.TYPE,-1,"RCPBODY","");
                    int nRECIPESECTIONNAMECOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_RECIPESECTIONNAMECOUNT=node_COUNT.add(ListFormat.TYPE,nRECIPESECTIONNAMECOUNT,"RECIPESECTIONNAMECOUNT","") as ListFormat; 
                    for(int n2=0; n2< nRECIPESECTIONNAMECOUNT; n2++) 
                    { 
                        ListFormat node_3=node_RECIPESECTIONNAMECOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(AsciiFormat.TYPE,-1,"RCPSECNAME","");
                            int nATTRCOUNT = 10; //varibale count, if need, change! 
                            ListFormat node_ATTRCOUNT=node_3.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                            for(int n4=0; n4< nATTRCOUNT; n4++) 
                            { 
                                ListFormat node_5=node_ATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                                    node_5.add(AsciiFormat.TYPE,-1,"RCPATTRIBUTEID","");
                                    node_5.add(AsciiFormat.TYPE,-1,"RCPATTRIBUTEDATA","");
                            } 
                    } 
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint1Format.TYPE,1,"RMACK","0");
                    int nERRORCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F19()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 19;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"RCPSPEC","");
                node_0.add(BooleanFormat.TYPE,1,"RCPRENAME","False");
                node_0.add(AsciiFormat.TYPE,-1,"RCPNEWID","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F20()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 20;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint1Format.TYPE,1,"RMACK","0");
                int nERRORCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ERRORCOUNT=node_0.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                for(int n1=0; n1< nERRORCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_2.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F21()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 21;

            ListFormat node_0=trx.add(ListFormat.TYPE,6,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(Uint1Format.TYPE,1,"RCPCMD","0");
                node_0.add(AsciiFormat.TYPE,-1,"RMNSSPEC","");
                node_0.add(Uint2Format.TYPE,1,"OPID","0");
                node_0.add(AsciiFormat.TYPE,-1,"AGENT","");
                int nRECIPECOUNT = 10; //varibale count, if need, change! 
                ListFormat node_RECIPECOUNT=node_0.add(ListFormat.TYPE,nRECIPECOUNT,"RECIPECOUNT","") as ListFormat; 
                for(int n1=0; n1< nRECIPECOUNT; n1++) 
                { 
                    node_RECIPECOUNT.add(AsciiFormat.TYPE,-1,"RCPID","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F22()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 22;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"AGENT","");
                node_0.add(Uint4Format.TYPE,1,"LINKID","0");
                node_0.add(Uint1Format.TYPE,1,"RCPCMD","0");
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint1Format.TYPE,1,"RMACK","0");
                    int nERRORCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F23()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 23;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(AsciiFormat.TYPE,-1,"OBJECTSPEC","");
                int nRECIPECOUNT = 10; //varibale count, if need, change! 
                ListFormat node_RECIPECOUNT=node_0.add(ListFormat.TYPE,nRECIPECOUNT,"RECIPECOUNT","") as ListFormat; 
                for(int n1=0; n1< nRECIPECOUNT; n1++) 
                { 
                    node_RECIPECOUNT.add(AsciiFormat.TYPE,-1,"RCPID","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F24()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 24;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                int nRECIPECOUNT = 20; //varibale count, if need, change! 
                ListFormat node_RECIPECOUNT=node_0.add(ListFormat.TYPE,nRECIPECOUNT,"RECIPECOUNT","") as ListFormat; 
                for(int n1=0; n1< nRECIPECOUNT; n1++) 
                { 
                    int nDESCRIPTORCOUNT = 20; //varibale count, if need, change! 
                    ListFormat node_DESCRIPTORCOUNT=node_RECIPECOUNT.add(ListFormat.TYPE,nDESCRIPTORCOUNT,"DESCRIPTORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nDESCRIPTORCOUNT; n2++) 
                    { 
                        ListFormat node_DESCRIPTOR=node_DESCRIPTORCOUNT.add(ListFormat.TYPE,3,"","DESCRIPTOR")  as ListFormat;
                            node_DESCRIPTOR.add(AsciiFormat.TYPE,-1,"RCPDESCNM","");
                            node_DESCRIPTOR.add(AsciiFormat.TYPE,-1,"RCPDESCTIME","");
                            node_DESCRIPTOR.add(Uint2Format.TYPE,1,"RCPDESCLTH","0");
                    } 
                } 
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint1Format.TYPE,1,"RMACK","0");
                    int nERRORCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F25()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 25;

            ListFormat node_0=trx.add(ListFormat.TYPE,5,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(AsciiFormat.TYPE,-1,"RMNSSpec","");
                node_0.add(AsciiFormat.TYPE,-1,"AGENT","");
                node_0.add(AsciiFormat.TYPE,-1,"RCPBODY","");
                int nRECIPEPARMCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_RECIPEPARMCOUNT=node_0.add(ListFormat.TYPE,nRECIPEPARMCOUNT,"RECIPEPARMCOUNT","") as ListFormat; 
                for(int n1=0; n1< nRECIPEPARMCOUNT; n1++) 
                { 
                    ListFormat node_2=node_RECIPEPARMCOUNT.add(ListFormat.TYPE,3,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"RCPPARNM","");
                        node_2.add(AsciiFormat.TYPE,-1,"RCPPARVAL","");
                        node_2.add(AsciiFormat.TYPE,-1,"RCPPARRULE","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F26()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 26;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint1Format.TYPE,1,"RMACK","0");
                int nERRORCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ERRORCOUNT=node_0.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                for(int n1=0; n1< nERRORCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_2.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F27()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 27;

            ListFormat node_0=trx.add(ListFormat.TYPE,5,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(BooleanFormat.TYPE,1,"RCPOWCODE","False");
                node_0.add(AsciiFormat.TYPE,-1,"RCPSPEC","");
                int nATTRCOUNT = 20; //varibale count, if need, change! 
                ListFormat node_ATTRCOUNT=node_0.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                for(int n1=0; n1< nATTRCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"RCPATTRID","");
                        node_2.add(AsciiFormat.TYPE,-1,"RCPATTRDATA","");
                } 
                node_0.add(AsciiFormat.TYPE,-1,"RCPBODY","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F28()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 28;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"RCPID","");
                int nATTRCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ATTRCOUNT=node_0.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                for(int n1=0; n1< nATTRCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"RCPATTRID","");
                        node_2.add(AsciiFormat.TYPE,-1,"RCPATTRDATA","");
                } 
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint1Format.TYPE,-1,"RMACK","");
                    int nERRORCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,-1,"ERRCODE","");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F29()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 29;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(Uint2Format.TYPE,1,"OPID","0");
                node_0.add(AsciiFormat.TYPE,-1,"RESPEC","");
                int nRECIPECOUNT = 10; //varibale count, if need, change! 
                ListFormat node_RECIPECOUNT=node_0.add(ListFormat.TYPE,nRECIPECOUNT,"RECIPECOUNT","") as ListFormat; 
                for(int n1=0; n1< nRECIPECOUNT; n1++) 
                { 
                    node_RECIPECOUNT.add(AsciiFormat.TYPE,-1,"RCPID","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F30()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 30;

            ListFormat node_0=trx.add(ListFormat.TYPE,5,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"OPID","0");
                node_0.add(Uint4Format.TYPE,1,"LINKID","0");
                node_0.add(AsciiFormat.TYPE,-1,"RCPID","");
                int nATTRCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ATTRCOUNT=node_0.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                for(int n1=0; n1< nATTRCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"RCPATTRID","");
                        node_2.add(AsciiFormat.TYPE,-1,"RCPATTRDATA","");
                } 
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint1Format.TYPE,-1,"RMACK","");
                    int nERRORCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,-1,"ERRCODE","");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F31()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 31;

            trx.add(AsciiFormat.TYPE,-1,"RCPSPEC","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F32()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 32;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"RCPSPEC","");
                int nATTRCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ATTRCOUNT=node_0.add(ListFormat.TYPE,nATTRCOUNT,"ATTRCOUNT","") as ListFormat; 
                for(int n1=0; n1< nATTRCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ATTRCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"RCPATTRID","");
                        node_2.add(AsciiFormat.TYPE,-1,"RCPATTRDATA","");
                } 
                node_0.add(AsciiFormat.TYPE,-1,"RCPBODY","");
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint1Format.TYPE,-1,"RMACK","");
                    int nERRORCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,-1,"ERRCODE","");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F33()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 33;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(AsciiFormat.TYPE,-1,"RESPEC","");
                int nRECIPECOUNT = 10; //varibale count, if need, change! 
                ListFormat node_RECIPECOUNT=node_0.add(ListFormat.TYPE,nRECIPECOUNT,"RECIPECOUNT","") as ListFormat; 
                for(int n1=0; n1< nRECIPECOUNT; n1++) 
                { 
                    ListFormat node_2=node_RECIPECOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"RCPPARNM","");
                        node_2.add(AsciiFormat.TYPE,-1,"RCPPARVAL","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F34()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 34;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint1Format.TYPE,1,"RMACK","0");
                int nERRORCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ERRORCOUNT=node_0.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                for(int n1=0; n1< nERRORCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_2.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F35()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 35;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(AsciiFormat.TYPE,-1,"RESPEC","");
                node_0.add(AsciiFormat.TYPE,-1,"RCPDEL","");
                int nRECIPECOUNT = 80; //varibale count, if need, change! 
                ListFormat node_RECIPECOUNT=node_0.add(ListFormat.TYPE,nRECIPECOUNT,"RECIPECOUNT","") as ListFormat; 
                for(int n1=0; n1< nRECIPECOUNT; n1++) 
                { 
                    node_RECIPECOUNT.add(AsciiFormat.TYPE,-1,"RCPID","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F36()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 36;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint1Format.TYPE,1,"RMACK","0");
                int nERRORCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ERRORCOUNT=node_0.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                for(int n1=0; n1< nERRORCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_2.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F37()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 37;

            ListFormat node_0=trx.add(ListFormat.TYPE,6,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"RMSEGSPEC","");
                node_0.add(Uint4Format.TYPE,1,"OBJTOKEN","0");
                node_0.add(BinaryFormat.TYPE,1,"RMGRNT","0");
                node_0.add(Uint4Format.TYPE,1,"OPID","0");
                node_0.add(AsciiFormat.TYPE,-1,"RCPID","");
                node_0.add(Uint4Format.TYPE,1,"RMCHGTYPE","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F38()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 38;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint1Format.TYPE,1,"RMACK","0");
                int nERRORCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ERRORCOUNT=node_0.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                for(int n1=0; n1< nERRORCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_2.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F39()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 39;

            ListFormat node_0=trx.add(ListFormat.TYPE,5,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(Uint1Format.TYPE,1,"RMNSCMD","0");
                node_0.add(AsciiFormat.TYPE,-1,"RMRECSPEC","");
                node_0.add(AsciiFormat.TYPE,-1,"RMSEGSPEC","");
                node_0.add(Uint4Format.TYPE,1,"OBJTOKEN","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F40()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 40;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint1Format.TYPE,1,"RMACK","0");
                int nERRORCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ERRORCOUNT=node_0.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                for(int n1=0; n1< nERRORCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_2.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F41()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 41;

            ListFormat node_0=trx.add(ListFormat.TYPE,5,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(AsciiFormat.TYPE,-1,"RMRECSPEC","");
                node_0.add(Uint4Format.TYPE,1,"OBJTOKEN","0");
                node_0.add(Uint1Format.TYPE,1,"RMNSCMD","0");
                ListFormat node_RecipeField=node_0.add(ListFormat.TYPE,7,"","RecipeField")  as ListFormat;
                    node_RecipeField.add(AsciiFormat.TYPE,-1,"RCPID","");
                    node_RecipeField.add(AsciiFormat.TYPE,-1,"RCPNEWID","");
                    node_RecipeField.add(AsciiFormat.TYPE,-1,"RMSEGSPEC","");
                    node_RecipeField.add(Uint4Format.TYPE,1,"RMCHGTYPE","0");
                    node_RecipeField.add(Uint4Format.TYPE,1,"OPID","0");
                    node_RecipeField.add(AsciiFormat.TYPE,-1,"TIMESTAMP","");
                    node_RecipeField.add(BooleanFormat.TYPE,1,"RMREQUESTOR","False");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F42()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 42;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint1Format.TYPE,1,"RMACK","0");
                int nERRORCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ERRORCOUNT=node_0.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                for(int n1=0; n1< nERRORCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_2.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F43()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 43;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(AsciiFormat.TYPE,-1,"OBJECTSPEC","");
                node_0.add(AsciiFormat.TYPE,-1,"TARGETSPEC","");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F44()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 44;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                int nRequestsCount = 20; //varibale count, if need, change! 
                ListFormat node_RequestsCount=node_0.add(ListFormat.TYPE,nRequestsCount,"RequestsCount","") as ListFormat; 
                for(int n1=0; n1< nRequestsCount; n1++) 
                { 
                    ListFormat node_2=node_RequestsCount.add(ListFormat.TYPE,7,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"RCPID","");
                        node_2.add(AsciiFormat.TYPE,-1,"RCPNEWID","");
                        node_2.add(AsciiFormat.TYPE,-1,"RMSEGSPEC","");
                        node_2.add(Uint4Format.TYPE,1,"RMCHGTYPE","0");
                        node_2.add(Uint4Format.TYPE,1,"OPID","0");
                        node_2.add(AsciiFormat.TYPE,-1,"TIMESTAMP","");
                        node_2.add(BooleanFormat.TYPE,1,"RMREQUESTOR","False");
                } 
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(Uint1Format.TYPE,1,"RMACK","0");
                    int nERRORCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F45()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 45;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(AsciiFormat.TYPE,-1,"RCPSPEC","");
                node_0.add(AsciiFormat.TYPE,-1,"RCPNEWID","");
                node_0.add(Uint4Format.TYPE,1,"RMCHGTYPE","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F46()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 46;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(Uint4Format.TYPE,1,"RMCHGTYPE","0");
                node_0.add(BinaryFormat.TYPE,1,"RMGRNT","0");
                node_0.add(Uint4Format.TYPE,1,"OPID","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F47()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, true);
            trx.Function = 47;

            ListFormat node_0=trx.add(ListFormat.TYPE,5,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(AsciiFormat.TYPE,-1,"OBJECTSPEC","");
                node_0.add(AsciiFormat.TYPE,-1,"RMNSSPEC","");
                node_0.add(AsciiFormat.TYPE,-1,"RMRECSPEC","");
                int nSpecCount = 80; //varibale count, if need, change! 
                ListFormat node_SpecCount=node_0.add(ListFormat.TYPE,nSpecCount,"SpecCount","") as ListFormat; 
                for(int n1=0; n1< nSpecCount; n1++) 
                { 
                    node_SpecCount.add(AsciiFormat.TYPE,-1,"RMSEGSPEC","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS15F48()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(15, false);
            trx.Function = 48;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint1Format.TYPE,1,"RMACK","0");
                int nERRORCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_ERRORCOUNT=node_0.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                for(int n1=0; n1< nERRORCOUNT; n1++) 
                { 
                    ListFormat node_2=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_2.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS16F1()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(16, true);
            trx.Function = 1;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(Uint2Format.TYPE,1,"DATALENGTH","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS16F2()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(16, false);
            trx.Function = 2;

            trx.add(BinaryFormat.TYPE,1,"GRANT","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS16F3()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(16, true);
            trx.Function = 3;

            ListFormat node_0=trx.add(ListFormat.TYPE,5,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(AsciiFormat.TYPE,-1,"MF","");
                int nMTCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_MTCOUNT=node_0.add(ListFormat.TYPE,nMTCOUNT,"MTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nMTCOUNT; n1++) 
                { 
                    node_MTCOUNT.add(AsciiFormat.TYPE,-1,"MTID","");
                } 
                ListFormat node_1=node_0.add(ListFormat.TYPE,3,"","")  as ListFormat;
                    node_1.add(AsciiFormat.TYPE,-1,"PRRECIPMETHOD","");
                    node_1.add(AsciiFormat.TYPE,-1,"RCPSPEC","");
                    int nRECIPEPARMCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_RECIPEPARMCOUNT=node_1.add(ListFormat.TYPE,nRECIPEPARMCOUNT,"RECIPEPARMCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nRECIPEPARMCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_RECIPEPARMCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(AsciiFormat.TYPE,-1,"RCPPARNM","");
                            node_3.add(AsciiFormat.TYPE,-1,"RCPPARVAL","");
                    } 
                node_0.add(BooleanFormat.TYPE,1,"PCPPARVAL","False");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS16F4()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(16, false);
            trx.Function = 4;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"PRJOBID","");
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(BooleanFormat.TYPE,1,"ACKA","False");
                    int nERRORCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS16F5()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(16, true);
            trx.Function = 5;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(AsciiFormat.TYPE,-1,"PRJOBID","");
                node_0.add(AsciiFormat.TYPE,-1,"PRCMDNAME","");
                int nCOMMANDPARMCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_COMMANDPARMCOUNT=node_0.add(ListFormat.TYPE,nCOMMANDPARMCOUNT,"COMMANDPARMCOUNT","") as ListFormat; 
                for(int n1=0; n1< nCOMMANDPARMCOUNT; n1++) 
                { 
                    ListFormat node_2=node_COMMANDPARMCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"CPNAME","");
                        node_2.add(AsciiFormat.TYPE,-1,"CPVAL","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS16F6()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(16, false);
            trx.Function = 6;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"PRJOBID","");
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(BooleanFormat.TYPE,1,"ACKA","False");
                    int nERRORCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS16F7()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(16, true);
            trx.Function = 7;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"TIMESTAMP","");
                node_0.add(AsciiFormat.TYPE,-1,"PRJOBID","");
                node_0.add(AsciiFormat.TYPE,-1,"PRJOBMILESTONE","");
                ListFormat node_1=node_0.add(ListFormat.TYPE,2,"","")  as ListFormat;
                    node_1.add(BooleanFormat.TYPE,1,"ACKA","False");
                    int nERRORCOUNT = 10; //varibale count, if need, change! 
                    ListFormat node_ERRORCOUNT=node_1.add(ListFormat.TYPE,nERRORCOUNT,"ERRORCOUNT","") as ListFormat; 
                    for(int n2=0; n2< nERRORCOUNT; n2++) 
                    { 
                        ListFormat node_3=node_ERRORCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                            node_3.add(Uint2Format.TYPE,1,"ERRCODE","0");
                            node_3.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                    } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS16F8()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(16, false);
            trx.Function = 8;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS16F9()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(16, true);
            trx.Function = 9;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"PREVENTID","0");
                node_0.add(AsciiFormat.TYPE,-1,"TIMESTAMP","");
                node_0.add(AsciiFormat.TYPE,-1,"PRJOBID","");
                int nVCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_VCOUNT=node_0.add(ListFormat.TYPE,nVCOUNT,"VCOUNT","") as ListFormat; 
                for(int n1=0; n1< nVCOUNT; n1++) 
                { 
                    ListFormat node_2=node_VCOUNT.add(ListFormat.TYPE,2,"","")  as ListFormat;
                        node_2.add(AsciiFormat.TYPE,-1,"VID","");
                        node_2.add(AsciiFormat.TYPE,-1,"VARIABLEDATA","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS16F10()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(16, false);
            trx.Function = 10;


    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS17F1()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(17, true);
            trx.Function = 1;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(Uint2Format.TYPE,1,"RPTID","0");
                node_0.add(AsciiFormat.TYPE,-1,"DATASRC","");
                int nVCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_VCOUNT=node_0.add(ListFormat.TYPE,nVCOUNT,"VCOUNT","") as ListFormat; 
                for(int n1=0; n1< nVCOUNT; n1++) 
                { 
                    node_VCOUNT.add(AsciiFormat.TYPE,-1,"VID","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS17F2()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(17, false);
            trx.Function = 2;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"RPTID","0");
                node_0.add(Uint2Format.TYPE,1,"ERRCODE","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS17F3()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(17, true);
            trx.Function = 3;

            int nREPORTCOUNT = 10; //varibale count, if need, change! 
            ListFormat node_REPORTCOUNT=trx.add(ListFormat.TYPE,nREPORTCOUNT,"REPORTCOUNT","") as ListFormat; 
            for(int n0=0; n0< nREPORTCOUNT; n0++) 
            { 
                node_REPORTCOUNT.add(Uint2Format.TYPE,1,"RPTID","0");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS17F4()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(17, false);
            trx.Function = 4;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BooleanFormat.TYPE,1,"ACKA","False");
                int nREPORTCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_REPORTCOUNT=node_0.add(ListFormat.TYPE,nREPORTCOUNT,"REPORTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nREPORTCOUNT; n1++) 
                { 
                    ListFormat node_2=node_REPORTCOUNT.add(ListFormat.TYPE,3,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"RPTID","0");
                        node_2.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_2.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS17F5()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(17, true);
            trx.Function = 5;

            ListFormat node_0=trx.add(ListFormat.TYPE,6,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(Uint2Format.TYPE,1,"TRID","0");
                node_0.add(BooleanFormat.TYPE,1,"CEED","False");
                int nREPORTCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_REPORTCOUNT=node_0.add(ListFormat.TYPE,nREPORTCOUNT,"REPORTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nREPORTCOUNT; n1++) 
                { 
                    node_REPORTCOUNT.add(Uint2Format.TYPE,1,"RPTID","0");
                } 
                node_0.add(Float4Format.TYPE,1,"TRSPER","0");
                ListFormat node_TRACEPARMCOUNT=node_0.add(ListFormat.TYPE,8,"","TRACEPARMCOUNT")  as ListFormat;
                    node_TRACEPARMCOUNT.add(Uint2Format.TYPE,1,"TOTSMP","0");
                    node_TRACEPARMCOUNT.add(Uint2Format.TYPE,1,"REPGSZ","0");
                    node_TRACEPARMCOUNT.add(AsciiFormat.TYPE,-1,"STARTEVNTSRC","");
                    node_TRACEPARMCOUNT.add(Uint2Format.TYPE,1,"STARTCEID","0");
                    node_TRACEPARMCOUNT.add(AsciiFormat.TYPE,-1,"STOPEVNTSRC","");
                    node_TRACEPARMCOUNT.add(Uint2Format.TYPE,1,"STOPCEID","0");
                    node_TRACEPARMCOUNT.add(BooleanFormat.TYPE,1,"TRAUTOD","False");
                    node_TRACEPARMCOUNT.add(BooleanFormat.TYPE,1,"RPTOC","False");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS17F6()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(17, false);
            trx.Function = 6;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"TRID","0");
                node_0.add(Uint2Format.TYPE,1,"ERRCODE","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS17F7()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(17, true);
            trx.Function = 7;

            int nTRACECOUNT = 10; //varibale count, if need, change! 
            ListFormat node_TRACECOUNT=trx.add(ListFormat.TYPE,nTRACECOUNT,"TRACECOUNT","") as ListFormat; 
            for(int n0=0; n0< nTRACECOUNT; n0++) 
            { 
                node_TRACECOUNT.add(Uint2Format.TYPE,1,"TRID","0");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS17F8()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(17, false);
            trx.Function = 8;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BooleanFormat.TYPE,-1,"ACKA","");
                int nTRACECOUNT = 10; //varibale count, if need, change! 
                ListFormat node_TRACECOUNT=node_0.add(ListFormat.TYPE,nTRACECOUNT,"TRACECOUNT","") as ListFormat; 
                for(int n1=0; n1< nTRACECOUNT; n1++) 
                { 
                    ListFormat node_2=node_TRACECOUNT.add(ListFormat.TYPE,3,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"TRID","0");
                        node_2.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_2.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS17F9()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(17, true);
            trx.Function = 9;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(Uint2Format.TYPE,1,"DATAID","0");
                node_0.add(AsciiFormat.TYPE,-1,"EVNTSRC","");
                node_0.add(Uint2Format.TYPE,1,"CEID","0");
                int nREPORTCOUNT = 10; //varibale count, if need, change! 
                ListFormat node_REPORTCOUNT=node_0.add(ListFormat.TYPE,nREPORTCOUNT,"REPORTCOUNT","") as ListFormat; 
                for(int n1=0; n1< nREPORTCOUNT; n1++) 
                { 
                    node_REPORTCOUNT.add(Uint2Format.TYPE,1,"RPTID","0");
                } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS17F10()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(17, false);
            trx.Function = 10;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"EVNTSRC","");
                node_0.add(Uint2Format.TYPE,1,"CEID","0");
                node_0.add(Uint2Format.TYPE,1,"ERRCODE","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : True
           * Logging : True
          */ 
        public SECSTransaction makeS17F11()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(17, true);
            trx.Function = 11;

            ListFormat node_0=trx.add(ListFormat.TYPE,3,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"EVNTSRC","");
                node_0.add(Uint2Format.TYPE,1,"CEID","0");
                node_0.add(Uint2Format.TYPE,1,"RPTID","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS17F12()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(17, false);
            trx.Function = 12;

            ListFormat node_0=trx.add(ListFormat.TYPE,4,"","")  as ListFormat;
                node_0.add(AsciiFormat.TYPE,-1,"EVNTSRC","");
                node_0.add(Uint2Format.TYPE,1,"CEID","0");
                node_0.add(Uint2Format.TYPE,1,"RPTID","0");
                node_0.add(Uint2Format.TYPE,1,"ERRCODE","0");

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H->E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS17F13()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(17, true);
            trx.Function = 13;

            int nTRACECOUNT = 10; //varibale count, if need, change! 
            ListFormat node_TRACECOUNT=trx.add(ListFormat.TYPE,nTRACECOUNT,"TRACECOUNT","") as ListFormat; 
            for(int n0=0; n0< nTRACECOUNT; n0++) 
            { 
                node_TRACECOUNT.add(Uint2Format.TYPE,1,"TRID","0");
            } 

    
            return trx;

        }
        /*
           * Description : 
           * Direction : H<-E
           * AutoReply : False
           * Logging : True
          */ 
        public SECSTransaction makeS17F14()
        {
            SECSTransaction trx = new SECSTransaction();

            trx.setStreamNWbit(17, false);
            trx.Function = 14;

            ListFormat node_0=trx.add(ListFormat.TYPE,2,"","")  as ListFormat;
                node_0.add(BooleanFormat.TYPE,-1,"ACKA","");
                int nTRACECOUNT = 10; //varibale count, if need, change! 
                ListFormat node_TRACECOUNT=node_0.add(ListFormat.TYPE,nTRACECOUNT,"TRACECOUNT","") as ListFormat; 
                for(int n1=0; n1< nTRACECOUNT; n1++) 
                { 
                    ListFormat node_2=node_TRACECOUNT.add(ListFormat.TYPE,3,"","")  as ListFormat;
                        node_2.add(Uint2Format.TYPE,1,"TRID","0");
                        node_2.add(Uint2Format.TYPE,1,"ERRCODE","0");
                        node_2.add(AsciiFormat.TYPE,-1,"ERRTEXT","");
                } 

    
            return trx;

        }
    }
}
