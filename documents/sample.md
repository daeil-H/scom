# Sample code

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

	public void onSECSAdditional(String arg0, AdditionalEventObject arg1) {

		
	}

	public void onSendComplete(String driverID, SECSTransaction transaction) {

		
	}

	public void onTimeout(String driverID, SECSTimeout timeout) {

		
	}

	public void onUnknownReceived(String driverID, SECSTransaction transaction) {

		
	}

}

```

# .NET
``` C#
using System;
using System.Collections.Generic;
using System.Text;
using kr.co.aim.scomdriver.global;
using kr.co.aim.scomdriver.plugin;
using kr.co.aim.scomdriver.structure;
using kr.co.aim.scomdriver.callback;
using kr.co.aim.scomdriver.timeout;

namespace codeGenerator
{
	class Example_Simulation_Host
	{
		private SinglePlugIn m_plugIn;

		//Method1: Set SinglePlugIn instance.
		public Example _Simulation_Host(SinglePlugIn plugin)
		{
			m_plugIn = plugin;
		}
		//Method2: Send Request Message.
		public ReturnObject sendRequestMessage(SECSTransaction trx)
		{
			return m_plugIn.request(trx);
		}
		//Method3: Send Reply Message.
		public ReturnObject sendReplyMessage(SECSTransaction trx)
		{
			return m_plugIn.request(trx);
		}
		//Method4: Get Message Information Object from SMD file.
		public SECSTransaction getDefinedMessage
		(int stream, int function, string definedMessageName)
		{
			ReturnObject returnObject = m_plugIn.GetDefinedMessage
		(stream, function, definedMessageName);
		if (returnObject.isSuccess())
			return returnObject.getReturnData() as SECSTransaction;
		else
		{
			System.Diagnostics.Trace.WriteLine("Faile to getDefinedMessage
			Error:" +  returnObject.ErrorObject.getErrorDiscription());
			return null;
		}
		//Method5: Edit S1F9 Message defined in SMD file.
		public SECSTransaction makeS1F9()
		{
			SECSTransaction trx = new SECSTransaction();

			trx.setStreamNWbit(1, true);
			trx.Function = 9;

			return trx;
		}
	}
…
}

```
