# 📌 Contents
* [🇯 Java](#Java)
* [🇳 .NET](#NET)

# Java
#### environment
* JDK: 1.6.0_45

#### dependency
* jdom: 1.0
* log4j: 1.2.15
* xutil4j: 1.0

#### sample code
```java
import kr.co.aim.scomenabler.callback.SECSListener;
import kr.co.aim.scomenabler.global.AdditionalEventObject;
import kr.co.aim.scomenabler.global.ReturnObject;
import kr.co.aim.scomenabler.plugin.SinglePlugIn;
import kr.co.aim.scomenabler.structure.SECSTransaction;
import kr.co.aim.scomenabler.timeout.SECSTimeout;

public class SECSWrapper implements SECSListener{
	private SinglePlugIn plugin;
	
	int nReceivedCount = 0;
	int nSentCount = 0;

	public static void main(String[] args) {
		System.out.println("done " + args[0]);
		new SECSWrapper(args[0]);
	}
	
	SECSWrapper(String arg){
		plugin = new SinglePlugIn();
		ReturnObject rtObj = plugin.initialize(arg, "ScomINI.xml");
		
		if(!rtObj.isSuccess()){
			System.out.println(rtObj.getErrorObject().getErrorDiscription());
			return;
		}
		
		plugin.addSECSListener(this);
		
		while(true) {
			
		}
	}

	public void onConnected(String arg0) {

	}

	public void onDisconnected(String arg0) {

	}

	public void onIllegal(String arg0, SECSTransaction arg1) {

	}

	public void onLog(String arg0, String arg1) {

	}

	public void onReceived(String arg0, SECSTransaction arg1) {

	}

	public void onSECSAdditional(String arg0, AdditionalEventObject arg1) {
		// TODO Auto-generated method stub
		
	}

	public void onSendComplete(String arg0, SECSTransaction arg1) {
		// TODO Auto-generated method stub
		
	}

	public void onTimeout(String arg0, SECSTimeout arg1) {
		// TODO Auto-generated method stub
		
	}

	public void onUnknownReceived(String arg0, SECSTransaction arg1) {
		// TODO Auto-generated method stub
		
	}

}

```

# .NET
``` C#
```
