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

