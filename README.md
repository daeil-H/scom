![image](https://user-images.githubusercontent.com/102704655/161009152-fc89a509-deac-4bdf-b9f1-f252c892f646.png)
![image](https://user-images.githubusercontent.com/102704655/161009188-40bca8ea-5039-4174-9bff-25e8a5c5c993.png)


## 📌 Table Of Contents
* [📖 Introduction](#-Introduction)
* [💡 License](#-License)
* [📫 Contact](#-Contact)

# 📖 Introduction
##### 1.1.	ScomDriver 
* Abbreviation for Semiconductor Equipment Communication Driver
* FAB Automation Development Solution for Semiconductor, LCD, Equipment, etc…
* Solution based on SEMI Standard and FAB Automation IT experience and technique of AIM Systems, INC.
* Supports Communication Driver using HSMS/SECS1 Protocol and requisite program for Development.
* Currently, integrated largely in FAB, it supports a stable solution with proper updates and patches.

##### 1.2.	Product Features 
* Support a variety of O/S Platform.
* Provide both java and .NET version of Library for wider option choices.

##### 1.3.	Product Function
* SECS Project Control
* Define and Modify message, and Create SECS Message Definition File (SMD file)
* Project Integration Management of Driver, Message file, and etc.
* SECS1/HSMS Communication Driver
* Virtual Host or Equipment Role 
* SECS1/HSMS Communication Test 
* Message Send/Receive Test 

##### 1.4.3.	ScomDriver
* Develop with reference from when creating EAP from subject of SECS / HSMS communication.
* .NET ScomDriver : ScomDriver library developed in .NET
* Java ScomDriver: ScomDriver library developed in Java

# 🔎 How to Use ScomDriver & Development
### Java
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

# 💡 License
* The information in this document is subject to change without notice and should not be construed as a commitment by AIM Systems, Inc. While all reasonable care has been taken to ensure accuracy, AIM Systems, Inc. assumes no responsibility for any errors that may appear in this document.

* The software described in this document is furnished under a license and may be used or copied only in accordance with the terms of such license.

### COPYRIGHT © 2010 AIM Systems, Inc.
### All rights reserved.

![image](https://user-images.githubusercontent.com/102704655/161007121-8da3684a-c5bc-4bc6-8247-6ea363a340eb.png)

* No part of this document may be reproduced in any form of by any means without permission in writing from AIM Systems, Inc.
* ScomDriver is a trademark of AIM Systems, Inc.

# 📫 Contact
http://www.aim.co.kr/
