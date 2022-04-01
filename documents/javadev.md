# How to Development EAP for JAVA Developer
<img src="https://img.shields.io/badge/java-007396?style=for-the-badge&logo=java&logoColor=white">

### [Example – JAVA Code](./sample.md)

### 📌 Index
* [Make SECS Instance](#make-secs-instance)
* [Invoke & Link SECS Event](#invoke-&-link-secs-event)
* [Initialize ScomDriver](#initialize-scomdriver)
* [Terminate ScomDriver](#terminate-scomdriver)
* [Send Request Message](#send-request-message)
* [Send Reply Message](#send-reply-message)
* [Reload SMD File](#reload-smd-file)
* [Reload Configuration](#reload-configuration)

### Make reference to ScomDriver Library  
###### Add libraries in project for further ScomDriver communication.  
Add ScomDriver1.0.jar and libraries from [Property] of project or [Configure Build Path] of Libraries Tab.  
![image](https://user-images.githubusercontent.com/102704655/161182295-6b6ed6a5-f384-4d2b-a6b1-f9cf25b61c4e.png)

##### ScomDriver need these libraries.  
(Libraries are located in RuntimeLib -> JavaLib folder of scom installation folder.)
* Scomdriver1.0.jar
* xutil4j-1.0.jar
* log4j-1.2.15.jar
* jdom-1.0.jar
* junit.jar
* dynamic-file-appender-1.0.0.jar
* commons-logging-1.0.4.jar

### Make SECS Instance
###### Create SECS instance to approach and control ScomDriver.  
Create SinglePlugIn object from kr.co.aim.Scomdriver.plugin.  
Class SinglePlugIn provides a method to complete communication by approaching ScomDriver.  
Create SinglePlugIn object by using Spring in Java.

``` java
  kr.co.aim.scomdriver.plugin.SinglePlugIn plugIn = new SinglePlugIn()
```

### Invoke & Link SECS Event  
###### ScomDriver supports Event. Invoke with Event connection.

Inherit SECSListener which is an interface about SECS event from  
kr.co.aim.scomenabler.callback.  

Example)  
``` java
  import kr.co.aim.scomenabler.plugin.*;
  import kr.co.aim.scomenabler.callback.SECSListener;
  Class SECSWrapper Implements SECSListener
  {
    SinglePlugIn plugIn = new SinglePlugIn();
  }
```

Example)  
``` java
import kr.co.aim.scomenabler.plugin.*;
import kr.co.aim.scomenabler.callback.SECSListener;
import kr.co.aim.scomenabler.structure.*;
import kr.co.aim.scomenabler.timeout.*;
Class SECSWrapper Implements SECSListener
{
  SinglePlugIn plugIn = new SinglePlugIn();
  public void onConnected(String driverID) {
  }
  public void onDisconnected(String driverID) {
  }    
  public void onIllegal(String driverID, SECSTransaction transaction) {
  }
  public void onLog(String driverID, String log) {
  }
  public void onReceived(String driverID, SECSTransaction transaction) {
  }
  public void onSendComplete(String driverID, SECSTransaction transaction) {
  }
  public void onTimeout(String driverID, SECSTimeout timeout) {
  }
  public void onUnknownReceived(String driverID, SECSTransaction transaction) {
  }
}
```
-	onConnected: Use when connection happened in SECS1/HSMS Transaction.  
-	onDisconnected: Use when disconnection happened in SECS1/HSMS  
-	Transaction.  
-	onIllegal: Use when Illegal Situation happened in SECS1/HSMS Transaction.  
-	onLog: Use when arising ScomDriver log.  
-	onReceived: Use when receiving message successfully.  
-	onSendComplete: Use when sending message completely.  
-	onTimeout: Use when timeout invoked at ScomDriver.  
-	onUnknownReceived: Use when received unknown message.  

###### add API which connects when an event invoked at SECSDriver.
``` java
  Boolean isSuccessful = plugin.addSECSListener(this);
```
* Boolean success: halfway point. Whether to succeed or not and return data.

Example) 
```java
public class SECSWrapper implements SECSListener{
  SECSWrapper(String arg){
    Boolean isSuccessful = plugin.addSECSListener(this);
		if(!isSuccessful){
			System.out.println("addSECSListener is Failed.");
			return;
		}
  }
}
```

### Initialize ScomDriver  
Initialize function is requesting connection for ScomDriver and listening to connect to  ScomDriver dependent on function mode.
```java
	ReturnObject returnObj = SinglePlugIn.initialize(SECSConfig config);
```
- SECSConfig config: Object which possesses ScomDriver config information.  
- ReturnObject returnObj: Halfway point. Whether to succeed and return data.  
Example)  
```java
import kr.co.aim.scomenabler.plugin.*;
import kr.co.aim.scomenabler.callback.SECSListener;
import kr.co.aim.scomenabler.global.ReturnObject;
import kr.co.aim.scomenabler.global.SECSConfig;
Class SECSWrapper Implements SECSListener
{
	SinglePlugIn plugIn = new SinglePlugIn();
	SECSConfig config = new SECSConfig();
	…
	public void Initialize()
	{
		plugin.addSECSListener(this);
		inializeConfig();
		IReturnObject returnObj = plugIn.initialize(config);
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
```java
	ReturnObject returnObj = SinglePlugIn.initialize(String DriverID, String
ScomINIXMLFilePath);

```
- String DriverID: Driver ID defined in ScomINI.XML  
- String ScomINIXMLFilePath: ScomDriver file path set from ScomEnabler.  
- ReturnObject returnObj: Halfway point. Whether to succeed and return data.  
- 
Example)  
```java
import kr.co.aim.scomenabler.plugin.*;
import kr.co.aim.scomenabler.callback.SECSListener;
import kr.co.aim.scomenabler.global.ReturnObject;
import kr.co.aim.scomenabler.global.SECSConfig;
Class SECSWrapper Implements SECSListener
{
	SinglePlugIn plugIn = new SinglePlugIn();
	…
	public void Initialize()
	{
		plugin.addSECSListener(this);
		IReturnObject returnObj = plugIn.Initialize(“EQP001”, “C:\Workspace\ScomINI.xml”);
	}
}

```

* Use Driver ID to initialize.
```java
	ReturnObject returnObj = SinglePlugIn.Initialize(String DriverID);
```
- String DriverID: Since ScomINIXMLFilePath does not exist, find DriverID.xml from local and use instead of ScomINI file.  
- IReturnObject returnObj: Halfway point. Whether to succeed and return data.  
Example)  
```java
import kr.co.aim.scomenabler.plugin.*;
import kr.co.aim.scomenabler.callback.SECSListener;
import kr.co.aim.scomenabler.global.ReturnObject;
import kr.co.aim.scomenabler.global.SECSConfig;
Class SECSWrapper Implements SECSListener
{
	SinglePlugIn plugIn = new SinglePlugIn();
	…
	public void Initialize()
	{
		plugin.addSECSListener(this);
		IReturnObject returnObj = plugIn.Initialize(“EQP001”);
	}
}

```

### Terminate ScomDriver  
Terminate function disconnects with ScomDriver and closes socket. If disconnected, request connection or clear listening condition.  

```java
	ReturnObject returnObj = SinglePlugIn.terminate ();
```
- ReturnObject returnObj: Halfway point. Whether to succeed and return data  

Example)  
```java
import kr.co.aim.scomenabler.plugin.*;
import kr.co.aim.scomenabler.callback.SECSListener;
import kr.co.aim.scomenabler.global.ReturnObject;
import kr.co.aim.scomenabler.global.SECSConfig;
Class SECSWrapper Implements SECSListener
{
	SinglePlugIn plugIn = new SinglePlugIn();
	…
	public void Terminate()
	{
		ReturnObject returnObj = plugIn. terminate ();
	}
}

```

### Send Request Message  
Send Message. Three ways of sending message.  

```java
	ReturnObject returnObj = SinglePlugIn.request(SECSTransaction message);
```
- ISECSTransaction message: SECSTransaction entity which has message information to send. Request refers Primary message information.  
- IReturnObject returnObj: Halfway point. Whether to succeed and return data  

* Hot Send  
As it is, send message which is defined in SMD file as Stream number, Function number and Message name.  
```java
import kr.co.aim.scomenabler.plugin.*;
import kr.co.aim.scomenabler.callback.SECSListener;
import kr.co.aim.scomenabler.global.ReturnObject;
Class SECSWrapper Implements SECSListener
{
	SinglePlugIn plugIn = new SinglePlugIn();
	…
	public void HotSend()
	{
		//1.Get S2F41 Message from SMD File.
		ReturnObject returnObj = plugIn. getDefinedMessage (2, 4, “S2F41”)
		if(returnObj.isSuccess())
		{
			//2. Send request Message.
			ReturnObject returnObj = new ReturnObject();
			SECSTransaction trx =
			(SECSTransaction)returnObj.getReturnData();
			returnObj = plugin.request(trx);
		}
	}
}

```

* Send with Library  
Edit and send with reference of predefined message in SMD File.  
```java
import kr.co.aim.scomenabler.plugin.*;
import kr.co.aim.scomenabler.callback.SECSListener;
import kr.co.aim.scomenabler.global.ReturnObject;

Class SECSWrapper Implements SECSListener
{
	SinglePlugIn plugIn = new SinglePlugIn();
	…
	public void HotSend()
	{
		//1. Create new SECSTransaction instance.
		SECSTransaction trx = new SECSTransaction();
		//2. Define message.
		trx.setStreamNWbit(2, false);
		trx.setFunction(41);//setFunction = 41;
		trx.add(new ListFormat());
		trx.add(AsciiFormat.TYPE, -1, "RCMD", "RCMDVALUE");
		int nCPCOUNT = 3;
		IFormat nodeCPCount =
		trx.add(ListFormat.TYPE, nCPCOUNT, "CPCOUNT", "");
		for (int i = 0; i < nCPCOUNT; i++)
		{
			IFormat temp = nodeCPCount.add(ListFormat.TYPE, 2, "", "");
			temp.add(AsciiFormat.TYPE, -1, "CPNAME",
			"CPNAMEVALUE" + i);
			temp.add(AsciiFormat.TYPE, 12, "CPVALUE",
			"CPVALUEVALUE" + i);
		}
		//3. Send request message.
		ReturnObject returnObj = plugIn.request(trx);
	}
}

```

* Send without Library   
Send predefined message in SMD file by code.   
```java
import kr.co.aim.scomenabler.plugin.*;
import kr.co.aim.scomenabler.callback.SECSListener;
import kr.co.aim.scomenabler.global.ReturnObject;

Class SECSWrapper Implements SECSListener
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
		ReturnObject returnObj = plugIn.request(trx) ;
	}
}

```

### Send Reply Message  
Send message. Three ways of sending message.  

```java
	ReturnObject returnObj = SinglePlugIn.reply(SECSTransaction message);
```
- SECSTransaction message: SECSTransaction entity which has message information to send. Reply refers Second message information.   
- ReturnObject returnObj: Halfway point. Whether to succeed and return data.  

###### Hot Send  
Same as Send Request Message.
* Send with Library
Same as Send Request Message.  
* Send without Library
Same as Send Request Message.


### Reload SMD File  
Reload message file in Driver.  

```java
	ReturnObject returnObj = SinglePlugIn.ReloadSMD(SECSConfig newConfig);
```
SECSConfig newConfig: Entity with Driver information which includes message file path. Leave the Message file path the same. If reloading only SMD, leave SECSConfig entity as it is. If switching file path, use with configure of SECSConfig.ModelingInfoFromFile.  
- ReturnObject returnObj: Halfway point. Whether to succeed and return data

```java
import kr.co.aim.scomenabler.plugin.*;
import kr.co.aim.scomenabler.callback.SECSListener;
import kr.co.aim.scomenabler.global.ReturnObject;
Class SECSWrapper Implements SECSListener
{
	SinglePlugIn plugIn = new SinglePlugIn();
	…
	public void ReloadSMD()
	{
		//1. Change config info.
		SECSConfig newConfig = this.plugIn.getConfig();
		newConfig.setModelingInfoFromFile
		("C:/Project/Btype/EAP01/stocker.smd");
		//2. Reload SMD.
		this.plugIn.reloadSMD(newConfig);
	}
}

```

### Reload Configuration  
Reload config information of Driver.  

```java
	ReturnObject returnObj = SinglePlugIn.reloadConfiguration (SECSConfig
newConfig, Boolean enforceReconnect, Boolean reloadSMD);

```
- SECSConfig newConfig: Reloading Driver entity.  
- Boolean enforceReconnect: Whether to reconnect or not.  
- Boolean reloadSMD: Whether to reload SMD File or not.  
- ReturnObject returnObj: Halfway point. Whether to succeed and return data  

```java
import kr.co.aim.scomenabler.plugin.*;
import kr.co.aim.scomenabler.callback.SECSListener;
import kr.co.aim.scomenabler.global.ReturnObject;
Class SECSWrapper Implements SECSListener
{
	SinglePlugIn plugIn = new SinglePlugIn();
	…
	public void ReloadSMD()
	{
		//1. Change config info.
		SECSConfig newConfig = this.plugIn.getConfig();
		newConfig.setTimeoutT3(20);
		newConfig.setTimeoutT6(45);
		//2. Reload Config.
		this.plugIn.reloadConfiguration(newConfig, false, true);
	}
}

```
