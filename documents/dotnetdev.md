# How to Development EAP for .NET Developer

### [Example – C# Code](./sample.md)

### 📌 Index
* [Make SECS Instance](#make-secs-instance)
* [Invoke & Link SECS Event](#invoke-&-link-secs-event)
* [Initialize ScomDriver](#initialize-scomdriver)
* [Terminate ScomDriver](#terminate-scomdriver)
* [Send Request Message](#send-request-message)
* [Send Reply Message](#send-reply-message)
* [Reload SMD File](#reload-smd-file)
* [Reload Configuration](#reload-configuration)

### Start to Develop EAP  
Explain both cases of .NET project and Java project. For the following explanation of development of each project, .Net project is based on Microsoft Visual Studio and java project is based on Eclipse SDK.

### Make reference to ScomDriver1 Library  
###### Add ScomDriver1 library in project for further ScomDriver communication. 
Add ScomDriver 1.0.dll by selecting [Add Reference…] in Solution Explorer.
 ![image](https://user-images.githubusercontent.com/102704655/161193014-ab9dd331-bca4-4f45-99fd-9875cebcfb64.png)

### Make SECS Instance  
###### Create SECS instance to approach and control ScomDriver.
Create SinglePlugIn object from kr.co.aim.Scomdriver.plugin. Class SinglePlugIn provides a method to complete communication by approaching ScomDriver.
```c#
  kr.co.aim.scomdriver.plugin.SinglePlugIn plugIn = new SinglePlugIn()
```
Example)  
```C#
using kr.co.aim.scomdriver.plugin;

Class SECSWrapper()
{
 SinglePlugIn plugIn = new SinglePlugIn();
}
```

### Invoke & Link SECS Event
###### ScomDriver supports Event. Invoke with Event connection.  
Inherit ISECSListener which is an interface about SECS event from kr.co.aim.Scomdriver.callback.  
Example)
```C#
using kr.co.aim.scomdriver.plugin;
using kr.co.aim.scomdriver.callback;

Class SECSWrapper() : ISECSListener
{
 SinglePlugIn plugIn = new SinglePlugIn();
}
```
```C#
using kr.co.aim.scomdriver.plugin;
using kr.co.aim.scomdriver.callback;
using kr.co.aim.scomdriver.structure;
using kr.co.aim.scomdriver.timeout;

Class SECSWrapper() : ISECSListener
{
 SinglePlugIn plugIn = new SinglePlugIn();

      void onConnected(string driverID)
      {
      }

      void onDisconnected(string driverID)
      {
      }

      void onIllegal(string driverID, SECSTransaction transaction)
      {
      }

      void onLog(string driverID, string log)
      {
      }

      void onReceived(string driverID, SECSTransaction transaction)
      {
      }

      void onSendComplete(string driverID, SECSTransaction transaction)
      {
      }

      void onTimeout(string driverID, SECSTimeout timeout)
      {
      }

      void onUnknownReceived(string driverID, SECSTransaction transaction)
      {
 }
}

```
- onConnected: Use when connection happened in SECS1/HSMS Transaction.  
-	onDisconnected: Use when disconnection happened in SECS1/HSMS Transaction.  
-	onIllegal: Use when Illegal Situation happened in SECS1/HSMS Transaction.  
-	onLog: Use when arising ScomDriver log.  
-	onReceived: Use when receiving message successfully.  
-	onSendComplete: Use when sending message completely.  
-	onTimeout: Use when timeout invoked at ScomDriver.  
-	onUnknownReceived: Use when received unknown message.  

Add API which connects when an event invoked at SECSDriver.  
```C#
 bool success = SinglePlugIn.AddSECSLitener(ISECSListener)
```
Example)  
```C#
using kr.co.aim.scomdriver.plugin;
using kr.co.aim.scomdriver.callback;

Class SECSWrapper() : ISECSListener
{
 SinglePlugIn plugIn = new SinglePlugIn();

 #region ISECSEvent Members
 …

 public void Initialize()
 {
     plugIn.AddSECSListener(this);
 }
}

```

### Initialize ScomDriver
###### Initialize function is requesting connection for ScomDriver and listening to connect to  ScomDriver dependent on function mode.  
Use Initialize function of SinglePlugIn.  
* Use SECSConfig to Initialize  
```c#
 IReturnObject returnObj = SinglePlugIn.Initialize(ISECSConfig config);
```
-	ISECSConfig config: Object which possesses ScomDriver config information.  
-	IReturnObject returnObj: Halfway point. Whether to succeed and return data.  

Example)  
```c#
using kr.co.aim.scomdriver.plugin;
using kr.co.aim.scomdriver.callback;
using kr.co.aim.scomdriver.global

Class SECSWrapper() : ISECSListener
{
SinglePlugIn plugIn = new SinglePlugIn();
SECSConfig config = new SECSConfig();
…
public void Initialize()
{
plugIn.AddSECSListener(this);
inializeConfig();
IReturnObject returnObj = plugIn.Initialize(config);
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
 config.IpAddress = "127.0.0.1";
 config.LinktestDuration = 120;
 config.LogModeDaily = true;
 config.LogModeDeleteDuration = 3;
 config.LogRootPath = ".";
 config.ModelingInfoFromFile = "default.smd";
 config.OverRawBinaryLength = 10;
 config.Port = 5000;
 config.SecsLogMode = 1;
 config.UseRawBinary = false;
 config.Timeout6 = 30;
 }
}

```

* Use DriverID, ScomINIXMLFilePath to Initialize  
```C#
 IReturnObject returnObj = 
         SinglePlugIn.Initialize(string DriverID, string ScomINIXMLFilePath);
```
-	string DriverID: Driver ID defined in ScomINI.XML  
-	string ScomINIXMLFilePath: ScomDriver file path set from ScomDriver.  
-	IReturnObject returnObj: Halfway point. Whether to succeed and return data.  
Example)  
```C#
 using kr.co.aim.scomdriver.plugin;
using kr.co.aim.scomdriver.callback;

Class SECSWrapper() : ISECSListener
{
 SinglePlugIn plugIn = new SinglePlugIn();
 …
 public void Initialize()
 {
     plugIn.AddSECSListener(this);
     IReturnObject returnObj = 
     plugIn.Initialize(“EQP001”, “C:\Workspace\ScomINI.xml”);
 }
}

```
* Use Driver ID to initialize.
```C#
 IReturnObject returnObj = SinglePlugIn.Initialize(string DriverID);
```
-	string DriverID: Since ScomINIXMLFilePath does not exist, find DriverID.xml from local and use instead of ScomINI file.  
-	IReturnObject returnObj: Halfway point. Whether to succeed and return data.  

Example)  
```C#
using kr.co.aim.scomdriver.plugin;
using kr.co.aim.scomdriver.callback;

Class SECSWrapper() : ISECSListener
{
 SinglePlugIn plugIn = new SinglePlugIn();
 …
 public void Initialize()
 {
     plugIn.AddSECSListener(this);
     IReturnObject returnObj = plugIn.Initialize(“EQP001”);
 }
}

```


### Terminate ScomDriver   
Terminate function disconnects with ScomDriver and closes socket. If disconnected, request connection or clear listening condition.
```C#
 ReturnObject returnObj = SinglePlugIn.terminate ();
```
-	ReturnObject returnObj: Halfway point. Whether to succeed and return data  

Example)  
```C#
using kr.co.aim.scomdriver.plugin;
using kr.co.aim.scomdriver.callback;

Class SECSWrapper() : ISECSListener
{
 SinglePlugIn plugIn = new SinglePlugIn();
 …
 public void Terminate()
 {
     IReturnObject returnObj = plugIn.Terminate();
 }
}

```

###	Send Request Message  
* Send Message. Three ways of sending message.

```C#
 IReturnObject returnObj = SinglePlugIn.request(ISECSTransaction message);
```
-	ISECSTransaction message: SECSTransaction entity which has message information to send. Request refers Primary message information.  
-	IReturnObject returnObj: Halfway point. Whether to succeed and return data  

* Hot Send  
As it is, send message which is defined in SMD file as Stream number, Function number and Message name.

```C#
using kr.co.aim.scomdriver.plugin;
using kr.co.aim.scomdriver.callback;

Class SECSWrapper() : ISECSListener
{
SinglePlugIn plugIn = new SinglePlugIn();
…
public void HotSend()
{
     //1.Get S2F41 Message from SMD File.
     ReturnObject returnObj = plugIn.GetDefinedMessage (2, 4, “S2F41”) 
 as ReturnObject;
          if(returnObj.isSuccess())
  {
  //2. Send request Message.
  SECSTransaction trx = returnObj.getReturnData() as SECSTransaction;
  returnObj = plugIn.request(trx);
  }
 }
}

```

* Send with Library  
Edit and send with reference of predefined message in SMD File.  
```C#
using kr.co.aim.scomdriver.plugin;
using kr.co.aim.scomdriver.callback;

Class SECSWrapper() : ISECSListener
{
    SinglePlugIn plugIn = new SinglePlugIn();
    …
    public void HotSend()
    {
        //1. Create new SECSTransaction instance.
        SECSTransaction trx = new SECSTransaction();
    //2. Define message.
    trx.setStreamNWbit(2, false);
    trx.setFunction = 41;
    trx.add(new ListFormat());
    trx.add(AsciiFormat.TYPE, -1, “RCMD”, “RCMDVALUE”);
    int nCPCOUNT = 3;
             IFormat nodeCPCount = trx.add(ListFormat.TYPE, nCPCOUNT, "CPCOUNT", "");
             for (int i = 0; i < nCPCOUNT; i++)
             {
                IFormat temp = nodeCPCount.add(ListFormat.TYPE, 2, "", "");
                temp.add(AsciiFormat.TYPE, -1, "CPNAME", "CPNAMEVALUE" + i); 
                temp.add(AsciiFormat.TYPE, 12, "CPVALUE", "CPVALUEVALUE" + i);
                // -1: send length of real value, others: send length written.
    }
    //3. Send request message.
    ReturnObject returnObj = plugIn.request(trx) as ReturnObject;
    }
}

```

* Send without Library  
Send predefined message in SMD file by code.  
```C#
using kr.co.aim.scomdriver.plugin;
using kr.co.aim.scomdriver.callback;

Class SECSWrapper() : ISECSListener
{
    SinglePlugIn plugIn = new SinglePlugIn();
    …
        public void HotSend()
        {
            //1. Create new SECSTransaction instance.
            SECSTransaction trx = new SECSTransaction();
        //2. Define message.
        trx.setStreamNWbit(2, false);
        trx.setFunction = 41;
        trx.add(new ListFormat());
        trx.add(AsciiFormat.TYPE, -1, “RCMD”, “RCMDVALUE”);
        int nCPCOUNT = 3;
                 IFormat nodeCPCount = trx.add(ListFormat.TYPE, nCPCOUNT, "CPCOUNT", "");
                 for (int i = 0; i < nCPCOUNT; i++)
                 {
                    IFormat temp = nodeCPCount.add(ListFormat.TYPE, 2, "", "");
                    temp.add(AsciiFormat.TYPE, -1, "CPNAME", "CPNAMEVALUE" + i);
                    temp.add(AsciiFormat.TYPE, 12, "CPVALUE", "CPVALUEVALUE" + i);
        }
        //3. Send request message.
        ReturnObject returnObj = plugIn.request(trx) as ReturnObject;
    }
}

```

### Send Reply Message  
Send message. Three ways of sending message.  
```C#

 IReturnObject returnObj = SinglePlugIn.reply(ISECSTransaction message);

```
-	ISECSTransaction message: SECSTransaction entity which has message information to send. Reply refers Second message information.  
-	IReturnObject returnObj: Halfway point. Whether to succeed and return data  

* Hot Send  
Same as Send Request Message.
* Send with Library  
Same as Send Request Message.
* Send without Library  
Same as Send Request Message.


### Reload SMD File  
Reload message file in Driver.  
```C#
 IReturnObject returnObj = SinglePlugIn.ReloadSMD(ISECSConfig newConfig);
```
-	ISECSConfig newConfig: Entity with Driver information which includes message file path. Leave the Message file path the same. If reloading only SMD, leave SECSConfig entity as it is. If switching file path, use with configure of SECSConfig.ModelingInfoFromFile.  
-	IReturnObject returnObj: Halfway point. Whether to succeed and return data  

```C#
using kr.co.aim.scomdriver.plugin;
using kr.co.aim.scomdriver.callback;

Class SECSWrapper() : ISECSListener
{
    SinglePlugIn plugIn = new SinglePlugIn();
    …
    public void ReloadSMD()
    {
        //1. Change config info.
        SECSConfig newConfig = this.plugIn.Config;
        newConfig.modelingInfoFromFile =
     @“C:\Project\Btype\EAP01\stocker.smd”;
    //2. Reload SMD.
    this.plugIn.ReloadSMD(newConfig);

    }
}

```

###	Reload Configuration  
Reload config information of Driver.  
```C#
 IReturnObject returnObj = SinglePlugIn.ReloadConfiguration(ISECSConfig newConfig, bool enforceReconnect, bool reloadSMD);
```
-	ISECSConfig newConfig: Reloading Driver entity.  
-	bool enforceReconnect: Whether to reconnect or not.  
-	bool reloadSMD: Whether to reload SMD File or not.  
-	IReturnObject returnObj: Halfway point. Whether to succeed and return data  

```C#
using kr.co.aim.scomdriver.plugin;
using kr.co.aim.scomdriver.callback;

Class SECSWrapper() : ISECSListener
{
    SinglePlugIn plugIn = new SinglePlugIn();
    …
    public void ReloadSMD()
    {
        //1. Change config info.
        SECSConfig newConfig = this.plugIn.Config;
        newConfig.Timeout3 = 20;
             newConfig.Timeout6 = 45;
        //2. Reload Config.
        this.plugIn.ReloadConfiguration (newConfig, false, true);

    }
}

```
